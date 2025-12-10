// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.PaiStudio20210202.Models;

namespace AlibabaCloud.SDK.PaiStudio20210202
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "pai.cn-beijing.aliyuncs.com"},
                {"cn-hangzhou", "pai.cn-hangzhou.data.aliyun.com"},
                {"cn-shanghai", "pai.cn-shanghai.aliyuncs.com"},
                {"cn-shenzhen", "pai.cn-shenzhen.aliyuncs.com"},
                {"cn-hongkong", "pai.cn-hongkong.aliyuncs.com"},
                {"ap-southeast-1", "pai.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "pai.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-3", "pai.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-5", "pai.ap-southeast-5.aliyuncs.com"},
                {"us-east-1", "pai.us-east-1.aliyuncs.com"},
                {"us-west-1", "pai.us-west-1.aliyuncs.com"},
                {"eu-central-1", "pai.eu-central-1.aliyuncs.com"},
                {"ap-south-1", "pai.ap-south-1.aliyuncs.com"},
                {"me-east-1", "pai.me-east-1.aliyuncs.com"},
                {"ap-northeast-1", "pai.ap-northeast-1.aliyuncs.com"},
                {"cn-qingdao", "pai.cn-qingdao.aliyuncs.com"},
                {"cn-shanghai-finance-1", "pai.cn-shanghai-finance-1.aliyuncs.com"},
                {"cn-wulanchabu", "pai.cn-wulanchabu.aliyuncs.com"},
                {"cn-zhangjiakou", "pai.cn-zhangjiakou.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("paistudio", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>复制实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyExperimentResponse
        /// </returns>
        public CopyExperimentResponse CopyExperimentWithOptions(string ExperimentId, CopyExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                body["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyExperiment",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/copy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>复制实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyExperimentResponse
        /// </returns>
        public async Task<CopyExperimentResponse> CopyExperimentWithOptionsAsync(string ExperimentId, CopyExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                body["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyExperiment",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/copy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>复制实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyExperimentResponse
        /// </returns>
        public CopyExperimentResponse CopyExperiment(string ExperimentId, CopyExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CopyExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>复制实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CopyExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyExperimentResponse
        /// </returns>
        public async Task<CopyExperimentResponse> CopyExperimentAsync(string ExperimentId, CopyExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CopyExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实验，或根据实验模版创建实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentResponse
        /// </returns>
        public CreateExperimentResponse CreateExperimentWithOptions(CreateExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                body["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExperiment",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实验，或根据实验模版创建实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentResponse
        /// </returns>
        public async Task<CreateExperimentResponse> CreateExperimentWithOptionsAsync(CreateExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                body["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExperiment",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实验，或根据实验模版创建实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentResponse
        /// </returns>
        public CreateExperimentResponse CreateExperiment(CreateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateExperimentWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建实验，或根据实验模版创建实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentResponse
        /// </returns>
        public async Task<CreateExperimentResponse> CreateExperimentAsync(CreateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateExperimentWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建算法文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentFolderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentFolderResponse
        /// </returns>
        public CreateExperimentFolderResponse CreateExperimentFolderWithOptions(CreateExperimentFolderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFolderId))
            {
                body["ParentFolderId"] = request.ParentFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExperimentFolder",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentfolders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExperimentFolderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建算法文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentFolderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentFolderResponse
        /// </returns>
        public async Task<CreateExperimentFolderResponse> CreateExperimentFolderWithOptionsAsync(CreateExperimentFolderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFolderId))
            {
                body["ParentFolderId"] = request.ParentFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExperimentFolder",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentfolders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExperimentFolderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建算法文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentFolderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentFolderResponse
        /// </returns>
        public CreateExperimentFolderResponse CreateExperimentFolder(CreateExperimentFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateExperimentFolderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建算法文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentFolderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentFolderResponse
        /// </returns>
        public async Task<CreateExperimentFolderResponse> CreateExperimentFolderAsync(CreateExperimentFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateExperimentFolderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验实验是否能迁移</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentMigrateValidationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentMigrateValidationResponse
        /// </returns>
        public CreateExperimentMigrateValidationResponse CreateExperimentMigrateValidationWithOptions(CreateExperimentMigrateValidationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceExpId))
            {
                query["SourceExpId"] = request.SourceExpId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExperimentMigrateValidation",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/migrate/experimentvalidation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExperimentMigrateValidationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验实验是否能迁移</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentMigrateValidationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentMigrateValidationResponse
        /// </returns>
        public async Task<CreateExperimentMigrateValidationResponse> CreateExperimentMigrateValidationWithOptionsAsync(CreateExperimentMigrateValidationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceExpId))
            {
                query["SourceExpId"] = request.SourceExpId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExperimentMigrateValidation",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/migrate/experimentvalidation",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExperimentMigrateValidationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验实验是否能迁移</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentMigrateValidationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentMigrateValidationResponse
        /// </returns>
        public CreateExperimentMigrateValidationResponse CreateExperimentMigrateValidation(CreateExperimentMigrateValidationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateExperimentMigrateValidationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验实验是否能迁移</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExperimentMigrateValidationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExperimentMigrateValidationResponse
        /// </returns>
        public async Task<CreateExperimentMigrateValidationResponse> CreateExperimentMigrateValidationAsync(CreateExperimentMigrateValidationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateExperimentMigrateValidationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个工作流的作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public CreateJobResponse CreateJobWithOptions(CreateJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteType))
            {
                body["ExecuteType"] = request.ExecuteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentId))
            {
                body["ExperimentId"] = request.ExperimentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineDraftId))
            {
                body["PipelineDraftId"] = request.PipelineDraftId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJob",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个工作流的作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public async Task<CreateJobResponse> CreateJobWithOptionsAsync(CreateJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteType))
            {
                body["ExecuteType"] = request.ExecuteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentId))
            {
                body["ExperimentId"] = request.ExperimentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                body["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineDraftId))
            {
                body["PipelineDraftId"] = request.PipelineDraftId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJob",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个工作流的作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public CreateJobResponse CreateJob(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一个工作流的作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public async Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实验</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExperimentResponse
        /// </returns>
        public DeleteExperimentResponse DeleteExperimentWithOptions(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperiment",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实验</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExperimentResponse
        /// </returns>
        public async Task<DeleteExperimentResponse> DeleteExperimentWithOptionsAsync(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperiment",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实验</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteExperimentResponse
        /// </returns>
        public DeleteExperimentResponse DeleteExperiment(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteExperimentWithOptions(ExperimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实验</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteExperimentResponse
        /// </returns>
        public async Task<DeleteExperimentResponse> DeleteExperimentAsync(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteExperimentWithOptionsAsync(ExperimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除算法文件夹</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExperimentFolderResponse
        /// </returns>
        public DeleteExperimentFolderResponse DeleteExperimentFolderWithOptions(string FolderId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperimentFolder",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentfolders/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FolderId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperimentFolderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除算法文件夹</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExperimentFolderResponse
        /// </returns>
        public async Task<DeleteExperimentFolderResponse> DeleteExperimentFolderWithOptionsAsync(string FolderId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExperimentFolder",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentfolders/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FolderId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExperimentFolderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除算法文件夹</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteExperimentFolderResponse
        /// </returns>
        public DeleteExperimentFolderResponse DeleteExperimentFolder(string FolderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteExperimentFolderWithOptions(FolderId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除算法文件夹</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteExperimentFolderResponse
        /// </returns>
        public async Task<DeleteExperimentFolderResponse> DeleteExperimentFolderAsync(string FolderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteExperimentFolderWithOptionsAsync(FolderId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取算法树</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlgoTreeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlgoTreeResponse
        /// </returns>
        public GetAlgoTreeResponse GetAlgoTreeWithOptions(GetAlgoTreeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlgoTree",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algo/tree",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlgoTreeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取算法树</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlgoTreeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlgoTreeResponse
        /// </returns>
        public async Task<GetAlgoTreeResponse> GetAlgoTreeWithOptionsAsync(GetAlgoTreeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlgoTree",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algo/tree",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlgoTreeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取算法树</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlgoTreeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlgoTreeResponse
        /// </returns>
        public GetAlgoTreeResponse GetAlgoTree(GetAlgoTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAlgoTreeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取算法树</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlgoTreeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlgoTreeResponse
        /// </returns>
        public async Task<GetAlgoTreeResponse> GetAlgoTreeAsync(GetAlgoTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAlgoTreeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取算法定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlgorithmDefRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlgorithmDefResponse
        /// </returns>
        public GetAlgorithmDefResponse GetAlgorithmDefWithOptions(GetAlgorithmDefRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgoVersion))
            {
                query["AlgoVersion"] = request.AlgoVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["Provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["Signature"] = request.Signature;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlgorithmDef",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithm/def",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlgorithmDefResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取算法定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlgorithmDefRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlgorithmDefResponse
        /// </returns>
        public async Task<GetAlgorithmDefResponse> GetAlgorithmDefWithOptionsAsync(GetAlgorithmDefRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlgoVersion))
            {
                query["AlgoVersion"] = request.AlgoVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["Provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["Signature"] = request.Signature;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlgorithmDef",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithm/def",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlgorithmDefResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取算法定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlgorithmDefRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlgorithmDefResponse
        /// </returns>
        public GetAlgorithmDefResponse GetAlgorithmDef(GetAlgorithmDefRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAlgorithmDefWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取算法定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlgorithmDefRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlgorithmDefResponse
        /// </returns>
        public async Task<GetAlgorithmDefResponse> GetAlgorithmDefAsync(GetAlgorithmDefRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAlgorithmDefWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取算法定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlgorithmDefsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlgorithmDefsResponse
        /// </returns>
        public GetAlgorithmDefsResponse GetAlgorithmDefsWithOptions(GetAlgorithmDefsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LatestTimestamp))
            {
                query["LatestTimestamp"] = request.LatestTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RangeEnd))
            {
                query["RangeEnd"] = request.RangeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RangeStart))
            {
                query["RangeStart"] = request.RangeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                query["Timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlgorithmDefs",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithm/defs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlgorithmDefsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取算法定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlgorithmDefsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlgorithmDefsResponse
        /// </returns>
        public async Task<GetAlgorithmDefsResponse> GetAlgorithmDefsWithOptionsAsync(GetAlgorithmDefsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LatestTimestamp))
            {
                query["LatestTimestamp"] = request.LatestTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RangeEnd))
            {
                query["RangeEnd"] = request.RangeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RangeStart))
            {
                query["RangeStart"] = request.RangeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamp))
            {
                query["Timestamp"] = request.Timestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlgorithmDefs",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithm/defs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlgorithmDefsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取算法定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlgorithmDefsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlgorithmDefsResponse
        /// </returns>
        public GetAlgorithmDefsResponse GetAlgorithmDefs(GetAlgorithmDefsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAlgorithmDefsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量获取算法定义</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlgorithmDefsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlgorithmDefsResponse
        /// </returns>
        public async Task<GetAlgorithmDefsResponse> GetAlgorithmDefsAsync(GetAlgorithmDefsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAlgorithmDefsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取算法树</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlgorithmTreeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlgorithmTreeResponse
        /// </returns>
        public GetAlgorithmTreeResponse GetAlgorithmTreeWithOptions(GetAlgorithmTreeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlgorithmTree",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithm/tree",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlgorithmTreeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取算法树</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlgorithmTreeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlgorithmTreeResponse
        /// </returns>
        public async Task<GetAlgorithmTreeResponse> GetAlgorithmTreeWithOptionsAsync(GetAlgorithmTreeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlgorithmTree",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/algorithm/tree",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlgorithmTreeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取算法树</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlgorithmTreeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlgorithmTreeResponse
        /// </returns>
        public GetAlgorithmTreeResponse GetAlgorithmTree(GetAlgorithmTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAlgorithmTreeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取算法树</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlgorithmTreeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlgorithmTreeResponse
        /// </returns>
        public async Task<GetAlgorithmTreeResponse> GetAlgorithmTreeAsync(GetAlgorithmTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAlgorithmTreeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentResponse
        /// </returns>
        public GetExperimentResponse GetExperimentWithOptions(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperiment",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentResponse
        /// </returns>
        public async Task<GetExperimentResponse> GetExperimentWithOptionsAsync(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperiment",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetExperimentResponse
        /// </returns>
        public GetExperimentResponse GetExperiment(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExperimentWithOptions(ExperimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetExperimentResponse
        /// </returns>
        public async Task<GetExperimentResponse> GetExperimentAsync(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExperimentWithOptionsAsync(ExperimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取算法文件夹下的内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentFolderChildrenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentFolderChildrenResponse
        /// </returns>
        public GetExperimentFolderChildrenResponse GetExperimentFolderChildrenWithOptions(string FolderId, GetExperimentFolderChildrenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                query["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyFolder))
            {
                query["OnlyFolder"] = request.OnlyFolder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperimentFolderChildren",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentfolders/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FolderId) + "/children",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentFolderChildrenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取算法文件夹下的内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentFolderChildrenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentFolderChildrenResponse
        /// </returns>
        public async Task<GetExperimentFolderChildrenResponse> GetExperimentFolderChildrenWithOptionsAsync(string FolderId, GetExperimentFolderChildrenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                query["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyFolder))
            {
                query["OnlyFolder"] = request.OnlyFolder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperimentFolderChildren",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentfolders/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FolderId) + "/children",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentFolderChildrenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取算法文件夹下的内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentFolderChildrenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentFolderChildrenResponse
        /// </returns>
        public GetExperimentFolderChildrenResponse GetExperimentFolderChildren(string FolderId, GetExperimentFolderChildrenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExperimentFolderChildrenWithOptions(FolderId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取算法文件夹下的内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentFolderChildrenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentFolderChildrenResponse
        /// </returns>
        public async Task<GetExperimentFolderChildrenResponse> GetExperimentFolderChildrenAsync(string FolderId, GetExperimentFolderChildrenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExperimentFolderChildrenWithOptionsAsync(FolderId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验的元信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentMetaResponse
        /// </returns>
        public GetExperimentMetaResponse GetExperimentMetaWithOptions(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperimentMeta",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/meta",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentMetaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验的元信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentMetaResponse
        /// </returns>
        public async Task<GetExperimentMetaResponse> GetExperimentMetaWithOptionsAsync(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperimentMeta",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/meta",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验的元信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetExperimentMetaResponse
        /// </returns>
        public GetExperimentMetaResponse GetExperimentMeta(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExperimentMetaWithOptions(ExperimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验的元信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetExperimentMetaResponse
        /// </returns>
        public async Task<GetExperimentMetaResponse> GetExperimentMetaAsync(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExperimentMetaWithOptionsAsync(ExperimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验以及实验节点的状态</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentStatusResponse
        /// </returns>
        public GetExperimentStatusResponse GetExperimentStatusWithOptions(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperimentStatus",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验以及实验节点的状态</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentStatusResponse
        /// </returns>
        public async Task<GetExperimentStatusResponse> GetExperimentStatusWithOptionsAsync(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperimentStatus",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验以及实验节点的状态</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetExperimentStatusResponse
        /// </returns>
        public GetExperimentStatusResponse GetExperimentStatus(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExperimentStatusWithOptions(ExperimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验以及实验节点的状态</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetExperimentStatusResponse
        /// </returns>
        public async Task<GetExperimentStatusResponse> GetExperimentStatusAsync(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExperimentStatusWithOptionsAsync(ExperimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实验的可视化meta</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentVisualizationMetaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentVisualizationMetaResponse
        /// </returns>
        public GetExperimentVisualizationMetaResponse GetExperimentVisualizationMetaWithOptions(string ExperimentId, GetExperimentVisualizationMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                query["NodeIds"] = request.NodeIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperimentVisualizationMeta",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/visualizationMeta",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentVisualizationMetaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实验的可视化meta</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentVisualizationMetaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentVisualizationMetaResponse
        /// </returns>
        public async Task<GetExperimentVisualizationMetaResponse> GetExperimentVisualizationMetaWithOptionsAsync(string ExperimentId, GetExperimentVisualizationMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                query["NodeIds"] = request.NodeIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperimentVisualizationMeta",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/visualizationMeta",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentVisualizationMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实验的可视化meta</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentVisualizationMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentVisualizationMetaResponse
        /// </returns>
        public GetExperimentVisualizationMetaResponse GetExperimentVisualizationMeta(string ExperimentId, GetExperimentVisualizationMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExperimentVisualizationMetaWithOptions(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实验的可视化meta</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentVisualizationMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentVisualizationMetaResponse
        /// </returns>
        public async Task<GetExperimentVisualizationMetaResponse> GetExperimentVisualizationMetaAsync(string ExperimentId, GetExperimentVisualizationMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExperimentVisualizationMetaWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验的统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentsStatisticsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentsStatisticsResponse
        /// </returns>
        public GetExperimentsStatisticsResponse GetExperimentsStatisticsWithOptions(GetExperimentsStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["WorkspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperimentsStatistics",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/statistics/experiments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentsStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验的统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentsStatisticsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentsStatisticsResponse
        /// </returns>
        public async Task<GetExperimentsStatisticsResponse> GetExperimentsStatisticsWithOptionsAsync(GetExperimentsStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceIds))
            {
                query["WorkspaceIds"] = request.WorkspaceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperimentsStatistics",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/statistics/experiments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentsStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验的统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentsStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentsStatisticsResponse
        /// </returns>
        public GetExperimentsStatisticsResponse GetExperimentsStatistics(GetExperimentsStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExperimentsStatisticsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验的统计信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentsStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentsStatisticsResponse
        /// </returns>
        public async Task<GetExperimentsStatisticsResponse> GetExperimentsStatisticsAsync(GetExperimentsStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExperimentsStatisticsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验或文件夹所有者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentsUsersStatisticsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentsUsersStatisticsResponse
        /// </returns>
        public GetExperimentsUsersStatisticsResponse GetExperimentsUsersStatisticsWithOptions(GetExperimentsUsersStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperimentsUsersStatistics",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/statistics/experimentsusers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentsUsersStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验或文件夹所有者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentsUsersStatisticsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentsUsersStatisticsResponse
        /// </returns>
        public async Task<GetExperimentsUsersStatisticsResponse> GetExperimentsUsersStatisticsWithOptionsAsync(GetExperimentsUsersStatisticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExperimentsUsersStatistics",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/statistics/experimentsusers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExperimentsUsersStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验或文件夹所有者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentsUsersStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentsUsersStatisticsResponse
        /// </returns>
        public GetExperimentsUsersStatisticsResponse GetExperimentsUsersStatistics(GetExperimentsUsersStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExperimentsUsersStatisticsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验或文件夹所有者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExperimentsUsersStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExperimentsUsersStatisticsResponse
        /// </returns>
        public async Task<GetExperimentsUsersStatisticsResponse> GetExperimentsUsersStatisticsAsync(GetExperimentsUsersStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExperimentsUsersStatisticsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个PAI Studio作业详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobResponse
        /// </returns>
        public GetJobResponse GetJobWithOptions(string JobId, GetJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJob",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个PAI Studio作业详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobResponse
        /// </returns>
        public async Task<GetJobResponse> GetJobWithOptionsAsync(string JobId, GetJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJob",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个PAI Studio作业详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobResponse
        /// </returns>
        public GetJobResponse GetJob(string JobId, GetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetJobWithOptions(JobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个PAI Studio作业详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobResponse
        /// </returns>
        public async Task<GetJobResponse> GetJobAsync(string JobId, GetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetJobWithOptionsAsync(JobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取MaxCompute表schema</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMCTableSchemaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMCTableSchemaResponse
        /// </returns>
        public GetMCTableSchemaResponse GetMCTableSchemaWithOptions(string TableName, GetMCTableSchemaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMCTableSchema",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasources/maxcompute/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableName) + "/schema",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMCTableSchemaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取MaxCompute表schema</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMCTableSchemaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMCTableSchemaResponse
        /// </returns>
        public async Task<GetMCTableSchemaResponse> GetMCTableSchemaWithOptionsAsync(string TableName, GetMCTableSchemaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMCTableSchema",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasources/maxcompute/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableName) + "/schema",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMCTableSchemaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取MaxCompute表schema</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMCTableSchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMCTableSchemaResponse
        /// </returns>
        public GetMCTableSchemaResponse GetMCTableSchema(string TableName, GetMCTableSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMCTableSchemaWithOptions(TableName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取MaxCompute表schema</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMCTableSchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMCTableSchemaResponse
        /// </returns>
        public async Task<GetMCTableSchemaResponse> GetMCTableSchemaAsync(string TableName, GetMCTableSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMCTableSchemaWithOptionsAsync(TableName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验节点输入桩的输入表的格式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeInputSchemaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNodeInputSchemaResponse
        /// </returns>
        public GetNodeInputSchemaResponse GetNodeInputSchemaWithOptions(string ExperimentId, string NodeId, GetNodeInputSchemaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputId))
            {
                query["InputId"] = request.InputId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputIndex))
            {
                query["InputIndex"] = request.InputIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeInputSchema",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/nodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodeId) + "/schema",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeInputSchemaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验节点输入桩的输入表的格式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeInputSchemaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNodeInputSchemaResponse
        /// </returns>
        public async Task<GetNodeInputSchemaResponse> GetNodeInputSchemaWithOptionsAsync(string ExperimentId, string NodeId, GetNodeInputSchemaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputId))
            {
                query["InputId"] = request.InputId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputIndex))
            {
                query["InputIndex"] = request.InputIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeInputSchema",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/nodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodeId) + "/schema",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeInputSchemaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验节点输入桩的输入表的格式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeInputSchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNodeInputSchemaResponse
        /// </returns>
        public GetNodeInputSchemaResponse GetNodeInputSchema(string ExperimentId, string NodeId, GetNodeInputSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetNodeInputSchemaWithOptions(ExperimentId, NodeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验节点输入桩的输入表的格式</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeInputSchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNodeInputSchemaResponse
        /// </returns>
        public async Task<GetNodeInputSchemaResponse> GetNodeInputSchemaAsync(string ExperimentId, string NodeId, GetNodeInputSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetNodeInputSchemaWithOptionsAsync(ExperimentId, NodeId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某个节点的输出模型信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeOutputRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNodeOutputResponse
        /// </returns>
        public GetNodeOutputResponse GetNodeOutputWithOptions(string ExperimentId, string NodeId, string OutputId, GetNodeOutputRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputIndex))
            {
                query["OutputIndex"] = request.OutputIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeOutput",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/nodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodeId) + "/outputs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(OutputId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeOutputResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某个节点的输出模型信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeOutputRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNodeOutputResponse
        /// </returns>
        public async Task<GetNodeOutputResponse> GetNodeOutputWithOptionsAsync(string ExperimentId, string NodeId, string OutputId, GetNodeOutputRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputIndex))
            {
                query["OutputIndex"] = request.OutputIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeOutput",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/nodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodeId) + "/outputs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(OutputId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeOutputResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某个节点的输出模型信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeOutputRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNodeOutputResponse
        /// </returns>
        public GetNodeOutputResponse GetNodeOutput(string ExperimentId, string NodeId, string OutputId, GetNodeOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetNodeOutputWithOptions(ExperimentId, NodeId, OutputId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某个节点的输出模型信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeOutputRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNodeOutputResponse
        /// </returns>
        public async Task<GetNodeOutputResponse> GetNodeOutputAsync(string ExperimentId, string NodeId, string OutputId, GetNodeOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetNodeOutputWithOptionsAsync(ExperimentId, NodeId, OutputId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取PAI Studio中指定模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public GetTemplateResponse GetTemplateWithOptions(string TemplateId, GetTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取PAI Studio中指定模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public async Task<GetTemplateResponse> GetTemplateWithOptionsAsync(string TemplateId, GetTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemplate",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取PAI Studio中指定模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public GetTemplateResponse GetTemplate(string TemplateId, GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTemplateWithOptions(TemplateId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取PAI Studio中指定模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemplateResponse
        /// </returns>
        public async Task<GetTemplateResponse> GetTemplateAsync(string TemplateId, GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTemplateWithOptionsAsync(TemplateId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取授权角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuthRolesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthRolesResponse
        /// </returns>
        public ListAuthRolesResponse ListAuthRolesWithOptions(ListAuthRolesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsGenerateToken))
            {
                query["IsGenerateToken"] = request.IsGenerateToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthRoles",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/authorization/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthRolesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取授权角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuthRolesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthRolesResponse
        /// </returns>
        public async Task<ListAuthRolesResponse> ListAuthRolesWithOptionsAsync(ListAuthRolesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsGenerateToken))
            {
                query["IsGenerateToken"] = request.IsGenerateToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthRoles",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/authorization/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取授权角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuthRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthRolesResponse
        /// </returns>
        public ListAuthRolesResponse ListAuthRoles(ListAuthRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAuthRolesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取授权角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuthRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthRolesResponse
        /// </returns>
        public async Task<ListAuthRolesResponse> ListAuthRolesAsync(ListAuthRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAuthRolesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExperimentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExperimentsResponse
        /// </returns>
        public ListExperimentsResponse ListExperimentsWithOptions(ListExperimentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentId))
            {
                query["ExperimentId"] = request.ExperimentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExperiments",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExperimentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExperimentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExperimentsResponse
        /// </returns>
        public async Task<ListExperimentsResponse> ListExperimentsWithOptionsAsync(ListExperimentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentId))
            {
                query["ExperimentId"] = request.ExperimentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExperiments",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExperimentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExperimentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExperimentsResponse
        /// </returns>
        public ListExperimentsResponse ListExperiments(ListExperimentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListExperimentsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实验列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExperimentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExperimentsResponse
        /// </returns>
        public async Task<ListExperimentsResponse> ListExperimentsAsync(ListExperimentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListExperimentsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImageLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListImageLabelsResponse
        /// </returns>
        public ListImageLabelsResponse ListImageLabelsWithOptions(ListImageLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelFilter))
            {
                query["LabelFilter"] = request.LabelFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKeys))
            {
                query["LabelKeys"] = request.LabelKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImageLabels",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/image/labels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImageLabelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImageLabelsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListImageLabelsResponse
        /// </returns>
        public async Task<ListImageLabelsResponse> ListImageLabelsWithOptionsAsync(ListImageLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelFilter))
            {
                query["LabelFilter"] = request.LabelFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelKeys))
            {
                query["LabelKeys"] = request.LabelKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImageLabels",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/image/labels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImageLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImageLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListImageLabelsResponse
        /// </returns>
        public ListImageLabelsResponse ListImageLabels(ListImageLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListImageLabelsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImageLabelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListImageLabelsResponse
        /// </returns>
        public async Task<ListImageLabelsResponse> ListImageLabelsAsync(ListImageLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListImageLabelsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举已注册镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImagesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListImagesResponse
        /// </returns>
        public ListImagesResponse ListImagesWithOptions(ListImagesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImages",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/images",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImagesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举已注册镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImagesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListImagesResponse
        /// </returns>
        public async Task<ListImagesResponse> ListImagesWithOptionsAsync(ListImagesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImages",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/images",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举已注册镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListImagesResponse
        /// </returns>
        public ListImagesResponse ListImages(ListImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListImagesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举已注册镜像</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListImagesResponse
        /// </returns>
        public async Task<ListImagesResponse> ListImagesAsync(ListImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListImagesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取作业详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public ListJobsResponse ListJobsWithOptions(ListJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentId))
            {
                query["ExperimentId"] = request.ExperimentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取作业详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public async Task<ListJobsResponse> ListJobsWithOptionsAsync(ListJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExperimentId))
            {
                query["ExperimentId"] = request.ExperimentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取作业详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public ListJobsResponse ListJobs(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListJobsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取作业详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListJobsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某个节点的输出模型列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNodeOutputsResponse
        /// </returns>
        public ListNodeOutputsResponse ListNodeOutputsWithOptions(string ExperimentId, string NodeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodeOutputs",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/nodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodeId) + "/outputs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodeOutputsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某个节点的输出模型列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNodeOutputsResponse
        /// </returns>
        public async Task<ListNodeOutputsResponse> ListNodeOutputsWithOptionsAsync(string ExperimentId, string NodeId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodeOutputs",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/nodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodeId) + "/outputs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodeOutputsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某个节点的输出模型列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListNodeOutputsResponse
        /// </returns>
        public ListNodeOutputsResponse ListNodeOutputs(string ExperimentId, string NodeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListNodeOutputsWithOptions(ExperimentId, NodeId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取某个节点的输出模型列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListNodeOutputsResponse
        /// </returns>
        public async Task<ListNodeOutputsResponse> ListNodeOutputsAsync(string ExperimentId, string NodeId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListNodeOutputsWithOptionsAsync(ExperimentId, NodeId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近的实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecentExperimentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRecentExperimentsResponse
        /// </returns>
        public ListRecentExperimentsResponse ListRecentExperimentsWithOptions(ListRecentExperimentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecentExperiments",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/recentexperiments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecentExperimentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近的实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecentExperimentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRecentExperimentsResponse
        /// </returns>
        public async Task<ListRecentExperimentsResponse> ListRecentExperimentsWithOptionsAsync(ListRecentExperimentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRecentExperiments",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/recentexperiments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRecentExperimentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近的实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecentExperimentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRecentExperimentsResponse
        /// </returns>
        public ListRecentExperimentsResponse ListRecentExperiments(ListRecentExperimentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRecentExperimentsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取最近的实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRecentExperimentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRecentExperimentsResponse
        /// </returns>
        public async Task<ListRecentExperimentsResponse> ListRecentExperimentsAsync(ListRecentExperimentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRecentExperimentsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取PAI Studio中指定模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public ListTemplatesResponse ListTemplatesWithOptions(ListTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.List))
            {
                query["List"] = request.List;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                query["TagId"] = request.TagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeId))
            {
                query["TypeId"] = request.TypeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplates",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取PAI Studio中指定模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public async Task<ListTemplatesResponse> ListTemplatesWithOptionsAsync(ListTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.List))
            {
                query["List"] = request.List;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                query["TagId"] = request.TagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["TemplateType"] = request.TemplateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeId))
            {
                query["TypeId"] = request.TypeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplates",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取PAI Studio中指定模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTemplatesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取PAI Studio中指定模板列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTemplatesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>迁移PAI Studio 1.0的实验目录 </para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MigrateExperimentFoldersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MigrateExperimentFoldersResponse
        /// </returns>
        public MigrateExperimentFoldersResponse MigrateExperimentFoldersWithOptions(MigrateExperimentFoldersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                query["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOwner))
            {
                query["IsOwner"] = request.IsOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateExperimentFolders",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/migrate/folders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateExperimentFoldersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>迁移PAI Studio 1.0的实验目录 </para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MigrateExperimentFoldersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MigrateExperimentFoldersResponse
        /// </returns>
        public async Task<MigrateExperimentFoldersResponse> MigrateExperimentFoldersWithOptionsAsync(MigrateExperimentFoldersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                query["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOwner))
            {
                query["IsOwner"] = request.IsOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateExperimentFolders",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/migrate/folders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateExperimentFoldersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>迁移PAI Studio 1.0的实验目录 </para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MigrateExperimentFoldersRequest
        /// </param>
        /// 
        /// <returns>
        /// MigrateExperimentFoldersResponse
        /// </returns>
        public MigrateExperimentFoldersResponse MigrateExperimentFolders(MigrateExperimentFoldersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MigrateExperimentFoldersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>迁移PAI Studio 1.0的实验目录 </para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MigrateExperimentFoldersRequest
        /// </param>
        /// 
        /// <returns>
        /// MigrateExperimentFoldersResponse
        /// </returns>
        public async Task<MigrateExperimentFoldersResponse> MigrateExperimentFoldersAsync(MigrateExperimentFoldersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MigrateExperimentFoldersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>迁移PAI Studio 1.0的实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MigrateExperimentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MigrateExperimentsResponse
        /// </returns>
        public MigrateExperimentsResponse MigrateExperimentsWithOptions(MigrateExperimentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                query["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestFolderId))
            {
                query["DestFolderId"] = request.DestFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOwner))
            {
                query["IsOwner"] = request.IsOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceExpId))
            {
                query["SourceExpId"] = request.SourceExpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateIfExists))
            {
                query["UpdateIfExists"] = request.UpdateIfExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateExperiments",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/migrate/experiments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateExperimentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>迁移PAI Studio 1.0的实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MigrateExperimentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MigrateExperimentsResponse
        /// </returns>
        public async Task<MigrateExperimentsResponse> MigrateExperimentsWithOptionsAsync(MigrateExperimentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                query["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestFolderId))
            {
                query["DestFolderId"] = request.DestFolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOwner))
            {
                query["IsOwner"] = request.IsOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceExpId))
            {
                query["SourceExpId"] = request.SourceExpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateIfExists))
            {
                query["UpdateIfExists"] = request.UpdateIfExists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateExperiments",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/migrate/experiments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateExperimentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>迁移PAI Studio 1.0的实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MigrateExperimentsRequest
        /// </param>
        /// 
        /// <returns>
        /// MigrateExperimentsResponse
        /// </returns>
        public MigrateExperimentsResponse MigrateExperiments(MigrateExperimentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MigrateExperimentsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>迁移PAI Studio 1.0的实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MigrateExperimentsRequest
        /// </param>
        /// 
        /// <returns>
        /// MigrateExperimentsResponse
        /// </returns>
        public async Task<MigrateExperimentsResponse> MigrateExperimentsAsync(MigrateExperimentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MigrateExperimentsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览Maxcompute表数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreviewMCTableRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreviewMCTableResponse
        /// </returns>
        public PreviewMCTableResponse PreviewMCTableWithOptions(string TableName, PreviewMCTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                query["Endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partition))
            {
                query["Partition"] = request.Partition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewMCTable",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasources/maxcompute/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableName) + "/preview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewMCTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览Maxcompute表数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreviewMCTableRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreviewMCTableResponse
        /// </returns>
        public async Task<PreviewMCTableResponse> PreviewMCTableWithOptionsAsync(string TableName, PreviewMCTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                query["Endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partition))
            {
                query["Partition"] = request.Partition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewMCTable",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasources/maxcompute/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TableName) + "/preview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewMCTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览Maxcompute表数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreviewMCTableRequest
        /// </param>
        /// 
        /// <returns>
        /// PreviewMCTableResponse
        /// </returns>
        public PreviewMCTableResponse PreviewMCTable(string TableName, PreviewMCTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PreviewMCTableWithOptions(TableName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览Maxcompute表数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreviewMCTableRequest
        /// </param>
        /// 
        /// <returns>
        /// PreviewMCTableResponse
        /// </returns>
        public async Task<PreviewMCTableResponse> PreviewMCTableAsync(string TableName, PreviewMCTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PreviewMCTableWithOptionsAsync(TableName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishExperimentResponse
        /// </returns>
        public PublishExperimentResponse PublishExperimentWithOptions(string ExperimentId, PublishExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                body["FolderId"] = request.FolderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishExperiment",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/publish",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishExperimentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishExperimentResponse
        /// </returns>
        public async Task<PublishExperimentResponse> PublishExperimentWithOptionsAsync(string ExperimentId, PublishExperimentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                body["FolderId"] = request.FolderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishExperiment",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/publish",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishExperimentResponse
        /// </returns>
        public PublishExperimentResponse PublishExperiment(string ExperimentId, PublishExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishExperimentWithOptions(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布实验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishExperimentRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishExperimentResponse
        /// </returns>
        public async Task<PublishExperimentResponse> PublishExperimentAsync(string ExperimentId, PublishExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishExperimentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实验的可视化数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExperimentVisualizationDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryExperimentVisualizationDataResponse
        /// </returns>
        public QueryExperimentVisualizationDataResponse QueryExperimentVisualizationDataWithOptions(string ExperimentId, QueryExperimentVisualizationDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryExperimentVisualizationData",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/visualizationDataQuery",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryExperimentVisualizationDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实验的可视化数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExperimentVisualizationDataRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryExperimentVisualizationDataResponse
        /// </returns>
        public async Task<QueryExperimentVisualizationDataResponse> QueryExperimentVisualizationDataWithOptionsAsync(string ExperimentId, QueryExperimentVisualizationDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryExperimentVisualizationData",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/visualizationDataQuery",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryExperimentVisualizationDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实验的可视化数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExperimentVisualizationDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryExperimentVisualizationDataResponse
        /// </returns>
        public QueryExperimentVisualizationDataResponse QueryExperimentVisualizationData(string ExperimentId, QueryExperimentVisualizationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryExperimentVisualizationDataWithOptions(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询实验的可视化数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExperimentVisualizationDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryExperimentVisualizationDataResponse
        /// </returns>
        public async Task<QueryExperimentVisualizationDataResponse> QueryExperimentVisualizationDataAsync(string ExperimentId, QueryExperimentVisualizationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryExperimentVisualizationDataWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索MaxCompute表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMCTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchMCTablesResponse
        /// </returns>
        public SearchMCTablesResponse SearchMCTablesWithOptions(SearchMCTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchMCTables",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasources/maxcompute/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchMCTablesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索MaxCompute表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMCTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchMCTablesResponse
        /// </returns>
        public async Task<SearchMCTablesResponse> SearchMCTablesWithOptionsAsync(SearchMCTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchMCTables",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/datasources/maxcompute/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchMCTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索MaxCompute表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMCTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchMCTablesResponse
        /// </returns>
        public SearchMCTablesResponse SearchMCTables(SearchMCTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchMCTablesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索MaxCompute表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchMCTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchMCTablesResponse
        /// </returns>
        public async Task<SearchMCTablesResponse> SearchMCTablesAsync(SearchMCTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchMCTablesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止实验所有运行中的作业</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopExperimentResponse
        /// </returns>
        public StopExperimentResponse StopExperimentWithOptions(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopExperiment",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopExperimentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止实验所有运行中的作业</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopExperimentResponse
        /// </returns>
        public async Task<StopExperimentResponse> StopExperimentWithOptionsAsync(string ExperimentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopExperiment",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopExperimentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止实验所有运行中的作业</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopExperimentResponse
        /// </returns>
        public StopExperimentResponse StopExperiment(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopExperimentWithOptions(ExperimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止实验所有运行中的作业</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopExperimentResponse
        /// </returns>
        public async Task<StopExperimentResponse> StopExperimentAsync(string ExperimentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopExperimentWithOptionsAsync(ExperimentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止一个实验的作业</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopJobResponse
        /// </returns>
        public StopJobResponse StopJobWithOptions(string JobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopJob",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止一个实验的作业</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopJobResponse
        /// </returns>
        public async Task<StopJobResponse> StopJobWithOptionsAsync(string JobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopJob",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(JobId) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止一个实验的作业</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopJobResponse
        /// </returns>
        public StopJobResponse StopJob(string JobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopJobWithOptions(JobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>停止一个实验的作业</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopJobResponse
        /// </returns>
        public async Task<StopJobResponse> StopJobAsync(string JobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopJobWithOptionsAsync(JobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实验内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentContentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentContentResponse
        /// </returns>
        public UpdateExperimentContentResponse UpdateExperimentContentWithOptions(string ExperimentId, UpdateExperimentContentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperimentContent",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/content",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentContentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实验内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentContentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentContentResponse
        /// </returns>
        public async Task<UpdateExperimentContentResponse> UpdateExperimentContentWithOptionsAsync(string ExperimentId, UpdateExperimentContentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperimentContent",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/content",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentContentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实验内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentContentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentContentResponse
        /// </returns>
        public UpdateExperimentContentResponse UpdateExperimentContent(string ExperimentId, UpdateExperimentContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExperimentContentWithOptions(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实验内容</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentContentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentContentResponse
        /// </returns>
        public async Task<UpdateExperimentContentResponse> UpdateExperimentContentAsync(string ExperimentId, UpdateExperimentContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExperimentContentWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新算法文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentFolderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentFolderResponse
        /// </returns>
        public UpdateExperimentFolderResponse UpdateExperimentFolderWithOptions(string FolderId, UpdateExperimentFolderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFolderId))
            {
                body["ParentFolderId"] = request.ParentFolderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperimentFolder",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentfolders/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FolderId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentFolderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新算法文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentFolderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentFolderResponse
        /// </returns>
        public async Task<UpdateExperimentFolderResponse> UpdateExperimentFolderWithOptionsAsync(string FolderId, UpdateExperimentFolderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentFolderId))
            {
                body["ParentFolderId"] = request.ParentFolderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperimentFolder",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experimentfolders/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(FolderId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentFolderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新算法文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentFolderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentFolderResponse
        /// </returns>
        public UpdateExperimentFolderResponse UpdateExperimentFolder(string FolderId, UpdateExperimentFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExperimentFolderWithOptions(FolderId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新算法文件夹</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentFolderRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentFolderResponse
        /// </returns>
        public async Task<UpdateExperimentFolderResponse> UpdateExperimentFolderAsync(string FolderId, UpdateExperimentFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExperimentFolderWithOptionsAsync(FolderId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实验的Meta信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentMetaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentMetaResponse
        /// </returns>
        public UpdateExperimentMetaResponse UpdateExperimentMetaWithOptions(string ExperimentId, UpdateExperimentMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                body["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperimentMeta",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/meta",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentMetaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实验的Meta信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentMetaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentMetaResponse
        /// </returns>
        public async Task<UpdateExperimentMetaResponse> UpdateExperimentMetaWithOptionsAsync(string ExperimentId, UpdateExperimentMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Accessibility))
            {
                body["Accessibility"] = request.Accessibility;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                body["FolderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExperimentMeta",
                Version = "2021-02-02",
                Protocol = "HTTPS",
                Pathname = "/api/v1/experiments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ExperimentId) + "/meta",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExperimentMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实验的Meta信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentMetaResponse
        /// </returns>
        public UpdateExperimentMetaResponse UpdateExperimentMeta(string ExperimentId, UpdateExperimentMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExperimentMetaWithOptions(ExperimentId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新实验的Meta信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExperimentMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExperimentMetaResponse
        /// </returns>
        public async Task<UpdateExperimentMetaResponse> UpdateExperimentMetaAsync(string ExperimentId, UpdateExperimentMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExperimentMetaWithOptionsAsync(ExperimentId, request, headers, runtime);
        }

    }
}
