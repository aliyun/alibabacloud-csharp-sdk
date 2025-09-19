// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.WebsiteBuild20250429.Models;

namespace AlibabaCloud.SDK.WebsiteBuild20250429
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("websitebuild", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>绑定应用域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAppDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAppDomainResponse
        /// </returns>
        public BindAppDomainResponse BindAppDomainWithOptions(BindAppDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                query["Extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAppDomain",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAppDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定应用域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAppDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAppDomainResponse
        /// </returns>
        public async Task<BindAppDomainResponse> BindAppDomainWithOptionsAsync(BindAppDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                query["Extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAppDomain",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAppDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定应用域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAppDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAppDomainResponse
        /// </returns>
        public BindAppDomainResponse BindAppDomain(BindAppDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAppDomainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>绑定应用域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAppDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAppDomainResponse
        /// </returns>
        public async Task<BindAppDomainResponse> BindAppDomainAsync(BindAppDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAppDomainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交创建Logo任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLogoTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLogoTaskResponse
        /// </returns>
        public CreateLogoTaskResponse CreateLogoTaskWithOptions(CreateLogoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogoVersion))
            {
                query["LogoVersion"] = request.LogoVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NegativePrompt))
            {
                query["NegativePrompt"] = request.NegativePrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLogoTask",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLogoTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交创建Logo任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLogoTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLogoTaskResponse
        /// </returns>
        public async Task<CreateLogoTaskResponse> CreateLogoTaskWithOptionsAsync(CreateLogoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogoVersion))
            {
                query["LogoVersion"] = request.LogoVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NegativePrompt))
            {
                query["NegativePrompt"] = request.NegativePrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLogoTask",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLogoTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交创建Logo任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLogoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLogoTaskResponse
        /// </returns>
        public CreateLogoTaskResponse CreateLogoTask(CreateLogoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLogoTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交创建Logo任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLogoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLogoTaskResponse
        /// </returns>
        public async Task<CreateLogoTaskResponse> CreateLogoTaskAsync(CreateLogoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLogoTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除域名的SSL证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppDomainCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppDomainCertificateResponse
        /// </returns>
        public DeleteAppDomainCertificateResponse DeleteAppDomainCertificateWithOptions(DeleteAppDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppDomainCertificate",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppDomainCertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除域名的SSL证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppDomainCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppDomainCertificateResponse
        /// </returns>
        public async Task<DeleteAppDomainCertificateResponse> DeleteAppDomainCertificateWithOptionsAsync(DeleteAppDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppDomainCertificate",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppDomainCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除域名的SSL证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppDomainCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppDomainCertificateResponse
        /// </returns>
        public DeleteAppDomainCertificateResponse DeleteAppDomainCertificate(DeleteAppDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppDomainCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除域名的SSL证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppDomainCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppDomainCertificateResponse
        /// </returns>
        public async Task<DeleteAppDomainCertificateResponse> DeleteAppDomainCertificateAsync(DeleteAppDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppDomainCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除域名的跳转规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppDomainRedirectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppDomainRedirectResponse
        /// </returns>
        public DeleteAppDomainRedirectResponse DeleteAppDomainRedirectWithOptions(DeleteAppDomainRedirectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppDomainRedirect",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppDomainRedirectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除域名的跳转规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppDomainRedirectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppDomainRedirectResponse
        /// </returns>
        public async Task<DeleteAppDomainRedirectResponse> DeleteAppDomainRedirectWithOptionsAsync(DeleteAppDomainRedirectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppDomainRedirect",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppDomainRedirectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除域名的跳转规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppDomainRedirectRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppDomainRedirectResponse
        /// </returns>
        public DeleteAppDomainRedirectResponse DeleteAppDomainRedirect(DeleteAppDomainRedirectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppDomainRedirectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除域名的跳转规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAppDomainRedirectRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppDomainRedirectResponse
        /// </returns>
        public async Task<DeleteAppDomainRedirectResponse> DeleteAppDomainRedirectAsync(DeleteAppDomainRedirectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppDomainRedirectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名的DNS解析记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppDomainDnsRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppDomainDnsRecordResponse
        /// </returns>
        public DescribeAppDomainDnsRecordResponse DescribeAppDomainDnsRecordWithOptions(DescribeAppDomainDnsRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Purpose))
            {
                query["Purpose"] = request.Purpose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppDomainDnsRecord",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppDomainDnsRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名的DNS解析记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppDomainDnsRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppDomainDnsRecordResponse
        /// </returns>
        public async Task<DescribeAppDomainDnsRecordResponse> DescribeAppDomainDnsRecordWithOptionsAsync(DescribeAppDomainDnsRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Purpose))
            {
                query["Purpose"] = request.Purpose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppDomainDnsRecord",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppDomainDnsRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名的DNS解析记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppDomainDnsRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppDomainDnsRecordResponse
        /// </returns>
        public DescribeAppDomainDnsRecordResponse DescribeAppDomainDnsRecord(DescribeAppDomainDnsRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppDomainDnsRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名的DNS解析记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppDomainDnsRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppDomainDnsRecordResponse
        /// </returns>
        public async Task<DescribeAppDomainDnsRecordResponse> DescribeAppDomainDnsRecordAsync(DescribeAppDomainDnsRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppDomainDnsRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Logo创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCreateLogoTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCreateLogoTaskResponse
        /// </returns>
        public GetCreateLogoTaskResponse GetCreateLogoTaskWithOptions(GetCreateLogoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetCreateLogoTask",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCreateLogoTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Logo创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCreateLogoTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCreateLogoTaskResponse
        /// </returns>
        public async Task<GetCreateLogoTaskResponse> GetCreateLogoTaskWithOptionsAsync(GetCreateLogoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetCreateLogoTask",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCreateLogoTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Logo创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCreateLogoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCreateLogoTaskResponse
        /// </returns>
        public GetCreateLogoTaskResponse GetCreateLogoTask(GetCreateLogoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCreateLogoTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Logo创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCreateLogoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCreateLogoTaskResponse
        /// </returns>
        public async Task<GetCreateLogoTaskResponse> GetCreateLogoTaskAsync(GetCreateLogoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCreateLogoTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提供给服务商的域名查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDomainInfoForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDomainInfoForPartnerResponse
        /// </returns>
        public GetDomainInfoForPartnerResponse GetDomainInfoForPartnerWithOptions(GetDomainInfoForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDomainInfoForPartner",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainInfoForPartnerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提供给服务商的域名查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDomainInfoForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDomainInfoForPartnerResponse
        /// </returns>
        public async Task<GetDomainInfoForPartnerResponse> GetDomainInfoForPartnerWithOptionsAsync(GetDomainInfoForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDomainInfoForPartner",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDomainInfoForPartnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提供给服务商的域名查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDomainInfoForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDomainInfoForPartnerResponse
        /// </returns>
        public GetDomainInfoForPartnerResponse GetDomainInfoForPartner(GetDomainInfoForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDomainInfoForPartnerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提供给服务商的域名查询接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDomainInfoForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDomainInfoForPartnerResponse
        /// </returns>
        public async Task<GetDomainInfoForPartnerResponse> GetDomainInfoForPartnerAsync(GetDomainInfoForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDomainInfoForPartnerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名备案信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIcpFilingInfoForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIcpFilingInfoForPartnerResponse
        /// </returns>
        public GetIcpFilingInfoForPartnerResponse GetIcpFilingInfoForPartnerWithOptions(GetIcpFilingInfoForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIcpFilingInfoForPartner",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIcpFilingInfoForPartnerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名备案信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIcpFilingInfoForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIcpFilingInfoForPartnerResponse
        /// </returns>
        public async Task<GetIcpFilingInfoForPartnerResponse> GetIcpFilingInfoForPartnerWithOptionsAsync(GetIcpFilingInfoForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIcpFilingInfoForPartner",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIcpFilingInfoForPartnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名备案信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIcpFilingInfoForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIcpFilingInfoForPartnerResponse
        /// </returns>
        public GetIcpFilingInfoForPartnerResponse GetIcpFilingInfoForPartner(GetIcpFilingInfoForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIcpFilingInfoForPartnerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名备案信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIcpFilingInfoForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIcpFilingInfoForPartnerResponse
        /// </returns>
        public async Task<GetIcpFilingInfoForPartnerResponse> GetIcpFilingInfoForPartnerAsync(GetIcpFilingInfoForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIcpFilingInfoForPartnerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴获取用户SLR角色授权临时凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserTmpIdentityForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserTmpIdentityForPartnerResponse
        /// </returns>
        public GetUserTmpIdentityForPartnerResponse GetUserTmpIdentityForPartnerWithOptions(GetUserTmpIdentityForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthPurpose))
            {
                query["AuthPurpose"] = request.AuthPurpose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                query["Extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLinkedRole))
            {
                query["ServiceLinkedRole"] = request.ServiceLinkedRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserTmpIdentityForPartner",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserTmpIdentityForPartnerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴获取用户SLR角色授权临时凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserTmpIdentityForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserTmpIdentityForPartnerResponse
        /// </returns>
        public async Task<GetUserTmpIdentityForPartnerResponse> GetUserTmpIdentityForPartnerWithOptionsAsync(GetUserTmpIdentityForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthPurpose))
            {
                query["AuthPurpose"] = request.AuthPurpose;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                query["Extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLinkedRole))
            {
                query["ServiceLinkedRole"] = request.ServiceLinkedRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserTmpIdentityForPartner",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserTmpIdentityForPartnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴获取用户SLR角色授权临时凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserTmpIdentityForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserTmpIdentityForPartnerResponse
        /// </returns>
        public GetUserTmpIdentityForPartnerResponse GetUserTmpIdentityForPartner(GetUserTmpIdentityForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserTmpIdentityForPartnerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴获取用户SLR角色授权临时凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserTmpIdentityForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserTmpIdentityForPartnerResponse
        /// </returns>
        public async Task<GetUserTmpIdentityForPartnerResponse> GetUserTmpIdentityForPartnerAsync(GetUserTmpIdentityForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserTmpIdentityForPartnerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名的跳转规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppDomainRedirectRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppDomainRedirectRecordsResponse
        /// </returns>
        public ListAppDomainRedirectRecordsResponse ListAppDomainRedirectRecordsWithOptions(ListAppDomainRedirectRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppDomainRedirectRecords",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppDomainRedirectRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名的跳转规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppDomainRedirectRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppDomainRedirectRecordsResponse
        /// </returns>
        public async Task<ListAppDomainRedirectRecordsResponse> ListAppDomainRedirectRecordsWithOptionsAsync(ListAppDomainRedirectRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppDomainRedirectRecords",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppDomainRedirectRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名的跳转规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppDomainRedirectRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppDomainRedirectRecordsResponse
        /// </returns>
        public ListAppDomainRedirectRecordsResponse ListAppDomainRedirectRecords(ListAppDomainRedirectRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppDomainRedirectRecordsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名的跳转规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppDomainRedirectRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppDomainRedirectRecordsResponse
        /// </returns>
        public async Task<ListAppDomainRedirectRecordsResponse> ListAppDomainRedirectRecordsAsync(ListAppDomainRedirectRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppDomainRedirectRecordsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用实例下的所有域名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstanceDomainsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstanceDomainsResponse
        /// </returns>
        public ListAppInstanceDomainsResponse ListAppInstanceDomainsWithOptions(ListAppInstanceDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                query["OrderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppInstanceDomains",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppInstanceDomainsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用实例下的所有域名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstanceDomainsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstanceDomainsResponse
        /// </returns>
        public async Task<ListAppInstanceDomainsResponse> ListAppInstanceDomainsWithOptionsAsync(ListAppInstanceDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                query["OrderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppInstanceDomains",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppInstanceDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用实例下的所有域名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstanceDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstanceDomainsResponse
        /// </returns>
        public ListAppInstanceDomainsResponse ListAppInstanceDomains(ListAppInstanceDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppInstanceDomainsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询应用实例下的所有域名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppInstanceDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppInstanceDomainsResponse
        /// </returns>
        public async Task<ListAppInstanceDomainsResponse> ListAppInstanceDomainsAsync(ListAppInstanceDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppInstanceDomainsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴操作应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAppInstanceForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateAppInstanceForPartnerResponse
        /// </returns>
        public OperateAppInstanceForPartnerResponse OperateAppInstanceForPartnerWithOptions(OperateAppInstanceForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                query["Extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateEvent))
            {
                query["OperateEvent"] = request.OperateEvent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateAppInstanceForPartner",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateAppInstanceForPartnerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴操作应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAppInstanceForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateAppInstanceForPartnerResponse
        /// </returns>
        public async Task<OperateAppInstanceForPartnerResponse> OperateAppInstanceForPartnerWithOptionsAsync(OperateAppInstanceForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                query["Extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateEvent))
            {
                query["OperateEvent"] = request.OperateEvent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateAppInstanceForPartner",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateAppInstanceForPartnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴操作应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAppInstanceForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateAppInstanceForPartnerResponse
        /// </returns>
        public OperateAppInstanceForPartnerResponse OperateAppInstanceForPartner(OperateAppInstanceForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateAppInstanceForPartnerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴操作应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAppInstanceForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateAppInstanceForPartnerResponse
        /// </returns>
        public async Task<OperateAppInstanceForPartnerResponse> OperateAppInstanceForPartnerAsync(OperateAppInstanceForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateAppInstanceForPartnerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴操作应用服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAppServiceForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateAppServiceForPartnerResponse
        /// </returns>
        public OperateAppServiceForPartnerResponse OperateAppServiceForPartnerWithOptions(OperateAppServiceForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                query["Extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateEvent))
            {
                query["OperateEvent"] = request.OperateEvent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateAppServiceForPartner",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateAppServiceForPartnerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴操作应用服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAppServiceForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateAppServiceForPartnerResponse
        /// </returns>
        public async Task<OperateAppServiceForPartnerResponse> OperateAppServiceForPartnerWithOptionsAsync(OperateAppServiceForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                query["Extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateEvent))
            {
                query["OperateEvent"] = request.OperateEvent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateAppServiceForPartner",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateAppServiceForPartnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴操作应用服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAppServiceForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateAppServiceForPartnerResponse
        /// </returns>
        public OperateAppServiceForPartnerResponse OperateAppServiceForPartner(OperateAppServiceForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateAppServiceForPartnerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴操作应用服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAppServiceForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateAppServiceForPartnerResponse
        /// </returns>
        public async Task<OperateAppServiceForPartnerResponse> OperateAppServiceForPartnerAsync(OperateAppServiceForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateAppServiceForPartnerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片检索</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SearchImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchImageResponse
        /// </returns>
        public SearchImageResponse SearchImageWithOptions(SearchImageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchImageShrinkRequest request = new SearchImageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColorHex))
            {
                query["ColorHex"] = request.ColorHex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasPerson))
            {
                query["HasPerson"] = request.HasPerson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCategory))
            {
                query["ImageCategory"] = request.ImageCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRatio))
            {
                query["ImageRatio"] = request.ImageRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxHeight))
            {
                query["MaxHeight"] = request.MaxHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxWidth))
            {
                query["MaxWidth"] = request.MaxWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinHeight))
            {
                query["MinHeight"] = request.MinHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinWidth))
            {
                query["MinWidth"] = request.MinWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                query["Text"] = request.Text;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchImage",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片检索</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SearchImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchImageResponse
        /// </returns>
        public async Task<SearchImageResponse> SearchImageWithOptionsAsync(SearchImageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchImageShrinkRequest request = new SearchImageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColorHex))
            {
                query["ColorHex"] = request.ColorHex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasPerson))
            {
                query["HasPerson"] = request.HasPerson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCategory))
            {
                query["ImageCategory"] = request.ImageCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRatio))
            {
                query["ImageRatio"] = request.ImageRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxHeight))
            {
                query["MaxHeight"] = request.MaxHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxWidth))
            {
                query["MaxWidth"] = request.MaxWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinHeight))
            {
                query["MinHeight"] = request.MinHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinWidth))
            {
                query["MinWidth"] = request.MinWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssKey))
            {
                query["OssKey"] = request.OssKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                query["Text"] = request.Text;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchImage",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片检索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchImageRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchImageResponse
        /// </returns>
        public SearchImageResponse SearchImage(SearchImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片检索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchImageRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchImageResponse
        /// </returns>
        public async Task<SearchImageResponse> SearchImageAsync(SearchImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchImageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置域名的SSL证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAppDomainCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetAppDomainCertificateResponse
        /// </returns>
        public SetAppDomainCertificateResponse SetAppDomainCertificateWithOptions(SetAppDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateName))
            {
                query["CertificateName"] = request.CertificateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateType))
            {
                query["CertificateType"] = request.CertificateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateKey))
            {
                query["PrivateKey"] = request.PrivateKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicKey))
            {
                query["PublicKey"] = request.PublicKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetAppDomainCertificate",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAppDomainCertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置域名的SSL证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAppDomainCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetAppDomainCertificateResponse
        /// </returns>
        public async Task<SetAppDomainCertificateResponse> SetAppDomainCertificateWithOptionsAsync(SetAppDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateName))
            {
                query["CertificateName"] = request.CertificateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateType))
            {
                query["CertificateType"] = request.CertificateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateKey))
            {
                query["PrivateKey"] = request.PrivateKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicKey))
            {
                query["PublicKey"] = request.PublicKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetAppDomainCertificate",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetAppDomainCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置域名的SSL证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAppDomainCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// SetAppDomainCertificateResponse
        /// </returns>
        public SetAppDomainCertificateResponse SetAppDomainCertificate(SetAppDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAppDomainCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置域名的SSL证书</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetAppDomainCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// SetAppDomainCertificateResponse
        /// </returns>
        public async Task<SetAppDomainCertificateResponse> SetAppDomainCertificateAsync(SetAppDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAppDomainCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴同步应用实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SyncAppInstanceForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncAppInstanceForPartnerResponse
        /// </returns>
        public SyncAppInstanceForPartnerResponse SyncAppInstanceForPartnerWithOptions(SyncAppInstanceForPartnerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SyncAppInstanceForPartnerShrinkRequest request = new SyncAppInstanceForPartnerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AppInstance))
            {
                request.AppInstanceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AppInstance, "AppInstance", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceShrink))
            {
                query["AppInstance"] = request.AppInstanceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceBizId))
            {
                query["SourceBizId"] = request.SourceBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncAppInstanceForPartner",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncAppInstanceForPartnerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴同步应用实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SyncAppInstanceForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncAppInstanceForPartnerResponse
        /// </returns>
        public async Task<SyncAppInstanceForPartnerResponse> SyncAppInstanceForPartnerWithOptionsAsync(SyncAppInstanceForPartnerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SyncAppInstanceForPartnerShrinkRequest request = new SyncAppInstanceForPartnerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AppInstance))
            {
                request.AppInstanceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AppInstance, "AppInstance", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceShrink))
            {
                query["AppInstance"] = request.AppInstanceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceBizId))
            {
                query["SourceBizId"] = request.SourceBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncAppInstanceForPartner",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncAppInstanceForPartnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴同步应用实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncAppInstanceForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncAppInstanceForPartnerResponse
        /// </returns>
        public SyncAppInstanceForPartnerResponse SyncAppInstanceForPartner(SyncAppInstanceForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncAppInstanceForPartnerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴同步应用实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncAppInstanceForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncAppInstanceForPartnerResponse
        /// </returns>
        public async Task<SyncAppInstanceForPartnerResponse> SyncAppInstanceForPartnerAsync(SyncAppInstanceForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncAppInstanceForPartnerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑应用域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAppDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindAppDomainResponse
        /// </returns>
        public UnbindAppDomainResponse UnbindAppDomainWithOptions(UnbindAppDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindAppDomain",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindAppDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑应用域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAppDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindAppDomainResponse
        /// </returns>
        public async Task<UnbindAppDomainResponse> UnbindAppDomainWithOptionsAsync(UnbindAppDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindAppDomain",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindAppDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑应用域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAppDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindAppDomainResponse
        /// </returns>
        public UnbindAppDomainResponse UnbindAppDomain(UnbindAppDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindAppDomainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑应用域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindAppDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindAppDomainResponse
        /// </returns>
        public async Task<UnbindAppDomainResponse> UnbindAppDomainAsync(UnbindAppDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindAppDomainWithOptionsAsync(request, runtime);
        }

    }
}
