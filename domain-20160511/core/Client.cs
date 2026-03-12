// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Domain20160511.Models;

namespace AlibabaCloud.SDK.Domain20160511
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("domain", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>域名检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDomainResponse
        /// </returns>
        public CheckDomainResponse CheckDomainWithOptions(CheckDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDomain",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDomainResponse
        /// </returns>
        public async Task<CheckDomainResponse> CheckDomainWithOptionsAsync(CheckDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDomain",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDomainResponse
        /// </returns>
        public CheckDomainResponse CheckDomain(CheckDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDomainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名检查</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDomainResponse
        /// </returns>
        public async Task<CheckDomainResponse> CheckDomainAsync(CheckDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDomainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteContactTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactTemplateResponse
        /// </returns>
        public DeleteContactTemplateResponse DeleteContactTemplateWithOptions(DeleteContactTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContactTemplate",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteContactTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactTemplateResponse
        /// </returns>
        public async Task<DeleteContactTemplateResponse> DeleteContactTemplateWithOptionsAsync(DeleteContactTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContactTemplate",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteContactTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactTemplateResponse
        /// </returns>
        public DeleteContactTemplateResponse DeleteContactTemplate(DeleteContactTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContactTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteContactTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactTemplateResponse
        /// </returns>
        public async Task<DeleteContactTemplateResponse> DeleteContactTemplateAsync(DeleteContactTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContactTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBatchTaskDetailListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBatchTaskDetailListResponse
        /// </returns>
        public QueryBatchTaskDetailListResponse QueryBatchTaskDetailListWithOptions(QueryBatchTaskDetailListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskNo))
            {
                query["TaskNo"] = request.TaskNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                query["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBatchTaskDetailList",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBatchTaskDetailListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBatchTaskDetailListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBatchTaskDetailListResponse
        /// </returns>
        public async Task<QueryBatchTaskDetailListResponse> QueryBatchTaskDetailListWithOptionsAsync(QueryBatchTaskDetailListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskNo))
            {
                query["TaskNo"] = request.TaskNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                query["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBatchTaskDetailList",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBatchTaskDetailListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBatchTaskDetailListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBatchTaskDetailListResponse
        /// </returns>
        public QueryBatchTaskDetailListResponse QueryBatchTaskDetailList(QueryBatchTaskDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBatchTaskDetailListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBatchTaskDetailListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBatchTaskDetailListResponse
        /// </returns>
        public async Task<QueryBatchTaskDetailListResponse> QueryBatchTaskDetailListAsync(QueryBatchTaskDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBatchTaskDetailListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBatchTaskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBatchTaskListResponse
        /// </returns>
        public QueryBatchTaskListResponse QueryBatchTaskListWithOptions(QueryBatchTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginCreateTime))
            {
                query["BeginCreateTime"] = request.BeginCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBatchTaskList",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBatchTaskListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBatchTaskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBatchTaskListResponse
        /// </returns>
        public async Task<QueryBatchTaskListResponse> QueryBatchTaskListWithOptionsAsync(QueryBatchTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginCreateTime))
            {
                query["BeginCreateTime"] = request.BeginCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBatchTaskList",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBatchTaskListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBatchTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBatchTaskListResponse
        /// </returns>
        public QueryBatchTaskListResponse QueryBatchTaskList(QueryBatchTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBatchTaskListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBatchTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBatchTaskListResponse
        /// </returns>
        public async Task<QueryBatchTaskListResponse> QueryBatchTaskListAsync(QueryBatchTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBatchTaskListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContactRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContactResponse
        /// </returns>
        public QueryContactResponse QueryContactWithOptions(QueryContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactType))
            {
                query["ContactType"] = request.ContactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryContact",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContactResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContactRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContactResponse
        /// </returns>
        public async Task<QueryContactResponse> QueryContactWithOptionsAsync(QueryContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactType))
            {
                query["ContactType"] = request.ContactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryContact",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContactRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContactResponse
        /// </returns>
        public QueryContactResponse QueryContact(QueryContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryContactWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContactRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContactResponse
        /// </returns>
        public async Task<QueryContactResponse> QueryContactAsync(QueryContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryContactWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContactTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContactTemplateResponse
        /// </returns>
        public QueryContactTemplateResponse QueryContactTemplateWithOptions(QueryContactTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CCompany))
            {
                query["CCompany"] = request.CCompany;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultTemplate))
            {
                query["DefaultTemplate"] = request.DefaultTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ECompany))
            {
                query["ECompany"] = request.ECompany;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegType))
            {
                query["RegType"] = request.RegType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryContactTemplate",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContactTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContactTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContactTemplateResponse
        /// </returns>
        public async Task<QueryContactTemplateResponse> QueryContactTemplateWithOptionsAsync(QueryContactTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CCompany))
            {
                query["CCompany"] = request.CCompany;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultTemplate))
            {
                query["DefaultTemplate"] = request.DefaultTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ECompany))
            {
                query["ECompany"] = request.ECompany;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegType))
            {
                query["RegType"] = request.RegType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryContactTemplate",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContactTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContactTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContactTemplateResponse
        /// </returns>
        public QueryContactTemplateResponse QueryContactTemplate(QueryContactTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryContactTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContactTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContactTemplateResponse
        /// </returns>
        public async Task<QueryContactTemplateResponse> QueryContactTemplateAsync(QueryContactTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryContactTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据saleId查询域名信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainBySaleIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainBySaleIdResponse
        /// </returns>
        public QueryDomainBySaleIdResponse QueryDomainBySaleIdWithOptions(QueryDomainBySaleIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainBySaleId",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainBySaleIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据saleId查询域名信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainBySaleIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainBySaleIdResponse
        /// </returns>
        public async Task<QueryDomainBySaleIdResponse> QueryDomainBySaleIdWithOptionsAsync(QueryDomainBySaleIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainBySaleId",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainBySaleIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据saleId查询域名信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainBySaleIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainBySaleIdResponse
        /// </returns>
        public QueryDomainBySaleIdResponse QueryDomainBySaleId(QueryDomainBySaleIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainBySaleIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据saleId查询域名信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainBySaleIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainBySaleIdResponse
        /// </returns>
        public async Task<QueryDomainBySaleIdResponse> QueryDomainBySaleIdAsync(QueryDomainBySaleIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainBySaleIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainListResponse
        /// </returns>
        public QueryDomainListResponse QueryDomainListWithOptions(QueryDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeadEndDate))
            {
                query["DeadEndDate"] = request.DeadEndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeadStartDate))
            {
                query["DeadStartDate"] = request.DeadStartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainType))
            {
                query["DomainType"] = request.DomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderByType))
            {
                query["OrderByType"] = request.OrderByType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderKeyType))
            {
                query["OrderKeyType"] = request.OrderKeyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDomainType))
            {
                query["ProductDomainType"] = request.ProductDomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegEndDate))
            {
                query["RegEndDate"] = request.RegEndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegStartDate))
            {
                query["RegStartDate"] = request.RegStartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainList",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainListResponse
        /// </returns>
        public async Task<QueryDomainListResponse> QueryDomainListWithOptionsAsync(QueryDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeadEndDate))
            {
                query["DeadEndDate"] = request.DeadEndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeadStartDate))
            {
                query["DeadStartDate"] = request.DeadStartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainType))
            {
                query["DomainType"] = request.DomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderByType))
            {
                query["OrderByType"] = request.OrderByType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderKeyType))
            {
                query["OrderKeyType"] = request.OrderKeyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDomainType))
            {
                query["ProductDomainType"] = request.ProductDomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegEndDate))
            {
                query["RegEndDate"] = request.RegEndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegStartDate))
            {
                query["RegStartDate"] = request.RegStartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainList",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainListResponse
        /// </returns>
        public QueryDomainListResponse QueryDomainList(QueryDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainListResponse
        /// </returns>
        public async Task<QueryDomainListResponse> QueryDomainListAsync(QueryDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询失败原因列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFailReasonListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFailReasonListResponse
        /// </returns>
        public QueryFailReasonListResponse QueryFailReasonListWithOptions(QueryFailReasonListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFailReasonList",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFailReasonListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询失败原因列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFailReasonListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFailReasonListResponse
        /// </returns>
        public async Task<QueryFailReasonListResponse> QueryFailReasonListWithOptionsAsync(QueryFailReasonListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFailReasonList",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFailReasonListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询失败原因列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFailReasonListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFailReasonListResponse
        /// </returns>
        public QueryFailReasonListResponse QueryFailReasonList(QueryFailReasonListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFailReasonListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询失败原因列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryFailReasonListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFailReasonListResponse
        /// </returns>
        public async Task<QueryFailReasonListResponse> QueryFailReasonListAsync(QueryFailReasonListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFailReasonListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveContactTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveContactTemplateResponse
        /// </returns>
        public SaveContactTemplateResponse SaveContactTemplateWithOptions(SaveContactTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CCity))
            {
                query["CCity"] = request.CCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CCompany))
            {
                query["CCompany"] = request.CCompany;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CCountry))
            {
                query["CCountry"] = request.CCountry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CName))
            {
                query["CName"] = request.CName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CProvince))
            {
                query["CProvince"] = request.CProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CVenu))
            {
                query["CVenu"] = request.CVenu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultTemplate))
            {
                query["DefaultTemplate"] = request.DefaultTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ECity))
            {
                query["ECity"] = request.ECity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ECompany))
            {
                query["ECompany"] = request.ECompany;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EName))
            {
                query["EName"] = request.EName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EProvince))
            {
                query["EProvince"] = request.EProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EVenu))
            {
                query["EVenu"] = request.EVenu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostalCode))
            {
                query["PostalCode"] = request.PostalCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegType))
            {
                query["RegType"] = request.RegType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelArea))
            {
                query["TelArea"] = request.TelArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelExt))
            {
                query["TelExt"] = request.TelExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelMain))
            {
                query["TelMain"] = request.TelMain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveContactTemplate",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveContactTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveContactTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveContactTemplateResponse
        /// </returns>
        public async Task<SaveContactTemplateResponse> SaveContactTemplateWithOptionsAsync(SaveContactTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CCity))
            {
                query["CCity"] = request.CCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CCompany))
            {
                query["CCompany"] = request.CCompany;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CCountry))
            {
                query["CCountry"] = request.CCountry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CName))
            {
                query["CName"] = request.CName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CProvince))
            {
                query["CProvince"] = request.CProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CVenu))
            {
                query["CVenu"] = request.CVenu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultTemplate))
            {
                query["DefaultTemplate"] = request.DefaultTemplate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ECity))
            {
                query["ECity"] = request.ECity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ECompany))
            {
                query["ECompany"] = request.ECompany;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EName))
            {
                query["EName"] = request.EName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EProvince))
            {
                query["EProvince"] = request.EProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EVenu))
            {
                query["EVenu"] = request.EVenu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostalCode))
            {
                query["PostalCode"] = request.PostalCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegType))
            {
                query["RegType"] = request.RegType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelArea))
            {
                query["TelArea"] = request.TelArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelExt))
            {
                query["TelExt"] = request.TelExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelMain))
            {
                query["TelMain"] = request.TelMain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveContactTemplate",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveContactTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveContactTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveContactTemplateResponse
        /// </returns>
        public SaveContactTemplateResponse SaveContactTemplate(SaveContactTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveContactTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveContactTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveContactTemplateResponse
        /// </returns>
        public async Task<SaveContactTemplateResponse> SaveContactTemplateAsync(SaveContactTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveContactTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板实名资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveContactTemplateCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveContactTemplateCredentialResponse
        /// </returns>
        public SaveContactTemplateCredentialResponse SaveContactTemplateCredentialWithOptions(SaveContactTemplateCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credential))
            {
                query["Credential"] = request.Credential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialNo))
            {
                query["CredentialNo"] = request.CredentialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveContactTemplateCredential",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveContactTemplateCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板实名资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveContactTemplateCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveContactTemplateCredentialResponse
        /// </returns>
        public async Task<SaveContactTemplateCredentialResponse> SaveContactTemplateCredentialWithOptionsAsync(SaveContactTemplateCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credential))
            {
                query["Credential"] = request.Credential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialNo))
            {
                query["CredentialNo"] = request.CredentialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveContactTemplateCredential",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveContactTemplateCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板实名资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveContactTemplateCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveContactTemplateCredentialResponse
        /// </returns>
        public SaveContactTemplateCredentialResponse SaveContactTemplateCredential(SaveContactTemplateCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveContactTemplateCredentialWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板实名资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveContactTemplateCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveContactTemplateCredentialResponse
        /// </returns>
        public async Task<SaveContactTemplateCredentialResponse> SaveContactTemplateCredentialAsync(SaveContactTemplateCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveContactTemplateCredentialWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改域名dns任务,对外开放接口，用于domain中</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForModifyingDomainDnsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForModifyingDomainDnsResponse
        /// </returns>
        public SaveTaskForModifyingDomainDnsResponse SaveTaskForModifyingDomainDnsWithOptions(SaveTaskForModifyingDomainDnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunDns))
            {
                query["AliyunDns"] = request.AliyunDns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsList))
            {
                query["DnsList"] = request.DnsList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForModifyingDomainDns",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForModifyingDomainDnsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改域名dns任务,对外开放接口，用于domain中</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForModifyingDomainDnsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForModifyingDomainDnsResponse
        /// </returns>
        public async Task<SaveTaskForModifyingDomainDnsResponse> SaveTaskForModifyingDomainDnsWithOptionsAsync(SaveTaskForModifyingDomainDnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunDns))
            {
                query["AliyunDns"] = request.AliyunDns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsList))
            {
                query["DnsList"] = request.DnsList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForModifyingDomainDns",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForModifyingDomainDnsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改域名dns任务,对外开放接口，用于domain中</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForModifyingDomainDnsRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForModifyingDomainDnsResponse
        /// </returns>
        public SaveTaskForModifyingDomainDnsResponse SaveTaskForModifyingDomainDns(SaveTaskForModifyingDomainDnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForModifyingDomainDnsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改域名dns任务,对外开放接口，用于domain中</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForModifyingDomainDnsRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForModifyingDomainDnsResponse
        /// </returns>
        public async Task<SaveTaskForModifyingDomainDnsResponse> SaveTaskForModifyingDomainDnsAsync(SaveTaskForModifyingDomainDnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForModifyingDomainDnsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存域名实名资料任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainNameCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainNameCredentialResponse
        /// </returns>
        public SaveTaskForSubmittingDomainNameCredentialResponse SaveTaskForSubmittingDomainNameCredentialWithOptions(SaveTaskForSubmittingDomainNameCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credential))
            {
                query["Credential"] = request.Credential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialNo))
            {
                query["CredentialNo"] = request.CredentialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialType))
            {
                query["CredentialType"] = request.CredentialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForSubmittingDomainNameCredential",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForSubmittingDomainNameCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存域名实名资料任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainNameCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainNameCredentialResponse
        /// </returns>
        public async Task<SaveTaskForSubmittingDomainNameCredentialResponse> SaveTaskForSubmittingDomainNameCredentialWithOptionsAsync(SaveTaskForSubmittingDomainNameCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credential))
            {
                query["Credential"] = request.Credential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialNo))
            {
                query["CredentialNo"] = request.CredentialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialType))
            {
                query["CredentialType"] = request.CredentialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForSubmittingDomainNameCredential",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForSubmittingDomainNameCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存域名实名资料任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainNameCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainNameCredentialResponse
        /// </returns>
        public SaveTaskForSubmittingDomainNameCredentialResponse SaveTaskForSubmittingDomainNameCredential(SaveTaskForSubmittingDomainNameCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForSubmittingDomainNameCredentialWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存域名实名资料任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainNameCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainNameCredentialResponse
        /// </returns>
        public async Task<SaveTaskForSubmittingDomainNameCredentialResponse> SaveTaskForSubmittingDomainNameCredentialAsync(SaveTaskForSubmittingDomainNameCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForSubmittingDomainNameCredentialWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板保存域名的实名认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainNameCredentialByTemplateIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainNameCredentialByTemplateIdResponse
        /// </returns>
        public SaveTaskForSubmittingDomainNameCredentialByTemplateIdResponse SaveTaskForSubmittingDomainNameCredentialByTemplateIdWithOptions(SaveTaskForSubmittingDomainNameCredentialByTemplateIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForSubmittingDomainNameCredentialByTemplateId",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForSubmittingDomainNameCredentialByTemplateIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板保存域名的实名认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainNameCredentialByTemplateIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainNameCredentialByTemplateIdResponse
        /// </returns>
        public async Task<SaveTaskForSubmittingDomainNameCredentialByTemplateIdResponse> SaveTaskForSubmittingDomainNameCredentialByTemplateIdWithOptionsAsync(SaveTaskForSubmittingDomainNameCredentialByTemplateIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForSubmittingDomainNameCredentialByTemplateId",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForSubmittingDomainNameCredentialByTemplateIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板保存域名的实名认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainNameCredentialByTemplateIdRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainNameCredentialByTemplateIdResponse
        /// </returns>
        public SaveTaskForSubmittingDomainNameCredentialByTemplateIdResponse SaveTaskForSubmittingDomainNameCredentialByTemplateId(SaveTaskForSubmittingDomainNameCredentialByTemplateIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForSubmittingDomainNameCredentialByTemplateIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板保存域名的实名认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainNameCredentialByTemplateIdRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainNameCredentialByTemplateIdResponse
        /// </returns>
        public async Task<SaveTaskForSubmittingDomainNameCredentialByTemplateIdResponse> SaveTaskForSubmittingDomainNameCredentialByTemplateIdAsync(SaveTaskForSubmittingDomainNameCredentialByTemplateIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForSubmittingDomainNameCredentialByTemplateIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存修改联系人的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForUpdatingContactByTempateIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForUpdatingContactByTempateIdResponse
        /// </returns>
        public SaveTaskForUpdatingContactByTempateIdResponse SaveTaskForUpdatingContactByTempateIdWithOptions(SaveTaskForUpdatingContactByTempateIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddTransferLock))
            {
                query["AddTransferLock"] = request.AddTransferLock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactType))
            {
                query["ContactType"] = request.ContactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForUpdatingContactByTempateId",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForUpdatingContactByTempateIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存修改联系人的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForUpdatingContactByTempateIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForUpdatingContactByTempateIdResponse
        /// </returns>
        public async Task<SaveTaskForUpdatingContactByTempateIdResponse> SaveTaskForUpdatingContactByTempateIdWithOptionsAsync(SaveTaskForUpdatingContactByTempateIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddTransferLock))
            {
                query["AddTransferLock"] = request.AddTransferLock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactType))
            {
                query["ContactType"] = request.ContactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForUpdatingContactByTempateId",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForUpdatingContactByTempateIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存修改联系人的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForUpdatingContactByTempateIdRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForUpdatingContactByTempateIdResponse
        /// </returns>
        public SaveTaskForUpdatingContactByTempateIdResponse SaveTaskForUpdatingContactByTempateId(SaveTaskForUpdatingContactByTempateIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForUpdatingContactByTempateIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存修改联系人的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForUpdatingContactByTempateIdRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForUpdatingContactByTempateIdResponse
        /// </returns>
        public async Task<SaveTaskForUpdatingContactByTempateIdResponse> SaveTaskForUpdatingContactByTempateIdAsync(SaveTaskForUpdatingContactByTempateIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForUpdatingContactByTempateIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存修改联系人的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForUpdatingContactByTemplateIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForUpdatingContactByTemplateIdResponse
        /// </returns>
        public SaveTaskForUpdatingContactByTemplateIdResponse SaveTaskForUpdatingContactByTemplateIdWithOptions(SaveTaskForUpdatingContactByTemplateIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddTransferLock))
            {
                query["AddTransferLock"] = request.AddTransferLock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactType))
            {
                query["ContactType"] = request.ContactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForUpdatingContactByTemplateId",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForUpdatingContactByTemplateIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存修改联系人的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForUpdatingContactByTemplateIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForUpdatingContactByTemplateIdResponse
        /// </returns>
        public async Task<SaveTaskForUpdatingContactByTemplateIdResponse> SaveTaskForUpdatingContactByTemplateIdWithOptionsAsync(SaveTaskForUpdatingContactByTemplateIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddTransferLock))
            {
                query["AddTransferLock"] = request.AddTransferLock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactType))
            {
                query["ContactType"] = request.ContactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleId))
            {
                query["SaleId"] = request.SaleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForUpdatingContactByTemplateId",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForUpdatingContactByTemplateIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存修改联系人的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForUpdatingContactByTemplateIdRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForUpdatingContactByTemplateIdResponse
        /// </returns>
        public SaveTaskForUpdatingContactByTemplateIdResponse SaveTaskForUpdatingContactByTemplateId(SaveTaskForUpdatingContactByTemplateIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForUpdatingContactByTemplateIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存修改联系人的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForUpdatingContactByTemplateIdRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForUpdatingContactByTemplateIdResponse
        /// </returns>
        public async Task<SaveTaskForUpdatingContactByTemplateIdResponse> SaveTaskForUpdatingContactByTemplateIdAsync(SaveTaskForUpdatingContactByTemplateIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForUpdatingContactByTemplateIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启或者关闭whois保护</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WhoisProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WhoisProtectionResponse
        /// </returns>
        public WhoisProtectionResponse WhoisProtectionWithOptions(WhoisProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataContent))
            {
                query["DataContent"] = request.DataContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                query["DataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhoisProtect))
            {
                query["WhoisProtect"] = request.WhoisProtect;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WhoisProtection",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WhoisProtectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启或者关闭whois保护</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WhoisProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WhoisProtectionResponse
        /// </returns>
        public async Task<WhoisProtectionResponse> WhoisProtectionWithOptionsAsync(WhoisProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataContent))
            {
                query["DataContent"] = request.DataContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                query["DataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhoisProtect))
            {
                query["WhoisProtect"] = request.WhoisProtect;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WhoisProtection",
                Version = "2016-05-11",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WhoisProtectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启或者关闭whois保护</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WhoisProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// WhoisProtectionResponse
        /// </returns>
        public WhoisProtectionResponse WhoisProtection(WhoisProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WhoisProtectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启或者关闭whois保护</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WhoisProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// WhoisProtectionResponse
        /// </returns>
        public async Task<WhoisProtectionResponse> WhoisProtectionAsync(WhoisProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WhoisProtectionWithOptionsAsync(request, runtime);
        }

    }
}
