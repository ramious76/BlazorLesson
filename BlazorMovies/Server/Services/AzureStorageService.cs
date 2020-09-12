﻿using BlazorMovies.Server.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorMovies.Server.Services
{
    //public class AzureStorageService : IFileStorageService
    //{
    //private readonly string connectionString;
    //public AzureStorageService(IConfiguration configuration)
    //{
    //    connectionString = configuration.GetConnectionString("AzureStorageConnection");
    //}

    //public async Task DeleteFile(string fileRoute, string containerName)
    //{
    //    var account = CloudStorageAccount.Parse(connectionString);
    //    var client = account.CreateCloudBlobClient();
    //    var container = client.GetContainerReference(containerName);

    //    var blobName = Path.GetFileName(fileRoute);
    //    var blob = container.GetBlobReference(blobName);
    //    await blob.DeleteIfExistsAsync();

    //}

    //public async Task<string> EditFile(byte[] content, string extension, string containerName, string fileRoute)
    //{
    //    if (!string.IsNullOrEmpty(fileRoute))
    //    {
    //        await DeleteFile(fileRoute, containerName);
    //    }
    //    return await SaveFile(content, extension, containerName);
    //}

    //public async Task<string> SaveFile(byte[] content, string extension, string containerName)
    //{
    //    var account = CloudStorageAccount.Parse(connectionString);
    //    var client = account.CreateCloudBlobClient();
    //    var container = client.GetContainerReference(containerName);
    //    await container.CreateIfNotExistsAsync();
    //    await container.SetPermissionsAsync(new BlobkContainerPermissions
    //    {
    //        PublicAccess = BlobContainerPublicAccessType.Blob
    //    });
    //    var fileName = $"{ Guid.NewGuid()}.{extension}";
    //    var blob = container.GetBlockBlobReference(fileName);
    //    blob.Properties.ContentType = "image/jpg";
    //    await blob.SetPropertiesAsync();
    //    return blob.Uri.ToString();
    //}
    //    }
}
