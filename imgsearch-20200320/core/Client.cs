// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Imgsearch20200320.Models;

namespace AlibabaCloud.SDK.Imgsearch20200320
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("imgsearch", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public string GetEndpoint(string productId, string regionId, string endpointRule, string network, string suffix, Dictionary<string, string> endpointMap, string endpoint)
        {
            if (!AlibabaCloud.TeaUtil.Common.Empty(endpoint))
            {
                return endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(endpointMap) && !AlibabaCloud.TeaUtil.Common.Empty(endpointMap.Get(regionId)))
            {
                return endpointMap.Get(regionId);
            }
            return AlibabaCloud.EndpointUtil.Common.GetEndpointRules(productId, regionId, endpointRule, network, suffix);
        }

        public AddImageResponse AddImageWithOptions(AddImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddImageResponse>(DoRPCRequest("AddImage", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddImageResponse> AddImageWithOptionsAsync(AddImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddImageResponse>(await DoRPCRequestAsync("AddImage", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddImageResponse AddImage(AddImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddImageWithOptions(request, runtime);
        }

        public async Task<AddImageResponse> AddImageAsync(AddImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddImageWithOptionsAsync(request, runtime);
        }

        public AddImageResponse AddImageAdvance(AddImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Endpoint = "openplatform.aliyuncs.com",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imgsearch",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            AddImageRequest addImageReq = new AddImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, addImageReq);
            authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
            ossConfig.AccessKeyId = authResponse.AccessKeyId;
            ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
            ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
            {
                Filename = authResponse.ObjectKey,
                Content = request.ImageUrlObject,
                ContentType = "",
            };
            ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
            {
                AccessKeyId = authResponse.AccessKeyId,
                Policy = authResponse.EncodedPolicy,
                Signature = authResponse.Signature,
                Key = authResponse.ObjectKey,
                File = fileObj,
                SuccessActionStatus = "201",
            };
            uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
            {
                BucketName = authResponse.Bucket,
                Header = ossHeader,
            };
            ossClient.PostObject(uploadRequest, ossRuntime);
            addImageReq.ImageUrl = "http://" + authResponse.Bucket + "." + authResponse.Endpoint + "/" + authResponse.ObjectKey;
            AddImageResponse addImageResp = AddImageWithOptions(addImageReq, runtime);
            return addImageResp;
        }

        public async Task<AddImageResponse> AddImageAdvanceAsync(AddImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Endpoint = "openplatform.aliyuncs.com",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imgsearch",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            AddImageRequest addImageReq = new AddImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, addImageReq);
            authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
            ossConfig.AccessKeyId = authResponse.AccessKeyId;
            ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
            ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
            {
                Filename = authResponse.ObjectKey,
                Content = request.ImageUrlObject,
                ContentType = "",
            };
            ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
            {
                AccessKeyId = authResponse.AccessKeyId,
                Policy = authResponse.EncodedPolicy,
                Signature = authResponse.Signature,
                Key = authResponse.ObjectKey,
                File = fileObj,
                SuccessActionStatus = "201",
            };
            uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
            {
                BucketName = authResponse.Bucket,
                Header = ossHeader,
            };
            await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
            addImageReq.ImageUrl = "http://" + authResponse.Bucket + "." + authResponse.Endpoint + "/" + authResponse.ObjectKey;
            AddImageResponse addImageResp = await AddImageWithOptionsAsync(addImageReq, runtime);
            return addImageResp;
        }

        public CreateImageDbResponse CreateImageDbWithOptions(CreateImageDbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateImageDbResponse>(DoRPCRequest("CreateImageDb", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateImageDbResponse> CreateImageDbWithOptionsAsync(CreateImageDbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateImageDbResponse>(await DoRPCRequestAsync("CreateImageDb", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateImageDbResponse CreateImageDb(CreateImageDbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageDbWithOptions(request, runtime);
        }

        public async Task<CreateImageDbResponse> CreateImageDbAsync(CreateImageDbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageDbWithOptionsAsync(request, runtime);
        }

        public DeleteImageResponse DeleteImageWithOptions(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteImageResponse>(DoRPCRequest("DeleteImage", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteImageResponse> DeleteImageWithOptionsAsync(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteImageResponse>(await DoRPCRequestAsync("DeleteImage", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteImageResponse DeleteImage(DeleteImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteImageWithOptions(request, runtime);
        }

        public async Task<DeleteImageResponse> DeleteImageAsync(DeleteImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteImageWithOptionsAsync(request, runtime);
        }

        public DeleteImageDbResponse DeleteImageDbWithOptions(DeleteImageDbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteImageDbResponse>(DoRPCRequest("DeleteImageDb", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteImageDbResponse> DeleteImageDbWithOptionsAsync(DeleteImageDbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteImageDbResponse>(await DoRPCRequestAsync("DeleteImageDb", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteImageDbResponse DeleteImageDb(DeleteImageDbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteImageDbWithOptions(request, runtime);
        }

        public async Task<DeleteImageDbResponse> DeleteImageDbAsync(DeleteImageDbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteImageDbWithOptionsAsync(request, runtime);
        }

        public ListImageDbsResponse ListImageDbsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListImageDbsResponse>(DoRPCRequest("ListImageDbs", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListImageDbsResponse> ListImageDbsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListImageDbsResponse>(await DoRPCRequestAsync("ListImageDbs", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListImageDbsResponse ListImageDbs()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListImageDbsWithOptions(runtime);
        }

        public async Task<ListImageDbsResponse> ListImageDbsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListImageDbsWithOptionsAsync(runtime);
        }

        public ListImagesResponse ListImagesWithOptions(ListImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListImagesResponse>(DoRPCRequest("ListImages", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListImagesResponse> ListImagesWithOptionsAsync(ListImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListImagesResponse>(await DoRPCRequestAsync("ListImages", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListImagesResponse ListImages(ListImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListImagesWithOptions(request, runtime);
        }

        public async Task<ListImagesResponse> ListImagesAsync(ListImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListImagesWithOptionsAsync(request, runtime);
        }

        public SearchImageResponse SearchImageWithOptions(SearchImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchImageResponse>(DoRPCRequest("SearchImage", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchImageResponse> SearchImageWithOptionsAsync(SearchImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchImageResponse>(await DoRPCRequestAsync("SearchImage", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchImageResponse SearchImage(SearchImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchImageWithOptions(request, runtime);
        }

        public async Task<SearchImageResponse> SearchImageAsync(SearchImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchImageWithOptionsAsync(request, runtime);
        }

        public SearchImageResponse SearchImageAdvance(SearchImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Endpoint = "openplatform.aliyuncs.com",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imgsearch",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SearchImageRequest searchImageReq = new SearchImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, searchImageReq);
            authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
            ossConfig.AccessKeyId = authResponse.AccessKeyId;
            ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
            ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
            {
                Filename = authResponse.ObjectKey,
                Content = request.ImageUrlObject,
                ContentType = "",
            };
            ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
            {
                AccessKeyId = authResponse.AccessKeyId,
                Policy = authResponse.EncodedPolicy,
                Signature = authResponse.Signature,
                Key = authResponse.ObjectKey,
                File = fileObj,
                SuccessActionStatus = "201",
            };
            uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
            {
                BucketName = authResponse.Bucket,
                Header = ossHeader,
            };
            ossClient.PostObject(uploadRequest, ossRuntime);
            searchImageReq.ImageUrl = "http://" + authResponse.Bucket + "." + authResponse.Endpoint + "/" + authResponse.ObjectKey;
            SearchImageResponse searchImageResp = SearchImageWithOptions(searchImageReq, runtime);
            return searchImageResp;
        }

        public async Task<SearchImageResponse> SearchImageAdvanceAsync(SearchImageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Endpoint = "openplatform.aliyuncs.com",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "imgsearch",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SearchImageRequest searchImageReq = new SearchImageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, searchImageReq);
            authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
            ossConfig.AccessKeyId = authResponse.AccessKeyId;
            ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
            ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
            {
                Filename = authResponse.ObjectKey,
                Content = request.ImageUrlObject,
                ContentType = "",
            };
            ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
            {
                AccessKeyId = authResponse.AccessKeyId,
                Policy = authResponse.EncodedPolicy,
                Signature = authResponse.Signature,
                Key = authResponse.ObjectKey,
                File = fileObj,
                SuccessActionStatus = "201",
            };
            uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
            {
                BucketName = authResponse.Bucket,
                Header = ossHeader,
            };
            await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
            searchImageReq.ImageUrl = "http://" + authResponse.Bucket + "." + authResponse.Endpoint + "/" + authResponse.ObjectKey;
            SearchImageResponse searchImageResp = await SearchImageWithOptionsAsync(searchImageReq, runtime);
            return searchImageResp;
        }

    }
}
