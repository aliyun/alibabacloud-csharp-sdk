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
            query["DatasetName"] = request.DatasetName;
            query["NotifyEndpoint"] = request.NotifyEndpoint;
            query["NotifyTopicName"] = request.NotifyTopicName;
            query["ProjectName"] = request.ProjectName;
            query["URIs"] = request.URIsShrink;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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
            query["DatasetName"] = request.DatasetName;
            query["NotifyEndpoint"] = request.NotifyEndpoint;
            query["NotifyTopicName"] = request.NotifyTopicName;
            query["ProjectName"] = request.ProjectName;
            query["URIs"] = request.URIsShrink;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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
            query["DatasetName"] = request.DatasetName;
            query["ProjectName"] = request.ProjectName;
            query["URIs"] = request.URIsShrink;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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
            query["DatasetName"] = request.DatasetName;
            query["ProjectName"] = request.ProjectName;
            query["URIs"] = request.URIsShrink;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["Files"] = request.FilesShrink;
            query["NotifyEndpoint"] = request.NotifyEndpoint;
            query["NotifyTopicName"] = request.NotifyTopicName;
            query["ProjectName"] = request.ProjectName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["Files"] = request.FilesShrink;
            query["NotifyEndpoint"] = request.NotifyEndpoint;
            query["NotifyTopicName"] = request.NotifyTopicName;
            query["ProjectName"] = request.ProjectName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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
            query["DatasetName"] = request.DatasetName;
            query["Files"] = request.FilesShrink;
            query["NotifyEndpoint"] = request.NotifyEndpoint;
            query["NotifyTopicName"] = request.NotifyTopicName;
            query["ProjectName"] = request.ProjectName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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
            query["DatasetName"] = request.DatasetName;
            query["Files"] = request.FilesShrink;
            query["NotifyEndpoint"] = request.NotifyEndpoint;
            query["NotifyTopicName"] = request.NotifyTopicName;
            query["ProjectName"] = request.ProjectName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

        public CreateBindingResponse CreateBindingWithOptions(CreateBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["ProjectName"] = request.ProjectName;
            query["URI"] = request.URI;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBindingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateBindingResponse> CreateBindingWithOptionsAsync(CreateBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["ProjectName"] = request.ProjectName;
            query["URI"] = request.URI;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

        public CreateDatasetResponse CreateDatasetWithOptions(CreateDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetMaxBindCount"] = request.DatasetMaxBindCount;
            query["DatasetMaxEntityCount"] = request.DatasetMaxEntityCount;
            query["DatasetMaxFileCount"] = request.DatasetMaxFileCount;
            query["DatasetMaxRelationCount"] = request.DatasetMaxRelationCount;
            query["DatasetMaxTotalFileSize"] = request.DatasetMaxTotalFileSize;
            query["DatasetName"] = request.DatasetName;
            query["Description"] = request.Description;
            query["ProjectName"] = request.ProjectName;
            query["TemplateId"] = request.TemplateId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDatasetResponse> CreateDatasetWithOptionsAsync(CreateDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetMaxBindCount"] = request.DatasetMaxBindCount;
            query["DatasetMaxEntityCount"] = request.DatasetMaxEntityCount;
            query["DatasetMaxFileCount"] = request.DatasetMaxFileCount;
            query["DatasetMaxRelationCount"] = request.DatasetMaxRelationCount;
            query["DatasetMaxTotalFileSize"] = request.DatasetMaxTotalFileSize;
            query["DatasetName"] = request.DatasetName;
            query["Description"] = request.Description;
            query["ProjectName"] = request.ProjectName;
            query["TemplateId"] = request.TemplateId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

        public CreateOfficeConversionTaskResponse CreateOfficeConversionTaskWithOptions(CreateOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndPage"] = request.EndPage;
            query["FirstPage"] = request.FirstPage;
            query["FitToHeight"] = request.FitToHeight;
            query["FitToWidth"] = request.FitToWidth;
            query["IsHorizontal"] = request.IsHorizontal;
            query["LongPic"] = request.LongPic;
            query["NotifyEndpoint"] = request.NotifyEndpoint;
            query["NotifyTopicName"] = request.NotifyTopicName;
            query["PaperSize"] = request.PaperSize;
            query["Password"] = request.Password;
            query["ProjectName"] = request.ProjectName;
            query["Quality"] = request.Quality;
            query["Scale"] = request.Scale;
            query["SheetCount"] = request.SheetCount;
            query["SheetIndex"] = request.SheetIndex;
            query["ShowComments"] = request.ShowComments;
            query["SourceType"] = request.SourceType;
            query["SourceUri"] = request.SourceUri;
            query["StartPage"] = request.StartPage;
            query["TargetType"] = request.TargetType;
            query["TargetUri"] = request.TargetUri;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOfficeConversionTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateOfficeConversionTaskResponse> CreateOfficeConversionTaskWithOptionsAsync(CreateOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndPage"] = request.EndPage;
            query["FirstPage"] = request.FirstPage;
            query["FitToHeight"] = request.FitToHeight;
            query["FitToWidth"] = request.FitToWidth;
            query["IsHorizontal"] = request.IsHorizontal;
            query["LongPic"] = request.LongPic;
            query["NotifyEndpoint"] = request.NotifyEndpoint;
            query["NotifyTopicName"] = request.NotifyTopicName;
            query["PaperSize"] = request.PaperSize;
            query["Password"] = request.Password;
            query["ProjectName"] = request.ProjectName;
            query["Quality"] = request.Quality;
            query["Scale"] = request.Scale;
            query["SheetCount"] = request.SheetCount;
            query["SheetIndex"] = request.SheetIndex;
            query["ShowComments"] = request.ShowComments;
            query["SourceType"] = request.SourceType;
            query["SourceUri"] = request.SourceUri;
            query["StartPage"] = request.StartPage;
            query["TargetType"] = request.TargetType;
            query["TargetUri"] = request.TargetUri;
            query["UserData"] = request.UserData;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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
            query["DatasetMaxBindCount"] = request.DatasetMaxBindCount;
            query["DatasetMaxEntityCount"] = request.DatasetMaxEntityCount;
            query["DatasetMaxFileCount"] = request.DatasetMaxFileCount;
            query["DatasetMaxRelationCount"] = request.DatasetMaxRelationCount;
            query["DatasetMaxTotalFileSize"] = request.DatasetMaxTotalFileSize;
            query["Description"] = request.Description;
            query["EngineConcurrency"] = request.EngineConcurrency;
            query["ProjectMaxDatasetCount"] = request.ProjectMaxDatasetCount;
            query["ProjectName"] = request.ProjectName;
            query["ProjectQueriesPerSecond"] = request.ProjectQueriesPerSecond;
            query["ServiceRole"] = request.ServiceRole;
            query["TemplateId"] = request.TemplateId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetMaxBindCount"] = request.DatasetMaxBindCount;
            query["DatasetMaxEntityCount"] = request.DatasetMaxEntityCount;
            query["DatasetMaxFileCount"] = request.DatasetMaxFileCount;
            query["DatasetMaxRelationCount"] = request.DatasetMaxRelationCount;
            query["DatasetMaxTotalFileSize"] = request.DatasetMaxTotalFileSize;
            query["Description"] = request.Description;
            query["EngineConcurrency"] = request.EngineConcurrency;
            query["ProjectMaxDatasetCount"] = request.ProjectMaxDatasetCount;
            query["ProjectName"] = request.ProjectName;
            query["ProjectQueriesPerSecond"] = request.ProjectQueriesPerSecond;
            query["ServiceRole"] = request.ServiceRole;
            query["TemplateId"] = request.TemplateId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

        public DeleteBindingResponse DeleteBindingWithOptions(DeleteBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["ProjectName"] = request.ProjectName;
            query["URI"] = request.URI;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBindingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteBindingResponse> DeleteBindingWithOptionsAsync(DeleteBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["ProjectName"] = request.ProjectName;
            query["URI"] = request.URI;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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
            query["DatasetName"] = request.DatasetName;
            query["ProjectName"] = request.ProjectName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDatasetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDatasetResponse> DeleteDatasetWithOptionsAsync(DeleteDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["ProjectName"] = request.ProjectName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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
            query["DatasetName"] = request.DatasetName;
            query["NotifyEndpoint"] = request.NotifyEndpoint;
            query["NotifyTopicName"] = request.NotifyTopicName;
            query["ProjectName"] = request.ProjectName;
            query["URI"] = request.URI;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileMetaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFileMetaResponse> DeleteFileMetaWithOptionsAsync(DeleteFileMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["NotifyEndpoint"] = request.NotifyEndpoint;
            query["NotifyTopicName"] = request.NotifyTopicName;
            query["ProjectName"] = request.ProjectName;
            query["URI"] = request.URI;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

        public DeleteProjectResponse DeleteProjectWithOptions(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectName"] = request.ProjectName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteProjectResponse> DeleteProjectWithOptionsAsync(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectName"] = request.ProjectName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

        public DetectImageLabelsResponse DetectImageLabelsWithOptions(DetectImageLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectName"] = request.ProjectName;
            query["SourceURI"] = request.SourceURI;
            query["Threshold"] = request.Threshold;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageLabelsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetectImageLabelsResponse> DetectImageLabelsWithOptionsAsync(DetectImageLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectName"] = request.ProjectName;
            query["SourceURI"] = request.SourceURI;
            query["Threshold"] = request.Threshold;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

        public FuzzyQueryResponse FuzzyQueryWithOptions(FuzzyQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["ProjectName"] = request.ProjectName;
            query["Query"] = request.Query;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FuzzyQueryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FuzzyQueryResponse> FuzzyQueryWithOptionsAsync(FuzzyQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["ProjectName"] = request.ProjectName;
            query["Query"] = request.Query;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

        public GetBindingResponse GetBindingWithOptions(GetBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["ProjectName"] = request.ProjectName;
            query["URI"] = request.URI;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBindingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetBindingResponse> GetBindingWithOptionsAsync(GetBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["ProjectName"] = request.ProjectName;
            query["URI"] = request.URI;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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
            query["DatasetName"] = request.DatasetName;
            query["ProjectName"] = request.ProjectName;
            query["WithStatistics"] = request.WithStatistics;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatasetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDatasetResponse> GetDatasetWithOptionsAsync(GetDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["ProjectName"] = request.ProjectName;
            query["WithStatistics"] = request.WithStatistics;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

        public GetFileMetaResponse GetFileMetaWithOptions(GetFileMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["ProjectName"] = request.ProjectName;
            query["URI"] = request.URI;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileMetaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFileMetaResponse> GetFileMetaWithOptionsAsync(GetFileMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["ProjectName"] = request.ProjectName;
            query["URI"] = request.URI;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

        public GetFileSignedURIResponse GetFileSignedURIWithOptions(GetFileSignedURIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectName"] = request.ProjectName;
            query["URI"] = request.URI;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileSignedURI",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileSignedURIResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFileSignedURIResponse> GetFileSignedURIWithOptionsAsync(GetFileSignedURIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectName"] = request.ProjectName;
            query["URI"] = request.URI;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFileSignedURI",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileSignedURIResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFileSignedURIResponse GetFileSignedURI(GetFileSignedURIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFileSignedURIWithOptions(request, runtime);
        }

        public async Task<GetFileSignedURIResponse> GetFileSignedURIAsync(GetFileSignedURIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFileSignedURIWithOptionsAsync(request, runtime);
        }

        public GetOfficeConversionTaskResponse GetOfficeConversionTaskWithOptions(GetOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectName"] = request.ProjectName;
            query["TaskId"] = request.TaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOfficeConversionTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOfficeConversionTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetOfficeConversionTaskResponse> GetOfficeConversionTaskWithOptionsAsync(GetOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectName"] = request.ProjectName;
            query["TaskId"] = request.TaskId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOfficeConversionTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOfficeConversionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetOfficeConversionTaskResponse GetOfficeConversionTask(GetOfficeConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOfficeConversionTaskWithOptions(request, runtime);
        }

        public async Task<GetOfficeConversionTaskResponse> GetOfficeConversionTaskAsync(GetOfficeConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOfficeConversionTaskWithOptionsAsync(request, runtime);
        }

        public GetProjectResponse GetProjectWithOptions(GetProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectName"] = request.ProjectName;
            query["WithStatistics"] = request.WithStatistics;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetProjectResponse> GetProjectWithOptionsAsync(GetProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ProjectName"] = request.ProjectName;
            query["WithStatistics"] = request.WithStatistics;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

        public GetWebofficeURLResponse GetWebofficeURLWithOptions(GetWebofficeURLRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetWebofficeURLShrinkRequest request = new GetWebofficeURLShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AssumeRoleChain.ToMap()))
            {
                request.AssumeRoleChainShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AssumeRoleChain.ToMap(), "AssumeRoleChain", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Permission.ToMap()))
            {
                request.PermissionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Permission.ToMap(), "Permission", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.User.ToMap()))
            {
                request.UserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.User.ToMap(), "User", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Watermark.ToMap()))
            {
                request.WatermarkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Watermark.ToMap(), "Watermark", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AssumeRoleChain"] = request.AssumeRoleChainShrink;
            query["ExternalUploaded"] = request.ExternalUploaded;
            query["Filename"] = request.Filename;
            query["Hidecmb"] = request.Hidecmb;
            query["NotifyEndpoint"] = request.NotifyEndpoint;
            query["NotifyTopicName"] = request.NotifyTopicName;
            query["Password"] = request.Password;
            query["Permission"] = request.PermissionShrink;
            query["PreviewPages"] = request.PreviewPages;
            query["ProjectName"] = request.ProjectName;
            query["Referer"] = request.Referer;
            query["SourceURI"] = request.SourceURI;
            query["User"] = request.UserShrink;
            query["UserData"] = request.UserData;
            query["Watermark"] = request.WatermarkShrink;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWebofficeURL",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWebofficeURLResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWebofficeURLResponse> GetWebofficeURLWithOptionsAsync(GetWebofficeURLRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetWebofficeURLShrinkRequest request = new GetWebofficeURLShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AssumeRoleChain.ToMap()))
            {
                request.AssumeRoleChainShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AssumeRoleChain.ToMap(), "AssumeRoleChain", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Permission.ToMap()))
            {
                request.PermissionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Permission.ToMap(), "Permission", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.User.ToMap()))
            {
                request.UserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.User.ToMap(), "User", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Watermark.ToMap()))
            {
                request.WatermarkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Watermark.ToMap(), "Watermark", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AssumeRoleChain"] = request.AssumeRoleChainShrink;
            query["ExternalUploaded"] = request.ExternalUploaded;
            query["Filename"] = request.Filename;
            query["Hidecmb"] = request.Hidecmb;
            query["NotifyEndpoint"] = request.NotifyEndpoint;
            query["NotifyTopicName"] = request.NotifyTopicName;
            query["Password"] = request.Password;
            query["Permission"] = request.PermissionShrink;
            query["PreviewPages"] = request.PreviewPages;
            query["ProjectName"] = request.ProjectName;
            query["Referer"] = request.Referer;
            query["SourceURI"] = request.SourceURI;
            query["User"] = request.UserShrink;
            query["UserData"] = request.UserData;
            query["Watermark"] = request.WatermarkShrink;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWebofficeURL",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWebofficeURLResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetWebofficeURLResponse GetWebofficeURL(GetWebofficeURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWebofficeURLWithOptions(request, runtime);
        }

        public async Task<GetWebofficeURLResponse> GetWebofficeURLAsync(GetWebofficeURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWebofficeURLWithOptionsAsync(request, runtime);
        }

        public IndexFileMetaResponse IndexFileMetaWithOptions(IndexFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            IndexFileMetaShrinkRequest request = new IndexFileMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.File.ToMap()))
            {
                request.FileShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.File.ToMap(), "File", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["File"] = request.FileShrink;
            query["NotifyEndpoint"] = request.NotifyEndpoint;
            query["NotifyTopicName"] = request.NotifyTopicName;
            query["ProjectName"] = request.ProjectName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndexFileMetaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<IndexFileMetaResponse> IndexFileMetaWithOptionsAsync(IndexFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            IndexFileMetaShrinkRequest request = new IndexFileMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.File.ToMap()))
            {
                request.FileShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.File.ToMap(), "File", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["File"] = request.FileShrink;
            query["NotifyEndpoint"] = request.NotifyEndpoint;
            query["NotifyTopicName"] = request.NotifyTopicName;
            query["ProjectName"] = request.ProjectName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

        public ListBindingsResponse ListBindingsWithOptions(ListBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["ProjectName"] = request.ProjectName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindingsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListBindingsResponse> ListBindingsWithOptionsAsync(ListBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["ProjectName"] = request.ProjectName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["Prefix"] = request.Prefix;
            query["ProjectName"] = request.ProjectName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatasetsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDatasetsResponse> ListDatasetsWithOptionsAsync(ListDatasetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["Prefix"] = request.Prefix;
            query["ProjectName"] = request.ProjectName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

        public ListOfficeConversionTaskResponse ListOfficeConversionTaskWithOptions(ListOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["ProjectName"] = request.ProjectName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOfficeConversionTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOfficeConversionTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListOfficeConversionTaskResponse> ListOfficeConversionTaskWithOptionsAsync(ListOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["ProjectName"] = request.ProjectName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOfficeConversionTask",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOfficeConversionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListOfficeConversionTaskResponse ListOfficeConversionTask(ListOfficeConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOfficeConversionTaskWithOptions(request, runtime);
        }

        public async Task<ListOfficeConversionTaskResponse> ListOfficeConversionTaskAsync(ListOfficeConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOfficeConversionTaskWithOptionsAsync(request, runtime);
        }

        public ListProjectsResponse ListProjectsWithOptions(ListProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["Prefix"] = request.Prefix;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProjectsResponse> ListProjectsWithOptionsAsync(ListProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["Prefix"] = request.Prefix;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

        public RefreshWebofficeTokenResponse RefreshWebofficeTokenWithOptions(RefreshWebofficeTokenRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RefreshWebofficeTokenShrinkRequest request = new RefreshWebofficeTokenShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AssumeRoleChain.ToMap()))
            {
                request.AssumeRoleChainShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AssumeRoleChain.ToMap(), "AssumeRoleChain", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccessToken"] = request.AccessToken;
            query["AssumeRoleChain"] = request.AssumeRoleChainShrink;
            query["ProjectName"] = request.ProjectName;
            query["RefreshToken"] = request.RefreshToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshWebofficeTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RefreshWebofficeTokenResponse> RefreshWebofficeTokenWithOptionsAsync(RefreshWebofficeTokenRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RefreshWebofficeTokenShrinkRequest request = new RefreshWebofficeTokenShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AssumeRoleChain.ToMap()))
            {
                request.AssumeRoleChainShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AssumeRoleChain.ToMap(), "AssumeRoleChain", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccessToken"] = request.AccessToken;
            query["AssumeRoleChain"] = request.AssumeRoleChainShrink;
            query["ProjectName"] = request.ProjectName;
            query["RefreshToken"] = request.RefreshToken;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

        public ResumeBindingResponse ResumeBindingWithOptions(ResumeBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["ProjectName"] = request.ProjectName;
            query["URI"] = request.URI;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeBinding",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeBindingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResumeBindingResponse> ResumeBindingWithOptionsAsync(ResumeBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["ProjectName"] = request.ProjectName;
            query["URI"] = request.URI;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeBinding",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeBindingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResumeBindingResponse ResumeBinding(ResumeBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeBindingWithOptions(request, runtime);
        }

        public async Task<ResumeBindingResponse> ResumeBindingAsync(ResumeBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeBindingWithOptionsAsync(request, runtime);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Query.ToMap()))
            {
                request.QueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Query.ToMap(), "Query", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Aggregations"] = request.AggregationsShrink;
            query["DatasetName"] = request.DatasetName;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["Order"] = request.Order;
            query["ProjectName"] = request.ProjectName;
            query["Query"] = request.QueryShrink;
            query["Sort"] = request.Sort;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Query.ToMap()))
            {
                request.QueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Query.ToMap(), "Query", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Aggregations"] = request.AggregationsShrink;
            query["DatasetName"] = request.DatasetName;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["Order"] = request.Order;
            query["ProjectName"] = request.ProjectName;
            query["Query"] = request.QueryShrink;
            query["Sort"] = request.Sort;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

        public StopBindingResponse StopBindingWithOptions(StopBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["ProjectName"] = request.ProjectName;
            query["Reason"] = request.Reason;
            query["URI"] = request.URI;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopBinding",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopBindingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopBindingResponse> StopBindingWithOptionsAsync(StopBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["ProjectName"] = request.ProjectName;
            query["Reason"] = request.Reason;
            query["URI"] = request.URI;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopBinding",
                Version = "2020-09-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopBindingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopBindingResponse StopBinding(StopBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopBindingWithOptions(request, runtime);
        }

        public async Task<StopBindingResponse> StopBindingAsync(StopBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopBindingWithOptionsAsync(request, runtime);
        }

        public UpdateDatasetResponse UpdateDatasetWithOptions(UpdateDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetMaxBindCount"] = request.DatasetMaxBindCount;
            query["DatasetMaxEntityCount"] = request.DatasetMaxEntityCount;
            query["DatasetMaxFileCount"] = request.DatasetMaxFileCount;
            query["DatasetMaxRelationCount"] = request.DatasetMaxRelationCount;
            query["DatasetMaxTotalFileSize"] = request.DatasetMaxTotalFileSize;
            query["DatasetName"] = request.DatasetName;
            query["Description"] = request.Description;
            query["ProjectName"] = request.ProjectName;
            query["TemplateId"] = request.TemplateId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDatasetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateDatasetResponse> UpdateDatasetWithOptionsAsync(UpdateDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetMaxBindCount"] = request.DatasetMaxBindCount;
            query["DatasetMaxEntityCount"] = request.DatasetMaxEntityCount;
            query["DatasetMaxFileCount"] = request.DatasetMaxFileCount;
            query["DatasetMaxRelationCount"] = request.DatasetMaxRelationCount;
            query["DatasetMaxTotalFileSize"] = request.DatasetMaxTotalFileSize;
            query["DatasetName"] = request.DatasetName;
            query["Description"] = request.Description;
            query["ProjectName"] = request.ProjectName;
            query["TemplateId"] = request.TemplateId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

        public UpdateFileMetaResponse UpdateFileMetaWithOptions(UpdateFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateFileMetaShrinkRequest request = new UpdateFileMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.File.ToMap()))
            {
                request.FileShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.File.ToMap(), "File", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["File"] = request.FileShrink;
            query["NotifyEndpoint"] = request.NotifyEndpoint;
            query["NotifyTopicName"] = request.NotifyTopicName;
            query["ProjectName"] = request.ProjectName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFileMetaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateFileMetaResponse> UpdateFileMetaWithOptionsAsync(UpdateFileMetaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateFileMetaShrinkRequest request = new UpdateFileMetaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.File.ToMap()))
            {
                request.FileShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.File.ToMap(), "File", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetName"] = request.DatasetName;
            query["File"] = request.FileShrink;
            query["NotifyEndpoint"] = request.NotifyEndpoint;
            query["NotifyTopicName"] = request.NotifyTopicName;
            query["ProjectName"] = request.ProjectName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

        public UpdateProjectResponse UpdateProjectWithOptions(UpdateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetMaxBindCount"] = request.DatasetMaxBindCount;
            query["DatasetMaxEntityCount"] = request.DatasetMaxEntityCount;
            query["DatasetMaxFileCount"] = request.DatasetMaxFileCount;
            query["DatasetMaxRelationCount"] = request.DatasetMaxRelationCount;
            query["DatasetMaxTotalFileSize"] = request.DatasetMaxTotalFileSize;
            query["Description"] = request.Description;
            query["EngineConcurrency"] = request.EngineConcurrency;
            query["ProjectMaxDatasetCount"] = request.ProjectMaxDatasetCount;
            query["ProjectName"] = request.ProjectName;
            query["ProjectQueriesPerSecond"] = request.ProjectQueriesPerSecond;
            query["ServiceRole"] = request.ServiceRole;
            query["TemplateId"] = request.TemplateId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateProjectResponse> UpdateProjectWithOptionsAsync(UpdateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["DatasetMaxBindCount"] = request.DatasetMaxBindCount;
            query["DatasetMaxEntityCount"] = request.DatasetMaxEntityCount;
            query["DatasetMaxFileCount"] = request.DatasetMaxFileCount;
            query["DatasetMaxRelationCount"] = request.DatasetMaxRelationCount;
            query["DatasetMaxTotalFileSize"] = request.DatasetMaxTotalFileSize;
            query["Description"] = request.Description;
            query["EngineConcurrency"] = request.EngineConcurrency;
            query["ProjectMaxDatasetCount"] = request.ProjectMaxDatasetCount;
            query["ProjectName"] = request.ProjectName;
            query["ProjectQueriesPerSecond"] = request.ProjectQueriesPerSecond;
            query["ServiceRole"] = request.ServiceRole;
            query["TemplateId"] = request.TemplateId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
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
                ReqBodyType = "json",
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

    }
}
