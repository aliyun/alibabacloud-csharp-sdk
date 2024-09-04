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

        /**
         * @summary 图片打马赛克算子
         *
         * @param tmpReq AddImageMosaicRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddImageMosaicResponse
         */
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

        /**
         * @summary 图片打马赛克算子
         *
         * @param tmpReq AddImageMosaicRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddImageMosaicResponse
         */
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

        /**
         * @summary 图片打马赛克算子
         *
         * @param request AddImageMosaicRequest
         * @return AddImageMosaicResponse
         */
        public AddImageMosaicResponse AddImageMosaic(AddImageMosaicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddImageMosaicWithOptions(request, runtime);
        }

        /**
         * @summary 图片打马赛克算子
         *
         * @param request AddImageMosaicRequest
         * @return AddImageMosaicResponse
         */
        public async Task<AddImageMosaicResponse> AddImageMosaicAsync(AddImageMosaicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddImageMosaicWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 为故事新增文件
         *
         * @param tmpReq AddStoryFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddStoryFilesResponse
         */
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

        /**
         * @summary 为故事新增文件
         *
         * @param tmpReq AddStoryFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddStoryFilesResponse
         */
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

        /**
         * @summary 为故事新增文件
         *
         * @param request AddStoryFilesRequest
         * @return AddStoryFilesResponse
         */
        public AddStoryFilesResponse AddStoryFiles(AddStoryFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddStoryFilesWithOptions(request, runtime);
        }

        /**
         * @summary 为故事新增文件
         *
         * @param request AddStoryFilesRequest
         * @return AddStoryFilesResponse
         */
        public async Task<AddStoryFilesResponse> AddStoryFilesAsync(AddStoryFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddStoryFilesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 绑定ossbucket
         *
         * @param request AttachOSSBucketRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachOSSBucketResponse
         */
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

        /**
         * @summary 绑定ossbucket
         *
         * @param request AttachOSSBucketRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachOSSBucketResponse
         */
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

        /**
         * @summary 绑定ossbucket
         *
         * @param request AttachOSSBucketRequest
         * @return AttachOSSBucketResponse
         */
        public AttachOSSBucketResponse AttachOSSBucket(AttachOSSBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachOSSBucketWithOptions(request, runtime);
        }

        /**
         * @summary 绑定ossbucket
         *
         * @param request AttachOSSBucketRequest
         * @return AttachOSSBucketResponse
         */
        public async Task<AttachOSSBucketResponse> AttachOSSBucketAsync(AttachOSSBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachOSSBucketWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量删除文件元信息
         *
         * @param tmpReq BatchDeleteFileMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchDeleteFileMetaResponse
         */
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

        /**
         * @summary 批量删除文件元信息
         *
         * @param tmpReq BatchDeleteFileMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchDeleteFileMetaResponse
         */
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

        /**
         * @summary 批量删除文件元信息
         *
         * @param request BatchDeleteFileMetaRequest
         * @return BatchDeleteFileMetaResponse
         */
        public BatchDeleteFileMetaResponse BatchDeleteFileMeta(BatchDeleteFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteFileMetaWithOptions(request, runtime);
        }

        /**
         * @summary 批量删除文件元信息
         *
         * @param request BatchDeleteFileMetaRequest
         * @return BatchDeleteFileMetaResponse
         */
        public async Task<BatchDeleteFileMetaResponse> BatchDeleteFileMetaAsync(BatchDeleteFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteFileMetaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量获取分组信息
         *
         * @param tmpReq BatchGetFigureClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchGetFigureClusterResponse
         */
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

        /**
         * @summary 批量获取分组信息
         *
         * @param tmpReq BatchGetFigureClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchGetFigureClusterResponse
         */
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

        /**
         * @summary 批量获取分组信息
         *
         * @param request BatchGetFigureClusterRequest
         * @return BatchGetFigureClusterResponse
         */
        public BatchGetFigureClusterResponse BatchGetFigureCluster(BatchGetFigureClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetFigureClusterWithOptions(request, runtime);
        }

        /**
         * @summary 批量获取分组信息
         *
         * @param request BatchGetFigureClusterRequest
         * @return BatchGetFigureClusterResponse
         */
        public async Task<BatchGetFigureClusterResponse> BatchGetFigureClusterAsync(BatchGetFigureClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetFigureClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量获取文件元信息
         *
         * @param tmpReq BatchGetFileMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchGetFileMetaResponse
         */
        public BatchGetFileMetaResponse BatchGetFileMetaWithOptions(BatchGetFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchGetFileMetaShrinkRequest request = new BatchGetFileMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.URIs))
            {
                request.URIsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.URIs, "URIs", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URIsShrink))
            {
                query["URIs"] = request.URIsShrink;
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

        /**
         * @summary 批量获取文件元信息
         *
         * @param tmpReq BatchGetFileMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchGetFileMetaResponse
         */
        public async Task<BatchGetFileMetaResponse> BatchGetFileMetaWithOptionsAsync(BatchGetFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchGetFileMetaShrinkRequest request = new BatchGetFileMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.URIs))
            {
                request.URIsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.URIs, "URIs", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URIsShrink))
            {
                query["URIs"] = request.URIsShrink;
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

        /**
         * @summary 批量获取文件元信息
         *
         * @param request BatchGetFileMetaRequest
         * @return BatchGetFileMetaResponse
         */
        public BatchGetFileMetaResponse BatchGetFileMeta(BatchGetFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetFileMetaWithOptions(request, runtime);
        }

        /**
         * @summary 批量获取文件元信息
         *
         * @param request BatchGetFileMetaRequest
         * @return BatchGetFileMetaResponse
         */
        public async Task<BatchGetFileMetaResponse> BatchGetFileMetaAsync(BatchGetFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetFileMetaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量索引文件元信息
         *
         * @param tmpReq BatchIndexFileMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchIndexFileMetaResponse
         */
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

        /**
         * @summary 批量索引文件元信息
         *
         * @param tmpReq BatchIndexFileMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchIndexFileMetaResponse
         */
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

        /**
         * @summary 批量索引文件元信息
         *
         * @param request BatchIndexFileMetaRequest
         * @return BatchIndexFileMetaResponse
         */
        public BatchIndexFileMetaResponse BatchIndexFileMeta(BatchIndexFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchIndexFileMetaWithOptions(request, runtime);
        }

        /**
         * @summary 批量索引文件元信息
         *
         * @param request BatchIndexFileMetaRequest
         * @return BatchIndexFileMetaResponse
         */
        public async Task<BatchIndexFileMetaResponse> BatchIndexFileMetaAsync(BatchIndexFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchIndexFileMetaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量更新文件元信息
         *
         * @param tmpReq BatchUpdateFileMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchUpdateFileMetaResponse
         */
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

        /**
         * @summary 批量更新文件元信息
         *
         * @param tmpReq BatchUpdateFileMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchUpdateFileMetaResponse
         */
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

        /**
         * @summary 批量更新文件元信息
         *
         * @param request BatchUpdateFileMetaRequest
         * @return BatchUpdateFileMetaResponse
         */
        public BatchUpdateFileMetaResponse BatchUpdateFileMeta(BatchUpdateFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUpdateFileMetaWithOptions(request, runtime);
        }

        /**
         * @summary 批量更新文件元信息
         *
         * @param request BatchUpdateFileMetaRequest
         * @return BatchUpdateFileMetaResponse
         */
        public async Task<BatchUpdateFileMetaResponse> BatchUpdateFileMetaAsync(BatchUpdateFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUpdateFileMetaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 以脸搜分组
         *
         * @param tmpReq CompareImageFacesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CompareImageFacesResponse
         */
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

        /**
         * @summary 以脸搜分组
         *
         * @param tmpReq CompareImageFacesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CompareImageFacesResponse
         */
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

        /**
         * @summary 以脸搜分组
         *
         * @param request CompareImageFacesRequest
         * @return CompareImageFacesResponse
         */
        public CompareImageFacesResponse CompareImageFaces(CompareImageFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompareImageFacesWithOptions(request, runtime);
        }

        /**
         * @summary 以脸搜分组
         *
         * @param request CompareImageFacesRequest
         * @return CompareImageFacesResponse
         */
        public async Task<CompareImageFacesResponse> CompareImageFacesAsync(CompareImageFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompareImageFacesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建查看压缩包内文件列表任务
         *
         * @param tmpReq CreateArchiveFileInspectionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateArchiveFileInspectionTaskResponse
         */
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

        /**
         * @summary 创建查看压缩包内文件列表任务
         *
         * @param tmpReq CreateArchiveFileInspectionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateArchiveFileInspectionTaskResponse
         */
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

        /**
         * @summary 创建查看压缩包内文件列表任务
         *
         * @param request CreateArchiveFileInspectionTaskRequest
         * @return CreateArchiveFileInspectionTaskResponse
         */
        public CreateArchiveFileInspectionTaskResponse CreateArchiveFileInspectionTask(CreateArchiveFileInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateArchiveFileInspectionTaskWithOptions(request, runtime);
        }

        /**
         * @summary 创建查看压缩包内文件列表任务
         *
         * @param request CreateArchiveFileInspectionTaskRequest
         * @return CreateArchiveFileInspectionTaskResponse
         */
        public async Task<CreateArchiveFileInspectionTaskResponse> CreateArchiveFileInspectionTaskAsync(CreateArchiveFileInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateArchiveFileInspectionTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建数据接入
         *
         * @param tmpReq CreateBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateBatchResponse
         */
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

        /**
         * @summary 创建数据接入
         *
         * @param tmpReq CreateBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateBatchResponse
         */
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

        /**
         * @summary 创建数据接入
         *
         * @param request CreateBatchRequest
         * @return CreateBatchResponse
         */
        public CreateBatchResponse CreateBatch(CreateBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBatchWithOptions(request, runtime);
        }

        /**
         * @summary 创建数据接入
         *
         * @param request CreateBatchRequest
         * @return CreateBatchResponse
         */
        public async Task<CreateBatchResponse> CreateBatchAsync(CreateBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBatchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建一个绑定任务，将 IMM 的数据集和 OSS Bucket 进行绑定，自动对其文件进行索引。
         *
         * @param request CreateBindingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateBindingResponse
         */
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

        /**
         * @summary 创建一个绑定任务，将 IMM 的数据集和 OSS Bucket 进行绑定，自动对其文件进行索引。
         *
         * @param request CreateBindingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateBindingResponse
         */
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

        /**
         * @summary 创建一个绑定任务，将 IMM 的数据集和 OSS Bucket 进行绑定，自动对其文件进行索引。
         *
         * @param request CreateBindingRequest
         * @return CreateBindingResponse
         */
        public CreateBindingResponse CreateBinding(CreateBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBindingWithOptions(request, runtime);
        }

        /**
         * @summary 创建一个绑定任务，将 IMM 的数据集和 OSS Bucket 进行绑定，自动对其文件进行索引。
         *
         * @param request CreateBindingRequest
         * @return CreateBindingResponse
         */
        public async Task<CreateBindingResponse> CreateBindingAsync(CreateBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBindingWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建点云压缩任务
         *
         * @param tmpReq CreateCompressPointCloudTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCompressPointCloudTaskResponse
         */
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

        /**
         * @summary 创建点云压缩任务
         *
         * @param tmpReq CreateCompressPointCloudTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCompressPointCloudTaskResponse
         */
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

        /**
         * @summary 创建点云压缩任务
         *
         * @param request CreateCompressPointCloudTaskRequest
         * @return CreateCompressPointCloudTaskResponse
         */
        public CreateCompressPointCloudTaskResponse CreateCompressPointCloudTask(CreateCompressPointCloudTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCompressPointCloudTaskWithOptions(request, runtime);
        }

        /**
         * @summary 创建点云压缩任务
         *
         * @param request CreateCompressPointCloudTaskRequest
         * @return CreateCompressPointCloudTaskResponse
         */
        public async Task<CreateCompressPointCloudTaskResponse> CreateCompressPointCloudTaskAsync(CreateCompressPointCloudTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCompressPointCloudTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建自定义故事
         *
         * @param tmpReq CreateCustomizedStoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCustomizedStoryResponse
         */
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

        /**
         * @summary 创建自定义故事
         *
         * @param tmpReq CreateCustomizedStoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCustomizedStoryResponse
         */
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

        /**
         * @summary 创建自定义故事
         *
         * @param request CreateCustomizedStoryRequest
         * @return CreateCustomizedStoryResponse
         */
        public CreateCustomizedStoryResponse CreateCustomizedStory(CreateCustomizedStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomizedStoryWithOptions(request, runtime);
        }

        /**
         * @summary 创建自定义故事
         *
         * @param request CreateCustomizedStoryRequest
         * @return CreateCustomizedStoryResponse
         */
        public async Task<CreateCustomizedStoryResponse> CreateCustomizedStoryAsync(CreateCustomizedStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomizedStoryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建数据集
         *
         * @param request CreateDatasetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDatasetResponse
         */
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

        /**
         * @summary 创建数据集
         *
         * @param request CreateDatasetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDatasetResponse
         */
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

        /**
         * @summary 创建数据集
         *
         * @param request CreateDatasetRequest
         * @return CreateDatasetResponse
         */
        public CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDatasetWithOptions(request, runtime);
        }

        /**
         * @summary 创建数据集
         *
         * @param request CreateDatasetRequest
         * @return CreateDatasetResponse
         */
        public async Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDatasetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提取盲水印
         *
         * @param tmpReq CreateDecodeBlindWatermarkTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDecodeBlindWatermarkTaskResponse
         */
        public CreateDecodeBlindWatermarkTaskResponse CreateDecodeBlindWatermarkTaskWithOptions(CreateDecodeBlindWatermarkTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDecodeBlindWatermarkTaskShrinkRequest request = new CreateDecodeBlindWatermarkTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageQuality))
            {
                query["ImageQuality"] = request.ImageQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalImageURI))
            {
                query["OriginalImageURI"] = request.OriginalImageURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrengthLevel))
            {
                query["StrengthLevel"] = request.StrengthLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURI))
            {
                query["TargetURI"] = request.TargetURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkType))
            {
                query["WatermarkType"] = request.WatermarkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDecodeBlindWatermarkTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDecodeBlindWatermarkTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提取盲水印
         *
         * @param tmpReq CreateDecodeBlindWatermarkTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDecodeBlindWatermarkTaskResponse
         */
        public async Task<CreateDecodeBlindWatermarkTaskResponse> CreateDecodeBlindWatermarkTaskWithOptionsAsync(CreateDecodeBlindWatermarkTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDecodeBlindWatermarkTaskShrinkRequest request = new CreateDecodeBlindWatermarkTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageQuality))
            {
                query["ImageQuality"] = request.ImageQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalImageURI))
            {
                query["OriginalImageURI"] = request.OriginalImageURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrengthLevel))
            {
                query["StrengthLevel"] = request.StrengthLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURI))
            {
                query["TargetURI"] = request.TargetURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkType))
            {
                query["WatermarkType"] = request.WatermarkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDecodeBlindWatermarkTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDecodeBlindWatermarkTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提取盲水印
         *
         * @param request CreateDecodeBlindWatermarkTaskRequest
         * @return CreateDecodeBlindWatermarkTaskResponse
         */
        public CreateDecodeBlindWatermarkTaskResponse CreateDecodeBlindWatermarkTask(CreateDecodeBlindWatermarkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDecodeBlindWatermarkTaskWithOptions(request, runtime);
        }

        /**
         * @summary 提取盲水印
         *
         * @param request CreateDecodeBlindWatermarkTaskRequest
         * @return CreateDecodeBlindWatermarkTaskResponse
         */
        public async Task<CreateDecodeBlindWatermarkTaskResponse> CreateDecodeBlindWatermarkTaskAsync(CreateDecodeBlindWatermarkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDecodeBlindWatermarkTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 以脸搜图
         *
         * @param tmpReq CreateFacesSearchingTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFacesSearchingTaskResponse
         */
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

        /**
         * @summary 以脸搜图
         *
         * @param tmpReq CreateFacesSearchingTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFacesSearchingTaskResponse
         */
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

        /**
         * @summary 以脸搜图
         *
         * @param request CreateFacesSearchingTaskRequest
         * @return CreateFacesSearchingTaskResponse
         */
        public CreateFacesSearchingTaskResponse CreateFacesSearchingTask(CreateFacesSearchingTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFacesSearchingTaskWithOptions(request, runtime);
        }

        /**
         * @summary 以脸搜图
         *
         * @param request CreateFacesSearchingTaskRequest
         * @return CreateFacesSearchingTaskResponse
         */
        public async Task<CreateFacesSearchingTaskResponse> CreateFacesSearchingTaskAsync(CreateFacesSearchingTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFacesSearchingTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 聚类
         *
         * @param tmpReq CreateFigureClusteringTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFigureClusteringTaskResponse
         */
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

        /**
         * @summary 聚类
         *
         * @param tmpReq CreateFigureClusteringTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFigureClusteringTaskResponse
         */
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

        /**
         * @summary 聚类
         *
         * @param request CreateFigureClusteringTaskRequest
         * @return CreateFigureClusteringTaskResponse
         */
        public CreateFigureClusteringTaskResponse CreateFigureClusteringTask(CreateFigureClusteringTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFigureClusteringTaskWithOptions(request, runtime);
        }

        /**
         * @summary 聚类
         *
         * @param request CreateFigureClusteringTaskRequest
         * @return CreateFigureClusteringTaskResponse
         */
        public async Task<CreateFigureClusteringTaskResponse> CreateFigureClusteringTaskAsync(CreateFigureClusteringTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFigureClusteringTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 合并聚类
         *
         * @param tmpReq CreateFigureClustersMergingTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFigureClustersMergingTaskResponse
         */
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

        /**
         * @summary 合并聚类
         *
         * @param tmpReq CreateFigureClustersMergingTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFigureClustersMergingTaskResponse
         */
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

        /**
         * @summary 合并聚类
         *
         * @param request CreateFigureClustersMergingTaskRequest
         * @return CreateFigureClustersMergingTaskResponse
         */
        public CreateFigureClustersMergingTaskResponse CreateFigureClustersMergingTask(CreateFigureClustersMergingTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFigureClustersMergingTaskWithOptions(request, runtime);
        }

        /**
         * @summary 合并聚类
         *
         * @param request CreateFigureClustersMergingTaskRequest
         * @return CreateFigureClustersMergingTaskResponse
         */
        public async Task<CreateFigureClustersMergingTaskResponse> CreateFigureClustersMergingTaskAsync(CreateFigureClustersMergingTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFigureClustersMergingTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 压缩/打包下载API
         *
         * @param tmpReq CreateFileCompressionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFileCompressionTaskResponse
         */
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

        /**
         * @summary 压缩/打包下载API
         *
         * @param tmpReq CreateFileCompressionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFileCompressionTaskResponse
         */
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

        /**
         * @summary 压缩/打包下载API
         *
         * @param request CreateFileCompressionTaskRequest
         * @return CreateFileCompressionTaskResponse
         */
        public CreateFileCompressionTaskResponse CreateFileCompressionTask(CreateFileCompressionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFileCompressionTaskWithOptions(request, runtime);
        }

        /**
         * @summary 压缩/打包下载API
         *
         * @param request CreateFileCompressionTaskRequest
         * @return CreateFileCompressionTaskResponse
         */
        public async Task<CreateFileCompressionTaskResponse> CreateFileCompressionTaskAsync(CreateFileCompressionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFileCompressionTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 在线解压API
         *
         * @param tmpReq CreateFileUncompressionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFileUncompressionTaskResponse
         */
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

        /**
         * @summary 在线解压API
         *
         * @param tmpReq CreateFileUncompressionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateFileUncompressionTaskResponse
         */
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

        /**
         * @summary 在线解压API
         *
         * @param request CreateFileUncompressionTaskRequest
         * @return CreateFileUncompressionTaskResponse
         */
        public CreateFileUncompressionTaskResponse CreateFileUncompressionTask(CreateFileUncompressionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFileUncompressionTaskWithOptions(request, runtime);
        }

        /**
         * @summary 在线解压API
         *
         * @param request CreateFileUncompressionTaskRequest
         * @return CreateFileUncompressionTaskResponse
         */
        public async Task<CreateFileUncompressionTaskResponse> CreateFileUncompressionTaskAsync(CreateFileUncompressionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFileUncompressionTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建图片检测
         *
         * @param tmpReq CreateImageModerationTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateImageModerationTaskResponse
         */
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

        /**
         * @summary 创建图片检测
         *
         * @param tmpReq CreateImageModerationTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateImageModerationTaskResponse
         */
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

        /**
         * @summary 创建图片检测
         *
         * @param request CreateImageModerationTaskRequest
         * @return CreateImageModerationTaskResponse
         */
        public CreateImageModerationTaskResponse CreateImageModerationTask(CreateImageModerationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageModerationTaskWithOptions(request, runtime);
        }

        /**
         * @summary 创建图片检测
         *
         * @param request CreateImageModerationTaskRequest
         * @return CreateImageModerationTaskResponse
         */
        public async Task<CreateImageModerationTaskResponse> CreateImageModerationTaskAsync(CreateImageModerationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageModerationTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 图片拼接
         *
         * @param tmpReq CreateImageSplicingTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateImageSplicingTaskResponse
         */
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

        /**
         * @summary 图片拼接
         *
         * @param tmpReq CreateImageSplicingTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateImageSplicingTaskResponse
         */
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

        /**
         * @summary 图片拼接
         *
         * @param request CreateImageSplicingTaskRequest
         * @return CreateImageSplicingTaskResponse
         */
        public CreateImageSplicingTaskResponse CreateImageSplicingTask(CreateImageSplicingTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageSplicingTaskWithOptions(request, runtime);
        }

        /**
         * @summary 图片拼接
         *
         * @param request CreateImageSplicingTaskRequest
         * @return CreateImageSplicingTaskResponse
         */
        public async Task<CreateImageSplicingTaskResponse> CreateImageSplicingTaskAsync(CreateImageSplicingTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageSplicingTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 图片转PDF
         *
         * @param tmpReq CreateImageToPDFTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateImageToPDFTaskResponse
         */
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

        /**
         * @summary 图片转PDF
         *
         * @param tmpReq CreateImageToPDFTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateImageToPDFTaskResponse
         */
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

        /**
         * @summary 图片转PDF
         *
         * @param request CreateImageToPDFTaskRequest
         * @return CreateImageToPDFTaskResponse
         */
        public CreateImageToPDFTaskResponse CreateImageToPDFTask(CreateImageToPDFTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageToPDFTaskWithOptions(request, runtime);
        }

        /**
         * @summary 图片转PDF
         *
         * @param request CreateImageToPDFTaskRequest
         * @return CreateImageToPDFTaskResponse
         */
        public async Task<CreateImageToPDFTaskResponse> CreateImageToPDFTaskAsync(CreateImageToPDFTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageToPDFTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建时空聚类任务
         *
         * @param tmpReq CreateLocationDateClusteringTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLocationDateClusteringTaskResponse
         */
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

        /**
         * @summary 创建时空聚类任务
         *
         * @param tmpReq CreateLocationDateClusteringTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLocationDateClusteringTaskResponse
         */
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

        /**
         * @summary 创建时空聚类任务
         *
         * @param request CreateLocationDateClusteringTaskRequest
         * @return CreateLocationDateClusteringTaskResponse
         */
        public CreateLocationDateClusteringTaskResponse CreateLocationDateClusteringTask(CreateLocationDateClusteringTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLocationDateClusteringTaskWithOptions(request, runtime);
        }

        /**
         * @summary 创建时空聚类任务
         *
         * @param request CreateLocationDateClusteringTaskRequest
         * @return CreateLocationDateClusteringTaskResponse
         */
        public async Task<CreateLocationDateClusteringTaskResponse> CreateLocationDateClusteringTaskAsync(CreateLocationDateClusteringTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLocationDateClusteringTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建转码服务
         *
         * @param tmpReq CreateMediaConvertTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMediaConvertTaskResponse
         */
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

        /**
         * @summary 创建转码服务
         *
         * @param tmpReq CreateMediaConvertTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateMediaConvertTaskResponse
         */
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

        /**
         * @summary 创建转码服务
         *
         * @param request CreateMediaConvertTaskRequest
         * @return CreateMediaConvertTaskResponse
         */
        public CreateMediaConvertTaskResponse CreateMediaConvertTask(CreateMediaConvertTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMediaConvertTaskWithOptions(request, runtime);
        }

        /**
         * @summary 创建转码服务
         *
         * @param request CreateMediaConvertTaskRequest
         * @return CreateMediaConvertTaskResponse
         */
        public async Task<CreateMediaConvertTaskResponse> CreateMediaConvertTaskAsync(CreateMediaConvertTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMediaConvertTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建文档转换任务
         *
         * @param tmpReq CreateOfficeConversionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOfficeConversionTaskResponse
         */
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

        /**
         * @summary 创建文档转换任务
         *
         * @param tmpReq CreateOfficeConversionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOfficeConversionTaskResponse
         */
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

        /**
         * @summary 创建文档转换任务
         *
         * @param request CreateOfficeConversionTaskRequest
         * @return CreateOfficeConversionTaskResponse
         */
        public CreateOfficeConversionTaskResponse CreateOfficeConversionTask(CreateOfficeConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOfficeConversionTaskWithOptions(request, runtime);
        }

        /**
         * @summary 创建文档转换任务
         *
         * @param request CreateOfficeConversionTaskRequest
         * @return CreateOfficeConversionTaskResponse
         */
        public async Task<CreateOfficeConversionTaskResponse> CreateOfficeConversionTaskAsync(CreateOfficeConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOfficeConversionTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建项目
         *
         * @param tmpReq CreateProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectResponse
         */
        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateProjectShrinkRequest request = new CreateProjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
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

        /**
         * @summary 创建项目
         *
         * @param tmpReq CreateProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectResponse
         */
        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateProjectShrinkRequest request = new CreateProjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
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

        /**
         * @summary 创建项目
         *
         * @param request CreateProjectRequest
         * @return CreateProjectResponse
         */
        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProjectWithOptions(request, runtime);
        }

        /**
         * @summary 创建项目
         *
         * @param request CreateProjectRequest
         * @return CreateProjectResponse
         */
        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建相似图片聚类任务
         *
         * @param tmpReq CreateSimilarImageClusteringTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSimilarImageClusteringTaskResponse
         */
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

        /**
         * @summary 创建相似图片聚类任务
         *
         * @param tmpReq CreateSimilarImageClusteringTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSimilarImageClusteringTaskResponse
         */
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

        /**
         * @summary 创建相似图片聚类任务
         *
         * @param request CreateSimilarImageClusteringTaskRequest
         * @return CreateSimilarImageClusteringTaskResponse
         */
        public CreateSimilarImageClusteringTaskResponse CreateSimilarImageClusteringTask(CreateSimilarImageClusteringTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSimilarImageClusteringTaskWithOptions(request, runtime);
        }

        /**
         * @summary 创建相似图片聚类任务
         *
         * @param request CreateSimilarImageClusteringTaskRequest
         * @return CreateSimilarImageClusteringTaskResponse
         */
        public async Task<CreateSimilarImageClusteringTaskResponse> CreateSimilarImageClusteringTaskAsync(CreateSimilarImageClusteringTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSimilarImageClusteringTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建一个 Story
         *
         * @param tmpReq CreateStoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateStoryResponse
         */
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

        /**
         * @summary 创建一个 Story
         *
         * @param tmpReq CreateStoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateStoryResponse
         */
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

        /**
         * @summary 创建一个 Story
         *
         * @param request CreateStoryRequest
         * @return CreateStoryResponse
         */
        public CreateStoryResponse CreateStory(CreateStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStoryWithOptions(request, runtime);
        }

        /**
         * @summary 创建一个 Story
         *
         * @param request CreateStoryRequest
         * @return CreateStoryResponse
         */
        public async Task<CreateStoryResponse> CreateStoryAsync(CreateStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStoryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建数据接入
         *
         * @param tmpReq CreateTriggerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTriggerResponse
         */
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

        /**
         * @summary 创建数据接入
         *
         * @param tmpReq CreateTriggerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTriggerResponse
         */
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

        /**
         * @summary 创建数据接入
         *
         * @param request CreateTriggerRequest
         * @return CreateTriggerResponse
         */
        public CreateTriggerResponse CreateTrigger(CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTriggerWithOptions(request, runtime);
        }

        /**
         * @summary 创建数据接入
         *
         * @param request CreateTriggerRequest
         * @return CreateTriggerResponse
         */
        public async Task<CreateTriggerResponse> CreateTriggerAsync(CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTriggerWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 检测视频中的内容
         *
         * @param tmpReq CreateVideoLabelClassificationTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVideoLabelClassificationTaskResponse
         */
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

        /**
         * @summary 检测视频中的内容
         *
         * @param tmpReq CreateVideoLabelClassificationTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVideoLabelClassificationTaskResponse
         */
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

        /**
         * @summary 检测视频中的内容
         *
         * @param request CreateVideoLabelClassificationTaskRequest
         * @return CreateVideoLabelClassificationTaskResponse
         */
        public CreateVideoLabelClassificationTaskResponse CreateVideoLabelClassificationTask(CreateVideoLabelClassificationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVideoLabelClassificationTaskWithOptions(request, runtime);
        }

        /**
         * @summary 检测视频中的内容
         *
         * @param request CreateVideoLabelClassificationTaskRequest
         * @return CreateVideoLabelClassificationTaskResponse
         */
        public async Task<CreateVideoLabelClassificationTaskResponse> CreateVideoLabelClassificationTaskAsync(CreateVideoLabelClassificationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVideoLabelClassificationTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建视频检测
         *
         * @param tmpReq CreateVideoModerationTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVideoModerationTaskResponse
         */
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

        /**
         * @summary 创建视频检测
         *
         * @param tmpReq CreateVideoModerationTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVideoModerationTaskResponse
         */
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

        /**
         * @summary 创建视频检测
         *
         * @param request CreateVideoModerationTaskRequest
         * @return CreateVideoModerationTaskResponse
         */
        public CreateVideoModerationTaskResponse CreateVideoModerationTask(CreateVideoModerationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVideoModerationTaskWithOptions(request, runtime);
        }

        /**
         * @summary 创建视频检测
         *
         * @param request CreateVideoModerationTaskRequest
         * @return CreateVideoModerationTaskResponse
         */
        public async Task<CreateVideoModerationTaskResponse> CreateVideoModerationTaskAsync(CreateVideoModerationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVideoModerationTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除数据接入实例
         *
         * @param request DeleteBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteBatchResponse
         */
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

        /**
         * @summary 删除数据接入实例
         *
         * @param request DeleteBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteBatchResponse
         */
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

        /**
         * @summary 删除数据接入实例
         *
         * @param request DeleteBatchRequest
         * @return DeleteBatchResponse
         */
        public DeleteBatchResponse DeleteBatch(DeleteBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBatchWithOptions(request, runtime);
        }

        /**
         * @summary 删除数据接入实例
         *
         * @param request DeleteBatchRequest
         * @return DeleteBatchResponse
         */
        public async Task<DeleteBatchResponse> DeleteBatchAsync(DeleteBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBatchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除绑定
         *
         * @param request DeleteBindingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteBindingResponse
         */
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

        /**
         * @summary 删除绑定
         *
         * @param request DeleteBindingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteBindingResponse
         */
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

        /**
         * @summary 删除绑定
         *
         * @param request DeleteBindingRequest
         * @return DeleteBindingResponse
         */
        public DeleteBindingResponse DeleteBinding(DeleteBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBindingWithOptions(request, runtime);
        }

        /**
         * @summary 删除绑定
         *
         * @param request DeleteBindingRequest
         * @return DeleteBindingResponse
         */
        public async Task<DeleteBindingResponse> DeleteBindingAsync(DeleteBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBindingWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除媒体集
         *
         * @param request DeleteDatasetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDatasetResponse
         */
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

        /**
         * @summary 删除媒体集
         *
         * @param request DeleteDatasetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDatasetResponse
         */
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

        /**
         * @summary 删除媒体集
         *
         * @param request DeleteDatasetRequest
         * @return DeleteDatasetResponse
         */
        public DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDatasetWithOptions(request, runtime);
        }

        /**
         * @summary 删除媒体集
         *
         * @param request DeleteDatasetRequest
         * @return DeleteDatasetResponse
         */
        public async Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDatasetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除文件元信息
         *
         * @param request DeleteFileMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFileMetaResponse
         */
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

        /**
         * @summary 删除文件元信息
         *
         * @param request DeleteFileMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFileMetaResponse
         */
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

        /**
         * @summary 删除文件元信息
         *
         * @param request DeleteFileMetaRequest
         * @return DeleteFileMetaResponse
         */
        public DeleteFileMetaResponse DeleteFileMeta(DeleteFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFileMetaWithOptions(request, runtime);
        }

        /**
         * @summary 删除文件元信息
         *
         * @param request DeleteFileMetaRequest
         * @return DeleteFileMetaResponse
         */
        public async Task<DeleteFileMetaResponse> DeleteFileMetaAsync(DeleteFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFileMetaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除时空聚类
         *
         * @param request DeleteLocationDateClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLocationDateClusterResponse
         */
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

        /**
         * @summary 删除时空聚类
         *
         * @param request DeleteLocationDateClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLocationDateClusterResponse
         */
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

        /**
         * @summary 删除时空聚类
         *
         * @param request DeleteLocationDateClusterRequest
         * @return DeleteLocationDateClusterResponse
         */
        public DeleteLocationDateClusterResponse DeleteLocationDateCluster(DeleteLocationDateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLocationDateClusterWithOptions(request, runtime);
        }

        /**
         * @summary 删除时空聚类
         *
         * @param request DeleteLocationDateClusterRequest
         * @return DeleteLocationDateClusterResponse
         */
        public async Task<DeleteLocationDateClusterResponse> DeleteLocationDateClusterAsync(DeleteLocationDateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLocationDateClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除项目
         *
         * @param request DeleteProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProjectResponse
         */
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

        /**
         * @summary 删除项目
         *
         * @param request DeleteProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProjectResponse
         */
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

        /**
         * @summary 删除项目
         *
         * @param request DeleteProjectRequest
         * @return DeleteProjectResponse
         */
        public DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProjectWithOptions(request, runtime);
        }

        /**
         * @summary 删除项目
         *
         * @param request DeleteProjectRequest
         * @return DeleteProjectResponse
         */
        public async Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除一个 Story
         *
         * @param request DeleteStoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteStoryResponse
         */
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

        /**
         * @summary 删除一个 Story
         *
         * @param request DeleteStoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteStoryResponse
         */
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

        /**
         * @summary 删除一个 Story
         *
         * @param request DeleteStoryRequest
         * @return DeleteStoryResponse
         */
        public DeleteStoryResponse DeleteStory(DeleteStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStoryWithOptions(request, runtime);
        }

        /**
         * @summary 删除一个 Story
         *
         * @param request DeleteStoryRequest
         * @return DeleteStoryResponse
         */
        public async Task<DeleteStoryResponse> DeleteStoryAsync(DeleteStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStoryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除数据接入实例
         *
         * @param request DeleteTriggerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTriggerResponse
         */
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

        /**
         * @summary 删除数据接入实例
         *
         * @param request DeleteTriggerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTriggerResponse
         */
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

        /**
         * @summary 删除数据接入实例
         *
         * @param request DeleteTriggerRequest
         * @return DeleteTriggerResponse
         */
        public DeleteTriggerResponse DeleteTrigger(DeleteTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTriggerWithOptions(request, runtime);
        }

        /**
         * @summary 删除数据接入实例
         *
         * @param request DeleteTriggerRequest
         * @return DeleteTriggerResponse
         */
        public async Task<DeleteTriggerResponse> DeleteTriggerAsync(DeleteTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTriggerWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 解绑ossbucket
         *
         * @param request DetachOSSBucketRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachOSSBucketResponse
         */
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

        /**
         * @summary 解绑ossbucket
         *
         * @param request DetachOSSBucketRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachOSSBucketResponse
         */
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

        /**
         * @summary 解绑ossbucket
         *
         * @param request DetachOSSBucketRequest
         * @return DetachOSSBucketResponse
         */
        public DetachOSSBucketResponse DetachOSSBucket(DetachOSSBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachOSSBucketWithOptions(request, runtime);
        }

        /**
         * @summary 解绑ossbucket
         *
         * @param request DetachOSSBucketRequest
         * @return DetachOSSBucketResponse
         */
        public async Task<DetachOSSBucketResponse> DetachOSSBucketAsync(DetachOSSBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachOSSBucketWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 人体检测算子
         *
         * @param tmpReq DetectImageBodiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectImageBodiesResponse
         */
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

        /**
         * @summary 人体检测算子
         *
         * @param tmpReq DetectImageBodiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectImageBodiesResponse
         */
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

        /**
         * @summary 人体检测算子
         *
         * @param request DetectImageBodiesRequest
         * @return DetectImageBodiesResponse
         */
        public DetectImageBodiesResponse DetectImageBodies(DetectImageBodiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageBodiesWithOptions(request, runtime);
        }

        /**
         * @summary 人体检测算子
         *
         * @param request DetectImageBodiesRequest
         * @return DetectImageBodiesResponse
         */
        public async Task<DetectImageBodiesResponse> DetectImageBodiesAsync(DetectImageBodiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageBodiesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 检测图片中车辆信息
         *
         * @param tmpReq DetectImageCarsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectImageCarsResponse
         */
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

        /**
         * @summary 检测图片中车辆信息
         *
         * @param tmpReq DetectImageCarsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectImageCarsResponse
         */
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

        /**
         * @summary 检测图片中车辆信息
         *
         * @param request DetectImageCarsRequest
         * @return DetectImageCarsResponse
         */
        public DetectImageCarsResponse DetectImageCars(DetectImageCarsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageCarsWithOptions(request, runtime);
        }

        /**
         * @summary 检测图片中车辆信息
         *
         * @param request DetectImageCarsRequest
         * @return DetectImageCarsResponse
         */
        public async Task<DetectImageCarsResponse> DetectImageCarsAsync(DetectImageCarsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageCarsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取图片二维码检测
         *
         * @param tmpReq DetectImageCodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectImageCodesResponse
         */
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

        /**
         * @summary 获取图片二维码检测
         *
         * @param tmpReq DetectImageCodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectImageCodesResponse
         */
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

        /**
         * @summary 获取图片二维码检测
         *
         * @param request DetectImageCodesRequest
         * @return DetectImageCodesResponse
         */
        public DetectImageCodesResponse DetectImageCodes(DetectImageCodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageCodesWithOptions(request, runtime);
        }

        /**
         * @summary 获取图片二维码检测
         *
         * @param request DetectImageCodesRequest
         * @return DetectImageCodesResponse
         */
        public async Task<DetectImageCodesResponse> DetectImageCodesAsync(DetectImageCodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageCodesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取图片裁剪信息
         *
         * @param tmpReq DetectImageCroppingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectImageCroppingResponse
         */
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

        /**
         * @summary 获取图片裁剪信息
         *
         * @param tmpReq DetectImageCroppingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectImageCroppingResponse
         */
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

        /**
         * @summary 获取图片裁剪信息
         *
         * @param request DetectImageCroppingRequest
         * @return DetectImageCroppingResponse
         */
        public DetectImageCroppingResponse DetectImageCropping(DetectImageCroppingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageCroppingWithOptions(request, runtime);
        }

        /**
         * @summary 获取图片裁剪信息
         *
         * @param request DetectImageCroppingRequest
         * @return DetectImageCroppingResponse
         */
        public async Task<DetectImageCroppingResponse> DetectImageCroppingAsync(DetectImageCroppingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageCroppingWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取图片人脸信息
         *
         * @param tmpReq DetectImageFacesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectImageFacesResponse
         */
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

        /**
         * @summary 获取图片人脸信息
         *
         * @param tmpReq DetectImageFacesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectImageFacesResponse
         */
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

        /**
         * @summary 获取图片人脸信息
         *
         * @param request DetectImageFacesRequest
         * @return DetectImageFacesResponse
         */
        public DetectImageFacesResponse DetectImageFaces(DetectImageFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageFacesWithOptions(request, runtime);
        }

        /**
         * @summary 获取图片人脸信息
         *
         * @param request DetectImageFacesRequest
         * @return DetectImageFacesResponse
         */
        public async Task<DetectImageFacesResponse> DetectImageFacesAsync(DetectImageFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageFacesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 检测图像中的内容
         *
         * @param tmpReq DetectImageLabelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectImageLabelsResponse
         */
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

        /**
         * @summary 检测图像中的内容
         *
         * @param tmpReq DetectImageLabelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectImageLabelsResponse
         */
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

        /**
         * @summary 检测图像中的内容
         *
         * @param request DetectImageLabelsRequest
         * @return DetectImageLabelsResponse
         */
        public DetectImageLabelsResponse DetectImageLabels(DetectImageLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageLabelsWithOptions(request, runtime);
        }

        /**
         * @summary 检测图像中的内容
         *
         * @param request DetectImageLabelsRequest
         * @return DetectImageLabelsResponse
         */
        public async Task<DetectImageLabelsResponse> DetectImageLabelsAsync(DetectImageLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageLabelsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取图片打分
         *
         * @param tmpReq DetectImageScoreRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectImageScoreResponse
         */
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

        /**
         * @summary 获取图片打分
         *
         * @param tmpReq DetectImageScoreRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectImageScoreResponse
         */
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

        /**
         * @summary 获取图片打分
         *
         * @param request DetectImageScoreRequest
         * @return DetectImageScoreResponse
         */
        public DetectImageScoreResponse DetectImageScore(DetectImageScoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageScoreWithOptions(request, runtime);
        }

        /**
         * @summary 获取图片打分
         *
         * @param request DetectImageScoreRequest
         * @return DetectImageScoreResponse
         */
        public async Task<DetectImageScoreResponse> DetectImageScoreAsync(DetectImageScoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageScoreWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 进行图片光学字符检测
         *
         * @param tmpReq DetectImageTextsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectImageTextsResponse
         */
        public DetectImageTextsResponse DetectImageTextsWithOptions(DetectImageTextsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectImageTextsShrinkRequest request = new DetectImageTextsShrinkRequest();
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
                Action = "DetectImageTexts",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageTextsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 进行图片光学字符检测
         *
         * @param tmpReq DetectImageTextsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectImageTextsResponse
         */
        public async Task<DetectImageTextsResponse> DetectImageTextsWithOptionsAsync(DetectImageTextsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetectImageTextsShrinkRequest request = new DetectImageTextsShrinkRequest();
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
                Action = "DetectImageTexts",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageTextsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 进行图片光学字符检测
         *
         * @param request DetectImageTextsRequest
         * @return DetectImageTextsResponse
         */
        public DetectImageTextsResponse DetectImageTexts(DetectImageTextsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageTextsWithOptions(request, runtime);
        }

        /**
         * @summary 进行图片光学字符检测
         *
         * @param request DetectImageTextsRequest
         * @return DetectImageTextsResponse
         */
        public async Task<DetectImageTextsResponse> DetectImageTextsAsync(DetectImageTextsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageTextsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取媒体文件信息
         *
         * @param tmpReq DetectMediaMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectMediaMetaResponse
         */
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

        /**
         * @summary 获取媒体文件信息
         *
         * @param tmpReq DetectMediaMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectMediaMetaResponse
         */
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

        /**
         * @summary 获取媒体文件信息
         *
         * @param request DetectMediaMetaRequest
         * @return DetectMediaMetaResponse
         */
        public DetectMediaMetaResponse DetectMediaMeta(DetectMediaMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectMediaMetaWithOptions(request, runtime);
        }

        /**
         * @summary 获取媒体文件信息
         *
         * @param request DetectMediaMetaRequest
         * @return DetectMediaMetaResponse
         */
        public async Task<DetectMediaMetaResponse> DetectMediaMetaAsync(DetectMediaMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectMediaMetaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 检测文本
         *
         * @param request DetectTextAnomalyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectTextAnomalyResponse
         */
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

        /**
         * @summary 检测文本
         *
         * @param request DetectTextAnomalyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetectTextAnomalyResponse
         */
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

        /**
         * @summary 检测文本
         *
         * @param request DetectTextAnomalyRequest
         * @return DetectTextAnomalyResponse
         */
        public DetectTextAnomalyResponse DetectTextAnomaly(DetectTextAnomalyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectTextAnomalyWithOptions(request, runtime);
        }

        /**
         * @summary 检测文本
         *
         * @param request DetectTextAnomalyRequest
         * @return DetectTextAnomalyResponse
         */
        public async Task<DetectTextAnomalyResponse> DetectTextAnomalyAsync(DetectTextAnomalyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectTextAnomalyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 嵌入图片盲水印算子
         *
         * @param request EncodeBlindWatermarkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EncodeBlindWatermarkResponse
         */
        public EncodeBlindWatermarkResponse EncodeBlindWatermarkWithOptions(EncodeBlindWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageQuality))
            {
                query["ImageQuality"] = request.ImageQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrengthLevel))
            {
                query["StrengthLevel"] = request.StrengthLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURI))
            {
                query["TargetURI"] = request.TargetURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EncodeBlindWatermark",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EncodeBlindWatermarkResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 嵌入图片盲水印算子
         *
         * @param request EncodeBlindWatermarkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EncodeBlindWatermarkResponse
         */
        public async Task<EncodeBlindWatermarkResponse> EncodeBlindWatermarkWithOptionsAsync(EncodeBlindWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageQuality))
            {
                query["ImageQuality"] = request.ImageQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrengthLevel))
            {
                query["StrengthLevel"] = request.StrengthLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetURI))
            {
                query["TargetURI"] = request.TargetURI;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EncodeBlindWatermark",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EncodeBlindWatermarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 嵌入图片盲水印算子
         *
         * @param request EncodeBlindWatermarkRequest
         * @return EncodeBlindWatermarkResponse
         */
        public EncodeBlindWatermarkResponse EncodeBlindWatermark(EncodeBlindWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EncodeBlindWatermarkWithOptions(request, runtime);
        }

        /**
         * @summary 嵌入图片盲水印算子
         *
         * @param request EncodeBlindWatermarkRequest
         * @return EncodeBlindWatermarkResponse
         */
        public async Task<EncodeBlindWatermarkResponse> EncodeBlindWatermarkAsync(EncodeBlindWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EncodeBlindWatermarkWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提取文档中的文本
         *
         * @param tmpReq ExtractDocumentTextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExtractDocumentTextResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
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

        /**
         * @summary 提取文档中的文本
         *
         * @param tmpReq ExtractDocumentTextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExtractDocumentTextResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
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

        /**
         * @summary 提取文档中的文本
         *
         * @param request ExtractDocumentTextRequest
         * @return ExtractDocumentTextResponse
         */
        public ExtractDocumentTextResponse ExtractDocumentText(ExtractDocumentTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExtractDocumentTextWithOptions(request, runtime);
        }

        /**
         * @summary 提取文档中的文本
         *
         * @param request ExtractDocumentTextRequest
         * @return ExtractDocumentTextResponse
         */
        public async Task<ExtractDocumentTextResponse> ExtractDocumentTextAsync(ExtractDocumentTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExtractDocumentTextWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 对 Dataset 内的元数据进行模糊搜索。
         *
         * @param tmpReq FuzzyQueryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FuzzyQueryResponse
         */
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

        /**
         * @summary 对 Dataset 内的元数据进行模糊搜索。
         *
         * @param tmpReq FuzzyQueryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FuzzyQueryResponse
         */
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

        /**
         * @summary 对 Dataset 内的元数据进行模糊搜索。
         *
         * @param request FuzzyQueryRequest
         * @return FuzzyQueryResponse
         */
        public FuzzyQueryResponse FuzzyQuery(FuzzyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FuzzyQueryWithOptions(request, runtime);
        }

        /**
         * @summary 对 Dataset 内的元数据进行模糊搜索。
         *
         * @param request FuzzyQueryRequest
         * @return FuzzyQueryResponse
         */
        public async Task<FuzzyQueryResponse> FuzzyQueryAsync(FuzzyQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FuzzyQueryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建实时转码任务
         *
         * @param tmpReq GenerateVideoPlaylistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateVideoPlaylistResponse
         */
        public GenerateVideoPlaylistResponse GenerateVideoPlaylistWithOptions(GenerateVideoPlaylistRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateVideoPlaylistShrinkRequest request = new GenerateVideoPlaylistShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceSubtitles))
            {
                request.SourceSubtitlesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceSubtitles, "SourceSubtitles", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterURI))
            {
                query["MasterURI"] = request.MasterURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverwritePolicy))
            {
                query["OverwritePolicy"] = request.OverwritePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDuration))
            {
                query["SourceDuration"] = request.SourceDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceStartTime))
            {
                query["SourceStartTime"] = request.SourceStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSubtitlesShrink))
            {
                query["SourceSubtitles"] = request.SourceSubtitlesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
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
                Action = "GenerateVideoPlaylist",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateVideoPlaylistResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建实时转码任务
         *
         * @param tmpReq GenerateVideoPlaylistRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateVideoPlaylistResponse
         */
        public async Task<GenerateVideoPlaylistResponse> GenerateVideoPlaylistWithOptionsAsync(GenerateVideoPlaylistRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateVideoPlaylistShrinkRequest request = new GenerateVideoPlaylistShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CredentialConfig))
            {
                request.CredentialConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CredentialConfig, "CredentialConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Notification))
            {
                request.NotificationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Notification, "Notification", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceSubtitles))
            {
                request.SourceSubtitlesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceSubtitles, "SourceSubtitles", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialConfigShrink))
            {
                query["CredentialConfig"] = request.CredentialConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterURI))
            {
                query["MasterURI"] = request.MasterURI;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationShrink))
            {
                query["Notification"] = request.NotificationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverwritePolicy))
            {
                query["OverwritePolicy"] = request.OverwritePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDuration))
            {
                query["SourceDuration"] = request.SourceDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceStartTime))
            {
                query["SourceStartTime"] = request.SourceStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSubtitlesShrink))
            {
                query["SourceSubtitles"] = request.SourceSubtitlesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceURI))
            {
                query["SourceURI"] = request.SourceURI;
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
                Action = "GenerateVideoPlaylist",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateVideoPlaylistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建实时转码任务
         *
         * @param request GenerateVideoPlaylistRequest
         * @return GenerateVideoPlaylistResponse
         */
        public GenerateVideoPlaylistResponse GenerateVideoPlaylist(GenerateVideoPlaylistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateVideoPlaylistWithOptions(request, runtime);
        }

        /**
         * @summary 创建实时转码任务
         *
         * @param request GenerateVideoPlaylistRequest
         * @return GenerateVideoPlaylistResponse
         */
        public async Task<GenerateVideoPlaylistResponse> GenerateVideoPlaylistAsync(GenerateVideoPlaylistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateVideoPlaylistWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取文档预览编辑凭证
         *
         * @param tmpReq GenerateWebofficeTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateWebofficeTokenResponse
         */
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

        /**
         * @summary 获取文档预览编辑凭证
         *
         * @param tmpReq GenerateWebofficeTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateWebofficeTokenResponse
         */
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

        /**
         * @summary 获取文档预览编辑凭证
         *
         * @param request GenerateWebofficeTokenRequest
         * @return GenerateWebofficeTokenResponse
         */
        public GenerateWebofficeTokenResponse GenerateWebofficeToken(GenerateWebofficeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateWebofficeTokenWithOptions(request, runtime);
        }

        /**
         * @summary 获取文档预览编辑凭证
         *
         * @param request GenerateWebofficeTokenRequest
         * @return GenerateWebofficeTokenResponse
         */
        public async Task<GenerateWebofficeTokenResponse> GenerateWebofficeTokenAsync(GenerateWebofficeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateWebofficeTokenWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取数据接入实例
         *
         * @param request GetBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBatchResponse
         */
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

        /**
         * @summary 获取数据接入实例
         *
         * @param request GetBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBatchResponse
         */
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

        /**
         * @summary 获取数据接入实例
         *
         * @param request GetBatchRequest
         * @return GetBatchResponse
         */
        public GetBatchResponse GetBatch(GetBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBatchWithOptions(request, runtime);
        }

        /**
         * @summary 获取数据接入实例
         *
         * @param request GetBatchRequest
         * @return GetBatchResponse
         */
        public async Task<GetBatchResponse> GetBatchAsync(GetBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBatchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取一个绑定任务的运行详情。
         *
         * @param request GetBindingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBindingResponse
         */
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

        /**
         * @summary 获取一个绑定任务的运行详情。
         *
         * @param request GetBindingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBindingResponse
         */
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

        /**
         * @summary 获取一个绑定任务的运行详情。
         *
         * @param request GetBindingRequest
         * @return GetBindingResponse
         */
        public GetBindingResponse GetBinding(GetBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBindingWithOptions(request, runtime);
        }

        /**
         * @summary 获取一个绑定任务的运行详情。
         *
         * @param request GetBindingRequest
         * @return GetBindingResponse
         */
        public async Task<GetBindingResponse> GetBindingAsync(GetBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBindingWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetDRMLicense is deprecated
         *
         * @summary drmlicense获取
         *
         * @param request GetDRMLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDRMLicenseResponse
         */
        // Deprecated
        public GetDRMLicenseResponse GetDRMLicenseWithOptions(GetDRMLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyEndpoint))
            {
                query["NotifyEndpoint"] = request.NotifyEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectionSystem))
            {
                query["ProtectionSystem"] = request.ProtectionSystem;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDRMLicense",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDRMLicenseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI GetDRMLicense is deprecated
         *
         * @summary drmlicense获取
         *
         * @param request GetDRMLicenseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDRMLicenseResponse
         */
        // Deprecated
        public async Task<GetDRMLicenseResponse> GetDRMLicenseWithOptionsAsync(GetDRMLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyEndpoint))
            {
                query["NotifyEndpoint"] = request.NotifyEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectionSystem))
            {
                query["ProtectionSystem"] = request.ProtectionSystem;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDRMLicense",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDRMLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI GetDRMLicense is deprecated
         *
         * @summary drmlicense获取
         *
         * @param request GetDRMLicenseRequest
         * @return GetDRMLicenseResponse
         */
        // Deprecated
        public GetDRMLicenseResponse GetDRMLicense(GetDRMLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDRMLicenseWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetDRMLicense is deprecated
         *
         * @summary drmlicense获取
         *
         * @param request GetDRMLicenseRequest
         * @return GetDRMLicenseResponse
         */
        // Deprecated
        public async Task<GetDRMLicenseResponse> GetDRMLicenseAsync(GetDRMLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDRMLicenseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取媒体集信息
         *
         * @param request GetDatasetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDatasetResponse
         */
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

        /**
         * @summary 获取媒体集信息
         *
         * @param request GetDatasetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDatasetResponse
         */
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

        /**
         * @summary 获取媒体集信息
         *
         * @param request GetDatasetRequest
         * @return GetDatasetResponse
         */
        public GetDatasetResponse GetDataset(GetDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDatasetWithOptions(request, runtime);
        }

        /**
         * @summary 获取媒体集信息
         *
         * @param request GetDatasetRequest
         * @return GetDatasetResponse
         */
        public async Task<GetDatasetResponse> GetDatasetAsync(GetDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDatasetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取提取水印的结果
         *
         * @param request GetDecodeBlindWatermarkResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDecodeBlindWatermarkResultResponse
         */
        public GetDecodeBlindWatermarkResultResponse GetDecodeBlindWatermarkResultWithOptions(GetDecodeBlindWatermarkResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDecodeBlindWatermarkResult",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDecodeBlindWatermarkResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取提取水印的结果
         *
         * @param request GetDecodeBlindWatermarkResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDecodeBlindWatermarkResultResponse
         */
        public async Task<GetDecodeBlindWatermarkResultResponse> GetDecodeBlindWatermarkResultWithOptionsAsync(GetDecodeBlindWatermarkResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDecodeBlindWatermarkResult",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDecodeBlindWatermarkResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取提取水印的结果
         *
         * @param request GetDecodeBlindWatermarkResultRequest
         * @return GetDecodeBlindWatermarkResultResponse
         */
        public GetDecodeBlindWatermarkResultResponse GetDecodeBlindWatermarkResult(GetDecodeBlindWatermarkResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDecodeBlindWatermarkResultWithOptions(request, runtime);
        }

        /**
         * @summary 获取提取水印的结果
         *
         * @param request GetDecodeBlindWatermarkResultRequest
         * @return GetDecodeBlindWatermarkResultResponse
         */
        public async Task<GetDecodeBlindWatermarkResultResponse> GetDecodeBlindWatermarkResultAsync(GetDecodeBlindWatermarkResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDecodeBlindWatermarkResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取聚类
         *
         * @param request GetFigureClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFigureClusterResponse
         */
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

        /**
         * @summary 获取聚类
         *
         * @param request GetFigureClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFigureClusterResponse
         */
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

        /**
         * @summary 获取聚类
         *
         * @param request GetFigureClusterRequest
         * @return GetFigureClusterResponse
         */
        public GetFigureClusterResponse GetFigureCluster(GetFigureClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFigureClusterWithOptions(request, runtime);
        }

        /**
         * @summary 获取聚类
         *
         * @param request GetFigureClusterRequest
         * @return GetFigureClusterResponse
         */
        public async Task<GetFigureClusterResponse> GetFigureClusterAsync(GetFigureClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFigureClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取文件元信息
         *
         * @param tmpReq GetFileMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileMetaResponse
         */
        public GetFileMetaResponse GetFileMetaWithOptions(GetFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetFileMetaShrinkRequest request = new GetFileMetaShrinkRequest();
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
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

        /**
         * @summary 获取文件元信息
         *
         * @param tmpReq GetFileMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileMetaResponse
         */
        public async Task<GetFileMetaResponse> GetFileMetaWithOptionsAsync(GetFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetFileMetaShrinkRequest request = new GetFileMetaShrinkRequest();
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.URI))
            {
                query["URI"] = request.URI;
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

        /**
         * @summary 获取文件元信息
         *
         * @param request GetFileMetaRequest
         * @return GetFileMetaResponse
         */
        public GetFileMetaResponse GetFileMeta(GetFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFileMetaWithOptions(request, runtime);
        }

        /**
         * @summary 获取文件元信息
         *
         * @param request GetFileMetaRequest
         * @return GetFileMetaResponse
         */
        public async Task<GetFileMetaResponse> GetFileMetaAsync(GetFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFileMetaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取图片审核任务结果
         *
         * @param request GetImageModerationResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetImageModerationResultResponse
         */
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

        /**
         * @summary 获取图片审核任务结果
         *
         * @param request GetImageModerationResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetImageModerationResultResponse
         */
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

        /**
         * @summary 获取图片审核任务结果
         *
         * @param request GetImageModerationResultRequest
         * @return GetImageModerationResultResponse
         */
        public GetImageModerationResultResponse GetImageModerationResult(GetImageModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageModerationResultWithOptions(request, runtime);
        }

        /**
         * @summary 获取图片审核任务结果
         *
         * @param request GetImageModerationResultRequest
         * @return GetImageModerationResultResponse
         */
        public async Task<GetImageModerationResultResponse> GetImageModerationResultAsync(GetImageModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageModerationResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取绑定的ossbucket
         *
         * @param request GetOSSBucketAttachmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOSSBucketAttachmentResponse
         */
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

        /**
         * @summary 获取绑定的ossbucket
         *
         * @param request GetOSSBucketAttachmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOSSBucketAttachmentResponse
         */
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

        /**
         * @summary 获取绑定的ossbucket
         *
         * @param request GetOSSBucketAttachmentRequest
         * @return GetOSSBucketAttachmentResponse
         */
        public GetOSSBucketAttachmentResponse GetOSSBucketAttachment(GetOSSBucketAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOSSBucketAttachmentWithOptions(request, runtime);
        }

        /**
         * @summary 获取绑定的ossbucket
         *
         * @param request GetOSSBucketAttachmentRequest
         * @return GetOSSBucketAttachmentResponse
         */
        public async Task<GetOSSBucketAttachmentResponse> GetOSSBucketAttachmentAsync(GetOSSBucketAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOSSBucketAttachmentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取项目信息
         *
         * @param request GetProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectResponse
         */
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

        /**
         * @summary 获取项目信息
         *
         * @param request GetProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetProjectResponse
         */
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

        /**
         * @summary 获取项目信息
         *
         * @param request GetProjectRequest
         * @return GetProjectResponse
         */
        public GetProjectResponse GetProject(GetProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProjectWithOptions(request, runtime);
        }

        /**
         * @summary 获取项目信息
         *
         * @param request GetProjectRequest
         * @return GetProjectResponse
         */
        public async Task<GetProjectResponse> GetProjectAsync(GetProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 返回一个 Story 的详细信息
         *
         * @param request GetStoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetStoryResponse
         */
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

        /**
         * @summary 返回一个 Story 的详细信息
         *
         * @param request GetStoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetStoryResponse
         */
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

        /**
         * @summary 返回一个 Story 的详细信息
         *
         * @param request GetStoryRequest
         * @return GetStoryResponse
         */
        public GetStoryResponse GetStory(GetStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStoryWithOptions(request, runtime);
        }

        /**
         * @summary 返回一个 Story 的详细信息
         *
         * @param request GetStoryRequest
         * @return GetStoryResponse
         */
        public async Task<GetStoryResponse> GetStoryAsync(GetStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStoryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取任务信息
         *
         * @param request GetTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskResponse
         */
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

        /**
         * @summary 获取任务信息
         *
         * @param request GetTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTaskResponse
         */
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

        /**
         * @summary 获取任务信息
         *
         * @param request GetTaskRequest
         * @return GetTaskResponse
         */
        public GetTaskResponse GetTask(GetTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTaskWithOptions(request, runtime);
        }

        /**
         * @summary 获取任务信息
         *
         * @param request GetTaskRequest
         * @return GetTaskResponse
         */
        public async Task<GetTaskResponse> GetTaskAsync(GetTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取数据接入实例
         *
         * @param request GetTriggerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTriggerResponse
         */
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

        /**
         * @summary 获取数据接入实例
         *
         * @param request GetTriggerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTriggerResponse
         */
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

        /**
         * @summary 获取数据接入实例
         *
         * @param request GetTriggerRequest
         * @return GetTriggerResponse
         */
        public GetTriggerResponse GetTrigger(GetTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTriggerWithOptions(request, runtime);
        }

        /**
         * @summary 获取数据接入实例
         *
         * @param request GetTriggerRequest
         * @return GetTriggerResponse
         */
        public async Task<GetTriggerResponse> GetTriggerAsync(GetTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTriggerWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取视频标签检测任务结果
         *
         * @param request GetVideoLabelClassificationResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetVideoLabelClassificationResultResponse
         */
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

        /**
         * @summary 获取视频标签检测任务结果
         *
         * @param request GetVideoLabelClassificationResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetVideoLabelClassificationResultResponse
         */
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

        /**
         * @summary 获取视频标签检测任务结果
         *
         * @param request GetVideoLabelClassificationResultRequest
         * @return GetVideoLabelClassificationResultResponse
         */
        public GetVideoLabelClassificationResultResponse GetVideoLabelClassificationResult(GetVideoLabelClassificationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoLabelClassificationResultWithOptions(request, runtime);
        }

        /**
         * @summary 获取视频标签检测任务结果
         *
         * @param request GetVideoLabelClassificationResultRequest
         * @return GetVideoLabelClassificationResultResponse
         */
        public async Task<GetVideoLabelClassificationResultResponse> GetVideoLabelClassificationResultAsync(GetVideoLabelClassificationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoLabelClassificationResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取视频审核任务结果
         *
         * @param request GetVideoModerationResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetVideoModerationResultResponse
         */
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

        /**
         * @summary 获取视频审核任务结果
         *
         * @param request GetVideoModerationResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetVideoModerationResultResponse
         */
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

        /**
         * @summary 获取视频审核任务结果
         *
         * @param request GetVideoModerationResultRequest
         * @return GetVideoModerationResultResponse
         */
        public GetVideoModerationResultResponse GetVideoModerationResult(GetVideoModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoModerationResultWithOptions(request, runtime);
        }

        /**
         * @summary 获取视频审核任务结果
         *
         * @param request GetVideoModerationResultRequest
         * @return GetVideoModerationResultResponse
         */
        public async Task<GetVideoModerationResultResponse> GetVideoModerationResultAsync(GetVideoModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoModerationResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 添加文件元信息
         *
         * @param tmpReq IndexFileMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndexFileMetaResponse
         */
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

        /**
         * @summary 添加文件元信息
         *
         * @param tmpReq IndexFileMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return IndexFileMetaResponse
         */
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

        /**
         * @summary 添加文件元信息
         *
         * @param request IndexFileMetaRequest
         * @return IndexFileMetaResponse
         */
        public IndexFileMetaResponse IndexFileMeta(IndexFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IndexFileMetaWithOptions(request, runtime);
        }

        /**
         * @summary 添加文件元信息
         *
         * @param request IndexFileMetaRequest
         * @return IndexFileMetaResponse
         */
        public async Task<IndexFileMetaResponse> IndexFileMetaAsync(IndexFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IndexFileMetaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出数据接入实例
         *
         * @param request ListBatchesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListBatchesResponse
         */
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

        /**
         * @summary 列出数据接入实例
         *
         * @param request ListBatchesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListBatchesResponse
         */
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

        /**
         * @summary 列出数据接入实例
         *
         * @param request ListBatchesRequest
         * @return ListBatchesResponse
         */
        public ListBatchesResponse ListBatches(ListBatchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBatchesWithOptions(request, runtime);
        }

        /**
         * @summary 列出数据接入实例
         *
         * @param request ListBatchesRequest
         * @return ListBatchesResponse
         */
        public async Task<ListBatchesResponse> ListBatchesAsync(ListBatchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBatchesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出绑定
         *
         * @param request ListBindingsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListBindingsResponse
         */
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

        /**
         * @summary 列出绑定
         *
         * @param request ListBindingsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListBindingsResponse
         */
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

        /**
         * @summary 列出绑定
         *
         * @param request ListBindingsRequest
         * @return ListBindingsResponse
         */
        public ListBindingsResponse ListBindings(ListBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBindingsWithOptions(request, runtime);
        }

        /**
         * @summary 列出绑定
         *
         * @param request ListBindingsRequest
         * @return ListBindingsResponse
         */
        public async Task<ListBindingsResponse> ListBindingsAsync(ListBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBindingsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出媒体集列表
         *
         * @param request ListDatasetsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDatasetsResponse
         */
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

        /**
         * @summary 列出媒体集列表
         *
         * @param request ListDatasetsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDatasetsResponse
         */
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

        /**
         * @summary 列出媒体集列表
         *
         * @param request ListDatasetsRequest
         * @return ListDatasetsResponse
         */
        public ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDatasetsWithOptions(request, runtime);
        }

        /**
         * @summary 列出媒体集列表
         *
         * @param request ListDatasetsRequest
         * @return ListDatasetsResponse
         */
        public async Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDatasetsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取项目列表
         *
         * @param tmpReq ListProjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProjectsResponse
         */
        public ListProjectsResponse ListProjectsWithOptions(ListProjectsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProjectsShrinkRequest request = new ListProjectsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
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

        /**
         * @summary 获取项目列表
         *
         * @param tmpReq ListProjectsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListProjectsResponse
         */
        public async Task<ListProjectsResponse> ListProjectsWithOptionsAsync(ListProjectsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProjectsShrinkRequest request = new ListProjectsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
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

        /**
         * @summary 获取项目列表
         *
         * @param request ListProjectsRequest
         * @return ListProjectsResponse
         */
        public ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectsWithOptions(request, runtime);
        }

        /**
         * @summary 获取项目列表
         *
         * @param request ListProjectsRequest
         * @return ListProjectsResponse
         */
        public async Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取地区列表
         *
         * @param request ListRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRegionsResponse
         */
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

        /**
         * @summary 获取地区列表
         *
         * @param request ListRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRegionsResponse
         */
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

        /**
         * @summary 获取地区列表
         *
         * @param request ListRegionsRequest
         * @return ListRegionsResponse
         */
        public ListRegionsResponse ListRegions(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegionsWithOptions(request, runtime);
        }

        /**
         * @summary 获取地区列表
         *
         * @param request ListRegionsRequest
         * @return ListRegionsResponse
         */
        public async Task<ListRegionsResponse> ListRegionsAsync(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取任务信息列表
         *
         * @param tmpReq ListTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTasksResponse
         */
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

        /**
         * @summary 获取任务信息列表
         *
         * @param tmpReq ListTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTasksResponse
         */
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

        /**
         * @summary 获取任务信息列表
         *
         * @param request ListTasksRequest
         * @return ListTasksResponse
         */
        public ListTasksResponse ListTasks(ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTasksWithOptions(request, runtime);
        }

        /**
         * @summary 获取任务信息列表
         *
         * @param request ListTasksRequest
         * @return ListTasksResponse
         */
        public async Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列出数据接入实例
         *
         * @param request ListTriggersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTriggersResponse
         */
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

        /**
         * @summary 列出数据接入实例
         *
         * @param request ListTriggersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTriggersResponse
         */
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

        /**
         * @summary 列出数据接入实例
         *
         * @param request ListTriggersRequest
         * @return ListTriggersResponse
         */
        public ListTriggersResponse ListTriggers(ListTriggersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTriggersWithOptions(request, runtime);
        }

        /**
         * @summary 列出数据接入实例
         *
         * @param request ListTriggersRequest
         * @return ListTriggersResponse
         */
        public async Task<ListTriggersResponse> ListTriggersAsync(ListTriggersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTriggersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询聚类分组
         *
         * @param tmpReq QueryFigureClustersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryFigureClustersResponse
         */
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

        /**
         * @summary 查询聚类分组
         *
         * @param tmpReq QueryFigureClustersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryFigureClustersResponse
         */
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

        /**
         * @summary 查询聚类分组
         *
         * @param request QueryFigureClustersRequest
         * @return QueryFigureClustersResponse
         */
        public QueryFigureClustersResponse QueryFigureClusters(QueryFigureClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFigureClustersWithOptions(request, runtime);
        }

        /**
         * @summary 查询聚类分组
         *
         * @param request QueryFigureClustersRequest
         * @return QueryFigureClustersResponse
         */
        public async Task<QueryFigureClustersResponse> QueryFigureClustersAsync(QueryFigureClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFigureClustersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查找时空分组
         *
         * @param tmpReq QueryLocationDateClustersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryLocationDateClustersResponse
         */
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

        /**
         * @summary 查找时空分组
         *
         * @param tmpReq QueryLocationDateClustersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryLocationDateClustersResponse
         */
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

        /**
         * @summary 查找时空分组
         *
         * @param request QueryLocationDateClustersRequest
         * @return QueryLocationDateClustersResponse
         */
        public QueryLocationDateClustersResponse QueryLocationDateClusters(QueryLocationDateClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryLocationDateClustersWithOptions(request, runtime);
        }

        /**
         * @summary 查找时空分组
         *
         * @param request QueryLocationDateClustersRequest
         * @return QueryLocationDateClustersResponse
         */
        public async Task<QueryLocationDateClustersResponse> QueryLocationDateClustersAsync(QueryLocationDateClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryLocationDateClustersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查找相似图片分组
         *
         * @param request QuerySimilarImageClustersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySimilarImageClustersResponse
         */
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

        /**
         * @summary 查找相似图片分组
         *
         * @param request QuerySimilarImageClustersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QuerySimilarImageClustersResponse
         */
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

        /**
         * @summary 查找相似图片分组
         *
         * @param request QuerySimilarImageClustersRequest
         * @return QuerySimilarImageClustersResponse
         */
        public QuerySimilarImageClustersResponse QuerySimilarImageClusters(QuerySimilarImageClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySimilarImageClustersWithOptions(request, runtime);
        }

        /**
         * @summary 查找相似图片分组
         *
         * @param request QuerySimilarImageClustersRequest
         * @return QuerySimilarImageClustersResponse
         */
        public async Task<QuerySimilarImageClustersResponse> QuerySimilarImageClustersAsync(QuerySimilarImageClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySimilarImageClustersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查找 Story
         *
         * @param tmpReq QueryStoriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryStoriesResponse
         */
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

        /**
         * @summary 查找 Story
         *
         * @param tmpReq QueryStoriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryStoriesResponse
         */
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

        /**
         * @summary 查找 Story
         *
         * @param request QueryStoriesRequest
         * @return QueryStoriesResponse
         */
        public QueryStoriesResponse QueryStories(QueryStoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryStoriesWithOptions(request, runtime);
        }

        /**
         * @summary 查找 Story
         *
         * @param request QueryStoriesRequest
         * @return QueryStoriesResponse
         */
        public async Task<QueryStoriesResponse> QueryStoriesAsync(QueryStoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryStoriesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 刷新文档预览编辑凭证
         *
         * @param tmpReq RefreshWebofficeTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefreshWebofficeTokenResponse
         */
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

        /**
         * @summary 刷新文档预览编辑凭证
         *
         * @param tmpReq RefreshWebofficeTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefreshWebofficeTokenResponse
         */
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

        /**
         * @summary 刷新文档预览编辑凭证
         *
         * @param request RefreshWebofficeTokenRequest
         * @return RefreshWebofficeTokenResponse
         */
        public RefreshWebofficeTokenResponse RefreshWebofficeToken(RefreshWebofficeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshWebofficeTokenWithOptions(request, runtime);
        }

        /**
         * @summary 刷新文档预览编辑凭证
         *
         * @param request RefreshWebofficeTokenRequest
         * @return RefreshWebofficeTokenResponse
         */
        public async Task<RefreshWebofficeTokenResponse> RefreshWebofficeTokenAsync(RefreshWebofficeTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshWebofficeTokenWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 为故事移除文件
         *
         * @param tmpReq RemoveStoryFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveStoryFilesResponse
         */
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

        /**
         * @summary 为故事移除文件
         *
         * @param tmpReq RemoveStoryFilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveStoryFilesResponse
         */
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

        /**
         * @summary 为故事移除文件
         *
         * @param request RemoveStoryFilesRequest
         * @return RemoveStoryFilesResponse
         */
        public RemoveStoryFilesResponse RemoveStoryFiles(RemoveStoryFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveStoryFilesWithOptions(request, runtime);
        }

        /**
         * @summary 为故事移除文件
         *
         * @param request RemoveStoryFilesRequest
         * @return RemoveStoryFilesResponse
         */
        public async Task<RemoveStoryFilesResponse> RemoveStoryFilesAsync(RemoveStoryFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveStoryFilesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 恢复一个挂起的数据接入任务
         *
         * @param request ResumeBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeBatchResponse
         */
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

        /**
         * @summary 恢复一个挂起的数据接入任务
         *
         * @param request ResumeBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeBatchResponse
         */
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

        /**
         * @summary 恢复一个挂起的数据接入任务
         *
         * @param request ResumeBatchRequest
         * @return ResumeBatchResponse
         */
        public ResumeBatchResponse ResumeBatch(ResumeBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeBatchWithOptions(request, runtime);
        }

        /**
         * @summary 恢复一个挂起的数据接入任务
         *
         * @param request ResumeBatchRequest
         * @return ResumeBatchResponse
         */
        public async Task<ResumeBatchResponse> ResumeBatchAsync(ResumeBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeBatchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 恢复一个挂起的数据接入任务
         *
         * @param request ResumeTriggerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeTriggerResponse
         */
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

        /**
         * @summary 恢复一个挂起的数据接入任务
         *
         * @param request ResumeTriggerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeTriggerResponse
         */
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

        /**
         * @summary 恢复一个挂起的数据接入任务
         *
         * @param request ResumeTriggerRequest
         * @return ResumeTriggerResponse
         */
        public ResumeTriggerResponse ResumeTrigger(ResumeTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeTriggerWithOptions(request, runtime);
        }

        /**
         * @summary 恢复一个挂起的数据接入任务
         *
         * @param request ResumeTriggerRequest
         * @return ResumeTriggerResponse
         */
        public async Task<ResumeTriggerResponse> ResumeTriggerAsync(ResumeTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeTriggerWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 以脸搜分组
         *
         * @param tmpReq SearchImageFigureClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchImageFigureClusterResponse
         */
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

        /**
         * @summary 以脸搜分组
         *
         * @param tmpReq SearchImageFigureClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchImageFigureClusterResponse
         */
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

        /**
         * @summary 以脸搜分组
         *
         * @param request SearchImageFigureClusterRequest
         * @return SearchImageFigureClusterResponse
         */
        public SearchImageFigureClusterResponse SearchImageFigureCluster(SearchImageFigureClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchImageFigureClusterWithOptions(request, runtime);
        }

        /**
         * @summary 以脸搜分组
         *
         * @param request SearchImageFigureClusterRequest
         * @return SearchImageFigureClusterResponse
         */
        public async Task<SearchImageFigureClusterResponse> SearchImageFigureClusterAsync(SearchImageFigureClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchImageFigureClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 通过输入自然语言文字，对 Dataset 内的元数据进行查询与统计分析
         *
         * @param tmpReq SemanticQueryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SemanticQueryResponse
         */
        public SemanticQueryResponse SemanticQueryWithOptions(SemanticQueryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SemanticQueryShrinkRequest request = new SemanticQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MediaTypes))
            {
                request.MediaTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MediaTypes, "MediaTypes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SmartClusterIds))
            {
                request.SmartClusterIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SmartClusterIds, "SmartClusterIds", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmartClusterIdsShrink))
            {
                query["SmartClusterIds"] = request.SmartClusterIdsShrink;
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

        /**
         * @summary 通过输入自然语言文字，对 Dataset 内的元数据进行查询与统计分析
         *
         * @param tmpReq SemanticQueryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SemanticQueryResponse
         */
        public async Task<SemanticQueryResponse> SemanticQueryWithOptionsAsync(SemanticQueryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SemanticQueryShrinkRequest request = new SemanticQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MediaTypes))
            {
                request.MediaTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MediaTypes, "MediaTypes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SmartClusterIds))
            {
                request.SmartClusterIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SmartClusterIds, "SmartClusterIds", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmartClusterIdsShrink))
            {
                query["SmartClusterIds"] = request.SmartClusterIdsShrink;
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

        /**
         * @summary 通过输入自然语言文字，对 Dataset 内的元数据进行查询与统计分析
         *
         * @param request SemanticQueryRequest
         * @return SemanticQueryResponse
         */
        public SemanticQueryResponse SemanticQuery(SemanticQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SemanticQueryWithOptions(request, runtime);
        }

        /**
         * @summary 通过输入自然语言文字，对 Dataset 内的元数据进行查询与统计分析
         *
         * @param request SemanticQueryRequest
         * @return SemanticQueryResponse
         */
        public async Task<SemanticQueryResponse> SemanticQueryAsync(SemanticQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SemanticQueryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 通过 JSON 结构的查询语言，对 Dataset 内的元数据进行查询与统计分析。
         *
         * @param tmpReq SimpleQueryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SimpleQueryResponse
         */
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

        /**
         * @summary 通过 JSON 结构的查询语言，对 Dataset 内的元数据进行查询与统计分析。
         *
         * @param tmpReq SimpleQueryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SimpleQueryResponse
         */
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

        /**
         * @summary 通过 JSON 结构的查询语言，对 Dataset 内的元数据进行查询与统计分析。
         *
         * @param request SimpleQueryRequest
         * @return SimpleQueryResponse
         */
        public SimpleQueryResponse SimpleQuery(SimpleQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SimpleQueryWithOptions(request, runtime);
        }

        /**
         * @summary 通过 JSON 结构的查询语言，对 Dataset 内的元数据进行查询与统计分析。
         *
         * @param request SimpleQueryRequest
         * @return SimpleQueryResponse
         */
        public async Task<SimpleQueryResponse> SimpleQueryAsync(SimpleQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SimpleQueryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 挂起一个数据接入任务
         *
         * @param request SuspendBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SuspendBatchResponse
         */
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

        /**
         * @summary 挂起一个数据接入任务
         *
         * @param request SuspendBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SuspendBatchResponse
         */
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

        /**
         * @summary 挂起一个数据接入任务
         *
         * @param request SuspendBatchRequest
         * @return SuspendBatchResponse
         */
        public SuspendBatchResponse SuspendBatch(SuspendBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendBatchWithOptions(request, runtime);
        }

        /**
         * @summary 挂起一个数据接入任务
         *
         * @param request SuspendBatchRequest
         * @return SuspendBatchResponse
         */
        public async Task<SuspendBatchResponse> SuspendBatchAsync(SuspendBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendBatchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 挂起一个数据接入任务
         *
         * @param request SuspendTriggerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SuspendTriggerResponse
         */
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

        /**
         * @summary 挂起一个数据接入任务
         *
         * @param request SuspendTriggerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SuspendTriggerResponse
         */
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

        /**
         * @summary 挂起一个数据接入任务
         *
         * @param request SuspendTriggerRequest
         * @return SuspendTriggerResponse
         */
        public SuspendTriggerResponse SuspendTrigger(SuspendTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendTriggerWithOptions(request, runtime);
        }

        /**
         * @summary 挂起一个数据接入任务
         *
         * @param request SuspendTriggerRequest
         * @return SuspendTriggerResponse
         */
        public async Task<SuspendTriggerResponse> SuspendTriggerAsync(SuspendTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendTriggerWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新数据接入实例
         *
         * @param tmpReq UpdateBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateBatchResponse
         */
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

        /**
         * @summary 更新数据接入实例
         *
         * @param tmpReq UpdateBatchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateBatchResponse
         */
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

        /**
         * @summary 更新数据接入实例
         *
         * @param request UpdateBatchRequest
         * @return UpdateBatchResponse
         */
        public UpdateBatchResponse UpdateBatch(UpdateBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBatchWithOptions(request, runtime);
        }

        /**
         * @summary 更新数据接入实例
         *
         * @param request UpdateBatchRequest
         * @return UpdateBatchResponse
         */
        public async Task<UpdateBatchResponse> UpdateBatchAsync(UpdateBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBatchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新媒体集
         *
         * @param request UpdateDatasetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDatasetResponse
         */
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

        /**
         * @summary 更新媒体集
         *
         * @param request UpdateDatasetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDatasetResponse
         */
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

        /**
         * @summary 更新媒体集
         *
         * @param request UpdateDatasetRequest
         * @return UpdateDatasetResponse
         */
        public UpdateDatasetResponse UpdateDataset(UpdateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDatasetWithOptions(request, runtime);
        }

        /**
         * @summary 更新媒体集
         *
         * @param request UpdateDatasetRequest
         * @return UpdateDatasetResponse
         */
        public async Task<UpdateDatasetResponse> UpdateDatasetAsync(UpdateDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDatasetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新聚类
         *
         * @param tmpReq UpdateFigureClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFigureClusterResponse
         */
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

        /**
         * @summary 更新聚类
         *
         * @param tmpReq UpdateFigureClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFigureClusterResponse
         */
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

        /**
         * @summary 更新聚类
         *
         * @param request UpdateFigureClusterRequest
         * @return UpdateFigureClusterResponse
         */
        public UpdateFigureClusterResponse UpdateFigureCluster(UpdateFigureClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFigureClusterWithOptions(request, runtime);
        }

        /**
         * @summary 更新聚类
         *
         * @param request UpdateFigureClusterRequest
         * @return UpdateFigureClusterResponse
         */
        public async Task<UpdateFigureClusterResponse> UpdateFigureClusterAsync(UpdateFigureClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFigureClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新文件元信息
         *
         * @param tmpReq UpdateFileMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFileMetaResponse
         */
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

        /**
         * @summary 更新文件元信息
         *
         * @param tmpReq UpdateFileMetaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateFileMetaResponse
         */
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

        /**
         * @summary 更新文件元信息
         *
         * @param request UpdateFileMetaRequest
         * @return UpdateFileMetaResponse
         */
        public UpdateFileMetaResponse UpdateFileMeta(UpdateFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFileMetaWithOptions(request, runtime);
        }

        /**
         * @summary 更新文件元信息
         *
         * @param request UpdateFileMetaRequest
         * @return UpdateFileMetaResponse
         */
        public async Task<UpdateFileMetaResponse> UpdateFileMetaAsync(UpdateFileMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFileMetaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新时空聚类
         *
         * @param tmpReq UpdateLocationDateClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLocationDateClusterResponse
         */
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

        /**
         * @summary 更新时空聚类
         *
         * @param tmpReq UpdateLocationDateClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLocationDateClusterResponse
         */
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

        /**
         * @summary 更新时空聚类
         *
         * @param request UpdateLocationDateClusterRequest
         * @return UpdateLocationDateClusterResponse
         */
        public UpdateLocationDateClusterResponse UpdateLocationDateCluster(UpdateLocationDateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLocationDateClusterWithOptions(request, runtime);
        }

        /**
         * @summary 更新时空聚类
         *
         * @param request UpdateLocationDateClusterRequest
         * @return UpdateLocationDateClusterResponse
         */
        public async Task<UpdateLocationDateClusterResponse> UpdateLocationDateClusterAsync(UpdateLocationDateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLocationDateClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新项目
         *
         * @param tmpReq UpdateProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProjectResponse
         */
        public UpdateProjectResponse UpdateProjectWithOptions(UpdateProjectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateProjectShrinkRequest request = new UpdateProjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
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

        /**
         * @summary 更新项目
         *
         * @param tmpReq UpdateProjectRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateProjectResponse
         */
        public async Task<UpdateProjectResponse> UpdateProjectWithOptionsAsync(UpdateProjectRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateProjectShrinkRequest request = new UpdateProjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
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

        /**
         * @summary 更新项目
         *
         * @param request UpdateProjectRequest
         * @return UpdateProjectResponse
         */
        public UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProjectWithOptions(request, runtime);
        }

        /**
         * @summary 更新项目
         *
         * @param request UpdateProjectRequest
         * @return UpdateProjectResponse
         */
        public async Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProjectWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新故事
         *
         * @param tmpReq UpdateStoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateStoryResponse
         */
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

        /**
         * @summary 更新故事
         *
         * @param tmpReq UpdateStoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateStoryResponse
         */
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

        /**
         * @summary 更新故事
         *
         * @param request UpdateStoryRequest
         * @return UpdateStoryResponse
         */
        public UpdateStoryResponse UpdateStory(UpdateStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateStoryWithOptions(request, runtime);
        }

        /**
         * @summary 更新故事
         *
         * @param request UpdateStoryRequest
         * @return UpdateStoryResponse
         */
        public async Task<UpdateStoryResponse> UpdateStoryAsync(UpdateStoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateStoryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新数据接入实例
         *
         * @param tmpReq UpdateTriggerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTriggerResponse
         */
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

        /**
         * @summary 更新数据接入实例
         *
         * @param tmpReq UpdateTriggerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTriggerResponse
         */
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

        /**
         * @summary 更新数据接入实例
         *
         * @param request UpdateTriggerRequest
         * @return UpdateTriggerResponse
         */
        public UpdateTriggerResponse UpdateTrigger(UpdateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTriggerWithOptions(request, runtime);
        }

        /**
         * @summary 更新数据接入实例
         *
         * @param request UpdateTriggerRequest
         * @return UpdateTriggerResponse
         */
        public async Task<UpdateTriggerResponse> UpdateTriggerAsync(UpdateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTriggerWithOptionsAsync(request, runtime);
        }

    }
}
