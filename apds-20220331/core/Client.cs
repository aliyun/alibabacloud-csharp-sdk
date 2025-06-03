// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Apds20220331.Models;

namespace AlibabaCloud.SDK.Apds20220331
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("apds", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>保存集群接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMigrationGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMigrationGroupResponse
        /// </returns>
        public CreateMigrationGroupResponse CreateMigrationGroupWithOptions(CreateMigrationGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMigrationGroup",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-group/save-migration-group",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMigrationGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存集群接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMigrationGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMigrationGroupResponse
        /// </returns>
        public async Task<CreateMigrationGroupResponse> CreateMigrationGroupWithOptionsAsync(CreateMigrationGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extra))
            {
                body["extra"] = request.Extra;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMigrationGroup",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-group/save-migration-group",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMigrationGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存集群接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMigrationGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMigrationGroupResponse
        /// </returns>
        public CreateMigrationGroupResponse CreateMigrationGroup(CreateMigrationGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMigrationGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存集群接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMigrationGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMigrationGroupResponse
        /// </returns>
        public async Task<CreateMigrationGroupResponse> CreateMigrationGroupAsync(CreateMigrationGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMigrationGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>写入同步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMigrationJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMigrationJobResponse
        /// </returns>
        public CreateMigrationJobResponse CreateMigrationJobWithOptions(CreateMigrationJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobList))
            {
                body["migrationJobList"] = request.MigrationJobList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMigrationJob",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-job/create-migration-jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMigrationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>写入同步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMigrationJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMigrationJobResponse
        /// </returns>
        public async Task<CreateMigrationJobResponse> CreateMigrationJobWithOptionsAsync(CreateMigrationJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MigrationJobList))
            {
                body["migrationJobList"] = request.MigrationJobList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMigrationJob",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-job/create-migration-jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMigrationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>写入同步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMigrationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMigrationJobResponse
        /// </returns>
        public CreateMigrationJobResponse CreateMigrationJob(CreateMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMigrationJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>写入同步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMigrationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMigrationJobResponse
        /// </returns>
        public async Task<CreateMigrationJobResponse> CreateMigrationJobAsync(CreateMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMigrationJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>南天门订单通知</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePayOrderCallbackRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePayOrderCallbackResponse
        /// </returns>
        public CreatePayOrderCallbackResponse CreatePayOrderCallbackWithOptions(CreatePayOrderCallbackRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["data"] = request.Data;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePayOrderCallback",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/sys/user/pop/api/v1/payOrderCallback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePayOrderCallbackResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>南天门订单通知</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePayOrderCallbackRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePayOrderCallbackResponse
        /// </returns>
        public async Task<CreatePayOrderCallbackResponse> CreatePayOrderCallbackWithOptionsAsync(CreatePayOrderCallbackRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["data"] = request.Data;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePayOrderCallback",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/sys/user/pop/api/v1/payOrderCallback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePayOrderCallbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>南天门订单通知</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePayOrderCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePayOrderCallbackResponse
        /// </returns>
        public CreatePayOrderCallbackResponse CreatePayOrderCallback(CreatePayOrderCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePayOrderCallbackWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>南天门订单通知</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePayOrderCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePayOrderCallbackResponse
        /// </returns>
        public async Task<CreatePayOrderCallbackResponse> CreatePayOrderCallbackAsync(CreatePayOrderCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePayOrderCallbackWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>退订</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRefundRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRefundResponse
        /// </returns>
        public CreateRefundResponse CreateRefundWithOptions(CreateRefundRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["data"] = request.Data;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRefund",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/sys/user/pop/api/v1/refund",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRefundResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>退订</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRefundRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRefundResponse
        /// </returns>
        public async Task<CreateRefundResponse> CreateRefundWithOptionsAsync(CreateRefundRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["data"] = request.Data;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRefund",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/sys/user/pop/api/v1/refund",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRefundResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>退订</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRefundRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRefundResponse
        /// </returns>
        public CreateRefundResponse CreateRefund(CreateRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRefundWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>退订</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRefundRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRefundResponse
        /// </returns>
        public async Task<CreateRefundResponse> CreateRefundAsync(CreateRefundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRefundWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSurveyJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSurveyJobResponse
        /// </returns>
        public CreateSurveyJobResponse CreateSurveyJobWithOptions(CreateSurveyJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ak))
            {
                body["ak"] = request.Ak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoConfirm))
            {
                body["autoConfirm"] = request.AutoConfirm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudType))
            {
                body["cloudType"] = request.CloudType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssObjectName))
            {
                body["ossObjectName"] = request.OssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypeList))
            {
                body["resourceTypeList"] = request.ResourceTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sk))
            {
                body["sk"] = request.Sk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Zone))
            {
                body["zone"] = request.Zone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSurveyJob",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/winback/add-survey-job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSurveyJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSurveyJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSurveyJobResponse
        /// </returns>
        public async Task<CreateSurveyJobResponse> CreateSurveyJobWithOptionsAsync(CreateSurveyJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ak))
            {
                body["ak"] = request.Ak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoConfirm))
            {
                body["autoConfirm"] = request.AutoConfirm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudType))
            {
                body["cloudType"] = request.CloudType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssObjectName))
            {
                body["ossObjectName"] = request.OssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypeList))
            {
                body["resourceTypeList"] = request.ResourceTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sk))
            {
                body["sk"] = request.Sk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Zone))
            {
                body["zone"] = request.Zone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSurveyJob",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/winback/add-survey-job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSurveyJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSurveyJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSurveyJobResponse
        /// </returns>
        public CreateSurveyJobResponse CreateSurveyJob(CreateSurveyJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSurveyJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSurveyJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSurveyJobResponse
        /// </returns>
        public async Task<CreateSurveyJobResponse> CreateSurveyJobAsync(CreateSurveyJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSurveyJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSurveyJobOfflineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSurveyJobOfflineResponse
        /// </returns>
        public CreateSurveyJobOfflineResponse CreateSurveyJobOfflineWithOptions(CreateSurveyJobOfflineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoConfirm))
            {
                body["autoConfirm"] = request.AutoConfirm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudType))
            {
                body["cloudType"] = request.CloudType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectName))
            {
                body["objectName"] = request.ObjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSurveyJobOffline",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/winback/add-import-survey-job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSurveyJobOfflineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSurveyJobOfflineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSurveyJobOfflineResponse
        /// </returns>
        public async Task<CreateSurveyJobOfflineResponse> CreateSurveyJobOfflineWithOptionsAsync(CreateSurveyJobOfflineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoConfirm))
            {
                body["autoConfirm"] = request.AutoConfirm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudType))
            {
                body["cloudType"] = request.CloudType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectName))
            {
                body["objectName"] = request.ObjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSurveyJobOffline",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/winback/add-import-survey-job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSurveyJobOfflineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSurveyJobOfflineRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSurveyJobOfflineResponse
        /// </returns>
        public CreateSurveyJobOfflineResponse CreateSurveyJobOffline(CreateSurveyJobOfflineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSurveyJobOfflineWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSurveyJobOfflineRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSurveyJobOfflineResponse
        /// </returns>
        public async Task<CreateSurveyJobOfflineResponse> CreateSurveyJobOfflineAsync(CreateSurveyJobOfflineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSurveyJobOfflineWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMigrationJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMigrationJobResponse
        /// </returns>
        public DeleteMigrationJobResponse DeleteMigrationJobWithOptions(DeleteMigrationJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMigrationJob",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-job/remove-migration-job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMigrationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMigrationJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMigrationJobResponse
        /// </returns>
        public async Task<DeleteMigrationJobResponse> DeleteMigrationJobWithOptionsAsync(DeleteMigrationJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMigrationJob",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-job/remove-migration-job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMigrationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMigrationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMigrationJobResponse
        /// </returns>
        public DeleteMigrationJobResponse DeleteMigrationJob(DeleteMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMigrationJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMigrationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMigrationJobResponse
        /// </returns>
        public async Task<DeleteMigrationJobResponse> DeleteMigrationJobAsync(DeleteMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMigrationJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据key删除oss文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOssFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOssFileResponse
        /// </returns>
        public DeleteOssFileResponse DeleteOssFileWithOptions(DeleteOssFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectName))
            {
                query["objectName"] = request.ObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOssFile",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/file-job/delete-file",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOssFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据key删除oss文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOssFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOssFileResponse
        /// </returns>
        public async Task<DeleteOssFileResponse> DeleteOssFileWithOptionsAsync(DeleteOssFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectName))
            {
                query["objectName"] = request.ObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOssFile",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/file-job/delete-file",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOssFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据key删除oss文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOssFileRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOssFileResponse
        /// </returns>
        public DeleteOssFileResponse DeleteOssFile(DeleteOssFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteOssFileWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据key删除oss文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOssFileRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOssFileResponse
        /// </returns>
        public async Task<DeleteOssFileResponse> DeleteOssFileAsync(DeleteOssFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteOssFileWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据id删除扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSurveyJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSurveyJobResponse
        /// </returns>
        public DeleteSurveyJobResponse DeleteSurveyJobWithOptions(DeleteSurveyJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSurveyJob",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/winback/delete-survey-job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSurveyJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据id删除扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSurveyJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSurveyJobResponse
        /// </returns>
        public async Task<DeleteSurveyJobResponse> DeleteSurveyJobWithOptionsAsync(DeleteSurveyJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSurveyJob",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/winback/delete-survey-job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSurveyJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据id删除扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSurveyJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSurveyJobResponse
        /// </returns>
        public DeleteSurveyJobResponse DeleteSurveyJob(DeleteSurveyJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSurveyJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据id删除扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSurveyJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSurveyJobResponse
        /// </returns>
        public async Task<DeleteSurveyJobResponse> DeleteSurveyJobAsync(DeleteSurveyJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSurveyJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发现-批量删除资源接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSurveyResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSurveyResourcesResponse
        /// </returns>
        public DeleteSurveyResourcesResponse DeleteSurveyResourcesWithOptions(DeleteSurveyResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["ids"] = request.Ids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSurveyResources",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/confirm-resource/destroy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSurveyResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发现-批量删除资源接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSurveyResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSurveyResourcesResponse
        /// </returns>
        public async Task<DeleteSurveyResourcesResponse> DeleteSurveyResourcesWithOptionsAsync(DeleteSurveyResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["ids"] = request.Ids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSurveyResources",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/confirm-resource/destroy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSurveyResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发现-批量删除资源接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSurveyResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSurveyResourcesResponse
        /// </returns>
        public DeleteSurveyResourcesResponse DeleteSurveyResources(DeleteSurveyResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSurveyResourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发现-批量删除资源接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSurveyResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSurveyResourcesResponse
        /// </returns>
        public async Task<DeleteSurveyResourcesResponse> DeleteSurveyResourcesAsync(DeleteSurveyResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSurveyResourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户维度同步任务的设置状态</para>
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
        /// DescribeMigrationJobConfigResponse
        /// </returns>
        public DescribeMigrationJobConfigResponse DescribeMigrationJobConfigWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMigrationJobConfig",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-job/describe-migration-job-config",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMigrationJobConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户维度同步任务的设置状态</para>
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
        /// DescribeMigrationJobConfigResponse
        /// </returns>
        public async Task<DescribeMigrationJobConfigResponse> DescribeMigrationJobConfigWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMigrationJobConfig",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-job/describe-migration-job-config",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMigrationJobConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户维度同步任务的设置状态</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeMigrationJobConfigResponse
        /// </returns>
        public DescribeMigrationJobConfigResponse DescribeMigrationJobConfig()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeMigrationJobConfigWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户维度同步任务的设置状态</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeMigrationJobConfigResponse
        /// </returns>
        public async Task<DescribeMigrationJobConfigResponse> DescribeMigrationJobConfigAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeMigrationJobConfigWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询同步任务数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMigrationJobCountRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMigrationJobCountResponse
        /// </returns>
        public DescribeMigrationJobCountResponse DescribeMigrationJobCountWithOptions(DescribeMigrationJobCountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchTaskGroupId))
            {
                body["batchTaskGroupId"] = request.BatchTaskGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CutoverPlanId))
            {
                body["cutoverPlanId"] = request.CutoverPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSideId))
            {
                body["outSideId"] = request.OutSideId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SurveyResourceId))
            {
                body["surveyResourceId"] = request.SurveyResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                body["tagList"] = request.TagList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeList))
            {
                body["typeList"] = request.TypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedType))
            {
                body["usedType"] = request.UsedType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMigrationJobCount",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-job/count-migration-jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMigrationJobCountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询同步任务数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMigrationJobCountRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMigrationJobCountResponse
        /// </returns>
        public async Task<DescribeMigrationJobCountResponse> DescribeMigrationJobCountWithOptionsAsync(DescribeMigrationJobCountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchTaskGroupId))
            {
                body["batchTaskGroupId"] = request.BatchTaskGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CutoverPlanId))
            {
                body["cutoverPlanId"] = request.CutoverPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSideId))
            {
                body["outSideId"] = request.OutSideId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SurveyResourceId))
            {
                body["surveyResourceId"] = request.SurveyResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                body["tagList"] = request.TagList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeList))
            {
                body["typeList"] = request.TypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedType))
            {
                body["usedType"] = request.UsedType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMigrationJobCount",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-job/count-migration-jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMigrationJobCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询同步任务数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMigrationJobCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMigrationJobCountResponse
        /// </returns>
        public DescribeMigrationJobCountResponse DescribeMigrationJobCount(DescribeMigrationJobCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeMigrationJobCountWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询同步任务数量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMigrationJobCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMigrationJobCountResponse
        /// </returns>
        public async Task<DescribeMigrationJobCountResponse> DescribeMigrationJobCountAsync(DescribeMigrationJobCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeMigrationJobCountWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取临时授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOssStsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOssStsResponse
        /// </returns>
        public DescribeOssStsResponse DescribeOssStsWithOptions(DescribeOssStsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ak))
            {
                query["ak"] = request.Ak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudType))
            {
                query["cloudType"] = request.CloudType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sk))
            {
                query["sk"] = request.Sk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOssSts",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/file-job/sts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOssStsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取临时授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOssStsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOssStsResponse
        /// </returns>
        public async Task<DescribeOssStsResponse> DescribeOssStsWithOptionsAsync(DescribeOssStsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ak))
            {
                query["ak"] = request.Ak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudType))
            {
                query["cloudType"] = request.CloudType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sk))
            {
                query["sk"] = request.Sk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOssSts",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/file-job/sts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOssStsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取临时授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOssStsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeOssStsResponse
        /// </returns>
        public DescribeOssStsResponse DescribeOssSts(DescribeOssStsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeOssStsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取临时授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOssStsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeOssStsResponse
        /// </returns>
        public async Task<DescribeOssStsResponse> DescribeOssStsAsync(DescribeOssStsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeOssStsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据状态进行汇总</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSummaryByStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSummaryByStatusResponse
        /// </returns>
        public DescribeSummaryByStatusResponse DescribeSummaryByStatusWithOptions(DescribeSummaryByStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSummaryByStatus",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/summary/summary-by-status",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSummaryByStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据状态进行汇总</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSummaryByStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSummaryByStatusResponse
        /// </returns>
        public async Task<DescribeSummaryByStatusResponse> DescribeSummaryByStatusWithOptionsAsync(DescribeSummaryByStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSummaryByStatus",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/summary/summary-by-status",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSummaryByStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据状态进行汇总</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSummaryByStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSummaryByStatusResponse
        /// </returns>
        public DescribeSummaryByStatusResponse DescribeSummaryByStatus(DescribeSummaryByStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSummaryByStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据状态进行汇总</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSummaryByStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSummaryByStatusResponse
        /// </returns>
        public async Task<DescribeSummaryByStatusResponse> DescribeSummaryByStatusAsync(DescribeSummaryByStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSummaryByStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据状态和集群进行汇总</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSummaryByStatusAndGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSummaryByStatusAndGroupResponse
        /// </returns>
        public DescribeSummaryByStatusAndGroupResponse DescribeSummaryByStatusAndGroupWithOptions(DescribeSummaryByStatusAndGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSummaryByStatusAndGroup",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/summary/summary-by-status-and-region",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSummaryByStatusAndGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据状态和集群进行汇总</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSummaryByStatusAndGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSummaryByStatusAndGroupResponse
        /// </returns>
        public async Task<DescribeSummaryByStatusAndGroupResponse> DescribeSummaryByStatusAndGroupWithOptionsAsync(DescribeSummaryByStatusAndGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSummaryByStatusAndGroup",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/summary/summary-by-status-and-region",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSummaryByStatusAndGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据状态和集群进行汇总</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSummaryByStatusAndGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSummaryByStatusAndGroupResponse
        /// </returns>
        public DescribeSummaryByStatusAndGroupResponse DescribeSummaryByStatusAndGroup(DescribeSummaryByStatusAndGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSummaryByStatusAndGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据状态和集群进行汇总</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSummaryByStatusAndGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSummaryByStatusAndGroupResponse
        /// </returns>
        public async Task<DescribeSummaryByStatusAndGroupResponse> DescribeSummaryByStatusAndGroupAsync(DescribeSummaryByStatusAndGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSummaryByStatusAndGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSurveyJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSurveyJobResponse
        /// </returns>
        public DescribeSurveyJobResponse DescribeSurveyJobWithOptions(DescribeSurveyJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSurveyJob",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/winback/query-survey-job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSurveyJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSurveyJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSurveyJobResponse
        /// </returns>
        public async Task<DescribeSurveyJobResponse> DescribeSurveyJobWithOptionsAsync(DescribeSurveyJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSurveyJob",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/winback/query-survey-job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSurveyJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSurveyJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSurveyJobResponse
        /// </returns>
        public DescribeSurveyJobResponse DescribeSurveyJob(DescribeSurveyJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSurveyJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSurveyJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSurveyJobResponse
        /// </returns>
        public async Task<DescribeSurveyJobResponse> DescribeSurveyJobAsync(DescribeSurveyJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSurveyJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSurveyJobCountRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSurveyJobCountResponse
        /// </returns>
        public DescribeSurveyJobCountResponse DescribeSurveyJobCountWithOptions(DescribeSurveyJobCountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelList))
            {
                body["channelList"] = request.ChannelList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudTypeList))
            {
                body["cloudTypeList"] = request.CloudTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSurveyJobCount",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/winback/count-survey-job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSurveyJobCountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSurveyJobCountRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSurveyJobCountResponse
        /// </returns>
        public async Task<DescribeSurveyJobCountResponse> DescribeSurveyJobCountWithOptionsAsync(DescribeSurveyJobCountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelList))
            {
                body["channelList"] = request.ChannelList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudTypeList))
            {
                body["cloudTypeList"] = request.CloudTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSurveyJobCount",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/winback/count-survey-job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSurveyJobCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSurveyJobCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSurveyJobCountResponse
        /// </returns>
        public DescribeSurveyJobCountResponse DescribeSurveyJobCount(DescribeSurveyJobCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSurveyJobCountWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSurveyJobCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSurveyJobCountResponse
        /// </returns>
        public async Task<DescribeSurveyJobCountResponse> DescribeSurveyJobCountAsync(DescribeSurveyJobCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSurveyJobCountWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源标签信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSurveyResourceTagRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSurveyResourceTagResponse
        /// </returns>
        public DescribeSurveyResourceTagResponse DescribeSurveyResourceTagWithOptions(DescribeSurveyResourceTagRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUserIdList))
            {
                body["sourceUserIdList"] = request.SourceUserIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSurveyResourceTag",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/confirm-resource/get-resource-tag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSurveyResourceTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源标签信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSurveyResourceTagRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSurveyResourceTagResponse
        /// </returns>
        public async Task<DescribeSurveyResourceTagResponse> DescribeSurveyResourceTagWithOptionsAsync(DescribeSurveyResourceTagRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                body["scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceUserIdList))
            {
                body["sourceUserIdList"] = request.SourceUserIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSurveyResourceTag",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/confirm-resource/get-resource-tag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSurveyResourceTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源标签信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSurveyResourceTagRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSurveyResourceTagResponse
        /// </returns>
        public DescribeSurveyResourceTagResponse DescribeSurveyResourceTag(DescribeSurveyResourceTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSurveyResourceTagWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源标签信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSurveyResourceTagRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSurveyResourceTagResponse
        /// </returns>
        public async Task<DescribeSurveyResourceTagResponse> DescribeSurveyResourceTagAsync(DescribeSurveyResourceTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSurveyResourceTagWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资源调研参数模板列表type</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSurveyTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSurveyTemplateResponse
        /// </returns>
        public DescribeSurveyTemplateResponse DescribeSurveyTemplateWithOptions(DescribeSurveyTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSurveyTemplate",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/survey-template/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSurveyTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资源调研参数模板列表type</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSurveyTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSurveyTemplateResponse
        /// </returns>
        public async Task<DescribeSurveyTemplateResponse> DescribeSurveyTemplateWithOptionsAsync(DescribeSurveyTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSurveyTemplate",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/survey-template/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSurveyTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资源调研参数模板列表type</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSurveyTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSurveyTemplateResponse
        /// </returns>
        public DescribeSurveyTemplateResponse DescribeSurveyTemplate(DescribeSurveyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSurveyTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资源调研参数模板列表type</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSurveyTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSurveyTemplateResponse
        /// </returns>
        public async Task<DescribeSurveyTemplateResponse> DescribeSurveyTemplateAsync(DescribeSurveyTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSurveyTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得脚本中的表名，以及获取已知的不支持转换函数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableMetaInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableMetaInfoResponse
        /// </returns>
        public GetTableMetaInfoResponse GetTableMetaInfoWithOptions(GetTableMetaInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDialect))
            {
                body["sourceDialect"] = request.SourceDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSqlScript))
            {
                body["sourceSqlScript"] = request.SourceSqlScript;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDialect))
            {
                body["targetDialect"] = request.TargetDialect;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableMetaInfo",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/sql-translator/open/single/get-table-info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableMetaInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得脚本中的表名，以及获取已知的不支持转换函数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableMetaInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableMetaInfoResponse
        /// </returns>
        public async Task<GetTableMetaInfoResponse> GetTableMetaInfoWithOptionsAsync(GetTableMetaInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDialect))
            {
                body["sourceDialect"] = request.SourceDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSqlScript))
            {
                body["sourceSqlScript"] = request.SourceSqlScript;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDialect))
            {
                body["targetDialect"] = request.TargetDialect;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableMetaInfo",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/sql-translator/open/single/get-table-info",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableMetaInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得脚本中的表名，以及获取已知的不支持转换函数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableMetaInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTableMetaInfoResponse
        /// </returns>
        public GetTableMetaInfoResponse GetTableMetaInfo(GetTableMetaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableMetaInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得脚本中的表名，以及获取已知的不支持转换函数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableMetaInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTableMetaInfoResponse
        /// </returns>
        public async Task<GetTableMetaInfoResponse> GetTableMetaInfoAsync(GetTableMetaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableMetaInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回显任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskDetailResponse
        /// </returns>
        public GetTaskDetailResponse GetTaskDetailWithOptions(GetTaskDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskDetail",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/jobMigrate/sqlTranslator/task/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回显任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskDetailResponse
        /// </returns>
        public async Task<GetTaskDetailResponse> GetTaskDetailWithOptionsAsync(GetTaskDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskDetail",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/jobMigrate/sqlTranslator/task/detail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回显任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskDetailResponse
        /// </returns>
        public GetTaskDetailResponse GetTaskDetail(GetTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回显任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskDetailResponse
        /// </returns>
        public async Task<GetTaskDetailResponse> GetTaskDetailAsync(GetTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分发页下载统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppDownloadHistoryRequest
        /// </param>
        /// <param name="headers">
        /// ListAppDownloadHistoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppDownloadHistoryResponse
        /// </returns>
        public ListAppDownloadHistoryResponse ListAppDownloadHistoryWithOptions(ListAppDownloadHistoryRequest request, ListAppDownloadHistoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantUid))
            {
                body["tenantUid"] = request.TenantUid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.BizModuleCode))
            {
                realHeaders["biz-module-code"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.BizModuleCode);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.TenantProxyUid))
            {
                realHeaders["tenant-proxy-uid"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.TenantProxyUid);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppDownloadHistory",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/abm/app/manager/api/v1/fetchAppDownloadHistory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppDownloadHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分发页下载统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppDownloadHistoryRequest
        /// </param>
        /// <param name="headers">
        /// ListAppDownloadHistoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppDownloadHistoryResponse
        /// </returns>
        public async Task<ListAppDownloadHistoryResponse> ListAppDownloadHistoryWithOptionsAsync(ListAppDownloadHistoryRequest request, ListAppDownloadHistoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantUid))
            {
                body["tenantUid"] = request.TenantUid;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.BizModuleCode))
            {
                realHeaders["biz-module-code"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.BizModuleCode);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.TenantProxyUid))
            {
                realHeaders["tenant-proxy-uid"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.TenantProxyUid);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppDownloadHistory",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/abm/app/manager/api/v1/fetchAppDownloadHistory",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppDownloadHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分发页下载统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppDownloadHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppDownloadHistoryResponse
        /// </returns>
        public ListAppDownloadHistoryResponse ListAppDownloadHistory(ListAppDownloadHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAppDownloadHistoryHeaders headers = new ListAppDownloadHistoryHeaders();
            return ListAppDownloadHistoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分发页下载统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppDownloadHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppDownloadHistoryResponse
        /// </returns>
        public async Task<ListAppDownloadHistoryResponse> ListAppDownloadHistoryAsync(ListAppDownloadHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListAppDownloadHistoryHeaders headers = new ListAppDownloadHistoryHeaders();
            return await ListAppDownloadHistoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询同步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMigrationJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMigrationJobsResponse
        /// </returns>
        public ListMigrationJobsResponse ListMigrationJobsWithOptions(ListMigrationJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchTaskGroupId))
            {
                body["batchTaskGroupId"] = request.BatchTaskGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CutoverPlanId))
            {
                body["cutoverPlanId"] = request.CutoverPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSideId))
            {
                body["outSideId"] = request.OutSideId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortCol))
            {
                body["sortCol"] = request.SortCol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                body["sortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SurveyResourceId))
            {
                body["surveyResourceId"] = request.SurveyResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                body["tagList"] = request.TagList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeList))
            {
                body["typeList"] = request.TypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedType))
            {
                body["usedType"] = request.UsedType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMigrationJobs",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-job/describe-migration-jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMigrationJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询同步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMigrationJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMigrationJobsResponse
        /// </returns>
        public async Task<ListMigrationJobsResponse> ListMigrationJobsWithOptionsAsync(ListMigrationJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchTaskGroupId))
            {
                body["batchTaskGroupId"] = request.BatchTaskGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CutoverPlanId))
            {
                body["cutoverPlanId"] = request.CutoverPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSideId))
            {
                body["outSideId"] = request.OutSideId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortCol))
            {
                body["sortCol"] = request.SortCol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                body["sortType"] = request.SortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SurveyResourceId))
            {
                body["surveyResourceId"] = request.SurveyResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                body["tagList"] = request.TagList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeList))
            {
                body["typeList"] = request.TypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedType))
            {
                body["usedType"] = request.UsedType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMigrationJobs",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-job/describe-migration-jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMigrationJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询同步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMigrationJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMigrationJobsResponse
        /// </returns>
        public ListMigrationJobsResponse ListMigrationJobs(ListMigrationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMigrationJobsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询同步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMigrationJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMigrationJobsResponse
        /// </returns>
        public async Task<ListMigrationJobsResponse> ListMigrationJobsAsync(ListMigrationJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMigrationJobsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取调研任务下载列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyJobDownLoadJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyJobDownLoadJobsResponse
        /// </returns>
        public ListSurveyJobDownLoadJobsResponse ListSurveyJobDownLoadJobsWithOptions(ListSurveyJobDownLoadJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortCol))
            {
                body["sortCol"] = request.SortCol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                body["sortType"] = request.SortType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSurveyJobDownLoadJobs",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/file-job/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSurveyJobDownLoadJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取调研任务下载列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyJobDownLoadJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyJobDownLoadJobsResponse
        /// </returns>
        public async Task<ListSurveyJobDownLoadJobsResponse> ListSurveyJobDownLoadJobsWithOptionsAsync(ListSurveyJobDownLoadJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortCol))
            {
                body["sortCol"] = request.SortCol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortType))
            {
                body["sortType"] = request.SortType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSurveyJobDownLoadJobs",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/file-job/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSurveyJobDownLoadJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取调研任务下载列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyJobDownLoadJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyJobDownLoadJobsResponse
        /// </returns>
        public ListSurveyJobDownLoadJobsResponse ListSurveyJobDownLoadJobs(ListSurveyJobDownLoadJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSurveyJobDownLoadJobsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取调研任务下载列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyJobDownLoadJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyJobDownLoadJobsResponse
        /// </returns>
        public async Task<ListSurveyJobDownLoadJobsResponse> ListSurveyJobDownLoadJobsAsync(ListSurveyJobDownLoadJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSurveyJobDownLoadJobsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看调研任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyJobsResponse
        /// </returns>
        public ListSurveyJobsResponse ListSurveyJobsWithOptions(ListSurveyJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelList))
            {
                body["channelList"] = request.ChannelList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudTypeList))
            {
                body["cloudTypeList"] = request.CloudTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SurveyRange))
            {
                body["surveyRange"] = request.SurveyRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSurveyJobs",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/winback/query-survey-jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSurveyJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看调研任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyJobsResponse
        /// </returns>
        public async Task<ListSurveyJobsResponse> ListSurveyJobsWithOptionsAsync(ListSurveyJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelList))
            {
                body["channelList"] = request.ChannelList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudTypeList))
            {
                body["cloudTypeList"] = request.CloudTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SurveyRange))
            {
                body["surveyRange"] = request.SurveyRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSurveyJobs",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/winback/query-survey-jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSurveyJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看调研任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyJobsResponse
        /// </returns>
        public ListSurveyJobsResponse ListSurveyJobs(ListSurveyJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSurveyJobsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看调研任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyJobsResponse
        /// </returns>
        public async Task<ListSurveyJobsResponse> ListSurveyJobsAsync(ListSurveyJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSurveyJobsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过集群ids获取下属资源</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListSurveyResourceByMigrationGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyResourceByMigrationGroupsResponse
        /// </returns>
        public ListSurveyResourceByMigrationGroupsResponse ListSurveyResourceByMigrationGroupsWithOptions(ListSurveyResourceByMigrationGroupsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSurveyResourceByMigrationGroupsShrinkRequest request = new ListSurveyResourceByMigrationGroupsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSurveyResourceByMigrationGroups",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-group/get-survey-resource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSurveyResourceByMigrationGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过集群ids获取下属资源</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListSurveyResourceByMigrationGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyResourceByMigrationGroupsResponse
        /// </returns>
        public async Task<ListSurveyResourceByMigrationGroupsResponse> ListSurveyResourceByMigrationGroupsWithOptionsAsync(ListSurveyResourceByMigrationGroupsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListSurveyResourceByMigrationGroupsShrinkRequest request = new ListSurveyResourceByMigrationGroupsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSurveyResourceByMigrationGroups",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-group/get-survey-resource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSurveyResourceByMigrationGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过集群ids获取下属资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyResourceByMigrationGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyResourceByMigrationGroupsResponse
        /// </returns>
        public ListSurveyResourceByMigrationGroupsResponse ListSurveyResourceByMigrationGroups(ListSurveyResourceByMigrationGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSurveyResourceByMigrationGroupsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过集群ids获取下属资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyResourceByMigrationGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyResourceByMigrationGroupsResponse
        /// </returns>
        public async Task<ListSurveyResourceByMigrationGroupsResponse> ListSurveyResourceByMigrationGroupsAsync(ListSurveyResourceByMigrationGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSurveyResourceByMigrationGroupsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资源网络拓扑</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyResourceConnectionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyResourceConnectionsResponse
        /// </returns>
        public ListSurveyResourceConnectionsResponse ListSurveyResourceConnectionsWithOptions(ListSurveyResourceConnectionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                body["ids"] = request.Ids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSurveyResourceConnections",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/resource-connects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSurveyResourceConnectionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资源网络拓扑</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyResourceConnectionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyResourceConnectionsResponse
        /// </returns>
        public async Task<ListSurveyResourceConnectionsResponse> ListSurveyResourceConnectionsWithOptionsAsync(ListSurveyResourceConnectionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                body["ids"] = request.Ids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSurveyResourceConnections",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/resource-connects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSurveyResourceConnectionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资源网络拓扑</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyResourceConnectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyResourceConnectionsResponse
        /// </returns>
        public ListSurveyResourceConnectionsResponse ListSurveyResourceConnections(ListSurveyResourceConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSurveyResourceConnectionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询资源网络拓扑</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyResourceConnectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyResourceConnectionsResponse
        /// </returns>
        public async Task<ListSurveyResourceConnectionsResponse> ListSurveyResourceConnectionsAsync(ListSurveyResourceConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSurveyResourceConnectionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源类型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyResourceTypesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyResourceTypesResponse
        /// </returns>
        public ListSurveyResourceTypesResponse ListSurveyResourceTypesWithOptions(ListSurveyResourceTypesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ak))
            {
                query["ak"] = request.Ak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudType))
            {
                query["cloudType"] = request.CloudType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sk))
            {
                query["sk"] = request.Sk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSurveyResourceTypes",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/winback/query-resource-type",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSurveyResourceTypesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源类型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyResourceTypesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyResourceTypesResponse
        /// </returns>
        public async Task<ListSurveyResourceTypesResponse> ListSurveyResourceTypesWithOptionsAsync(ListSurveyResourceTypesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ak))
            {
                query["ak"] = request.Ak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudType))
            {
                query["cloudType"] = request.CloudType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sk))
            {
                query["sk"] = request.Sk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSurveyResourceTypes",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/winback/query-resource-type",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSurveyResourceTypesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源类型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyResourceTypesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyResourceTypesResponse
        /// </returns>
        public ListSurveyResourceTypesResponse ListSurveyResourceTypes(ListSurveyResourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSurveyResourceTypesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取资源类型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyResourceTypesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyResourceTypesResponse
        /// </returns>
        public async Task<ListSurveyResourceTypesResponse> ListSurveyResourceTypesAsync(ListSurveyResourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSurveyResourceTypesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务下属资源列表详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyResourcesDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyResourcesDetailResponse
        /// </returns>
        public ListSurveyResourcesDetailResponse ListSurveyResourcesDetailWithOptions(ListSurveyResourcesDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["jobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubProjectId))
            {
                body["subProjectId"] = request.SubProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSurveyResourcesDetail",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/survey-detail/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSurveyResourcesDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务下属资源列表详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyResourcesDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyResourcesDetailResponse
        /// </returns>
        public async Task<ListSurveyResourcesDetailResponse> ListSurveyResourcesDetailWithOptionsAsync(ListSurveyResourcesDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                body["ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["jobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubProjectId))
            {
                body["subProjectId"] = request.SubProjectId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSurveyResourcesDetail",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/survey-detail/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSurveyResourcesDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务下属资源列表详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyResourcesDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyResourcesDetailResponse
        /// </returns>
        public ListSurveyResourcesDetailResponse ListSurveyResourcesDetail(ListSurveyResourcesDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSurveyResourcesDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务下属资源列表详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSurveyResourcesDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSurveyResourcesDetailResponse
        /// </returns>
        public async Task<ListSurveyResourcesDetailResponse> ListSurveyResourcesDetailAsync(ListSurveyResourcesDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSurveyResourcesDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增sql转换任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PopCreateTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PopCreateTaskResponse
        /// </returns>
        public PopCreateTaskResponse PopCreateTaskWithOptions(PopCreateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTypeMappingFile))
            {
                body["dataTypeMappingFile"] = request.DataTypeMappingFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTypeOssFileName))
            {
                body["dataTypeOssFileName"] = request.DataTypeOssFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTypeOssObjectName))
            {
                body["dataTypeOssObjectName"] = request.DataTypeOssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTypeRealFileName))
            {
                body["dataTypeRealFileName"] = request.DataTypeRealFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DqlAssociationDDLTaskList))
            {
                body["dqlAssociationDDLTaskList"] = request.DqlAssociationDDLTaskList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DqlRelateTargetDatasourceId))
            {
                body["dqlRelateTargetDatasourceId"] = request.DqlRelateTargetDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DqlTestDatasourceId))
            {
                body["dqlTestDatasourceId"] = request.DqlTestDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DqlTestProject))
            {
                body["dqlTestProject"] = request.DqlTestProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalParams))
            {
                body["globalParams"] = request.GlobalParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssObjectName))
            {
                body["ossObjectName"] = request.OssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealFileName))
            {
                body["realFileName"] = request.RealFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDdlContentOssFileName))
            {
                body["relatedDdlContentOssFileName"] = request.RelatedDdlContentOssFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDdlContentOssObjectName))
            {
                body["relatedDdlContentOssObjectName"] = request.RelatedDdlContentOssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDdlContentRealFileName))
            {
                body["relatedDdlContentRealFileName"] = request.RelatedDdlContentRealFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDatasourceId))
            {
                body["sourceDatasourceId"] = request.SourceDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDialect))
            {
                body["sourceDialect"] = request.SourceDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProject))
            {
                body["sourceProject"] = request.SourceProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNameMappingFile))
            {
                body["tableNameMappingFile"] = request.TableNameMappingFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNameOssFileName))
            {
                body["tableNameOssFileName"] = request.TableNameOssFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNameOssObjectName))
            {
                body["tableNameOssObjectName"] = request.TableNameOssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNameRealFileName))
            {
                body["tableNameRealFileName"] = request.TableNameRealFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDatasourceId))
            {
                body["targetDatasourceId"] = request.TargetDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDialect))
            {
                body["targetDialect"] = request.TargetDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetProject))
            {
                body["targetProject"] = request.TargetProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransformSchema))
            {
                body["transformSchema"] = request.TransformSchema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopCreateTask",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/jobMigrate/sqlTranslator/task/popAdd",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopCreateTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增sql转换任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PopCreateTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PopCreateTaskResponse
        /// </returns>
        public async Task<PopCreateTaskResponse> PopCreateTaskWithOptionsAsync(PopCreateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTypeMappingFile))
            {
                body["dataTypeMappingFile"] = request.DataTypeMappingFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTypeOssFileName))
            {
                body["dataTypeOssFileName"] = request.DataTypeOssFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTypeOssObjectName))
            {
                body["dataTypeOssObjectName"] = request.DataTypeOssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTypeRealFileName))
            {
                body["dataTypeRealFileName"] = request.DataTypeRealFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DqlAssociationDDLTaskList))
            {
                body["dqlAssociationDDLTaskList"] = request.DqlAssociationDDLTaskList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DqlRelateTargetDatasourceId))
            {
                body["dqlRelateTargetDatasourceId"] = request.DqlRelateTargetDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DqlTestDatasourceId))
            {
                body["dqlTestDatasourceId"] = request.DqlTestDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DqlTestProject))
            {
                body["dqlTestProject"] = request.DqlTestProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalParams))
            {
                body["globalParams"] = request.GlobalParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssObjectName))
            {
                body["ossObjectName"] = request.OssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealFileName))
            {
                body["realFileName"] = request.RealFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDdlContentOssFileName))
            {
                body["relatedDdlContentOssFileName"] = request.RelatedDdlContentOssFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDdlContentOssObjectName))
            {
                body["relatedDdlContentOssObjectName"] = request.RelatedDdlContentOssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDdlContentRealFileName))
            {
                body["relatedDdlContentRealFileName"] = request.RelatedDdlContentRealFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDatasourceId))
            {
                body["sourceDatasourceId"] = request.SourceDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDialect))
            {
                body["sourceDialect"] = request.SourceDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProject))
            {
                body["sourceProject"] = request.SourceProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNameMappingFile))
            {
                body["tableNameMappingFile"] = request.TableNameMappingFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNameOssFileName))
            {
                body["tableNameOssFileName"] = request.TableNameOssFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNameOssObjectName))
            {
                body["tableNameOssObjectName"] = request.TableNameOssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNameRealFileName))
            {
                body["tableNameRealFileName"] = request.TableNameRealFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDatasourceId))
            {
                body["targetDatasourceId"] = request.TargetDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDialect))
            {
                body["targetDialect"] = request.TargetDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetProject))
            {
                body["targetProject"] = request.TargetProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransformSchema))
            {
                body["transformSchema"] = request.TransformSchema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopCreateTask",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/jobMigrate/sqlTranslator/task/popAdd",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopCreateTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增sql转换任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PopCreateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// PopCreateTaskResponse
        /// </returns>
        public PopCreateTaskResponse PopCreateTask(PopCreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PopCreateTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增sql转换任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PopCreateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// PopCreateTaskResponse
        /// </returns>
        public async Task<PopCreateTaskResponse> PopCreateTaskAsync(PopCreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PopCreateTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载表名映射模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PopDownloadTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PopDownloadTemplateResponse
        /// </returns>
        public PopDownloadTemplateResponse PopDownloadTemplateWithOptions(PopDownloadTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDialect))
            {
                query["targetDialect"] = request.TargetDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopDownloadTemplate",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/jobMigrate/sqlTranslator/task/popDownload/TableNameMappingTemplate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopDownloadTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载表名映射模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PopDownloadTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PopDownloadTemplateResponse
        /// </returns>
        public async Task<PopDownloadTemplateResponse> PopDownloadTemplateWithOptionsAsync(PopDownloadTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDialect))
            {
                query["targetDialect"] = request.TargetDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopDownloadTemplate",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/jobMigrate/sqlTranslator/task/popDownload/TableNameMappingTemplate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopDownloadTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载表名映射模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PopDownloadTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// PopDownloadTemplateResponse
        /// </returns>
        public PopDownloadTemplateResponse PopDownloadTemplate(PopDownloadTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PopDownloadTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下载表名映射模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PopDownloadTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// PopDownloadTemplateResponse
        /// </returns>
        public async Task<PopDownloadTemplateResponse> PopDownloadTemplateAsync(PopDownloadTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PopDownloadTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑sql转换任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PopEditTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PopEditTaskResponse
        /// </returns>
        public PopEditTaskResponse PopEditTaskWithOptions(PopEditTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTypeMappingFile))
            {
                body["dataTypeMappingFile"] = request.DataTypeMappingFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTypeOssFileName))
            {
                body["dataTypeOssFileName"] = request.DataTypeOssFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTypeOssObjectName))
            {
                body["dataTypeOssObjectName"] = request.DataTypeOssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTypeRealFileName))
            {
                body["dataTypeRealFileName"] = request.DataTypeRealFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DqlAssociationDDLTaskList))
            {
                body["dqlAssociationDDLTaskList"] = request.DqlAssociationDDLTaskList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DqlRelateTargetDatasourceId))
            {
                body["dqlRelateTargetDatasourceId"] = request.DqlRelateTargetDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DqlTestDatasourceId))
            {
                body["dqlTestDatasourceId"] = request.DqlTestDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DqlTestProject))
            {
                body["dqlTestProject"] = request.DqlTestProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalParams))
            {
                body["globalParams"] = request.GlobalParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssObjectName))
            {
                body["ossObjectName"] = request.OssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealFileName))
            {
                body["realFileName"] = request.RealFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDdlContentOssFileName))
            {
                body["relatedDdlContentOssFileName"] = request.RelatedDdlContentOssFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDdlContentOssObjectName))
            {
                body["relatedDdlContentOssObjectName"] = request.RelatedDdlContentOssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDdlContentRealFileName))
            {
                body["relatedDdlContentRealFileName"] = request.RelatedDdlContentRealFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDatasourceId))
            {
                body["sourceDatasourceId"] = request.SourceDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDialect))
            {
                body["sourceDialect"] = request.SourceDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProject))
            {
                body["sourceProject"] = request.SourceProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNameMappingFile))
            {
                body["tableNameMappingFile"] = request.TableNameMappingFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNameOssFileName))
            {
                body["tableNameOssFileName"] = request.TableNameOssFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNameOssObjectName))
            {
                body["tableNameOssObjectName"] = request.TableNameOssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNameRealFileName))
            {
                body["tableNameRealFileName"] = request.TableNameRealFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDatasourceId))
            {
                body["targetDatasourceId"] = request.TargetDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDialect))
            {
                body["targetDialect"] = request.TargetDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetProject))
            {
                body["targetProject"] = request.TargetProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransformSchema))
            {
                body["transformSchema"] = request.TransformSchema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopEditTask",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/jobMigrate/sqlTranslator/task/popEdit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopEditTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑sql转换任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PopEditTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PopEditTaskResponse
        /// </returns>
        public async Task<PopEditTaskResponse> PopEditTaskWithOptionsAsync(PopEditTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTypeMappingFile))
            {
                body["dataTypeMappingFile"] = request.DataTypeMappingFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTypeOssFileName))
            {
                body["dataTypeOssFileName"] = request.DataTypeOssFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTypeOssObjectName))
            {
                body["dataTypeOssObjectName"] = request.DataTypeOssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataTypeRealFileName))
            {
                body["dataTypeRealFileName"] = request.DataTypeRealFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DqlAssociationDDLTaskList))
            {
                body["dqlAssociationDDLTaskList"] = request.DqlAssociationDDLTaskList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DqlRelateTargetDatasourceId))
            {
                body["dqlRelateTargetDatasourceId"] = request.DqlRelateTargetDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DqlTestDatasourceId))
            {
                body["dqlTestDatasourceId"] = request.DqlTestDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DqlTestProject))
            {
                body["dqlTestProject"] = request.DqlTestProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GlobalParams))
            {
                body["globalParams"] = request.GlobalParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssObjectName))
            {
                body["ossObjectName"] = request.OssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealFileName))
            {
                body["realFileName"] = request.RealFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDdlContentOssFileName))
            {
                body["relatedDdlContentOssFileName"] = request.RelatedDdlContentOssFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDdlContentOssObjectName))
            {
                body["relatedDdlContentOssObjectName"] = request.RelatedDdlContentOssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedDdlContentRealFileName))
            {
                body["relatedDdlContentRealFileName"] = request.RelatedDdlContentRealFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDatasourceId))
            {
                body["sourceDatasourceId"] = request.SourceDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDialect))
            {
                body["sourceDialect"] = request.SourceDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProject))
            {
                body["sourceProject"] = request.SourceProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNameMappingFile))
            {
                body["tableNameMappingFile"] = request.TableNameMappingFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNameOssFileName))
            {
                body["tableNameOssFileName"] = request.TableNameOssFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNameOssObjectName))
            {
                body["tableNameOssObjectName"] = request.TableNameOssObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNameRealFileName))
            {
                body["tableNameRealFileName"] = request.TableNameRealFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDatasourceId))
            {
                body["targetDatasourceId"] = request.TargetDatasourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDialect))
            {
                body["targetDialect"] = request.TargetDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetProject))
            {
                body["targetProject"] = request.TargetProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDescription))
            {
                body["taskDescription"] = request.TaskDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransformSchema))
            {
                body["transformSchema"] = request.TransformSchema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PopEditTask",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/jobMigrate/sqlTranslator/task/popEdit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PopEditTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑sql转换任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PopEditTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// PopEditTaskResponse
        /// </returns>
        public PopEditTaskResponse PopEditTask(PopEditTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PopEditTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑sql转换任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PopEditTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// PopEditTaskResponse
        /// </returns>
        public async Task<PopEditTaskResponse> PopEditTaskAsync(PopEditTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PopEditTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>恢复删除任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecoverMigrationJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecoverMigrationJobResponse
        /// </returns>
        public RecoverMigrationJobResponse RecoverMigrationJobWithOptions(RecoverMigrationJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecoverMigrationJob",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-job/recover-migration-job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecoverMigrationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>恢复删除任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecoverMigrationJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecoverMigrationJobResponse
        /// </returns>
        public async Task<RecoverMigrationJobResponse> RecoverMigrationJobWithOptionsAsync(RecoverMigrationJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecoverMigrationJob",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-job/recover-migration-job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecoverMigrationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>恢复删除任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecoverMigrationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// RecoverMigrationJobResponse
        /// </returns>
        public RecoverMigrationJobResponse RecoverMigrationJob(RecoverMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RecoverMigrationJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>恢复删除任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecoverMigrationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// RecoverMigrationJobResponse
        /// </returns>
        public async Task<RecoverMigrationJobResponse> RecoverMigrationJobAsync(RecoverMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RecoverMigrationJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>此接口不直接前端使用，供外部调用的接口，可在此接口上做权限校验以及限流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SingleScriptSyncTranslateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SingleScriptSyncTranslateResponse
        /// </returns>
        public SingleScriptSyncTranslateResponse SingleScriptSyncTranslateWithOptions(SingleScriptSyncTranslateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDialect))
            {
                body["sourceDialect"] = request.SourceDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSqlScript))
            {
                body["sourceSqlScript"] = request.SourceSqlScript;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableMapping))
            {
                body["tableMapping"] = request.TableMapping;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDialect))
            {
                body["targetDialect"] = request.TargetDialect;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SingleScriptSyncTranslate",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/sql-translator/open/single/translate-sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SingleScriptSyncTranslateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>此接口不直接前端使用，供外部调用的接口，可在此接口上做权限校验以及限流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SingleScriptSyncTranslateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SingleScriptSyncTranslateResponse
        /// </returns>
        public async Task<SingleScriptSyncTranslateResponse> SingleScriptSyncTranslateWithOptionsAsync(SingleScriptSyncTranslateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDialect))
            {
                body["sourceDialect"] = request.SourceDialect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSqlScript))
            {
                body["sourceSqlScript"] = request.SourceSqlScript;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableMapping))
            {
                body["tableMapping"] = request.TableMapping;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetDialect))
            {
                body["targetDialect"] = request.TargetDialect;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SingleScriptSyncTranslate",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/api/bigdata/sql-translator/open/single/translate-sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SingleScriptSyncTranslateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>此接口不直接前端使用，供外部调用的接口，可在此接口上做权限校验以及限流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SingleScriptSyncTranslateRequest
        /// </param>
        /// 
        /// <returns>
        /// SingleScriptSyncTranslateResponse
        /// </returns>
        public SingleScriptSyncTranslateResponse SingleScriptSyncTranslate(SingleScriptSyncTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SingleScriptSyncTranslateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>此接口不直接前端使用，供外部调用的接口，可在此接口上做权限校验以及限流</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SingleScriptSyncTranslateRequest
        /// </param>
        /// 
        /// <returns>
        /// SingleScriptSyncTranslateResponse
        /// </returns>
        public async Task<SingleScriptSyncTranslateResponse> SingleScriptSyncTranslateAsync(SingleScriptSyncTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SingleScriptSyncTranslateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>断开同步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopSyncMigrationJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopSyncMigrationJobResponse
        /// </returns>
        public StopSyncMigrationJobResponse StopSyncMigrationJobWithOptions(StopSyncMigrationJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["jobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopSyncMigrationJob",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-job/unsync-migration-job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopSyncMigrationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>断开同步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopSyncMigrationJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopSyncMigrationJobResponse
        /// </returns>
        public async Task<StopSyncMigrationJobResponse> StopSyncMigrationJobWithOptionsAsync(StopSyncMigrationJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["jobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopSyncMigrationJob",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-job/unsync-migration-job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopSyncMigrationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>断开同步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopSyncMigrationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// StopSyncMigrationJobResponse
        /// </returns>
        public StopSyncMigrationJobResponse StopSyncMigrationJob(StopSyncMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopSyncMigrationJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>断开同步任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopSyncMigrationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// StopSyncMigrationJobResponse
        /// </returns>
        public async Task<StopSyncMigrationJobResponse> StopSyncMigrationJobAsync(StopSyncMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopSyncMigrationJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步迁移任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncMigrationJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncMigrationJobResponse
        /// </returns>
        public SyncMigrationJobResponse SyncMigrationJobWithOptions(SyncMigrationJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["jobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["operationType"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regions))
            {
                query["regions"] = request.Regions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncMigrationJob",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-job/sync-migration-job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncMigrationJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步迁移任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncMigrationJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncMigrationJobResponse
        /// </returns>
        public async Task<SyncMigrationJobResponse> SyncMigrationJobWithOptionsAsync(SyncMigrationJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["jobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationType))
            {
                query["operationType"] = request.OperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regions))
            {
                query["regions"] = request.Regions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncMigrationJob",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/okss-services/migration-job/sync-migration-job",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncMigrationJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步迁移任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncMigrationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncMigrationJobResponse
        /// </returns>
        public SyncMigrationJobResponse SyncMigrationJob(SyncMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SyncMigrationJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步迁移任务信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncMigrationJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncMigrationJobResponse
        /// </returns>
        public async Task<SyncMigrationJobResponse> SyncMigrationJobAsync(SyncMigrationJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SyncMigrationJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新push</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePushAppRequest
        /// </param>
        /// <param name="headers">
        /// UpdatePushAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePushAppResponse
        /// </returns>
        public UpdatePushAppResponse UpdatePushAppWithOptions(UpdatePushAppRequest request, UpdatePushAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadLink))
            {
                body["DownloadLink"] = request.DownloadLink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.TenantProxyUid))
            {
                realHeaders["tenant-proxy-uid"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.TenantProxyUid);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePushApp",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/abm/app/manager/api/v1/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePushAppResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新push</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePushAppRequest
        /// </param>
        /// <param name="headers">
        /// UpdatePushAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePushAppResponse
        /// </returns>
        public async Task<UpdatePushAppResponse> UpdatePushAppWithOptionsAsync(UpdatePushAppRequest request, UpdatePushAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadLink))
            {
                body["DownloadLink"] = request.DownloadLink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.TenantProxyUid))
            {
                realHeaders["tenant-proxy-uid"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.TenantProxyUid);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePushApp",
                Version = "2022-03-31",
                Protocol = "HTTPS",
                Pathname = "/abm/app/manager/api/v1/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePushAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新push</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePushAppRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePushAppResponse
        /// </returns>
        public UpdatePushAppResponse UpdatePushApp(UpdatePushAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePushAppHeaders headers = new UpdatePushAppHeaders();
            return UpdatePushAppWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新push</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePushAppRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePushAppResponse
        /// </returns>
        public async Task<UpdatePushAppResponse> UpdatePushAppAsync(UpdatePushAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdatePushAppHeaders headers = new UpdatePushAppHeaders();
            return await UpdatePushAppWithOptionsAsync(request, headers, runtime);
        }

    }
}
