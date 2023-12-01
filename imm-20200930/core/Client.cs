// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Imm20200930.Models;

namespace AlibabaCloud.SDK.Imm20200930
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing-gov-1", "imm-vpc.cn-beijing-gov-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("imm", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddImageMosaicResponse AddImageMosaicWithOptions(AddImageMosaicRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddImageMosaicShrinkRequest request = new AddImageMosaicShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Targets))
            {
                request.TargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Targets, "Targets", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFormat))
            {
                query["ImageFormat"] = request.ImageFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quality))
            {
                query["Quality"] = request.Quality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURI))
            {
                query["TargetURI"] = request.TargetURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetsShrink))
            {
                query["Targets"] = request.TargetsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddImageMosaic",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddImageMosaicResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddImageMosaicResponse> AddImageMosaicWithOptionsAsync(AddImageMosaicRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddImageMosaicShrinkRequest request = new AddImageMosaicShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Targets))
            {
                request.TargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Targets, "Targets", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFormat))
            {
                query["ImageFormat"] = request.ImageFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quality))
            {
                query["Quality"] = request.Quality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURI))
            {
                query["TargetURI"] = request.TargetURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetsShrink))
            {
                query["Targets"] = request.TargetsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddImageMosaic",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddImageMosaicResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddImageMosaicResponse AddImageMosaic(AddImageMosaicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddImageMosaicWithOptions(request, runtime);
        }

        public async Task<AddImageMosaicResponse> AddImageMosaicAsync(AddImageMosaicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddImageMosaicWithOptionsAsync(request, runtime);
        }

        public AddStoryFilesResponse AddStoryFilesWithOptions(AddStoryFilesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddStoryFilesShrinkRequest request = new AddStoryFilesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Files))
            {
                request.FilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Files, "Files", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesShrink))
            {
                body["Files"] = request.FilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddStoryFiles",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddStoryFilesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddStoryFilesResponse> AddStoryFilesWithOptionsAsync(AddStoryFilesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddStoryFilesShrinkRequest request = new AddStoryFilesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Files))
            {
                request.FilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Files, "Files", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesShrink))
            {
                body["Files"] = request.FilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddStoryFiles",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddStoryFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddStoryFilesResponse AddStoryFiles(AddStoryFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddStoryFilesWithOptions(request, runtime);
        }

        public async Task<AddStoryFilesResponse> AddStoryFilesAsync(AddStoryFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddStoryFilesWithOptionsAsync(request, runtime);
        }

        public AttachOSSBucketResponse AttachOSSBucketWithOptions(AttachOSSBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OSSBucket))
            {
                query["OSSBucket"] = request.OSSBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachOSSBucket",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachOSSBucketResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AttachOSSBucketResponse> AttachOSSBucketWithOptionsAsync(AttachOSSBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OSSBucket))
            {
                query["OSSBucket"] = request.OSSBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachOSSBucket",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachOSSBucketResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AttachOSSBucketResponse AttachOSSBucket(AttachOSSBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachOSSBucketWithOptions(request, runtime);
        }

        public async Task<AttachOSSBucketResponse> AttachOSSBucketAsync(AttachOSSBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachOSSBucketWithOptionsAsync(request, runtime);
        }

        public BatchDeleteFileMetaResponse BatchDeleteFileMetaWithOptions(BatchDeleteFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchDeleteFileMetaShrinkRequest request = new BatchDeleteFileMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.URIs))
            {
                request.URIsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.URIs, "URIs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URIsShrink))
            {
                query["URIs"] = request.URIsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteFileMeta",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteFileMetaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchDeleteFileMetaResponse> BatchDeleteFileMetaWithOptionsAsync(BatchDeleteFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchDeleteFileMetaShrinkRequest request = new BatchDeleteFileMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.URIs))
            {
                request.URIsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.URIs, "URIs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URIsShrink))
            {
                query["URIs"] = request.URIsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteFileMeta",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteFileMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchDeleteFileMetaResponse BatchDeleteFileMeta(BatchDeleteFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteFileMetaWithOptions(request, runtime);
        }

        public async Task<BatchDeleteFileMetaResponse> BatchDeleteFileMetaAsync(BatchDeleteFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteFileMetaWithOptionsAsync(request, runtime);
        }

        public BatchGetFigureClusterResponse BatchGetFigureClusterWithOptions(BatchGetFigureClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchGetFigureClusterShrinkRequest request = new BatchGetFigureClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ObjectIds))
            {
                request.ObjectIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ObjectIds, "ObjectIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectIdsShrink))
            {
                query["ObjectIds"] = request.ObjectIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetFigureCluster",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetFigureClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchGetFigureClusterResponse> BatchGetFigureClusterWithOptionsAsync(BatchGetFigureClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchGetFigureClusterShrinkRequest request = new BatchGetFigureClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ObjectIds))
            {
                request.ObjectIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ObjectIds, "ObjectIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectIdsShrink))
            {
                query["ObjectIds"] = request.ObjectIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetFigureCluster",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetFigureClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchGetFigureClusterResponse BatchGetFigureCluster(BatchGetFigureClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetFigureClusterWithOptions(request, runtime);
        }

        public async Task<BatchGetFigureClusterResponse> BatchGetFigureClusterAsync(BatchGetFigureClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetFigureClusterWithOptionsAsync(request, runtime);
        }

        public BatchGetFileMetaResponse BatchGetFileMetaWithOptions(BatchGetFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchGetFileMetaShrinkRequest request = new BatchGetFileMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.URIs))
            {
                request.URIsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.URIs, "URIs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URIsShrink))
            {
                query["URIs"] = request.URIsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetFileMeta",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetFileMetaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchGetFileMetaResponse> BatchGetFileMetaWithOptionsAsync(BatchGetFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchGetFileMetaShrinkRequest request = new BatchGetFileMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.URIs))
            {
                request.URIsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.URIs, "URIs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URIsShrink))
            {
                query["URIs"] = request.URIsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGetFileMeta",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGetFileMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchGetFileMetaResponse BatchGetFileMeta(BatchGetFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetFileMetaWithOptions(request, runtime);
        }

        public async Task<BatchGetFileMetaResponse> BatchGetFileMetaAsync(BatchGetFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetFileMetaWithOptionsAsync(request, runtime);
        }

        public BatchIndexFileMetaResponse BatchIndexFileMetaWithOptions(BatchIndexFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchIndexFileMetaShrinkRequest request = new BatchIndexFileMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Files))
            {
                request.FilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Files, "Files", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesShrink))
            {
                query["Files"] = request.FilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchIndexFileMeta",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchIndexFileMetaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchIndexFileMetaResponse> BatchIndexFileMetaWithOptionsAsync(BatchIndexFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchIndexFileMetaShrinkRequest request = new BatchIndexFileMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Files))
            {
                request.FilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Files, "Files", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesShrink))
            {
                query["Files"] = request.FilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchIndexFileMeta",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchIndexFileMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchIndexFileMetaResponse BatchIndexFileMeta(BatchIndexFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchIndexFileMetaWithOptions(request, runtime);
        }

        public async Task<BatchIndexFileMetaResponse> BatchIndexFileMetaAsync(BatchIndexFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchIndexFileMetaWithOptionsAsync(request, runtime);
        }

        public BatchUpdateFileMetaResponse BatchUpdateFileMetaWithOptions(BatchUpdateFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchUpdateFileMetaShrinkRequest request = new BatchUpdateFileMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Files))
            {
                request.FilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Files, "Files", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesShrink))
            {
                query["Files"] = request.FilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUpdateFileMeta",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateFileMetaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchUpdateFileMetaResponse> BatchUpdateFileMetaWithOptionsAsync(BatchUpdateFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchUpdateFileMetaShrinkRequest request = new BatchUpdateFileMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Files))
            {
                request.FilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Files, "Files", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesShrink))
            {
                query["Files"] = request.FilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUpdateFileMeta",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateFileMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchUpdateFileMetaResponse BatchUpdateFileMeta(BatchUpdateFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUpdateFileMetaWithOptions(request, runtime);
        }

        public async Task<BatchUpdateFileMetaResponse> BatchUpdateFileMetaAsync(BatchUpdateFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUpdateFileMetaWithOptionsAsync(request, runtime);
        }

        public CompareImageFacesResponse CompareImageFacesWithOptions(CompareImageFacesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CompareImageFacesShrinkRequest request = new CompareImageFacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Source))
            {
                request.SourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Source, "Source", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceShrink))
            {
                query["Source"] = request.SourceShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompareImageFaces",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompareImageFacesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CompareImageFacesResponse> CompareImageFacesWithOptionsAsync(CompareImageFacesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CompareImageFacesShrinkRequest request = new CompareImageFacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Source))
            {
                request.SourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Source, "Source", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceShrink))
            {
                query["Source"] = request.SourceShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompareImageFaces",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompareImageFacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CompareImageFacesResponse CompareImageFaces(CompareImageFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompareImageFacesWithOptions(request, runtime);
        }

        public async Task<CompareImageFacesResponse> CompareImageFacesAsync(CompareImageFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompareImageFacesWithOptionsAsync(request, runtime);
        }

        public CreateArchiveFileInspectionTaskResponse CreateArchiveFileInspectionTaskWithOptions(CreateArchiveFileInspectionTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateArchiveFileInspectionTaskShrinkRequest request = new CreateArchiveFileInspectionTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateArchiveFileInspectionTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateArchiveFileInspectionTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateArchiveFileInspectionTaskResponse> CreateArchiveFileInspectionTaskWithOptionsAsync(CreateArchiveFileInspectionTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateArchiveFileInspectionTaskShrinkRequest request = new CreateArchiveFileInspectionTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateArchiveFileInspectionTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateArchiveFileInspectionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateArchiveFileInspectionTaskResponse CreateArchiveFileInspectionTask(CreateArchiveFileInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateArchiveFileInspectionTaskWithOptions(request, runtime);
        }

        public async Task<CreateArchiveFileInspectionTaskResponse> CreateArchiveFileInspectionTaskAsync(CreateArchiveFileInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateArchiveFileInspectionTaskWithOptionsAsync(request, runtime);
        }

        public CreateBatchResponse CreateBatchWithOptions(CreateBatchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBatchShrinkRequest request = new CreateBatchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Actions))
            {
                request.ActionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Actions, "Actions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionsShrink))
            {
                body["Actions"] = request.ActionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                body["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                body["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRole))
            {
                body["ServiceRole"] = request.ServiceRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBatch",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBatchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateBatchResponse> CreateBatchWithOptionsAsync(CreateBatchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBatchShrinkRequest request = new CreateBatchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Actions))
            {
                request.ActionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Actions, "Actions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionsShrink))
            {
                body["Actions"] = request.ActionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                body["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                body["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRole))
            {
                body["ServiceRole"] = request.ServiceRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBatch",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateBatchResponse CreateBatch(CreateBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBatchWithOptions(request, runtime);
        }

        public async Task<CreateBatchResponse> CreateBatchAsync(CreateBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBatchWithOptionsAsync(request, runtime);
        }

        public CreateBindingResponse CreateBindingWithOptions(CreateBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBinding",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBindingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateBindingResponse> CreateBindingWithOptionsAsync(CreateBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBinding",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBindingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateBindingResponse CreateBinding(CreateBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBindingWithOptions(request, runtime);
        }

        public async Task<CreateBindingResponse> CreateBindingAsync(CreateBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBindingWithOptionsAsync(request, runtime);
        }

        public CreateCompressPointCloudTaskResponse CreateCompressPointCloudTaskWithOptions(CreateCompressPointCloudTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCompressPointCloudTaskShrinkRequest request = new CreateCompressPointCloudTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.KdtreeOption))
            {
                request.KdtreeOptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.KdtreeOption, "KdtreeOption", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OctreeOption))
            {
                request.OctreeOptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OctreeOption, "OctreeOption", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PointCloudFields))
            {
                request.PointCloudFieldsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PointCloudFields, "PointCloudFields", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompressMethod))
            {
                query["CompressMethod"] = request.CompressMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KdtreeOptionShrink))
            {
                query["KdtreeOption"] = request.KdtreeOptionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OctreeOptionShrink))
            {
                query["OctreeOption"] = request.OctreeOptionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PointCloudFieldsShrink))
            {
                query["PointCloudFields"] = request.PointCloudFieldsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PointCloudFileFormat))
            {
                query["PointCloudFileFormat"] = request.PointCloudFileFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURI))
            {
                query["TargetURI"] = request.TargetURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCompressPointCloudTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCompressPointCloudTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCompressPointCloudTaskResponse> CreateCompressPointCloudTaskWithOptionsAsync(CreateCompressPointCloudTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCompressPointCloudTaskShrinkRequest request = new CreateCompressPointCloudTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.KdtreeOption))
            {
                request.KdtreeOptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.KdtreeOption, "KdtreeOption", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OctreeOption))
            {
                request.OctreeOptionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OctreeOption, "OctreeOption", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PointCloudFields))
            {
                request.PointCloudFieldsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PointCloudFields, "PointCloudFields", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompressMethod))
            {
                query["CompressMethod"] = request.CompressMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KdtreeOptionShrink))
            {
                query["KdtreeOption"] = request.KdtreeOptionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OctreeOptionShrink))
            {
                query["OctreeOption"] = request.OctreeOptionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PointCloudFieldsShrink))
            {
                query["PointCloudFields"] = request.PointCloudFieldsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PointCloudFileFormat))
            {
                query["PointCloudFileFormat"] = request.PointCloudFileFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURI))
            {
                query["TargetURI"] = request.TargetURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCompressPointCloudTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCompressPointCloudTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCompressPointCloudTaskResponse CreateCompressPointCloudTask(CreateCompressPointCloudTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCompressPointCloudTaskWithOptions(request, runtime);
        }

        public async Task<CreateCompressPointCloudTaskResponse> CreateCompressPointCloudTaskAsync(CreateCompressPointCloudTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCompressPointCloudTaskWithOptionsAsync(request, runtime);
        }

        public CreateCustomizedStoryResponse CreateCustomizedStoryWithOptions(CreateCustomizedStoryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCustomizedStoryShrinkRequest request = new CreateCustomizedStoryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Cover))
            {
                request.CoverShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Cover, "Cover", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomLabels))
            {
                request.CustomLabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomLabels, "CustomLabels", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Files))
            {
                request.FilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Files, "Files", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverShrink))
            {
                body["Cover"] = request.CoverShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabelsShrink))
            {
                body["CustomLabels"] = request.CustomLabelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesShrink))
            {
                body["Files"] = request.FilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryName))
            {
                body["StoryName"] = request.StoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorySubType))
            {
                body["StorySubType"] = request.StorySubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryType))
            {
                body["StoryType"] = request.StoryType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomizedStory",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomizedStoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCustomizedStoryResponse> CreateCustomizedStoryWithOptionsAsync(CreateCustomizedStoryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCustomizedStoryShrinkRequest request = new CreateCustomizedStoryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Cover))
            {
                request.CoverShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Cover, "Cover", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomLabels))
            {
                request.CustomLabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomLabels, "CustomLabels", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Files))
            {
                request.FilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Files, "Files", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverShrink))
            {
                body["Cover"] = request.CoverShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabelsShrink))
            {
                body["CustomLabels"] = request.CustomLabelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesShrink))
            {
                body["Files"] = request.FilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryName))
            {
                body["StoryName"] = request.StoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorySubType))
            {
                body["StorySubType"] = request.StorySubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryType))
            {
                body["StoryType"] = request.StoryType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomizedStory",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomizedStoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCustomizedStoryResponse CreateCustomizedStory(CreateCustomizedStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomizedStoryWithOptions(request, runtime);
        }

        public async Task<CreateCustomizedStoryResponse> CreateCustomizedStoryAsync(CreateCustomizedStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomizedStoryWithOptionsAsync(request, runtime);
        }

        public CreateDatasetResponse CreateDatasetWithOptions(CreateDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxBindCount))
            {
                query["DatasetMaxBindCount"] = request.DatasetMaxBindCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxEntityCount))
            {
                query["DatasetMaxEntityCount"] = request.DatasetMaxEntityCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxFileCount))
            {
                query["DatasetMaxFileCount"] = request.DatasetMaxFileCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxRelationCount))
            {
                query["DatasetMaxRelationCount"] = request.DatasetMaxRelationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxTotalFileSize))
            {
                query["DatasetMaxTotalFileSize"] = request.DatasetMaxTotalFileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataset",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDatasetResponse> CreateDatasetWithOptionsAsync(CreateDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxBindCount))
            {
                query["DatasetMaxBindCount"] = request.DatasetMaxBindCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxEntityCount))
            {
                query["DatasetMaxEntityCount"] = request.DatasetMaxEntityCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxFileCount))
            {
                query["DatasetMaxFileCount"] = request.DatasetMaxFileCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxRelationCount))
            {
                query["DatasetMaxRelationCount"] = request.DatasetMaxRelationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxTotalFileSize))
            {
                query["DatasetMaxTotalFileSize"] = request.DatasetMaxTotalFileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataset",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDatasetWithOptions(request, runtime);
        }

        public async Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDatasetWithOptionsAsync(request, runtime);
        }

        public CreateFacesSearchingTaskResponse CreateFacesSearchingTaskWithOptions(CreateFacesSearchingTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFacesSearchingTaskShrinkRequest request = new CreateFacesSearchingTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sources))
            {
                request.SourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sources, "Sources", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResult))
            {
                query["MaxResult"] = request.MaxResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcesShrink))
            {
                query["Sources"] = request.SourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFacesSearchingTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFacesSearchingTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFacesSearchingTaskResponse> CreateFacesSearchingTaskWithOptionsAsync(CreateFacesSearchingTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFacesSearchingTaskShrinkRequest request = new CreateFacesSearchingTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sources))
            {
                request.SourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sources, "Sources", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResult))
            {
                query["MaxResult"] = request.MaxResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcesShrink))
            {
                query["Sources"] = request.SourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFacesSearchingTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFacesSearchingTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFacesSearchingTaskResponse CreateFacesSearchingTask(CreateFacesSearchingTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFacesSearchingTaskWithOptions(request, runtime);
        }

        public async Task<CreateFacesSearchingTaskResponse> CreateFacesSearchingTaskAsync(CreateFacesSearchingTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFacesSearchingTaskWithOptionsAsync(request, runtime);
        }

        public CreateFigureClusteringTaskResponse CreateFigureClusteringTaskWithOptions(CreateFigureClusteringTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFigureClusteringTaskShrinkRequest request = new CreateFigureClusteringTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFigureClusteringTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFigureClusteringTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFigureClusteringTaskResponse> CreateFigureClusteringTaskWithOptionsAsync(CreateFigureClusteringTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFigureClusteringTaskShrinkRequest request = new CreateFigureClusteringTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFigureClusteringTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFigureClusteringTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFigureClusteringTaskResponse CreateFigureClusteringTask(CreateFigureClusteringTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFigureClusteringTaskWithOptions(request, runtime);
        }

        public async Task<CreateFigureClusteringTaskResponse> CreateFigureClusteringTaskAsync(CreateFigureClusteringTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFigureClusteringTaskWithOptionsAsync(request, runtime);
        }

        public CreateFigureClustersMergingTaskResponse CreateFigureClustersMergingTaskWithOptions(CreateFigureClustersMergingTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFigureClustersMergingTaskShrinkRequest request = new CreateFigureClustersMergingTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Froms))
            {
                request.FromsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Froms, "Froms", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromsShrink))
            {
                query["Froms"] = request.FromsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["To"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFigureClustersMergingTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFigureClustersMergingTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFigureClustersMergingTaskResponse> CreateFigureClustersMergingTaskWithOptionsAsync(CreateFigureClustersMergingTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFigureClustersMergingTaskShrinkRequest request = new CreateFigureClustersMergingTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Froms))
            {
                request.FromsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Froms, "Froms", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromsShrink))
            {
                query["Froms"] = request.FromsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["To"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFigureClustersMergingTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFigureClustersMergingTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFigureClustersMergingTaskResponse CreateFigureClustersMergingTask(CreateFigureClustersMergingTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFigureClustersMergingTaskWithOptions(request, runtime);
        }

        public async Task<CreateFigureClustersMergingTaskResponse> CreateFigureClustersMergingTaskAsync(CreateFigureClustersMergingTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFigureClustersMergingTaskWithOptionsAsync(request, runtime);
        }

        public CreateFileCompressionTaskResponse CreateFileCompressionTaskWithOptions(CreateFileCompressionTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFileCompressionTaskShrinkRequest request = new CreateFileCompressionTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sources))
            {
                request.SourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sources, "Sources", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompressedFormat))
            {
                query["CompressedFormat"] = request.CompressedFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceManifestURI))
            {
                query["SourceManifestURI"] = request.SourceManifestURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcesShrink))
            {
                query["Sources"] = request.SourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURI))
            {
                query["TargetURI"] = request.TargetURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFileCompressionTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFileCompressionTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFileCompressionTaskResponse> CreateFileCompressionTaskWithOptionsAsync(CreateFileCompressionTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFileCompressionTaskShrinkRequest request = new CreateFileCompressionTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sources))
            {
                request.SourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sources, "Sources", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompressedFormat))
            {
                query["CompressedFormat"] = request.CompressedFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceManifestURI))
            {
                query["SourceManifestURI"] = request.SourceManifestURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcesShrink))
            {
                query["Sources"] = request.SourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURI))
            {
                query["TargetURI"] = request.TargetURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFileCompressionTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFileCompressionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFileCompressionTaskResponse CreateFileCompressionTask(CreateFileCompressionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFileCompressionTaskWithOptions(request, runtime);
        }

        public async Task<CreateFileCompressionTaskResponse> CreateFileCompressionTaskAsync(CreateFileCompressionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFileCompressionTaskWithOptionsAsync(request, runtime);
        }

        public CreateFileUncompressionTaskResponse CreateFileUncompressionTaskWithOptions(CreateFileUncompressionTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFileUncompressionTaskShrinkRequest request = new CreateFileUncompressionTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SelectedFiles))
            {
                request.SelectedFilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SelectedFiles, "SelectedFiles", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectedFilesShrink))
            {
                query["SelectedFiles"] = request.SelectedFilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURI))
            {
                query["TargetURI"] = request.TargetURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFileUncompressionTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFileUncompressionTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFileUncompressionTaskResponse> CreateFileUncompressionTaskWithOptionsAsync(CreateFileUncompressionTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFileUncompressionTaskShrinkRequest request = new CreateFileUncompressionTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SelectedFiles))
            {
                request.SelectedFilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SelectedFiles, "SelectedFiles", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectedFilesShrink))
            {
                query["SelectedFiles"] = request.SelectedFilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURI))
            {
                query["TargetURI"] = request.TargetURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFileUncompressionTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFileUncompressionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFileUncompressionTaskResponse CreateFileUncompressionTask(CreateFileUncompressionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFileUncompressionTaskWithOptions(request, runtime);
        }

        public async Task<CreateFileUncompressionTaskResponse> CreateFileUncompressionTaskAsync(CreateFileUncompressionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFileUncompressionTaskWithOptionsAsync(request, runtime);
        }

        public CreateImageModerationTaskResponse CreateImageModerationTaskWithOptions(CreateImageModerationTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateImageModerationTaskShrinkRequest request = new CreateImageModerationTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Scenes))
            {
                request.ScenesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Scenes, "Scenes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxFrames))
            {
                query["MaxFrames"] = request.MaxFrames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenesShrink))
            {
                query["Scenes"] = request.ScenesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageModerationTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageModerationTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateImageModerationTaskResponse> CreateImageModerationTaskWithOptionsAsync(CreateImageModerationTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateImageModerationTaskShrinkRequest request = new CreateImageModerationTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Scenes))
            {
                request.ScenesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Scenes, "Scenes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxFrames))
            {
                query["MaxFrames"] = request.MaxFrames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenesShrink))
            {
                query["Scenes"] = request.ScenesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageModerationTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageModerationTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateImageModerationTaskResponse CreateImageModerationTask(CreateImageModerationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageModerationTaskWithOptions(request, runtime);
        }

        public async Task<CreateImageModerationTaskResponse> CreateImageModerationTaskAsync(CreateImageModerationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageModerationTaskWithOptionsAsync(request, runtime);
        }

        public CreateImageSplicingTaskResponse CreateImageSplicingTaskWithOptions(CreateImageSplicingTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateImageSplicingTaskShrinkRequest request = new CreateImageSplicingTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sources))
            {
                request.SourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sources, "Sources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Align))
            {
                query["Align"] = request.Align;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundColor))
            {
                query["BackgroundColor"] = request.BackgroundColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFormat))
            {
                query["ImageFormat"] = request.ImageFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Margin))
            {
                query["Margin"] = request.Margin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Padding))
            {
                query["Padding"] = request.Padding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quality))
            {
                query["Quality"] = request.Quality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleType))
            {
                query["ScaleType"] = request.ScaleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcesShrink))
            {
                query["Sources"] = request.SourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURI))
            {
                query["TargetURI"] = request.TargetURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageSplicingTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageSplicingTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateImageSplicingTaskResponse> CreateImageSplicingTaskWithOptionsAsync(CreateImageSplicingTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateImageSplicingTaskShrinkRequest request = new CreateImageSplicingTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sources))
            {
                request.SourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sources, "Sources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Align))
            {
                query["Align"] = request.Align;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundColor))
            {
                query["BackgroundColor"] = request.BackgroundColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFormat))
            {
                query["ImageFormat"] = request.ImageFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Margin))
            {
                query["Margin"] = request.Margin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Padding))
            {
                query["Padding"] = request.Padding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quality))
            {
                query["Quality"] = request.Quality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleType))
            {
                query["ScaleType"] = request.ScaleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcesShrink))
            {
                query["Sources"] = request.SourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURI))
            {
                query["TargetURI"] = request.TargetURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageSplicingTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageSplicingTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateImageSplicingTaskResponse CreateImageSplicingTask(CreateImageSplicingTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageSplicingTaskWithOptions(request, runtime);
        }

        public async Task<CreateImageSplicingTaskResponse> CreateImageSplicingTaskAsync(CreateImageSplicingTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageSplicingTaskWithOptionsAsync(request, runtime);
        }

        public CreateImageToPDFTaskResponse CreateImageToPDFTaskWithOptions(CreateImageToPDFTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateImageToPDFTaskShrinkRequest request = new CreateImageToPDFTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sources))
            {
                request.SourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sources, "Sources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcesShrink))
            {
                query["Sources"] = request.SourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURI))
            {
                query["TargetURI"] = request.TargetURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageToPDFTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageToPDFTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateImageToPDFTaskResponse> CreateImageToPDFTaskWithOptionsAsync(CreateImageToPDFTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateImageToPDFTaskShrinkRequest request = new CreateImageToPDFTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sources))
            {
                request.SourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sources, "Sources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcesShrink))
            {
                query["Sources"] = request.SourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURI))
            {
                query["TargetURI"] = request.TargetURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageToPDFTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageToPDFTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateImageToPDFTaskResponse CreateImageToPDFTask(CreateImageToPDFTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageToPDFTaskWithOptions(request, runtime);
        }

        public async Task<CreateImageToPDFTaskResponse> CreateImageToPDFTaskAsync(CreateImageToPDFTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageToPDFTaskWithOptionsAsync(request, runtime);
        }

        public CreateLocationDateClusteringTaskResponse CreateLocationDateClusteringTaskWithOptions(CreateLocationDateClusteringTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateLocationDateClusteringTaskShrinkRequest request = new CreateLocationDateClusteringTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DateOptions))
            {
                request.DateOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DateOptions, "DateOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LocationOptions))
            {
                request.LocationOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LocationOptions, "LocationOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateOptionsShrink))
            {
                query["DateOptions"] = request.DateOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationOptionsShrink))
            {
                query["LocationOptions"] = request.LocationOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLocationDateClusteringTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLocationDateClusteringTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateLocationDateClusteringTaskResponse> CreateLocationDateClusteringTaskWithOptionsAsync(CreateLocationDateClusteringTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateLocationDateClusteringTaskShrinkRequest request = new CreateLocationDateClusteringTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DateOptions))
            {
                request.DateOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DateOptions, "DateOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LocationOptions))
            {
                request.LocationOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LocationOptions, "LocationOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateOptionsShrink))
            {
                query["DateOptions"] = request.DateOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationOptionsShrink))
            {
                query["LocationOptions"] = request.LocationOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLocationDateClusteringTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLocationDateClusteringTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateLocationDateClusteringTaskResponse CreateLocationDateClusteringTask(CreateLocationDateClusteringTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLocationDateClusteringTaskWithOptions(request, runtime);
        }

        public async Task<CreateLocationDateClusteringTaskResponse> CreateLocationDateClusteringTaskAsync(CreateLocationDateClusteringTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLocationDateClusteringTaskWithOptionsAsync(request, runtime);
        }

        public CreateMediaConvertTaskResponse CreateMediaConvertTaskWithOptions(CreateMediaConvertTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateMediaConvertTaskShrinkRequest request = new CreateMediaConvertTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sources))
            {
                request.SourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sources, "Sources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Targets))
            {
                request.TargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Targets, "Targets", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlignmentIndex))
            {
                query["AlignmentIndex"] = request.AlignmentIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcesShrink))
            {
                query["Sources"] = request.SourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetsShrink))
            {
                query["Targets"] = request.TargetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMediaConvertTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMediaConvertTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateMediaConvertTaskResponse> CreateMediaConvertTaskWithOptionsAsync(CreateMediaConvertTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateMediaConvertTaskShrinkRequest request = new CreateMediaConvertTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sources))
            {
                request.SourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sources, "Sources", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Targets))
            {
                request.TargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Targets, "Targets", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlignmentIndex))
            {
                query["AlignmentIndex"] = request.AlignmentIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcesShrink))
            {
                query["Sources"] = request.SourcesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetsShrink))
            {
                query["Targets"] = request.TargetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMediaConvertTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMediaConvertTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateMediaConvertTaskResponse CreateMediaConvertTask(CreateMediaConvertTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMediaConvertTaskWithOptions(request, runtime);
        }

        public async Task<CreateMediaConvertTaskResponse> CreateMediaConvertTaskAsync(CreateMediaConvertTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMediaConvertTaskWithOptionsAsync(request, runtime);
        }

        public CreateOfficeConversionTaskResponse CreateOfficeConversionTaskWithOptions(CreateOfficeConversionTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOfficeConversionTaskShrinkRequest request = new CreateOfficeConversionTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TrimPolicy))
            {
                request.TrimPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TrimPolicy, "TrimPolicy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPage))
            {
                query["EndPage"] = request.EndPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstPage))
            {
                query["FirstPage"] = request.FirstPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FitToHeight))
            {
                query["FitToHeight"] = request.FitToHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FitToWidth))
            {
                query["FitToWidth"] = request.FitToWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoldLineFeed))
            {
                query["HoldLineFeed"] = request.HoldLineFeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageDPI))
            {
                query["ImageDPI"] = request.ImageDPI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LongPicture))
            {
                query["LongPicture"] = request.LongPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LongText))
            {
                query["LongText"] = request.LongText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSheetColumn))
            {
                query["MaxSheetColumn"] = request.MaxSheetColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSheetRow))
            {
                query["MaxSheetRow"] = request.MaxSheetRow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pages))
            {
                query["Pages"] = request.Pages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaperHorizontal))
            {
                query["PaperHorizontal"] = request.PaperHorizontal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaperSize))
            {
                query["PaperSize"] = request.PaperSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quality))
            {
                query["Quality"] = request.Quality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalePercentage))
            {
                query["ScalePercentage"] = request.ScalePercentage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetCount))
            {
                query["SheetCount"] = request.SheetCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetIndex))
            {
                query["SheetIndex"] = request.SheetIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowComments))
            {
                query["ShowComments"] = request.ShowComments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPage))
            {
                query["StartPage"] = request.StartPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURI))
            {
                query["TargetURI"] = request.TargetURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURIPrefix))
            {
                query["TargetURIPrefix"] = request.TargetURIPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrimPolicyShrink))
            {
                query["TrimPolicy"] = request.TrimPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOfficeConversionTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOfficeConversionTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateOfficeConversionTaskResponse> CreateOfficeConversionTaskWithOptionsAsync(CreateOfficeConversionTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOfficeConversionTaskShrinkRequest request = new CreateOfficeConversionTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TrimPolicy))
            {
                request.TrimPolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TrimPolicy, "TrimPolicy", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPage))
            {
                query["EndPage"] = request.EndPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstPage))
            {
                query["FirstPage"] = request.FirstPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FitToHeight))
            {
                query["FitToHeight"] = request.FitToHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FitToWidth))
            {
                query["FitToWidth"] = request.FitToWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HoldLineFeed))
            {
                query["HoldLineFeed"] = request.HoldLineFeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageDPI))
            {
                query["ImageDPI"] = request.ImageDPI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LongPicture))
            {
                query["LongPicture"] = request.LongPicture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LongText))
            {
                query["LongText"] = request.LongText;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSheetColumn))
            {
                query["MaxSheetColumn"] = request.MaxSheetColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSheetRow))
            {
                query["MaxSheetRow"] = request.MaxSheetRow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pages))
            {
                query["Pages"] = request.Pages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaperHorizontal))
            {
                query["PaperHorizontal"] = request.PaperHorizontal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaperSize))
            {
                query["PaperSize"] = request.PaperSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quality))
            {
                query["Quality"] = request.Quality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalePercentage))
            {
                query["ScalePercentage"] = request.ScalePercentage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetCount))
            {
                query["SheetCount"] = request.SheetCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetIndex))
            {
                query["SheetIndex"] = request.SheetIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowComments))
            {
                query["ShowComments"] = request.ShowComments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPage))
            {
                query["StartPage"] = request.StartPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURI))
            {
                query["TargetURI"] = request.TargetURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURIPrefix))
            {
                query["TargetURIPrefix"] = request.TargetURIPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrimPolicyShrink))
            {
                query["TrimPolicy"] = request.TrimPolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOfficeConversionTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOfficeConversionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateOfficeConversionTaskResponse CreateOfficeConversionTask(CreateOfficeConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOfficeConversionTaskWithOptions(request, runtime);
        }

        public async Task<CreateOfficeConversionTaskResponse> CreateOfficeConversionTaskAsync(CreateOfficeConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOfficeConversionTaskWithOptionsAsync(request, runtime);
        }

        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxBindCount))
            {
                query["DatasetMaxBindCount"] = request.DatasetMaxBindCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxEntityCount))
            {
                query["DatasetMaxEntityCount"] = request.DatasetMaxEntityCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxFileCount))
            {
                query["DatasetMaxFileCount"] = request.DatasetMaxFileCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxRelationCount))
            {
                query["DatasetMaxRelationCount"] = request.DatasetMaxRelationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxTotalFileSize))
            {
                query["DatasetMaxTotalFileSize"] = request.DatasetMaxTotalFileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectMaxDatasetCount))
            {
                query["ProjectMaxDatasetCount"] = request.ProjectMaxDatasetCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRole))
            {
                query["ServiceRole"] = request.ServiceRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxBindCount))
            {
                query["DatasetMaxBindCount"] = request.DatasetMaxBindCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxEntityCount))
            {
                query["DatasetMaxEntityCount"] = request.DatasetMaxEntityCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxFileCount))
            {
                query["DatasetMaxFileCount"] = request.DatasetMaxFileCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxRelationCount))
            {
                query["DatasetMaxRelationCount"] = request.DatasetMaxRelationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxTotalFileSize))
            {
                query["DatasetMaxTotalFileSize"] = request.DatasetMaxTotalFileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectMaxDatasetCount))
            {
                query["ProjectMaxDatasetCount"] = request.ProjectMaxDatasetCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRole))
            {
                query["ServiceRole"] = request.ServiceRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProjectWithOptions(request, runtime);
        }

        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProjectWithOptionsAsync(request, runtime);
        }

        public CreateSimilarImageClusteringTaskResponse CreateSimilarImageClusteringTaskWithOptions(CreateSimilarImageClusteringTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSimilarImageClusteringTaskShrinkRequest request = new CreateSimilarImageClusteringTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSimilarImageClusteringTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSimilarImageClusteringTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSimilarImageClusteringTaskResponse> CreateSimilarImageClusteringTaskWithOptionsAsync(CreateSimilarImageClusteringTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSimilarImageClusteringTaskShrinkRequest request = new CreateSimilarImageClusteringTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSimilarImageClusteringTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSimilarImageClusteringTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSimilarImageClusteringTaskResponse CreateSimilarImageClusteringTask(CreateSimilarImageClusteringTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSimilarImageClusteringTaskWithOptions(request, runtime);
        }

        public async Task<CreateSimilarImageClusteringTaskResponse> CreateSimilarImageClusteringTaskAsync(CreateSimilarImageClusteringTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSimilarImageClusteringTaskWithOptionsAsync(request, runtime);
        }

        public CreateStoryResponse CreateStoryWithOptions(CreateStoryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateStoryShrinkRequest request = new CreateStoryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Address))
            {
                request.AddressShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Address, "Address", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomLabels))
            {
                request.CustomLabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomLabels, "CustomLabels", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressShrink))
            {
                body["Address"] = request.AddressShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomId))
            {
                body["CustomId"] = request.CustomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabelsShrink))
            {
                body["CustomLabels"] = request.CustomLabelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxFileCount))
            {
                body["MaxFileCount"] = request.MaxFileCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinFileCount))
            {
                body["MinFileCount"] = request.MinFileCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                body["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryEndTime))
            {
                body["StoryEndTime"] = request.StoryEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryName))
            {
                body["StoryName"] = request.StoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryStartTime))
            {
                body["StoryStartTime"] = request.StoryStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorySubType))
            {
                body["StorySubType"] = request.StorySubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryType))
            {
                body["StoryType"] = request.StoryType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStory",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateStoryResponse> CreateStoryWithOptionsAsync(CreateStoryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateStoryShrinkRequest request = new CreateStoryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Address))
            {
                request.AddressShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Address, "Address", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomLabels))
            {
                request.CustomLabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomLabels, "CustomLabels", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressShrink))
            {
                body["Address"] = request.AddressShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomId))
            {
                body["CustomId"] = request.CustomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabelsShrink))
            {
                body["CustomLabels"] = request.CustomLabelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxFileCount))
            {
                body["MaxFileCount"] = request.MaxFileCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinFileCount))
            {
                body["MinFileCount"] = request.MinFileCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                body["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryEndTime))
            {
                body["StoryEndTime"] = request.StoryEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryName))
            {
                body["StoryName"] = request.StoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryStartTime))
            {
                body["StoryStartTime"] = request.StoryStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorySubType))
            {
                body["StorySubType"] = request.StorySubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryType))
            {
                body["StoryType"] = request.StoryType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStory",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateStoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateStoryResponse CreateStory(CreateStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStoryWithOptions(request, runtime);
        }

        public async Task<CreateStoryResponse> CreateStoryAsync(CreateStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStoryWithOptionsAsync(request, runtime);
        }

        public CreateTriggerResponse CreateTriggerWithOptions(CreateTriggerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTriggerShrinkRequest request = new CreateTriggerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Actions))
            {
                request.ActionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Actions, "Actions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionsShrink))
            {
                body["Actions"] = request.ActionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                body["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                body["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRole))
            {
                body["ServiceRole"] = request.ServiceRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrigger",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTriggerResponse> CreateTriggerWithOptionsAsync(CreateTriggerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTriggerShrinkRequest request = new CreateTriggerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Actions))
            {
                request.ActionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Actions, "Actions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionsShrink))
            {
                body["Actions"] = request.ActionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                body["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                body["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRole))
            {
                body["ServiceRole"] = request.ServiceRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrigger",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTriggerResponse CreateTrigger(CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTriggerWithOptions(request, runtime);
        }

        public async Task<CreateTriggerResponse> CreateTriggerAsync(CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTriggerWithOptionsAsync(request, runtime);
        }

        public CreateVideoLabelClassificationTaskResponse CreateVideoLabelClassificationTaskWithOptions(CreateVideoLabelClassificationTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateVideoLabelClassificationTaskShrinkRequest request = new CreateVideoLabelClassificationTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVideoLabelClassificationTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoLabelClassificationTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateVideoLabelClassificationTaskResponse> CreateVideoLabelClassificationTaskWithOptionsAsync(CreateVideoLabelClassificationTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateVideoLabelClassificationTaskShrinkRequest request = new CreateVideoLabelClassificationTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVideoLabelClassificationTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoLabelClassificationTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateVideoLabelClassificationTaskResponse CreateVideoLabelClassificationTask(CreateVideoLabelClassificationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVideoLabelClassificationTaskWithOptions(request, runtime);
        }

        public async Task<CreateVideoLabelClassificationTaskResponse> CreateVideoLabelClassificationTaskAsync(CreateVideoLabelClassificationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVideoLabelClassificationTaskWithOptionsAsync(request, runtime);
        }

        public CreateVideoModerationTaskResponse CreateVideoModerationTaskWithOptions(CreateVideoModerationTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateVideoModerationTaskShrinkRequest request = new CreateVideoModerationTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Scenes))
            {
                request.ScenesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Scenes, "Scenes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxFrames))
            {
                query["MaxFrames"] = request.MaxFrames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenesShrink))
            {
                query["Scenes"] = request.ScenesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVideoModerationTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoModerationTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateVideoModerationTaskResponse> CreateVideoModerationTaskWithOptionsAsync(CreateVideoModerationTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateVideoModerationTaskShrinkRequest request = new CreateVideoModerationTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Scenes))
            {
                request.ScenesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Scenes, "Scenes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxFrames))
            {
                query["MaxFrames"] = request.MaxFrames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScenesShrink))
            {
                query["Scenes"] = request.ScenesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVideoModerationTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoModerationTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateVideoModerationTaskResponse CreateVideoModerationTask(CreateVideoModerationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVideoModerationTaskWithOptions(request, runtime);
        }

        public async Task<CreateVideoModerationTaskResponse> CreateVideoModerationTaskAsync(CreateVideoModerationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVideoModerationTaskWithOptionsAsync(request, runtime);
        }

        public DeleteBatchResponse DeleteBatchWithOptions(DeleteBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBatch",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBatchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteBatchResponse> DeleteBatchWithOptionsAsync(DeleteBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBatch",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteBatchResponse DeleteBatch(DeleteBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBatchWithOptions(request, runtime);
        }

        public async Task<DeleteBatchResponse> DeleteBatchAsync(DeleteBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBatchWithOptionsAsync(request, runtime);
        }

        public DeleteBindingResponse DeleteBindingWithOptions(DeleteBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBinding",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBindingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteBindingResponse> DeleteBindingWithOptionsAsync(DeleteBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBinding",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBindingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteBindingResponse DeleteBinding(DeleteBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBindingWithOptions(request, runtime);
        }

        public async Task<DeleteBindingResponse> DeleteBindingAsync(DeleteBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBindingWithOptionsAsync(request, runtime);
        }

        public DeleteDatasetResponse DeleteDatasetWithOptions(DeleteDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataset",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDatasetResponse> DeleteDatasetWithOptionsAsync(DeleteDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataset",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDatasetWithOptions(request, runtime);
        }

        public async Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDatasetWithOptionsAsync(request, runtime);
        }

        public DeleteFileMetaResponse DeleteFileMetaWithOptions(DeleteFileMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFileMeta",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileMetaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFileMetaResponse> DeleteFileMetaWithOptionsAsync(DeleteFileMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFileMeta",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFileMetaResponse DeleteFileMeta(DeleteFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFileMetaWithOptions(request, runtime);
        }

        public async Task<DeleteFileMetaResponse> DeleteFileMetaAsync(DeleteFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFileMetaWithOptionsAsync(request, runtime);
        }

        public DeleteLocationDateClusterResponse DeleteLocationDateClusterWithOptions(DeleteLocationDateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["ObjectId"] = request.ObjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLocationDateCluster",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLocationDateClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteLocationDateClusterResponse> DeleteLocationDateClusterWithOptionsAsync(DeleteLocationDateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["ObjectId"] = request.ObjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLocationDateCluster",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLocationDateClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteLocationDateClusterResponse DeleteLocationDateCluster(DeleteLocationDateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLocationDateClusterWithOptions(request, runtime);
        }

        public async Task<DeleteLocationDateClusterResponse> DeleteLocationDateClusterAsync(DeleteLocationDateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLocationDateClusterWithOptionsAsync(request, runtime);
        }

        public DeleteProjectResponse DeleteProjectWithOptions(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteProjectResponse> DeleteProjectWithOptionsAsync(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProjectWithOptions(request, runtime);
        }

        public async Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProjectWithOptionsAsync(request, runtime);
        }

        public DeleteStoryResponse DeleteStoryWithOptions(DeleteStoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                query["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStory",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteStoryResponse> DeleteStoryWithOptionsAsync(DeleteStoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                query["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteStory",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteStoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteStoryResponse DeleteStory(DeleteStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStoryWithOptions(request, runtime);
        }

        public async Task<DeleteStoryResponse> DeleteStoryAsync(DeleteStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStoryWithOptionsAsync(request, runtime);
        }

        public DeleteTriggerResponse DeleteTriggerWithOptions(DeleteTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrigger",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTriggerResponse> DeleteTriggerWithOptionsAsync(DeleteTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrigger",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTriggerResponse DeleteTrigger(DeleteTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTriggerWithOptions(request, runtime);
        }

        public async Task<DeleteTriggerResponse> DeleteTriggerAsync(DeleteTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTriggerWithOptionsAsync(request, runtime);
        }

        public DetachOSSBucketResponse DetachOSSBucketWithOptions(DetachOSSBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OSSBucket))
            {
                query["OSSBucket"] = request.OSSBucket;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachOSSBucket",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachOSSBucketResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetachOSSBucketResponse> DetachOSSBucketWithOptionsAsync(DetachOSSBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OSSBucket))
            {
                query["OSSBucket"] = request.OSSBucket;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachOSSBucket",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachOSSBucketResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetachOSSBucketResponse DetachOSSBucket(DetachOSSBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachOSSBucketWithOptions(request, runtime);
        }

        public async Task<DetachOSSBucketResponse> DetachOSSBucketAsync(DetachOSSBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachOSSBucketWithOptionsAsync(request, runtime);
        }

        public DetectImageBodiesResponse DetectImageBodiesWithOptions(DetectImageBodiesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectImageBodiesShrinkRequest request = new DetectImageBodiesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sensitivity))
            {
                query["Sensitivity"] = request.Sensitivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageBodies",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageBodiesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetectImageBodiesResponse> DetectImageBodiesWithOptionsAsync(DetectImageBodiesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectImageBodiesShrinkRequest request = new DetectImageBodiesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sensitivity))
            {
                query["Sensitivity"] = request.Sensitivity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageBodies",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageBodiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetectImageBodiesResponse DetectImageBodies(DetectImageBodiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageBodiesWithOptions(request, runtime);
        }

        public async Task<DetectImageBodiesResponse> DetectImageBodiesAsync(DetectImageBodiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageBodiesWithOptionsAsync(request, runtime);
        }

        public DetectImageCarsResponse DetectImageCarsWithOptions(DetectImageCarsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectImageCarsShrinkRequest request = new DetectImageCarsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageCars",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageCarsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetectImageCarsResponse> DetectImageCarsWithOptionsAsync(DetectImageCarsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectImageCarsShrinkRequest request = new DetectImageCarsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageCars",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageCarsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetectImageCarsResponse DetectImageCars(DetectImageCarsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageCarsWithOptions(request, runtime);
        }

        public async Task<DetectImageCarsResponse> DetectImageCarsAsync(DetectImageCarsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageCarsWithOptionsAsync(request, runtime);
        }

        public DetectImageCodesResponse DetectImageCodesWithOptions(DetectImageCodesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectImageCodesShrinkRequest request = new DetectImageCodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageCodes",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageCodesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetectImageCodesResponse> DetectImageCodesWithOptionsAsync(DetectImageCodesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectImageCodesShrinkRequest request = new DetectImageCodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageCodes",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageCodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetectImageCodesResponse DetectImageCodes(DetectImageCodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageCodesWithOptions(request, runtime);
        }

        public async Task<DetectImageCodesResponse> DetectImageCodesAsync(DetectImageCodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageCodesWithOptionsAsync(request, runtime);
        }

        public DetectImageCroppingResponse DetectImageCroppingWithOptions(DetectImageCroppingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectImageCroppingShrinkRequest request = new DetectImageCroppingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AspectRatios))
            {
                query["AspectRatios"] = request.AspectRatios;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageCropping",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageCroppingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetectImageCroppingResponse> DetectImageCroppingWithOptionsAsync(DetectImageCroppingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectImageCroppingShrinkRequest request = new DetectImageCroppingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AspectRatios))
            {
                query["AspectRatios"] = request.AspectRatios;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageCropping",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageCroppingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetectImageCroppingResponse DetectImageCropping(DetectImageCroppingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageCroppingWithOptions(request, runtime);
        }

        public async Task<DetectImageCroppingResponse> DetectImageCroppingAsync(DetectImageCroppingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageCroppingWithOptionsAsync(request, runtime);
        }

        public DetectImageFacesResponse DetectImageFacesWithOptions(DetectImageFacesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectImageFacesShrinkRequest request = new DetectImageFacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageFaces",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageFacesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetectImageFacesResponse> DetectImageFacesWithOptionsAsync(DetectImageFacesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectImageFacesShrinkRequest request = new DetectImageFacesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageFaces",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageFacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetectImageFacesResponse DetectImageFaces(DetectImageFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageFacesWithOptions(request, runtime);
        }

        public async Task<DetectImageFacesResponse> DetectImageFacesAsync(DetectImageFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageFacesWithOptionsAsync(request, runtime);
        }

        public DetectImageLabelsResponse DetectImageLabelsWithOptions(DetectImageLabelsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectImageLabelsShrinkRequest request = new DetectImageLabelsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageLabels",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageLabelsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetectImageLabelsResponse> DetectImageLabelsWithOptionsAsync(DetectImageLabelsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectImageLabelsShrinkRequest request = new DetectImageLabelsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageLabels",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetectImageLabelsResponse DetectImageLabels(DetectImageLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageLabelsWithOptions(request, runtime);
        }

        public async Task<DetectImageLabelsResponse> DetectImageLabelsAsync(DetectImageLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageLabelsWithOptionsAsync(request, runtime);
        }

        public DetectImageScoreResponse DetectImageScoreWithOptions(DetectImageScoreRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectImageScoreShrinkRequest request = new DetectImageScoreShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageScore",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageScoreResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetectImageScoreResponse> DetectImageScoreWithOptionsAsync(DetectImageScoreRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectImageScoreShrinkRequest request = new DetectImageScoreShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageScore",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageScoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetectImageScoreResponse DetectImageScore(DetectImageScoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageScoreWithOptions(request, runtime);
        }

        public async Task<DetectImageScoreResponse> DetectImageScoreAsync(DetectImageScoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageScoreWithOptionsAsync(request, runtime);
        }

        public DetectMediaMetaResponse DetectMediaMetaWithOptions(DetectMediaMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectMediaMetaShrinkRequest request = new DetectMediaMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectMediaMeta",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectMediaMetaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetectMediaMetaResponse> DetectMediaMetaWithOptionsAsync(DetectMediaMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectMediaMetaShrinkRequest request = new DetectMediaMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectMediaMeta",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectMediaMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetectMediaMetaResponse DetectMediaMeta(DetectMediaMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectMediaMetaWithOptions(request, runtime);
        }

        public async Task<DetectMediaMetaResponse> DetectMediaMetaAsync(DetectMediaMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectMediaMetaWithOptionsAsync(request, runtime);
        }

        public DetectTextAnomalyResponse DetectTextAnomalyWithOptions(DetectTextAnomalyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectTextAnomaly",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectTextAnomalyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetectTextAnomalyResponse> DetectTextAnomalyWithOptionsAsync(DetectTextAnomalyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectTextAnomaly",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectTextAnomalyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetectTextAnomalyResponse DetectTextAnomaly(DetectTextAnomalyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectTextAnomalyWithOptions(request, runtime);
        }

        public async Task<DetectTextAnomalyResponse> DetectTextAnomalyAsync(DetectTextAnomalyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectTextAnomalyWithOptionsAsync(request, runtime);
        }

        public ExtractDocumentTextResponse ExtractDocumentTextWithOptions(ExtractDocumentTextRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExtractDocumentTextShrinkRequest request = new ExtractDocumentTextShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExtractDocumentText",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExtractDocumentTextResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ExtractDocumentTextResponse> ExtractDocumentTextWithOptionsAsync(ExtractDocumentTextRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExtractDocumentTextShrinkRequest request = new ExtractDocumentTextShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExtractDocumentText",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExtractDocumentTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ExtractDocumentTextResponse ExtractDocumentText(ExtractDocumentTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExtractDocumentTextWithOptions(request, runtime);
        }

        public async Task<ExtractDocumentTextResponse> ExtractDocumentTextAsync(ExtractDocumentTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExtractDocumentTextWithOptionsAsync(request, runtime);
        }

        public FuzzyQueryResponse FuzzyQueryWithOptions(FuzzyQueryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FuzzyQueryShrinkRequest request = new FuzzyQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WithFields))
            {
                request.WithFieldsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WithFields, "WithFields", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithFieldsShrink))
            {
                query["WithFields"] = request.WithFieldsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FuzzyQuery",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FuzzyQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FuzzyQueryResponse> FuzzyQueryWithOptionsAsync(FuzzyQueryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FuzzyQueryShrinkRequest request = new FuzzyQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WithFields))
            {
                request.WithFieldsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WithFields, "WithFields", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithFieldsShrink))
            {
                query["WithFields"] = request.WithFieldsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FuzzyQuery",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FuzzyQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FuzzyQueryResponse FuzzyQuery(FuzzyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FuzzyQueryWithOptions(request, runtime);
        }

        public async Task<FuzzyQueryResponse> FuzzyQueryAsync(FuzzyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FuzzyQueryWithOptionsAsync(request, runtime);
        }

        public GenerateWebofficeTokenResponse GenerateWebofficeTokenWithOptions(GenerateWebofficeTokenRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateWebofficeTokenShrinkRequest request = new GenerateWebofficeTokenShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Permission))
            {
                request.PermissionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Permission, "Permission", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.User))
            {
                request.UserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.User, "User", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Watermark))
            {
                request.WatermarkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Watermark, "Watermark", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CachePreview))
            {
                query["CachePreview"] = request.CachePreview;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalUploaded))
            {
                query["ExternalUploaded"] = request.ExternalUploaded;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filename))
            {
                query["Filename"] = request.Filename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hidecmb))
            {
                query["Hidecmb"] = request.Hidecmb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionShrink))
            {
                query["Permission"] = request.PermissionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewPages))
            {
                query["PreviewPages"] = request.PreviewPages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Referer))
            {
                query["Referer"] = request.Referer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserShrink))
            {
                query["User"] = request.UserShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkShrink))
            {
                query["Watermark"] = request.WatermarkShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateWebofficeToken",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateWebofficeTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateWebofficeTokenResponse> GenerateWebofficeTokenWithOptionsAsync(GenerateWebofficeTokenRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateWebofficeTokenShrinkRequest request = new GenerateWebofficeTokenShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Permission))
            {
                request.PermissionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Permission, "Permission", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.User))
            {
                request.UserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.User, "User", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Watermark))
            {
                request.WatermarkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Watermark, "Watermark", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CachePreview))
            {
                query["CachePreview"] = request.CachePreview;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalUploaded))
            {
                query["ExternalUploaded"] = request.ExternalUploaded;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filename))
            {
                query["Filename"] = request.Filename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hidecmb))
            {
                query["Hidecmb"] = request.Hidecmb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionShrink))
            {
                query["Permission"] = request.PermissionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreviewPages))
            {
                query["PreviewPages"] = request.PreviewPages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Referer))
            {
                query["Referer"] = request.Referer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserShrink))
            {
                query["User"] = request.UserShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkShrink))
            {
                query["Watermark"] = request.WatermarkShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateWebofficeToken",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateWebofficeTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateWebofficeTokenResponse GenerateWebofficeToken(GenerateWebofficeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateWebofficeTokenWithOptions(request, runtime);
        }

        public async Task<GenerateWebofficeTokenResponse> GenerateWebofficeTokenAsync(GenerateWebofficeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateWebofficeTokenWithOptionsAsync(request, runtime);
        }

        public GetBatchResponse GetBatchWithOptions(GetBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBatch",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBatchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetBatchResponse> GetBatchWithOptionsAsync(GetBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBatch",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetBatchResponse GetBatch(GetBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBatchWithOptions(request, runtime);
        }

        public async Task<GetBatchResponse> GetBatchAsync(GetBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBatchWithOptionsAsync(request, runtime);
        }

        public GetBindingResponse GetBindingWithOptions(GetBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBinding",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBindingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetBindingResponse> GetBindingWithOptionsAsync(GetBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBinding",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBindingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetBindingResponse GetBinding(GetBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBindingWithOptions(request, runtime);
        }

        public async Task<GetBindingResponse> GetBindingAsync(GetBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBindingWithOptionsAsync(request, runtime);
        }

        public GetDatasetResponse GetDatasetWithOptions(GetDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithStatistics))
            {
                query["WithStatistics"] = request.WithStatistics;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataset",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDatasetResponse> GetDatasetWithOptionsAsync(GetDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithStatistics))
            {
                query["WithStatistics"] = request.WithStatistics;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataset",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDatasetResponse GetDataset(GetDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDatasetWithOptions(request, runtime);
        }

        public async Task<GetDatasetResponse> GetDatasetAsync(GetDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDatasetWithOptionsAsync(request, runtime);
        }

        public GetFigureClusterResponse GetFigureClusterWithOptions(GetFigureClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                query["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFigureCluster",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFigureClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFigureClusterResponse> GetFigureClusterWithOptionsAsync(GetFigureClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                query["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFigureCluster",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFigureClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFigureClusterResponse GetFigureCluster(GetFigureClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFigureClusterWithOptions(request, runtime);
        }

        public async Task<GetFigureClusterResponse> GetFigureClusterAsync(GetFigureClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFigureClusterWithOptionsAsync(request, runtime);
        }

        public GetFileMetaResponse GetFileMetaWithOptions(GetFileMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileMeta",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileMetaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFileMetaResponse> GetFileMetaWithOptionsAsync(GetFileMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileMeta",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFileMetaResponse GetFileMeta(GetFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFileMetaWithOptions(request, runtime);
        }

        public async Task<GetFileMetaResponse> GetFileMetaAsync(GetFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFileMetaWithOptionsAsync(request, runtime);
        }

        public GetImageModerationResultResponse GetImageModerationResultWithOptions(GetImageModerationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImageModerationResult",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageModerationResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetImageModerationResultResponse> GetImageModerationResultWithOptionsAsync(GetImageModerationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImageModerationResult",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageModerationResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetImageModerationResultResponse GetImageModerationResult(GetImageModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageModerationResultWithOptions(request, runtime);
        }

        public async Task<GetImageModerationResultResponse> GetImageModerationResultAsync(GetImageModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageModerationResultWithOptionsAsync(request, runtime);
        }

        public GetOSSBucketAttachmentResponse GetOSSBucketAttachmentWithOptions(GetOSSBucketAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OSSBucket))
            {
                query["OSSBucket"] = request.OSSBucket;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOSSBucketAttachment",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOSSBucketAttachmentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetOSSBucketAttachmentResponse> GetOSSBucketAttachmentWithOptionsAsync(GetOSSBucketAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OSSBucket))
            {
                query["OSSBucket"] = request.OSSBucket;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOSSBucketAttachment",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOSSBucketAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetOSSBucketAttachmentResponse GetOSSBucketAttachment(GetOSSBucketAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOSSBucketAttachmentWithOptions(request, runtime);
        }

        public async Task<GetOSSBucketAttachmentResponse> GetOSSBucketAttachmentAsync(GetOSSBucketAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOSSBucketAttachmentWithOptionsAsync(request, runtime);
        }

        public GetProjectResponse GetProjectWithOptions(GetProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithStatistics))
            {
                query["WithStatistics"] = request.WithStatistics;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetProjectResponse> GetProjectWithOptionsAsync(GetProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithStatistics))
            {
                query["WithStatistics"] = request.WithStatistics;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetProjectResponse GetProject(GetProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProjectWithOptions(request, runtime);
        }

        public async Task<GetProjectResponse> GetProjectAsync(GetProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProjectWithOptionsAsync(request, runtime);
        }

        public GetStoryResponse GetStoryWithOptions(GetStoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                query["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStory",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetStoryResponse> GetStoryWithOptionsAsync(GetStoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                query["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStory",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetStoryResponse GetStory(GetStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStoryWithOptions(request, runtime);
        }

        public async Task<GetStoryResponse> GetStoryAsync(GetStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStoryWithOptionsAsync(request, runtime);
        }

        public GetTaskResponse GetTaskWithOptions(GetTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestDefinition))
            {
                query["RequestDefinition"] = request.RequestDefinition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTaskResponse> GetTaskWithOptionsAsync(GetTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestDefinition))
            {
                query["RequestDefinition"] = request.RequestDefinition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTaskResponse GetTask(GetTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTaskWithOptions(request, runtime);
        }

        public async Task<GetTaskResponse> GetTaskAsync(GetTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTaskWithOptionsAsync(request, runtime);
        }

        public GetTriggerResponse GetTriggerWithOptions(GetTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrigger",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTriggerResponse> GetTriggerWithOptionsAsync(GetTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrigger",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTriggerResponse GetTrigger(GetTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTriggerWithOptions(request, runtime);
        }

        public async Task<GetTriggerResponse> GetTriggerAsync(GetTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTriggerWithOptionsAsync(request, runtime);
        }

        public GetVideoLabelClassificationResultResponse GetVideoLabelClassificationResultWithOptions(GetVideoLabelClassificationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoLabelClassificationResult",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoLabelClassificationResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetVideoLabelClassificationResultResponse> GetVideoLabelClassificationResultWithOptionsAsync(GetVideoLabelClassificationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoLabelClassificationResult",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoLabelClassificationResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetVideoLabelClassificationResultResponse GetVideoLabelClassificationResult(GetVideoLabelClassificationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoLabelClassificationResultWithOptions(request, runtime);
        }

        public async Task<GetVideoLabelClassificationResultResponse> GetVideoLabelClassificationResultAsync(GetVideoLabelClassificationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoLabelClassificationResultWithOptionsAsync(request, runtime);
        }

        public GetVideoModerationResultResponse GetVideoModerationResultWithOptions(GetVideoModerationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoModerationResult",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoModerationResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetVideoModerationResultResponse> GetVideoModerationResultWithOptionsAsync(GetVideoModerationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoModerationResult",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoModerationResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetVideoModerationResultResponse GetVideoModerationResult(GetVideoModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoModerationResultWithOptions(request, runtime);
        }

        public async Task<GetVideoModerationResultResponse> GetVideoModerationResultAsync(GetVideoModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoModerationResultWithOptionsAsync(request, runtime);
        }

        public IndexFileMetaResponse IndexFileMetaWithOptions(IndexFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            IndexFileMetaShrinkRequest request = new IndexFileMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.File))
            {
                request.FileShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.File, "File", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileShrink))
            {
                query["File"] = request.FileShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IndexFileMeta",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndexFileMetaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<IndexFileMetaResponse> IndexFileMetaWithOptionsAsync(IndexFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            IndexFileMetaShrinkRequest request = new IndexFileMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.File))
            {
                request.FileShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.File, "File", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileShrink))
            {
                query["File"] = request.FileShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IndexFileMeta",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndexFileMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public IndexFileMetaResponse IndexFileMeta(IndexFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IndexFileMetaWithOptions(request, runtime);
        }

        public async Task<IndexFileMetaResponse> IndexFileMetaAsync(IndexFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IndexFileMetaWithOptionsAsync(request, runtime);
        }

        public ListBatchesResponse ListBatchesWithOptions(ListBatchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagSelector))
            {
                query["TagSelector"] = request.TagSelector;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBatches",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBatchesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListBatchesResponse> ListBatchesWithOptionsAsync(ListBatchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagSelector))
            {
                query["TagSelector"] = request.TagSelector;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBatches",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBatchesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListBatchesResponse ListBatches(ListBatchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBatchesWithOptions(request, runtime);
        }

        public async Task<ListBatchesResponse> ListBatchesAsync(ListBatchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBatchesWithOptionsAsync(request, runtime);
        }

        public ListBindingsResponse ListBindingsWithOptions(ListBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindings",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindingsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListBindingsResponse> ListBindingsWithOptionsAsync(ListBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindings",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListBindingsResponse ListBindings(ListBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBindingsWithOptions(request, runtime);
        }

        public async Task<ListBindingsResponse> ListBindingsAsync(ListBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBindingsWithOptionsAsync(request, runtime);
        }

        public ListDatasetsResponse ListDatasetsWithOptions(ListDatasetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["Prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasets",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDatasetsResponse> ListDatasetsWithOptionsAsync(ListDatasetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["Prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatasets",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDatasetsWithOptions(request, runtime);
        }

        public async Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDatasetsWithOptionsAsync(request, runtime);
        }

        public ListProjectsResponse ListProjectsWithOptions(ListProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["Prefix"] = request.Prefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProjectsResponse> ListProjectsWithOptionsAsync(ListProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["Prefix"] = request.Prefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectsWithOptions(request, runtime);
        }

        public async Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectsWithOptionsAsync(request, runtime);
        }

        public ListRegionsResponse ListRegionsWithOptions(ListRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRegionsResponse> ListRegionsWithOptionsAsync(ListRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRegionsResponse ListRegions(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegionsWithOptions(request, runtime);
        }

        public async Task<ListRegionsResponse> ListRegionsAsync(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegionsWithOptionsAsync(request, runtime);
        }

        public ListTasksResponse ListTasksWithOptions(ListTasksRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTasksShrinkRequest request = new ListTasksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EndTimeRange))
            {
                request.EndTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EndTimeRange, "EndTimeRange", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StartTimeRange))
            {
                request.StartTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StartTimeRange, "StartTimeRange", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskTypes))
            {
                request.TaskTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskTypes, "TaskTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeRangeShrink))
            {
                query["EndTimeRange"] = request.EndTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestDefinition))
            {
                query["RequestDefinition"] = request.RequestDefinition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeRangeShrink))
            {
                query["StartTimeRange"] = request.StartTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagSelector))
            {
                query["TagSelector"] = request.TagSelector;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTypesShrink))
            {
                query["TaskTypes"] = request.TaskTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTasksResponse> ListTasksWithOptionsAsync(ListTasksRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTasksShrinkRequest request = new ListTasksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EndTimeRange))
            {
                request.EndTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EndTimeRange, "EndTimeRange", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StartTimeRange))
            {
                request.StartTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StartTimeRange, "StartTimeRange", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskTypes))
            {
                request.TaskTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskTypes, "TaskTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeRangeShrink))
            {
                query["EndTimeRange"] = request.EndTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestDefinition))
            {
                query["RequestDefinition"] = request.RequestDefinition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeRangeShrink))
            {
                query["StartTimeRange"] = request.StartTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagSelector))
            {
                query["TagSelector"] = request.TagSelector;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTypesShrink))
            {
                query["TaskTypes"] = request.TaskTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTasksResponse ListTasks(ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTasksWithOptions(request, runtime);
        }

        public async Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTasksWithOptionsAsync(request, runtime);
        }

        public ListTriggersResponse ListTriggersWithOptions(ListTriggersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagSelector))
            {
                query["TagSelector"] = request.TagSelector;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTriggers",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTriggersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTriggersResponse> ListTriggersWithOptionsAsync(ListTriggersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagSelector))
            {
                query["TagSelector"] = request.TagSelector;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTriggers",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTriggersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTriggersResponse ListTriggers(ListTriggersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTriggersWithOptions(request, runtime);
        }

        public async Task<ListTriggersResponse> ListTriggersAsync(ListTriggersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTriggersWithOptionsAsync(request, runtime);
        }

        public QueryFigureClustersResponse QueryFigureClustersWithOptions(QueryFigureClustersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryFigureClustersShrinkRequest request = new QueryFigureClustersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateTimeRange))
            {
                request.CreateTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateTimeRange, "CreateTimeRange", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateTimeRange))
            {
                request.UpdateTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateTimeRange, "UpdateTimeRange", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeRangeShrink))
            {
                query["CreateTimeRange"] = request.CreateTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabels))
            {
                query["CustomLabels"] = request.CustomLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTimeRangeShrink))
            {
                query["UpdateTimeRange"] = request.UpdateTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithTotalCount))
            {
                query["WithTotalCount"] = request.WithTotalCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFigureClusters",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFigureClustersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryFigureClustersResponse> QueryFigureClustersWithOptionsAsync(QueryFigureClustersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryFigureClustersShrinkRequest request = new QueryFigureClustersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateTimeRange))
            {
                request.CreateTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateTimeRange, "CreateTimeRange", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateTimeRange))
            {
                request.UpdateTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateTimeRange, "UpdateTimeRange", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeRangeShrink))
            {
                query["CreateTimeRange"] = request.CreateTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabels))
            {
                query["CustomLabels"] = request.CustomLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTimeRangeShrink))
            {
                query["UpdateTimeRange"] = request.UpdateTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithTotalCount))
            {
                query["WithTotalCount"] = request.WithTotalCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFigureClusters",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFigureClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryFigureClustersResponse QueryFigureClusters(QueryFigureClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFigureClustersWithOptions(request, runtime);
        }

        public async Task<QueryFigureClustersResponse> QueryFigureClustersAsync(QueryFigureClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFigureClustersWithOptionsAsync(request, runtime);
        }

        public QueryLocationDateClustersResponse QueryLocationDateClustersWithOptions(QueryLocationDateClustersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryLocationDateClustersShrinkRequest request = new QueryLocationDateClustersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Address))
            {
                request.AddressShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Address, "Address", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateTimeRange))
            {
                request.CreateTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateTimeRange, "CreateTimeRange", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LocationDateClusterEndTimeRange))
            {
                request.LocationDateClusterEndTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LocationDateClusterEndTimeRange, "LocationDateClusterEndTimeRange", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LocationDateClusterLevels))
            {
                request.LocationDateClusterLevelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LocationDateClusterLevels, "LocationDateClusterLevels", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LocationDateClusterStartTimeRange))
            {
                request.LocationDateClusterStartTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LocationDateClusterStartTimeRange, "LocationDateClusterStartTimeRange", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateTimeRange))
            {
                request.UpdateTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateTimeRange, "UpdateTimeRange", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressShrink))
            {
                query["Address"] = request.AddressShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeRangeShrink))
            {
                query["CreateTimeRange"] = request.CreateTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabels))
            {
                query["CustomLabels"] = request.CustomLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationDateClusterEndTimeRangeShrink))
            {
                query["LocationDateClusterEndTimeRange"] = request.LocationDateClusterEndTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationDateClusterLevelsShrink))
            {
                query["LocationDateClusterLevels"] = request.LocationDateClusterLevelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationDateClusterStartTimeRangeShrink))
            {
                query["LocationDateClusterStartTimeRange"] = request.LocationDateClusterStartTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                query["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTimeRangeShrink))
            {
                query["UpdateTimeRange"] = request.UpdateTimeRangeShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLocationDateClusters",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLocationDateClustersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryLocationDateClustersResponse> QueryLocationDateClustersWithOptionsAsync(QueryLocationDateClustersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryLocationDateClustersShrinkRequest request = new QueryLocationDateClustersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Address))
            {
                request.AddressShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Address, "Address", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateTimeRange))
            {
                request.CreateTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateTimeRange, "CreateTimeRange", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LocationDateClusterEndTimeRange))
            {
                request.LocationDateClusterEndTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LocationDateClusterEndTimeRange, "LocationDateClusterEndTimeRange", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LocationDateClusterLevels))
            {
                request.LocationDateClusterLevelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LocationDateClusterLevels, "LocationDateClusterLevels", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LocationDateClusterStartTimeRange))
            {
                request.LocationDateClusterStartTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LocationDateClusterStartTimeRange, "LocationDateClusterStartTimeRange", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UpdateTimeRange))
            {
                request.UpdateTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UpdateTimeRange, "UpdateTimeRange", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressShrink))
            {
                query["Address"] = request.AddressShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeRangeShrink))
            {
                query["CreateTimeRange"] = request.CreateTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabels))
            {
                query["CustomLabels"] = request.CustomLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationDateClusterEndTimeRangeShrink))
            {
                query["LocationDateClusterEndTimeRange"] = request.LocationDateClusterEndTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationDateClusterLevelsShrink))
            {
                query["LocationDateClusterLevels"] = request.LocationDateClusterLevelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationDateClusterStartTimeRangeShrink))
            {
                query["LocationDateClusterStartTimeRange"] = request.LocationDateClusterStartTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                query["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTimeRangeShrink))
            {
                query["UpdateTimeRange"] = request.UpdateTimeRangeShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLocationDateClusters",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLocationDateClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryLocationDateClustersResponse QueryLocationDateClusters(QueryLocationDateClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryLocationDateClustersWithOptions(request, runtime);
        }

        public async Task<QueryLocationDateClustersResponse> QueryLocationDateClustersAsync(QueryLocationDateClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryLocationDateClustersWithOptionsAsync(request, runtime);
        }

        public QuerySimilarImageClustersResponse QuerySimilarImageClustersWithOptions(QuerySimilarImageClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabels))
            {
                query["CustomLabels"] = request.CustomLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySimilarImageClusters",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySimilarImageClustersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QuerySimilarImageClustersResponse> QuerySimilarImageClustersWithOptionsAsync(QuerySimilarImageClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabels))
            {
                query["CustomLabels"] = request.CustomLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySimilarImageClusters",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySimilarImageClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QuerySimilarImageClustersResponse QuerySimilarImageClusters(QuerySimilarImageClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySimilarImageClustersWithOptions(request, runtime);
        }

        public async Task<QuerySimilarImageClustersResponse> QuerySimilarImageClustersAsync(QuerySimilarImageClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySimilarImageClustersWithOptionsAsync(request, runtime);
        }

        public QueryStoriesResponse QueryStoriesWithOptions(QueryStoriesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryStoriesShrinkRequest request = new QueryStoriesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateTimeRange))
            {
                request.CreateTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateTimeRange, "CreateTimeRange", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FigureClusterIds))
            {
                request.FigureClusterIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FigureClusterIds, "FigureClusterIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StoryEndTimeRange))
            {
                request.StoryEndTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StoryEndTimeRange, "StoryEndTimeRange", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StoryStartTimeRange))
            {
                request.StoryStartTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StoryStartTimeRange, "StoryStartTimeRange", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeRangeShrink))
            {
                query["CreateTimeRange"] = request.CreateTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabels))
            {
                query["CustomLabels"] = request.CustomLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FigureClusterIdsShrink))
            {
                query["FigureClusterIds"] = request.FigureClusterIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                query["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryEndTimeRangeShrink))
            {
                query["StoryEndTimeRange"] = request.StoryEndTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryName))
            {
                query["StoryName"] = request.StoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryStartTimeRangeShrink))
            {
                query["StoryStartTimeRange"] = request.StoryStartTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorySubType))
            {
                query["StorySubType"] = request.StorySubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryType))
            {
                query["StoryType"] = request.StoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithEmptyStories))
            {
                query["WithEmptyStories"] = request.WithEmptyStories;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryStories",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryStoriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryStoriesResponse> QueryStoriesWithOptionsAsync(QueryStoriesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryStoriesShrinkRequest request = new QueryStoriesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateTimeRange))
            {
                request.CreateTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateTimeRange, "CreateTimeRange", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FigureClusterIds))
            {
                request.FigureClusterIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FigureClusterIds, "FigureClusterIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StoryEndTimeRange))
            {
                request.StoryEndTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StoryEndTimeRange, "StoryEndTimeRange", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StoryStartTimeRange))
            {
                request.StoryStartTimeRangeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StoryStartTimeRange, "StoryStartTimeRange", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeRangeShrink))
            {
                query["CreateTimeRange"] = request.CreateTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabels))
            {
                query["CustomLabels"] = request.CustomLabels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FigureClusterIdsShrink))
            {
                query["FigureClusterIds"] = request.FigureClusterIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                query["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryEndTimeRangeShrink))
            {
                query["StoryEndTimeRange"] = request.StoryEndTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryName))
            {
                query["StoryName"] = request.StoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryStartTimeRangeShrink))
            {
                query["StoryStartTimeRange"] = request.StoryStartTimeRangeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorySubType))
            {
                query["StorySubType"] = request.StorySubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryType))
            {
                query["StoryType"] = request.StoryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithEmptyStories))
            {
                query["WithEmptyStories"] = request.WithEmptyStories;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryStories",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryStoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryStoriesResponse QueryStories(QueryStoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryStoriesWithOptions(request, runtime);
        }

        public async Task<QueryStoriesResponse> QueryStoriesAsync(QueryStoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryStoriesWithOptionsAsync(request, runtime);
        }

        public RefreshWebofficeTokenResponse RefreshWebofficeTokenWithOptions(RefreshWebofficeTokenRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RefreshWebofficeTokenShrinkRequest request = new RefreshWebofficeTokenShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshToken))
            {
                query["RefreshToken"] = request.RefreshToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshWebofficeToken",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshWebofficeTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RefreshWebofficeTokenResponse> RefreshWebofficeTokenWithOptionsAsync(RefreshWebofficeTokenRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RefreshWebofficeTokenShrinkRequest request = new RefreshWebofficeTokenShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefreshToken))
            {
                query["RefreshToken"] = request.RefreshToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshWebofficeToken",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshWebofficeTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RefreshWebofficeTokenResponse RefreshWebofficeToken(RefreshWebofficeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshWebofficeTokenWithOptions(request, runtime);
        }

        public async Task<RefreshWebofficeTokenResponse> RefreshWebofficeTokenAsync(RefreshWebofficeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshWebofficeTokenWithOptionsAsync(request, runtime);
        }

        public RemoveStoryFilesResponse RemoveStoryFilesWithOptions(RemoveStoryFilesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveStoryFilesShrinkRequest request = new RemoveStoryFilesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Files))
            {
                request.FilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Files, "Files", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesShrink))
            {
                body["Files"] = request.FilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveStoryFiles",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveStoryFilesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveStoryFilesResponse> RemoveStoryFilesWithOptionsAsync(RemoveStoryFilesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveStoryFilesShrinkRequest request = new RemoveStoryFilesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Files))
            {
                request.FilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Files, "Files", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesShrink))
            {
                body["Files"] = request.FilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveStoryFiles",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveStoryFilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveStoryFilesResponse RemoveStoryFiles(RemoveStoryFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveStoryFilesWithOptions(request, runtime);
        }

        public async Task<RemoveStoryFilesResponse> RemoveStoryFilesAsync(RemoveStoryFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveStoryFilesWithOptionsAsync(request, runtime);
        }

        public ResumeBatchResponse ResumeBatchWithOptions(ResumeBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeBatch",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeBatchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResumeBatchResponse> ResumeBatchWithOptionsAsync(ResumeBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeBatch",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeBatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResumeBatchResponse ResumeBatch(ResumeBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeBatchWithOptions(request, runtime);
        }

        public async Task<ResumeBatchResponse> ResumeBatchAsync(ResumeBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeBatchWithOptionsAsync(request, runtime);
        }

        public ResumeTriggerResponse ResumeTriggerWithOptions(ResumeTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeTrigger",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResumeTriggerResponse> ResumeTriggerWithOptionsAsync(ResumeTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeTrigger",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResumeTriggerResponse ResumeTrigger(ResumeTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeTriggerWithOptions(request, runtime);
        }

        public async Task<ResumeTriggerResponse> ResumeTriggerAsync(ResumeTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeTriggerWithOptionsAsync(request, runtime);
        }

        public SearchImageFigureClusterResponse SearchImageFigureClusterWithOptions(SearchImageFigureClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchImageFigureClusterShrinkRequest request = new SearchImageFigureClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchImageFigureCluster",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchImageFigureClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SearchImageFigureClusterResponse> SearchImageFigureClusterWithOptionsAsync(SearchImageFigureClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchImageFigureClusterShrinkRequest request = new SearchImageFigureClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchImageFigureCluster",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchImageFigureClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SearchImageFigureClusterResponse SearchImageFigureCluster(SearchImageFigureClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchImageFigureClusterWithOptions(request, runtime);
        }

        public async Task<SearchImageFigureClusterResponse> SearchImageFigureClusterAsync(SearchImageFigureClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchImageFigureClusterWithOptionsAsync(request, runtime);
        }

        public SemanticQueryResponse SemanticQueryWithOptions(SemanticQueryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SemanticQueryShrinkRequest request = new SemanticQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MediaTypes))
            {
                request.MediaTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MediaTypes, "MediaTypes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WithFields))
            {
                request.WithFieldsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WithFields, "WithFields", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaTypesShrink))
            {
                query["MediaTypes"] = request.MediaTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithFieldsShrink))
            {
                query["WithFields"] = request.WithFieldsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SemanticQuery",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SemanticQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SemanticQueryResponse> SemanticQueryWithOptionsAsync(SemanticQueryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SemanticQueryShrinkRequest request = new SemanticQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MediaTypes))
            {
                request.MediaTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MediaTypes, "MediaTypes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WithFields))
            {
                request.WithFieldsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WithFields, "WithFields", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaTypesShrink))
            {
                query["MediaTypes"] = request.MediaTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithFieldsShrink))
            {
                query["WithFields"] = request.WithFieldsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SemanticQuery",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SemanticQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SemanticQueryResponse SemanticQuery(SemanticQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SemanticQueryWithOptions(request, runtime);
        }

        public async Task<SemanticQueryResponse> SemanticQueryAsync(SemanticQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SemanticQueryWithOptionsAsync(request, runtime);
        }

        public SimpleQueryResponse SimpleQueryWithOptions(SimpleQueryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SimpleQueryShrinkRequest request = new SimpleQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Aggregations))
            {
                request.AggregationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Aggregations, "Aggregations", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Query))
            {
                request.QueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Query, "Query", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WithFields))
            {
                request.WithFieldsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WithFields, "WithFields", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregationsShrink))
            {
                query["Aggregations"] = request.AggregationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryShrink))
            {
                query["Query"] = request.QueryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithFieldsShrink))
            {
                query["WithFields"] = request.WithFieldsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithoutTotalHits))
            {
                query["WithoutTotalHits"] = request.WithoutTotalHits;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SimpleQuery",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SimpleQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SimpleQueryResponse> SimpleQueryWithOptionsAsync(SimpleQueryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SimpleQueryShrinkRequest request = new SimpleQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Aggregations))
            {
                request.AggregationsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Aggregations, "Aggregations", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Query))
            {
                request.QueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Query, "Query", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WithFields))
            {
                request.WithFieldsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WithFields, "WithFields", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggregationsShrink))
            {
                query["Aggregations"] = request.AggregationsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryShrink))
            {
                query["Query"] = request.QueryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithFieldsShrink))
            {
                query["WithFields"] = request.WithFieldsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithoutTotalHits))
            {
                query["WithoutTotalHits"] = request.WithoutTotalHits;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SimpleQuery",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SimpleQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SimpleQueryResponse SimpleQuery(SimpleQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SimpleQueryWithOptions(request, runtime);
        }

        public async Task<SimpleQueryResponse> SimpleQueryAsync(SimpleQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SimpleQueryWithOptionsAsync(request, runtime);
        }

        public SuspendBatchResponse SuspendBatchWithOptions(SuspendBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendBatch",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendBatchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SuspendBatchResponse> SuspendBatchWithOptionsAsync(SuspendBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendBatch",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendBatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SuspendBatchResponse SuspendBatch(SuspendBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendBatchWithOptions(request, runtime);
        }

        public async Task<SuspendBatchResponse> SuspendBatchAsync(SuspendBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendBatchWithOptionsAsync(request, runtime);
        }

        public SuspendTriggerResponse SuspendTriggerWithOptions(SuspendTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendTrigger",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SuspendTriggerResponse> SuspendTriggerWithOptionsAsync(SuspendTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendTrigger",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SuspendTriggerResponse SuspendTrigger(SuspendTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendTriggerWithOptions(request, runtime);
        }

        public async Task<SuspendTriggerResponse> SuspendTriggerAsync(SuspendTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendTriggerWithOptionsAsync(request, runtime);
        }

        public UpdateBatchResponse UpdateBatchWithOptions(UpdateBatchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateBatchShrinkRequest request = new UpdateBatchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Actions))
            {
                request.ActionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Actions, "Actions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionsShrink))
            {
                body["Actions"] = request.ActionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                body["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBatch",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBatchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateBatchResponse> UpdateBatchWithOptionsAsync(UpdateBatchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateBatchShrinkRequest request = new UpdateBatchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Actions))
            {
                request.ActionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Actions, "Actions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionsShrink))
            {
                body["Actions"] = request.ActionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                body["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBatch",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateBatchResponse UpdateBatch(UpdateBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBatchWithOptions(request, runtime);
        }

        public async Task<UpdateBatchResponse> UpdateBatchAsync(UpdateBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBatchWithOptionsAsync(request, runtime);
        }

        public UpdateDatasetResponse UpdateDatasetWithOptions(UpdateDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxBindCount))
            {
                query["DatasetMaxBindCount"] = request.DatasetMaxBindCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxEntityCount))
            {
                query["DatasetMaxEntityCount"] = request.DatasetMaxEntityCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxFileCount))
            {
                query["DatasetMaxFileCount"] = request.DatasetMaxFileCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxRelationCount))
            {
                query["DatasetMaxRelationCount"] = request.DatasetMaxRelationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxTotalFileSize))
            {
                query["DatasetMaxTotalFileSize"] = request.DatasetMaxTotalFileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataset",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateDatasetResponse> UpdateDatasetWithOptionsAsync(UpdateDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxBindCount))
            {
                query["DatasetMaxBindCount"] = request.DatasetMaxBindCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxEntityCount))
            {
                query["DatasetMaxEntityCount"] = request.DatasetMaxEntityCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxFileCount))
            {
                query["DatasetMaxFileCount"] = request.DatasetMaxFileCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxRelationCount))
            {
                query["DatasetMaxRelationCount"] = request.DatasetMaxRelationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxTotalFileSize))
            {
                query["DatasetMaxTotalFileSize"] = request.DatasetMaxTotalFileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataset",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateDatasetResponse UpdateDataset(UpdateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDatasetWithOptions(request, runtime);
        }

        public async Task<UpdateDatasetResponse> UpdateDatasetAsync(UpdateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDatasetWithOptionsAsync(request, runtime);
        }

        public UpdateFigureClusterResponse UpdateFigureClusterWithOptions(UpdateFigureClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateFigureClusterShrinkRequest request = new UpdateFigureClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FigureCluster))
            {
                request.FigureClusterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FigureCluster, "FigureCluster", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FigureClusterShrink))
            {
                query["FigureCluster"] = request.FigureClusterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFigureCluster",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFigureClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateFigureClusterResponse> UpdateFigureClusterWithOptionsAsync(UpdateFigureClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateFigureClusterShrinkRequest request = new UpdateFigureClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FigureCluster))
            {
                request.FigureClusterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FigureCluster, "FigureCluster", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FigureClusterShrink))
            {
                query["FigureCluster"] = request.FigureClusterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFigureCluster",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFigureClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateFigureClusterResponse UpdateFigureCluster(UpdateFigureClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFigureClusterWithOptions(request, runtime);
        }

        public async Task<UpdateFigureClusterResponse> UpdateFigureClusterAsync(UpdateFigureClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFigureClusterWithOptionsAsync(request, runtime);
        }

        public UpdateFileMetaResponse UpdateFileMetaWithOptions(UpdateFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateFileMetaShrinkRequest request = new UpdateFileMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.File))
            {
                request.FileShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.File, "File", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileShrink))
            {
                query["File"] = request.FileShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFileMeta",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFileMetaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateFileMetaResponse> UpdateFileMetaWithOptionsAsync(UpdateFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateFileMetaShrinkRequest request = new UpdateFileMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.File))
            {
                request.FileShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.File, "File", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileShrink))
            {
                query["File"] = request.FileShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFileMeta",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFileMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateFileMetaResponse UpdateFileMeta(UpdateFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFileMetaWithOptions(request, runtime);
        }

        public async Task<UpdateFileMetaResponse> UpdateFileMetaAsync(UpdateFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFileMetaWithOptionsAsync(request, runtime);
        }

        public UpdateLocationDateClusterResponse UpdateLocationDateClusterWithOptions(UpdateLocationDateClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateLocationDateClusterShrinkRequest request = new UpdateLocationDateClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomLabels))
            {
                request.CustomLabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomLabels, "CustomLabels", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomId))
            {
                query["CustomId"] = request.CustomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabelsShrink))
            {
                query["CustomLabels"] = request.CustomLabelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                query["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLocationDateCluster",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLocationDateClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateLocationDateClusterResponse> UpdateLocationDateClusterWithOptionsAsync(UpdateLocationDateClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateLocationDateClusterShrinkRequest request = new UpdateLocationDateClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomLabels))
            {
                request.CustomLabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomLabels, "CustomLabels", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomId))
            {
                query["CustomId"] = request.CustomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabelsShrink))
            {
                query["CustomLabels"] = request.CustomLabelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                query["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                query["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLocationDateCluster",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLocationDateClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateLocationDateClusterResponse UpdateLocationDateCluster(UpdateLocationDateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLocationDateClusterWithOptions(request, runtime);
        }

        public async Task<UpdateLocationDateClusterResponse> UpdateLocationDateClusterAsync(UpdateLocationDateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLocationDateClusterWithOptionsAsync(request, runtime);
        }

        public UpdateProjectResponse UpdateProjectWithOptions(UpdateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxBindCount))
            {
                query["DatasetMaxBindCount"] = request.DatasetMaxBindCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxEntityCount))
            {
                query["DatasetMaxEntityCount"] = request.DatasetMaxEntityCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxFileCount))
            {
                query["DatasetMaxFileCount"] = request.DatasetMaxFileCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxRelationCount))
            {
                query["DatasetMaxRelationCount"] = request.DatasetMaxRelationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxTotalFileSize))
            {
                query["DatasetMaxTotalFileSize"] = request.DatasetMaxTotalFileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectMaxDatasetCount))
            {
                query["ProjectMaxDatasetCount"] = request.ProjectMaxDatasetCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRole))
            {
                query["ServiceRole"] = request.ServiceRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProject",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateProjectResponse> UpdateProjectWithOptionsAsync(UpdateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxBindCount))
            {
                query["DatasetMaxBindCount"] = request.DatasetMaxBindCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxEntityCount))
            {
                query["DatasetMaxEntityCount"] = request.DatasetMaxEntityCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxFileCount))
            {
                query["DatasetMaxFileCount"] = request.DatasetMaxFileCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxRelationCount))
            {
                query["DatasetMaxRelationCount"] = request.DatasetMaxRelationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetMaxTotalFileSize))
            {
                query["DatasetMaxTotalFileSize"] = request.DatasetMaxTotalFileSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectMaxDatasetCount))
            {
                query["ProjectMaxDatasetCount"] = request.ProjectMaxDatasetCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRole))
            {
                query["ServiceRole"] = request.ServiceRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProject",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProjectWithOptions(request, runtime);
        }

        public async Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProjectWithOptionsAsync(request, runtime);
        }

        public UpdateStoryResponse UpdateStoryWithOptions(UpdateStoryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateStoryShrinkRequest request = new UpdateStoryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Cover))
            {
                request.CoverShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Cover, "Cover", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomLabels))
            {
                request.CustomLabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomLabels, "CustomLabels", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverShrink))
            {
                body["Cover"] = request.CoverShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomId))
            {
                body["CustomId"] = request.CustomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabelsShrink))
            {
                body["CustomLabels"] = request.CustomLabelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryName))
            {
                body["StoryName"] = request.StoryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStory",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateStoryResponse> UpdateStoryWithOptionsAsync(UpdateStoryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateStoryShrinkRequest request = new UpdateStoryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Cover))
            {
                request.CoverShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Cover, "Cover", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomLabels))
            {
                request.CustomLabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomLabels, "CustomLabels", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoverShrink))
            {
                body["Cover"] = request.CoverShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomId))
            {
                body["CustomId"] = request.CustomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomLabelsShrink))
            {
                body["CustomLabels"] = request.CustomLabelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetName))
            {
                body["DatasetName"] = request.DatasetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectId))
            {
                body["ObjectId"] = request.ObjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoryName))
            {
                body["StoryName"] = request.StoryName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStory",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateStoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateStoryResponse UpdateStory(UpdateStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStoryWithOptions(request, runtime);
        }

        public async Task<UpdateStoryResponse> UpdateStoryAsync(UpdateStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStoryWithOptionsAsync(request, runtime);
        }

        public UpdateTriggerResponse UpdateTriggerWithOptions(UpdateTriggerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTriggerShrinkRequest request = new UpdateTriggerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Actions))
            {
                request.ActionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Actions, "Actions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionsShrink))
            {
                body["Actions"] = request.ActionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                body["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrigger",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTriggerResponse> UpdateTriggerWithOptionsAsync(UpdateTriggerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTriggerShrinkRequest request = new UpdateTriggerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Actions))
            {
                request.ActionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Actions, "Actions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionsShrink))
            {
                body["Actions"] = request.ActionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                body["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                body["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrigger",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTriggerResponse UpdateTrigger(UpdateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTriggerWithOptions(request, runtime);
        }

        public async Task<UpdateTriggerResponse> UpdateTriggerAsync(UpdateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTriggerWithOptionsAsync(request, runtime);
        }

    }
}
