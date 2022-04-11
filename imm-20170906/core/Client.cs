// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Imm20170906.Models;

namespace AlibabaCloud.SDK.Imm20170906
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

        public CompareImageFacesResponse CompareImageFacesWithOptions(CompareImageFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceIdA))
            {
                query["FaceIdA"] = request.FaceIdA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceIdB))
            {
                query["FaceIdB"] = request.FaceIdB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUriA))
            {
                query["ImageUriA"] = request.ImageUriA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUriB))
            {
                query["ImageUriB"] = request.ImageUriB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompareImageFaces",
                Version = "2017-09-06",
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

        public async Task<CompareImageFacesResponse> CompareImageFacesWithOptionsAsync(CompareImageFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceIdA))
            {
                query["FaceIdA"] = request.FaceIdA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceIdB))
            {
                query["FaceIdB"] = request.FaceIdB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUriA))
            {
                query["ImageUriA"] = request.ImageUriA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUriB))
            {
                query["ImageUriB"] = request.ImageUriB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompareImageFaces",
                Version = "2017-09-06",
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

        public ConvertOfficeFormatResponse ConvertOfficeFormatWithOptions(ConvertOfficeFormatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPage))
            {
                query["EndPage"] = request.EndPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FitToPagesTall))
            {
                query["FitToPagesTall"] = request.FitToPagesTall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FitToPagesWide))
            {
                query["FitToPagesWide"] = request.FitToPagesWide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hidecomments))
            {
                query["Hidecomments"] = request.Hidecomments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSheetCol))
            {
                query["MaxSheetCol"] = request.MaxSheetCol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSheetCount))
            {
                query["MaxSheetCount"] = request.MaxSheetCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSheetRow))
            {
                query["MaxSheetRow"] = request.MaxSheetRow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PdfVector))
            {
                query["PdfVector"] = request.PdfVector;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetOnePage))
            {
                query["SheetOnePage"] = request.SheetOnePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcType))
            {
                query["SrcType"] = request.SrcType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUri))
            {
                query["SrcUri"] = request.SrcUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPage))
            {
                query["StartPage"] = request.StartPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtFilePages))
            {
                query["TgtFilePages"] = request.TgtFilePages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtFilePrefix))
            {
                query["TgtFilePrefix"] = request.TgtFilePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtFileSuffix))
            {
                query["TgtFileSuffix"] = request.TgtFileSuffix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtType))
            {
                query["TgtType"] = request.TgtType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtUri))
            {
                query["TgtUri"] = request.TgtUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertOfficeFormat",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertOfficeFormatResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConvertOfficeFormatResponse> ConvertOfficeFormatWithOptionsAsync(ConvertOfficeFormatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPage))
            {
                query["EndPage"] = request.EndPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FitToPagesTall))
            {
                query["FitToPagesTall"] = request.FitToPagesTall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FitToPagesWide))
            {
                query["FitToPagesWide"] = request.FitToPagesWide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hidecomments))
            {
                query["Hidecomments"] = request.Hidecomments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSheetCol))
            {
                query["MaxSheetCol"] = request.MaxSheetCol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSheetCount))
            {
                query["MaxSheetCount"] = request.MaxSheetCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSheetRow))
            {
                query["MaxSheetRow"] = request.MaxSheetRow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PdfVector))
            {
                query["PdfVector"] = request.PdfVector;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetOnePage))
            {
                query["SheetOnePage"] = request.SheetOnePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcType))
            {
                query["SrcType"] = request.SrcType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUri))
            {
                query["SrcUri"] = request.SrcUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPage))
            {
                query["StartPage"] = request.StartPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtFilePages))
            {
                query["TgtFilePages"] = request.TgtFilePages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtFilePrefix))
            {
                query["TgtFilePrefix"] = request.TgtFilePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtFileSuffix))
            {
                query["TgtFileSuffix"] = request.TgtFileSuffix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtType))
            {
                query["TgtType"] = request.TgtType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtUri))
            {
                query["TgtUri"] = request.TgtUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConvertOfficeFormat",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertOfficeFormatResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConvertOfficeFormatResponse ConvertOfficeFormat(ConvertOfficeFormatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConvertOfficeFormatWithOptions(request, runtime);
        }

        public async Task<ConvertOfficeFormatResponse> ConvertOfficeFormatAsync(ConvertOfficeFormatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConvertOfficeFormatWithOptionsAsync(request, runtime);
        }

        public CreateGrabFrameTaskResponse CreateGrabFrameTaskWithOptions(CreateGrabFrameTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomMessage))
            {
                query["CustomMessage"] = request.CustomMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyEndpoint))
            {
                query["NotifyEndpoint"] = request.NotifyEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetList))
            {
                query["TargetList"] = request.TargetList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUri))
            {
                query["VideoUri"] = request.VideoUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGrabFrameTask",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGrabFrameTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGrabFrameTaskResponse> CreateGrabFrameTaskWithOptionsAsync(CreateGrabFrameTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomMessage))
            {
                query["CustomMessage"] = request.CustomMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyEndpoint))
            {
                query["NotifyEndpoint"] = request.NotifyEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetList))
            {
                query["TargetList"] = request.TargetList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUri))
            {
                query["VideoUri"] = request.VideoUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGrabFrameTask",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGrabFrameTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateGrabFrameTaskResponse CreateGrabFrameTask(CreateGrabFrameTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGrabFrameTaskWithOptions(request, runtime);
        }

        public async Task<CreateGrabFrameTaskResponse> CreateGrabFrameTaskAsync(CreateGrabFrameTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGrabFrameTaskWithOptionsAsync(request, runtime);
        }

        public CreateGroupFacesJobResponse CreateGroupFacesJobWithOptions(CreateGroupFacesJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyEndpoint))
            {
                query["NotifyEndpoint"] = request.NotifyEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroupFacesJob",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupFacesJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGroupFacesJobResponse> CreateGroupFacesJobWithOptionsAsync(CreateGroupFacesJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyEndpoint))
            {
                query["NotifyEndpoint"] = request.NotifyEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroupFacesJob",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupFacesJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateGroupFacesJobResponse CreateGroupFacesJob(CreateGroupFacesJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupFacesJobWithOptions(request, runtime);
        }

        public async Task<CreateGroupFacesJobResponse> CreateGroupFacesJobAsync(CreateGroupFacesJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupFacesJobWithOptionsAsync(request, runtime);
        }

        public CreateMergeFaceGroupsJobResponse CreateMergeFaceGroupsJobWithOptions(CreateMergeFaceGroupsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomMessage))
            {
                query["CustomMessage"] = request.CustomMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIdFrom))
            {
                query["GroupIdFrom"] = request.GroupIdFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIdTo))
            {
                query["GroupIdTo"] = request.GroupIdTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyEndpoint))
            {
                query["NotifyEndpoint"] = request.NotifyEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMergeFaceGroupsJob",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMergeFaceGroupsJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateMergeFaceGroupsJobResponse> CreateMergeFaceGroupsJobWithOptionsAsync(CreateMergeFaceGroupsJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomMessage))
            {
                query["CustomMessage"] = request.CustomMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIdFrom))
            {
                query["GroupIdFrom"] = request.GroupIdFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIdTo))
            {
                query["GroupIdTo"] = request.GroupIdTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyEndpoint))
            {
                query["NotifyEndpoint"] = request.NotifyEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMergeFaceGroupsJob",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMergeFaceGroupsJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateMergeFaceGroupsJobResponse CreateMergeFaceGroupsJob(CreateMergeFaceGroupsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMergeFaceGroupsJobWithOptions(request, runtime);
        }

        public async Task<CreateMergeFaceGroupsJobResponse> CreateMergeFaceGroupsJobAsync(CreateMergeFaceGroupsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMergeFaceGroupsJobWithOptionsAsync(request, runtime);
        }

        public CreateOfficeConversionTaskResponse CreateOfficeConversionTaskWithOptions(CreateOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayDpi))
            {
                query["DisplayDpi"] = request.DisplayDpi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPage))
            {
                query["EndPage"] = request.EndPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FitToPagesTall))
            {
                query["FitToPagesTall"] = request.FitToPagesTall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FitToPagesWide))
            {
                query["FitToPagesWide"] = request.FitToPagesWide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hidecomments))
            {
                query["Hidecomments"] = request.Hidecomments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentToken))
            {
                query["IdempotentToken"] = request.IdempotentToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSheetCol))
            {
                query["MaxSheetCol"] = request.MaxSheetCol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSheetCount))
            {
                query["MaxSheetCount"] = request.MaxSheetCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSheetRow))
            {
                query["MaxSheetRow"] = request.MaxSheetRow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyEndpoint))
            {
                query["NotifyEndpoint"] = request.NotifyEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PdfVector))
            {
                query["PdfVector"] = request.PdfVector;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetOnePage))
            {
                query["SheetOnePage"] = request.SheetOnePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcType))
            {
                query["SrcType"] = request.SrcType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUri))
            {
                query["SrcUri"] = request.SrcUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPage))
            {
                query["StartPage"] = request.StartPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtFilePages))
            {
                query["TgtFilePages"] = request.TgtFilePages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtFilePrefix))
            {
                query["TgtFilePrefix"] = request.TgtFilePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtFileSuffix))
            {
                query["TgtFileSuffix"] = request.TgtFileSuffix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtType))
            {
                query["TgtType"] = request.TgtType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtUri))
            {
                query["TgtUri"] = request.TgtUri;
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
                Version = "2017-09-06",
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

        public async Task<CreateOfficeConversionTaskResponse> CreateOfficeConversionTaskWithOptionsAsync(CreateOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayDpi))
            {
                query["DisplayDpi"] = request.DisplayDpi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPage))
            {
                query["EndPage"] = request.EndPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FitToPagesTall))
            {
                query["FitToPagesTall"] = request.FitToPagesTall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FitToPagesWide))
            {
                query["FitToPagesWide"] = request.FitToPagesWide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hidecomments))
            {
                query["Hidecomments"] = request.Hidecomments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdempotentToken))
            {
                query["IdempotentToken"] = request.IdempotentToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSheetCol))
            {
                query["MaxSheetCol"] = request.MaxSheetCol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSheetCount))
            {
                query["MaxSheetCount"] = request.MaxSheetCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSheetRow))
            {
                query["MaxSheetRow"] = request.MaxSheetRow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyEndpoint))
            {
                query["NotifyEndpoint"] = request.NotifyEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PdfVector))
            {
                query["PdfVector"] = request.PdfVector;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SheetOnePage))
            {
                query["SheetOnePage"] = request.SheetOnePage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcType))
            {
                query["SrcType"] = request.SrcType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUri))
            {
                query["SrcUri"] = request.SrcUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPage))
            {
                query["StartPage"] = request.StartPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtFilePages))
            {
                query["TgtFilePages"] = request.TgtFilePages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtFilePrefix))
            {
                query["TgtFilePrefix"] = request.TgtFilePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtFileSuffix))
            {
                query["TgtFileSuffix"] = request.TgtFileSuffix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtType))
            {
                query["TgtType"] = request.TgtType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtUri))
            {
                query["TgtUri"] = request.TgtUri;
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
                Version = "2017-09-06",
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

        public CreateSetResponse CreateSetWithOptions(CreateSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetName))
            {
                query["SetName"] = request.SetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSet",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSetResponse> CreateSetWithOptionsAsync(CreateSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetName))
            {
                query["SetName"] = request.SetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSet",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSetResponse CreateSet(CreateSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSetWithOptions(request, runtime);
        }

        public async Task<CreateSetResponse> CreateSetAsync(CreateSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSetWithOptionsAsync(request, runtime);
        }

        public CreateVideoCompressTaskResponse CreateVideoCompressTaskWithOptions(CreateVideoCompressTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomMessage))
            {
                query["CustomMessage"] = request.CustomMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyEndpoint))
            {
                query["NotifyEndpoint"] = request.NotifyEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetList))
            {
                query["TargetList"] = request.TargetList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSegment))
            {
                query["TargetSegment"] = request.TargetSegment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSubtitle))
            {
                query["TargetSubtitle"] = request.TargetSubtitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUri))
            {
                query["VideoUri"] = request.VideoUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVideoCompressTask",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoCompressTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateVideoCompressTaskResponse> CreateVideoCompressTaskWithOptionsAsync(CreateVideoCompressTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomMessage))
            {
                query["CustomMessage"] = request.CustomMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyEndpoint))
            {
                query["NotifyEndpoint"] = request.NotifyEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetList))
            {
                query["TargetList"] = request.TargetList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSegment))
            {
                query["TargetSegment"] = request.TargetSegment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetSubtitle))
            {
                query["TargetSubtitle"] = request.TargetSubtitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUri))
            {
                query["VideoUri"] = request.VideoUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVideoCompressTask",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVideoCompressTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateVideoCompressTaskResponse CreateVideoCompressTask(CreateVideoCompressTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVideoCompressTaskWithOptions(request, runtime);
        }

        public async Task<CreateVideoCompressTaskResponse> CreateVideoCompressTaskAsync(CreateVideoCompressTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVideoCompressTaskWithOptionsAsync(request, runtime);
        }

        public DecodeBlindWatermarkResponse DecodeBlindWatermarkWithOptions(DecodeBlindWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageQuality))
            {
                query["ImageQuality"] = request.ImageQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalImageUri))
            {
                query["OriginalImageUri"] = request.OriginalImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUri))
            {
                query["TargetUri"] = request.TargetUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DecodeBlindWatermark",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DecodeBlindWatermarkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DecodeBlindWatermarkResponse> DecodeBlindWatermarkWithOptionsAsync(DecodeBlindWatermarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageQuality))
            {
                query["ImageQuality"] = request.ImageQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalImageUri))
            {
                query["OriginalImageUri"] = request.OriginalImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUri))
            {
                query["TargetUri"] = request.TargetUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DecodeBlindWatermark",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DecodeBlindWatermarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DecodeBlindWatermarkResponse DecodeBlindWatermark(DecodeBlindWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DecodeBlindWatermarkWithOptions(request, runtime);
        }

        public async Task<DecodeBlindWatermarkResponse> DecodeBlindWatermarkAsync(DecodeBlindWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DecodeBlindWatermarkWithOptionsAsync(request, runtime);
        }

        public DeleteImageResponse DeleteImageWithOptions(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteImage",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteImageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteImageResponse> DeleteImageWithOptionsAsync(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteImage",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteImageResponse>(await CallApiAsync(params_, req, runtime));
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

        public DeleteOfficeConversionTaskResponse DeleteOfficeConversionTaskWithOptions(DeleteOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOfficeConversionTask",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOfficeConversionTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteOfficeConversionTaskResponse> DeleteOfficeConversionTaskWithOptionsAsync(DeleteOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOfficeConversionTask",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOfficeConversionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteOfficeConversionTaskResponse DeleteOfficeConversionTask(DeleteOfficeConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOfficeConversionTaskWithOptions(request, runtime);
        }

        public async Task<DeleteOfficeConversionTaskResponse> DeleteOfficeConversionTaskAsync(DeleteOfficeConversionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOfficeConversionTaskWithOptionsAsync(request, runtime);
        }

        public DeleteProjectResponse DeleteProjectWithOptions(DeleteProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2017-09-06",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2017-09-06",
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

        public DeleteSetResponse DeleteSetWithOptions(DeleteSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSet",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteSetResponse> DeleteSetWithOptionsAsync(DeleteSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSet",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteSetResponse DeleteSet(DeleteSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSetWithOptions(request, runtime);
        }

        public async Task<DeleteSetResponse> DeleteSetAsync(DeleteSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSetWithOptionsAsync(request, runtime);
        }

        public DeleteVideoResponse DeleteVideoWithOptions(DeleteVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUri))
            {
                query["VideoUri"] = request.VideoUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVideo",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVideoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteVideoResponse> DeleteVideoWithOptionsAsync(DeleteVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUri))
            {
                query["VideoUri"] = request.VideoUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVideo",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVideoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteVideoResponse DeleteVideo(DeleteVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVideoWithOptions(request, runtime);
        }

        public async Task<DeleteVideoResponse> DeleteVideoAsync(DeleteVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVideoWithOptionsAsync(request, runtime);
        }

        public DeleteVideoTaskResponse DeleteVideoTaskWithOptions(DeleteVideoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
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
                Action = "DeleteVideoTask",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVideoTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteVideoTaskResponse> DeleteVideoTaskWithOptionsAsync(DeleteVideoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
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
                Action = "DeleteVideoTask",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVideoTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteVideoTaskResponse DeleteVideoTask(DeleteVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVideoTaskWithOptions(request, runtime);
        }

        public async Task<DeleteVideoTaskResponse> DeleteVideoTaskAsync(DeleteVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVideoTaskWithOptionsAsync(request, runtime);
        }

        public DetectImageBodiesResponse DetectImageBodiesWithOptions(DetectImageBodiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageBodies",
                Version = "2017-09-06",
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

        public async Task<DetectImageBodiesResponse> DetectImageBodiesWithOptionsAsync(DetectImageBodiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageBodies",
                Version = "2017-09-06",
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

        public DetectImageFacesResponse DetectImageFacesWithOptions(DetectImageFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageFaces",
                Version = "2017-09-06",
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

        public async Task<DetectImageFacesResponse> DetectImageFacesWithOptionsAsync(DetectImageFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageFaces",
                Version = "2017-09-06",
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

        public DetectImageQRCodesResponse DetectImageQRCodesWithOptions(DetectImageQRCodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageQRCodes",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageQRCodesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetectImageQRCodesResponse> DetectImageQRCodesWithOptionsAsync(DetectImageQRCodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageQRCodes",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageQRCodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetectImageQRCodesResponse DetectImageQRCodes(DetectImageQRCodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageQRCodesWithOptions(request, runtime);
        }

        public async Task<DetectImageQRCodesResponse> DetectImageQRCodesAsync(DetectImageQRCodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageQRCodesWithOptionsAsync(request, runtime);
        }

        public DetectImageTagsResponse DetectImageTagsWithOptions(DetectImageTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageTags",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageTagsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetectImageTagsResponse> DetectImageTagsWithOptionsAsync(DetectImageTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectImageTags",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectImageTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetectImageTagsResponse DetectImageTags(DetectImageTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectImageTagsWithOptions(request, runtime);
        }

        public async Task<DetectImageTagsResponse> DetectImageTagsAsync(DetectImageTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectImageTagsWithOptionsAsync(request, runtime);
        }

        public DetectQRCodesResponse DetectQRCodesWithOptions(DetectQRCodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUris))
            {
                query["SrcUris"] = request.SrcUris;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectQRCodes",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectQRCodesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetectQRCodesResponse> DetectQRCodesWithOptionsAsync(DetectQRCodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUris))
            {
                query["SrcUris"] = request.SrcUris;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectQRCodes",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectQRCodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetectQRCodesResponse DetectQRCodes(DetectQRCodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectQRCodesWithOptions(request, runtime);
        }

        public async Task<DetectQRCodesResponse> DetectQRCodesAsync(DetectQRCodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectQRCodesWithOptionsAsync(request, runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetImageType))
            {
                query["TargetImageType"] = request.TargetImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUri))
            {
                query["TargetUri"] = request.TargetUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkUri))
            {
                query["WatermarkUri"] = request.WatermarkUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EncodeBlindWatermark",
                Version = "2017-09-06",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetImageType))
            {
                query["TargetImageType"] = request.TargetImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUri))
            {
                query["TargetUri"] = request.TargetUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkUri))
            {
                query["WatermarkUri"] = request.WatermarkUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EncodeBlindWatermark",
                Version = "2017-09-06",
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

        public EncodeBlindWatermarkResponse EncodeBlindWatermark(EncodeBlindWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EncodeBlindWatermarkWithOptions(request, runtime);
        }

        public async Task<EncodeBlindWatermarkResponse> EncodeBlindWatermarkAsync(EncodeBlindWatermarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EncodeBlindWatermarkWithOptionsAsync(request, runtime);
        }

        public FindImagesResponse FindImagesWithOptions(FindImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressLineContentsMatch))
            {
                query["AddressLineContentsMatch"] = request.AddressLineContentsMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgeRange))
            {
                query["AgeRange"] = request.AgeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeRange))
            {
                query["CreateTimeRange"] = request.CreateTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Emotion))
            {
                query["Emotion"] = request.Emotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalId))
            {
                query["ExternalId"] = request.ExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacesModifyTimeRange))
            {
                query["FacesModifyTimeRange"] = request.FacesModifyTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                query["Gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageSizeRange))
            {
                query["ImageSizeRange"] = request.ImageSizeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageTimeRange))
            {
                query["ImageTimeRange"] = request.ImageTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationBoundary))
            {
                query["LocationBoundary"] = request.LocationBoundary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyTimeRange))
            {
                query["ModifyTimeRange"] = request.ModifyTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OCRContentsMatch))
            {
                query["OCRContentsMatch"] = request.OCRContentsMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksAPrefix))
            {
                query["RemarksAPrefix"] = request.RemarksAPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayAIn))
            {
                query["RemarksArrayAIn"] = request.RemarksArrayAIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayBIn))
            {
                query["RemarksArrayBIn"] = request.RemarksArrayBIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksBPrefix))
            {
                query["RemarksBPrefix"] = request.RemarksBPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksCPrefix))
            {
                query["RemarksCPrefix"] = request.RemarksCPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksDPrefix))
            {
                query["RemarksDPrefix"] = request.RemarksDPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUriPrefix))
            {
                query["SourceUriPrefix"] = request.SourceUriPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagNames))
            {
                query["TagNames"] = request.TagNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsModifyTimeRange))
            {
                query["TagsModifyTimeRange"] = request.TagsModifyTimeRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindImages",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindImagesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FindImagesResponse> FindImagesWithOptionsAsync(FindImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressLineContentsMatch))
            {
                query["AddressLineContentsMatch"] = request.AddressLineContentsMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgeRange))
            {
                query["AgeRange"] = request.AgeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeRange))
            {
                query["CreateTimeRange"] = request.CreateTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Emotion))
            {
                query["Emotion"] = request.Emotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalId))
            {
                query["ExternalId"] = request.ExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacesModifyTimeRange))
            {
                query["FacesModifyTimeRange"] = request.FacesModifyTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                query["Gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageSizeRange))
            {
                query["ImageSizeRange"] = request.ImageSizeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageTimeRange))
            {
                query["ImageTimeRange"] = request.ImageTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationBoundary))
            {
                query["LocationBoundary"] = request.LocationBoundary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyTimeRange))
            {
                query["ModifyTimeRange"] = request.ModifyTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OCRContentsMatch))
            {
                query["OCRContentsMatch"] = request.OCRContentsMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksAPrefix))
            {
                query["RemarksAPrefix"] = request.RemarksAPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayAIn))
            {
                query["RemarksArrayAIn"] = request.RemarksArrayAIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayBIn))
            {
                query["RemarksArrayBIn"] = request.RemarksArrayBIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksBPrefix))
            {
                query["RemarksBPrefix"] = request.RemarksBPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksCPrefix))
            {
                query["RemarksCPrefix"] = request.RemarksCPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksDPrefix))
            {
                query["RemarksDPrefix"] = request.RemarksDPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUriPrefix))
            {
                query["SourceUriPrefix"] = request.SourceUriPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagNames))
            {
                query["TagNames"] = request.TagNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsModifyTimeRange))
            {
                query["TagsModifyTimeRange"] = request.TagsModifyTimeRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindImages",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindImagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FindImagesResponse FindImages(FindImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindImagesWithOptions(request, runtime);
        }

        public async Task<FindImagesResponse> FindImagesAsync(FindImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindImagesWithOptionsAsync(request, runtime);
        }

        public FindSimilarFacesResponse FindSimilarFacesWithOptions(FindSimilarFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceId))
            {
                query["FaceId"] = request.FaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinSimilarity))
            {
                query["MinSimilarity"] = request.MinSimilarity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseFormat))
            {
                query["ResponseFormat"] = request.ResponseFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindSimilarFaces",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindSimilarFacesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FindSimilarFacesResponse> FindSimilarFacesWithOptionsAsync(FindSimilarFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceId))
            {
                query["FaceId"] = request.FaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinSimilarity))
            {
                query["MinSimilarity"] = request.MinSimilarity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResponseFormat))
            {
                query["ResponseFormat"] = request.ResponseFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindSimilarFaces",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindSimilarFacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FindSimilarFacesResponse FindSimilarFaces(FindSimilarFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindSimilarFacesWithOptions(request, runtime);
        }

        public async Task<FindSimilarFacesResponse> FindSimilarFacesAsync(FindSimilarFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindSimilarFacesWithOptionsAsync(request, runtime);
        }

        public GetImageResponse GetImageWithOptions(GetImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImage",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetImageResponse> GetImageWithOptionsAsync(GetImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImage",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetImageResponse GetImage(GetImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageWithOptions(request, runtime);
        }

        public async Task<GetImageResponse> GetImageAsync(GetImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageWithOptionsAsync(request, runtime);
        }

        public GetImageCroppingSuggestionsResponse GetImageCroppingSuggestionsWithOptions(GetImageCroppingSuggestionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AspectRatios))
            {
                query["AspectRatios"] = request.AspectRatios;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImageCroppingSuggestions",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageCroppingSuggestionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetImageCroppingSuggestionsResponse> GetImageCroppingSuggestionsWithOptionsAsync(GetImageCroppingSuggestionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AspectRatios))
            {
                query["AspectRatios"] = request.AspectRatios;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImageCroppingSuggestions",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageCroppingSuggestionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetImageCroppingSuggestionsResponse GetImageCroppingSuggestions(GetImageCroppingSuggestionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageCroppingSuggestionsWithOptions(request, runtime);
        }

        public async Task<GetImageCroppingSuggestionsResponse> GetImageCroppingSuggestionsAsync(GetImageCroppingSuggestionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageCroppingSuggestionsWithOptionsAsync(request, runtime);
        }

        public GetImageQualityResponse GetImageQualityWithOptions(GetImageQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImageQuality",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageQualityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetImageQualityResponse> GetImageQualityWithOptionsAsync(GetImageQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetImageQuality",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageQualityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetImageQualityResponse GetImageQuality(GetImageQualityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageQualityWithOptions(request, runtime);
        }

        public async Task<GetImageQualityResponse> GetImageQualityAsync(GetImageQualityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageQualityWithOptionsAsync(request, runtime);
        }

        public GetMediaMetaResponse GetMediaMetaWithOptions(GetMediaMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaUri))
            {
                query["MediaUri"] = request.MediaUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMediaMeta",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaMetaResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMediaMetaResponse> GetMediaMetaWithOptionsAsync(GetMediaMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaUri))
            {
                query["MediaUri"] = request.MediaUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMediaMeta",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMediaMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMediaMetaResponse GetMediaMeta(GetMediaMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMediaMetaWithOptions(request, runtime);
        }

        public async Task<GetMediaMetaResponse> GetMediaMetaAsync(GetMediaMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMediaMetaWithOptionsAsync(request, runtime);
        }

        public GetOfficeConversionTaskResponse GetOfficeConversionTaskWithOptions(GetOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOfficeConversionTask",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOfficeConversionTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetOfficeConversionTaskResponse> GetOfficeConversionTaskWithOptionsAsync(GetOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOfficeConversionTask",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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

        public GetOfficePreviewURLResponse GetOfficePreviewURLWithOptions(GetOfficePreviewURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcType))
            {
                query["SrcType"] = request.SrcType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUri))
            {
                query["SrcUri"] = request.SrcUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkFillStyle))
            {
                query["WatermarkFillStyle"] = request.WatermarkFillStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkFont))
            {
                query["WatermarkFont"] = request.WatermarkFont;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkHorizontal))
            {
                query["WatermarkHorizontal"] = request.WatermarkHorizontal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkRotate))
            {
                query["WatermarkRotate"] = request.WatermarkRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkType))
            {
                query["WatermarkType"] = request.WatermarkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkValue))
            {
                query["WatermarkValue"] = request.WatermarkValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkVertical))
            {
                query["WatermarkVertical"] = request.WatermarkVertical;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOfficePreviewURL",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOfficePreviewURLResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetOfficePreviewURLResponse> GetOfficePreviewURLWithOptionsAsync(GetOfficePreviewURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcType))
            {
                query["SrcType"] = request.SrcType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcUri))
            {
                query["SrcUri"] = request.SrcUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkFillStyle))
            {
                query["WatermarkFillStyle"] = request.WatermarkFillStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkFont))
            {
                query["WatermarkFont"] = request.WatermarkFont;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkHorizontal))
            {
                query["WatermarkHorizontal"] = request.WatermarkHorizontal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkRotate))
            {
                query["WatermarkRotate"] = request.WatermarkRotate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkType))
            {
                query["WatermarkType"] = request.WatermarkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkValue))
            {
                query["WatermarkValue"] = request.WatermarkValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WatermarkVertical))
            {
                query["WatermarkVertical"] = request.WatermarkVertical;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOfficePreviewURL",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOfficePreviewURLResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetOfficePreviewURLResponse GetOfficePreviewURL(GetOfficePreviewURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOfficePreviewURLWithOptions(request, runtime);
        }

        public async Task<GetOfficePreviewURLResponse> GetOfficePreviewURLAsync(GetOfficePreviewURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOfficePreviewURLWithOptionsAsync(request, runtime);
        }

        public GetProjectResponse GetProjectWithOptions(GetProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2017-09-06",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2017-09-06",
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

        public GetSetResponse GetSetWithOptions(GetSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSet",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSetResponse> GetSetWithOptionsAsync(GetSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSet",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSetResponse GetSet(GetSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSetWithOptions(request, runtime);
        }

        public async Task<GetSetResponse> GetSetAsync(GetSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSetWithOptionsAsync(request, runtime);
        }

        public GetVideoResponse GetVideoWithOptions(GetVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUri))
            {
                query["VideoUri"] = request.VideoUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideo",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetVideoResponse> GetVideoWithOptionsAsync(GetVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUri))
            {
                query["VideoUri"] = request.VideoUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideo",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetVideoResponse GetVideo(GetVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoWithOptions(request, runtime);
        }

        public async Task<GetVideoResponse> GetVideoAsync(GetVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoWithOptionsAsync(request, runtime);
        }

        public GetVideoTaskResponse GetVideoTaskWithOptions(GetVideoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
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
                Action = "GetVideoTask",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetVideoTaskResponse> GetVideoTaskWithOptionsAsync(GetVideoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
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
                Action = "GetVideoTask",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetVideoTaskResponse GetVideoTask(GetVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoTaskWithOptions(request, runtime);
        }

        public async Task<GetVideoTaskResponse> GetVideoTaskAsync(GetVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoTaskWithOptionsAsync(request, runtime);
        }

        public GetWebofficeURLResponse GetWebofficeURLWithOptions(GetWebofficeURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.File))
            {
                query["File"] = request.File;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileID))
            {
                query["FileID"] = request.FileID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hidecmb))
            {
                query["Hidecmb"] = request.Hidecmb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyEndpoint))
            {
                query["NotifyEndpoint"] = request.NotifyEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission))
            {
                query["Permission"] = request.Permission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcType))
            {
                query["SrcType"] = request.SrcType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.User))
            {
                query["User"] = request.User;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Watermark))
            {
                query["Watermark"] = request.Watermark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWebofficeURL",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWebofficeURLResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWebofficeURLResponse> GetWebofficeURLWithOptionsAsync(GetWebofficeURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.File))
            {
                query["File"] = request.File;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileID))
            {
                query["FileID"] = request.FileID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hidecmb))
            {
                query["Hidecmb"] = request.Hidecmb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyEndpoint))
            {
                query["NotifyEndpoint"] = request.NotifyEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permission))
            {
                query["Permission"] = request.Permission;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcType))
            {
                query["SrcType"] = request.SrcType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.User))
            {
                query["User"] = request.User;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Watermark))
            {
                query["Watermark"] = request.Watermark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWebofficeURL",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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

        public IndexImageResponse IndexImageWithOptions(IndexImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalId))
            {
                query["ExternalId"] = request.ExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyEndpoint))
            {
                query["NotifyEndpoint"] = request.NotifyEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksA))
            {
                query["RemarksA"] = request.RemarksA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayA))
            {
                query["RemarksArrayA"] = request.RemarksArrayA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayB))
            {
                query["RemarksArrayB"] = request.RemarksArrayB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksB))
            {
                query["RemarksB"] = request.RemarksB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksC))
            {
                query["RemarksC"] = request.RemarksC;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksD))
            {
                query["RemarksD"] = request.RemarksD;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePosition))
            {
                query["SourcePosition"] = request.SourcePosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUri))
            {
                query["SourceUri"] = request.SourceUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IndexImage",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndexImageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<IndexImageResponse> IndexImageWithOptionsAsync(IndexImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalId))
            {
                query["ExternalId"] = request.ExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyEndpoint))
            {
                query["NotifyEndpoint"] = request.NotifyEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksA))
            {
                query["RemarksA"] = request.RemarksA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayA))
            {
                query["RemarksArrayA"] = request.RemarksArrayA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayB))
            {
                query["RemarksArrayB"] = request.RemarksArrayB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksB))
            {
                query["RemarksB"] = request.RemarksB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksC))
            {
                query["RemarksC"] = request.RemarksC;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksD))
            {
                query["RemarksD"] = request.RemarksD;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePosition))
            {
                query["SourcePosition"] = request.SourcePosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUri))
            {
                query["SourceUri"] = request.SourceUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IndexImage",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndexImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public IndexImageResponse IndexImage(IndexImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IndexImageWithOptions(request, runtime);
        }

        public async Task<IndexImageResponse> IndexImageAsync(IndexImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IndexImageWithOptionsAsync(request, runtime);
        }

        public IndexVideoResponse IndexVideoWithOptions(IndexVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalId))
            {
                query["ExternalId"] = request.ExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyEndpoint))
            {
                query["NotifyEndpoint"] = request.NotifyEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksA))
            {
                query["RemarksA"] = request.RemarksA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksB))
            {
                query["RemarksB"] = request.RemarksB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksC))
            {
                query["RemarksC"] = request.RemarksC;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksD))
            {
                query["RemarksD"] = request.RemarksD;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtUri))
            {
                query["TgtUri"] = request.TgtUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUri))
            {
                query["VideoUri"] = request.VideoUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IndexVideo",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndexVideoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<IndexVideoResponse> IndexVideoWithOptionsAsync(IndexVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalId))
            {
                query["ExternalId"] = request.ExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyEndpoint))
            {
                query["NotifyEndpoint"] = request.NotifyEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTopicName))
            {
                query["NotifyTopicName"] = request.NotifyTopicName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksA))
            {
                query["RemarksA"] = request.RemarksA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksB))
            {
                query["RemarksB"] = request.RemarksB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksC))
            {
                query["RemarksC"] = request.RemarksC;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksD))
            {
                query["RemarksD"] = request.RemarksD;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TgtUri))
            {
                query["TgtUri"] = request.TgtUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUri))
            {
                query["VideoUri"] = request.VideoUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IndexVideo",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndexVideoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public IndexVideoResponse IndexVideo(IndexVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IndexVideoWithOptions(request, runtime);
        }

        public async Task<IndexVideoResponse> IndexVideoAsync(IndexVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IndexVideoWithOptionsAsync(request, runtime);
        }

        public ListFaceGroupsResponse ListFaceGroupsWithOptions(ListFaceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalId))
            {
                query["ExternalId"] = request.ExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksAQuery))
            {
                query["RemarksAQuery"] = request.RemarksAQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayAQuery))
            {
                query["RemarksArrayAQuery"] = request.RemarksArrayAQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayBQuery))
            {
                query["RemarksArrayBQuery"] = request.RemarksArrayBQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksBQuery))
            {
                query["RemarksBQuery"] = request.RemarksBQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksCQuery))
            {
                query["RemarksCQuery"] = request.RemarksCQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksDQuery))
            {
                query["RemarksDQuery"] = request.RemarksDQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFaceGroups",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFaceGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFaceGroupsResponse> ListFaceGroupsWithOptionsAsync(ListFaceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalId))
            {
                query["ExternalId"] = request.ExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksAQuery))
            {
                query["RemarksAQuery"] = request.RemarksAQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayAQuery))
            {
                query["RemarksArrayAQuery"] = request.RemarksArrayAQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayBQuery))
            {
                query["RemarksArrayBQuery"] = request.RemarksArrayBQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksBQuery))
            {
                query["RemarksBQuery"] = request.RemarksBQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksCQuery))
            {
                query["RemarksCQuery"] = request.RemarksCQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksDQuery))
            {
                query["RemarksDQuery"] = request.RemarksDQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFaceGroups",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFaceGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFaceGroupsResponse ListFaceGroups(ListFaceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFaceGroupsWithOptions(request, runtime);
        }

        public async Task<ListFaceGroupsResponse> ListFaceGroupsAsync(ListFaceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFaceGroupsWithOptionsAsync(request, runtime);
        }

        public ListImagesResponse ListImagesWithOptions(ListImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImages",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImagesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListImagesResponse> ListImagesWithOptionsAsync(ListImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImages",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImagesResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListOfficeConversionTaskResponse ListOfficeConversionTaskWithOptions(ListOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxKeys))
            {
                query["MaxKeys"] = request.MaxKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOfficeConversionTask",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOfficeConversionTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListOfficeConversionTaskResponse> ListOfficeConversionTaskWithOptionsAsync(ListOfficeConversionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxKeys))
            {
                query["MaxKeys"] = request.MaxKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOfficeConversionTask",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxKeys))
            {
                query["MaxKeys"] = request.MaxKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2017-09-06",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxKeys))
            {
                query["MaxKeys"] = request.MaxKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2017-09-06",
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

        public ListSetTagsResponse ListSetTagsWithOptions(ListSetTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSetTags",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSetTagsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSetTagsResponse> ListSetTagsWithOptionsAsync(ListSetTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSetTags",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSetTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSetTagsResponse ListSetTags(ListSetTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSetTagsWithOptions(request, runtime);
        }

        public async Task<ListSetTagsResponse> ListSetTagsAsync(ListSetTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSetTagsWithOptionsAsync(request, runtime);
        }

        public ListSetsResponse ListSetsWithOptions(ListSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSets",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSetsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSetsResponse> ListSetsWithOptionsAsync(ListSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSets",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSetsResponse ListSets(ListSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSetsWithOptions(request, runtime);
        }

        public async Task<ListSetsResponse> ListSetsAsync(ListSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSetsWithOptionsAsync(request, runtime);
        }

        public ListVideoAudiosResponse ListVideoAudiosWithOptions(ListVideoAudiosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUri))
            {
                query["VideoUri"] = request.VideoUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVideoAudios",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVideoAudiosResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListVideoAudiosResponse> ListVideoAudiosWithOptionsAsync(ListVideoAudiosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUri))
            {
                query["VideoUri"] = request.VideoUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVideoAudios",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVideoAudiosResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListVideoAudiosResponse ListVideoAudios(ListVideoAudiosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVideoAudiosWithOptions(request, runtime);
        }

        public async Task<ListVideoAudiosResponse> ListVideoAudiosAsync(ListVideoAudiosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVideoAudiosWithOptionsAsync(request, runtime);
        }

        public ListVideoFramesResponse ListVideoFramesWithOptions(ListVideoFramesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUri))
            {
                query["VideoUri"] = request.VideoUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVideoFrames",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVideoFramesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListVideoFramesResponse> ListVideoFramesWithOptionsAsync(ListVideoFramesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUri))
            {
                query["VideoUri"] = request.VideoUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVideoFrames",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVideoFramesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListVideoFramesResponse ListVideoFrames(ListVideoFramesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVideoFramesWithOptions(request, runtime);
        }

        public async Task<ListVideoFramesResponse> ListVideoFramesAsync(ListVideoFramesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVideoFramesWithOptionsAsync(request, runtime);
        }

        public ListVideoTasksResponse ListVideoTasksWithOptions(ListVideoTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxKeys))
            {
                query["MaxKeys"] = request.MaxKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
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
                Action = "ListVideoTasks",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVideoTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListVideoTasksResponse> ListVideoTasksWithOptionsAsync(ListVideoTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxKeys))
            {
                query["MaxKeys"] = request.MaxKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
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
                Action = "ListVideoTasks",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVideoTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListVideoTasksResponse ListVideoTasks(ListVideoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVideoTasksWithOptions(request, runtime);
        }

        public async Task<ListVideoTasksResponse> ListVideoTasksAsync(ListVideoTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVideoTasksWithOptionsAsync(request, runtime);
        }

        public ListVideosResponse ListVideosWithOptions(ListVideosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVideos",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVideosResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListVideosResponse> ListVideosWithOptionsAsync(ListVideosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                query["CreateTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVideos",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVideosResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListVideosResponse ListVideos(ListVideosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVideosWithOptions(request, runtime);
        }

        public async Task<ListVideosResponse> ListVideosAsync(ListVideosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVideosWithOptionsAsync(request, runtime);
        }

        public OpenImmServiceResponse OpenImmServiceWithOptions(OpenImmServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenImmService",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenImmServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<OpenImmServiceResponse> OpenImmServiceWithOptionsAsync(OpenImmServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenImmService",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenImmServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public OpenImmServiceResponse OpenImmService(OpenImmServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenImmServiceWithOptions(request, runtime);
        }

        public async Task<OpenImmServiceResponse> OpenImmServiceAsync(OpenImmServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenImmServiceWithOptionsAsync(request, runtime);
        }

        public PutProjectResponse PutProjectWithOptions(PutProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRole))
            {
                query["ServiceRole"] = request.ServiceRole;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutProject",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutProjectResponse> PutProjectWithOptionsAsync(PutProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceRole))
            {
                query["ServiceRole"] = request.ServiceRole;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutProject",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutProjectResponse PutProject(PutProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutProjectWithOptions(request, runtime);
        }

        public async Task<PutProjectResponse> PutProjectAsync(PutProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutProjectWithOptionsAsync(request, runtime);
        }

        public RefreshOfficePreviewTokenResponse RefreshOfficePreviewTokenWithOptions(RefreshOfficePreviewTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
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
                Action = "RefreshOfficePreviewToken",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshOfficePreviewTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RefreshOfficePreviewTokenResponse> RefreshOfficePreviewTokenWithOptionsAsync(RefreshOfficePreviewTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
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
                Action = "RefreshOfficePreviewToken",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshOfficePreviewTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RefreshOfficePreviewTokenResponse RefreshOfficePreviewToken(RefreshOfficePreviewTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshOfficePreviewTokenWithOptions(request, runtime);
        }

        public async Task<RefreshOfficePreviewTokenResponse> RefreshOfficePreviewTokenAsync(RefreshOfficePreviewTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshOfficePreviewTokenWithOptionsAsync(request, runtime);
        }

        public RefreshWebofficeTokenResponse RefreshWebofficeTokenWithOptions(RefreshWebofficeTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
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
                Version = "2017-09-06",
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

        public async Task<RefreshWebofficeTokenResponse> RefreshWebofficeTokenWithOptionsAsync(RefreshWebofficeTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessToken))
            {
                query["AccessToken"] = request.AccessToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
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
                Version = "2017-09-06",
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

        public UpdateFaceGroupResponse UpdateFaceGroupWithOptions(UpdateFaceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalId))
            {
                query["ExternalId"] = request.ExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCoverFaceId))
            {
                query["GroupCoverFaceId"] = request.GroupCoverFaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksA))
            {
                query["RemarksA"] = request.RemarksA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayA))
            {
                query["RemarksArrayA"] = request.RemarksArrayA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayB))
            {
                query["RemarksArrayB"] = request.RemarksArrayB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksB))
            {
                query["RemarksB"] = request.RemarksB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksC))
            {
                query["RemarksC"] = request.RemarksC;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksD))
            {
                query["RemarksD"] = request.RemarksD;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResetItems))
            {
                query["ResetItems"] = request.ResetItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFaceGroup",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFaceGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateFaceGroupResponse> UpdateFaceGroupWithOptionsAsync(UpdateFaceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalId))
            {
                query["ExternalId"] = request.ExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCoverFaceId))
            {
                query["GroupCoverFaceId"] = request.GroupCoverFaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksA))
            {
                query["RemarksA"] = request.RemarksA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayA))
            {
                query["RemarksArrayA"] = request.RemarksArrayA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayB))
            {
                query["RemarksArrayB"] = request.RemarksArrayB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksB))
            {
                query["RemarksB"] = request.RemarksB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksC))
            {
                query["RemarksC"] = request.RemarksC;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksD))
            {
                query["RemarksD"] = request.RemarksD;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResetItems))
            {
                query["ResetItems"] = request.ResetItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFaceGroup",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFaceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateFaceGroupResponse UpdateFaceGroup(UpdateFaceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFaceGroupWithOptions(request, runtime);
        }

        public async Task<UpdateFaceGroupResponse> UpdateFaceGroupAsync(UpdateFaceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFaceGroupWithOptionsAsync(request, runtime);
        }

        public UpdateImageResponse UpdateImageWithOptions(UpdateImageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateImageShrinkRequest request = new UpdateImageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Faces))
            {
                request.FacesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Faces, "Faces", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalId))
            {
                query["ExternalId"] = request.ExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacesShrink))
            {
                query["Faces"] = request.FacesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksA))
            {
                query["RemarksA"] = request.RemarksA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayA))
            {
                query["RemarksArrayA"] = request.RemarksArrayA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayB))
            {
                query["RemarksArrayB"] = request.RemarksArrayB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksB))
            {
                query["RemarksB"] = request.RemarksB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksC))
            {
                query["RemarksC"] = request.RemarksC;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksD))
            {
                query["RemarksD"] = request.RemarksD;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePosition))
            {
                query["SourcePosition"] = request.SourcePosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUri))
            {
                query["SourceUri"] = request.SourceUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateImage",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateImageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateImageResponse> UpdateImageWithOptionsAsync(UpdateImageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateImageShrinkRequest request = new UpdateImageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Faces))
            {
                request.FacesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Faces, "Faces", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalId))
            {
                query["ExternalId"] = request.ExternalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FacesShrink))
            {
                query["Faces"] = request.FacesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUri))
            {
                query["ImageUri"] = request.ImageUri;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksA))
            {
                query["RemarksA"] = request.RemarksA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayA))
            {
                query["RemarksArrayA"] = request.RemarksArrayA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksArrayB))
            {
                query["RemarksArrayB"] = request.RemarksArrayB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksB))
            {
                query["RemarksB"] = request.RemarksB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksC))
            {
                query["RemarksC"] = request.RemarksC;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemarksD))
            {
                query["RemarksD"] = request.RemarksD;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePosition))
            {
                query["SourcePosition"] = request.SourcePosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUri))
            {
                query["SourceUri"] = request.SourceUri;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateImage",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateImageResponse UpdateImage(UpdateImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateImageWithOptions(request, runtime);
        }

        public async Task<UpdateImageResponse> UpdateImageAsync(UpdateImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateImageWithOptionsAsync(request, runtime);
        }

        public UpdateProjectResponse UpdateProjectWithOptions(UpdateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewCU))
            {
                query["NewCU"] = request.NewCU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewServiceRole))
            {
                query["NewServiceRole"] = request.NewServiceRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProject",
                Version = "2017-09-06",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewCU))
            {
                query["NewCU"] = request.NewCU;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewServiceRole))
            {
                query["NewServiceRole"] = request.NewServiceRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProject",
                Version = "2017-09-06",
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

        public UpdateSetResponse UpdateSetWithOptions(UpdateSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetName))
            {
                query["SetName"] = request.SetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSet",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateSetResponse> UpdateSetWithOptionsAsync(UpdateSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetId))
            {
                query["SetId"] = request.SetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SetName))
            {
                query["SetName"] = request.SetName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSet",
                Version = "2017-09-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateSetResponse UpdateSet(UpdateSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSetWithOptions(request, runtime);
        }

        public async Task<UpdateSetResponse> UpdateSetAsync(UpdateSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSetWithOptionsAsync(request, runtime);
        }

    }
}
