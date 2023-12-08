// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Alicloudproc20240104.Models;

namespace AlibabaCloud.SDK.Alicloudproc20240104
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("alicloudproc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateSourcingProjectResponse CreateSourcingProjectWithOptions(CreateSourcingProjectRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSourcingProjectShrinkRequest request = new CreateSourcingProjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Address))
            {
                request.AddressShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Address, "Address", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Company))
            {
                request.CompanyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Company, "Company", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contact))
            {
                request.ContactShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contact, "Contact", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtendInfo))
            {
                request.ExtendInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtendInfo, "ExtendInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Subjects))
            {
                request.SubjectsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Subjects, "Subjects", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressShrink))
            {
                query["Address"] = request.AddressShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizNo))
            {
                query["BizNo"] = request.BizNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyShrink))
            {
                query["Company"] = request.CompanyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactShrink))
            {
                query["Contact"] = request.ContactShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["CreateTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfoShrink))
            {
                query["ExtendInfo"] = request.ExtendInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUrl))
            {
                query["SourceUrl"] = request.SourceUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizType))
            {
                query["SubBizType"] = request.SubBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubjectsShrink))
            {
                query["Subjects"] = request.SubjectsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSourcingProject",
                Version = "2024-01-04",
                Protocol = "HTTPS",
                Pathname = "/srm/lite/sourcing/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSourcingProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSourcingProjectResponse> CreateSourcingProjectWithOptionsAsync(CreateSourcingProjectRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSourcingProjectShrinkRequest request = new CreateSourcingProjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Address))
            {
                request.AddressShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Address, "Address", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Company))
            {
                request.CompanyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Company, "Company", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Contact))
            {
                request.ContactShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Contact, "Contact", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtendInfo))
            {
                request.ExtendInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtendInfo, "ExtendInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Subjects))
            {
                request.SubjectsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Subjects, "Subjects", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressShrink))
            {
                query["Address"] = request.AddressShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizNo))
            {
                query["BizNo"] = request.BizNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyShrink))
            {
                query["Company"] = request.CompanyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactShrink))
            {
                query["Contact"] = request.ContactShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["CreateTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfoShrink))
            {
                query["ExtendInfo"] = request.ExtendInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUrl))
            {
                query["SourceUrl"] = request.SourceUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubBizType))
            {
                query["SubBizType"] = request.SubBizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubjectsShrink))
            {
                query["Subjects"] = request.SubjectsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSourcingProject",
                Version = "2024-01-04",
                Protocol = "HTTPS",
                Pathname = "/srm/lite/sourcing/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSourcingProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSourcingProjectResponse CreateSourcingProject(CreateSourcingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSourcingProjectWithOptions(request, headers, runtime);
        }

        public async Task<CreateSourcingProjectResponse> CreateSourcingProjectAsync(CreateSourcingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSourcingProjectWithOptionsAsync(request, headers, runtime);
        }

        public UpdateSourcingProjectResponse UpdateSourcingProjectWithOptions(UpdateSourcingProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTime))
            {
                query["UpdateTime"] = request.UpdateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSourcingProject",
                Version = "2024-01-04",
                Protocol = "HTTPS",
                Pathname = "/srm/lite/sourcing/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSourcingProjectResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateSourcingProjectResponse> UpdateSourcingProjectWithOptionsAsync(UpdateSourcingProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTime))
            {
                query["UpdateTime"] = request.UpdateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSourcingProject",
                Version = "2024-01-04",
                Protocol = "HTTPS",
                Pathname = "/srm/lite/sourcing/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSourcingProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateSourcingProjectResponse UpdateSourcingProject(UpdateSourcingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSourcingProjectWithOptions(request, headers, runtime);
        }

        public async Task<UpdateSourcingProjectResponse> UpdateSourcingProjectAsync(UpdateSourcingProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSourcingProjectWithOptionsAsync(request, headers, runtime);
        }

    }
}
