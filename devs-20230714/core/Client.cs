// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Devs20230714.Models;

namespace AlibabaCloud.SDK.Devs20230714
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("devs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>激活身份绑定,完成OAuth授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActivateConnectionResponse
        /// </returns>
        public ActivateConnectionResponse ActivateConnectionWithOptions(string name, ActivateConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credential))
            {
                body["credential"] = request.Credential;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateConnection",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/activate",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ActivateConnectionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ActivateConnectionResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>激活身份绑定,完成OAuth授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActivateConnectionResponse
        /// </returns>
        public async Task<ActivateConnectionResponse> ActivateConnectionWithOptionsAsync(string name, ActivateConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credential))
            {
                body["credential"] = request.Credential;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateConnection",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/activate",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ActivateConnectionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ActivateConnectionResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>激活身份绑定,完成OAuth授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// ActivateConnectionResponse
        /// </returns>
        public ActivateConnectionResponse ActivateConnection(string name, ActivateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ActivateConnectionWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>激活身份绑定,完成OAuth授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// ActivateConnectionResponse
        /// </returns>
        public async Task<ActivateConnectionResponse> ActivateConnectionAsync(string name, ActivateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ActivateConnectionWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消流水线</para>
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
        /// CancelPipelineResponse
        /// </returns>
        public CancelPipelineResponse CancelPipelineWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelPipeline",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/cancel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CancelPipelineResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CancelPipelineResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消流水线</para>
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
        /// CancelPipelineResponse
        /// </returns>
        public async Task<CancelPipelineResponse> CancelPipelineWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelPipeline",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/cancel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CancelPipelineResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CancelPipelineResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消流水线</para>
        /// </summary>
        /// 
        /// <returns>
        /// CancelPipelineResponse
        /// </returns>
        public CancelPipelineResponse CancelPipeline(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelPipelineWithOptions(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消流水线</para>
        /// </summary>
        /// 
        /// <returns>
        /// CancelPipelineResponse
        /// </returns>
        public async Task<CancelPipelineResponse> CancelPipelineAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelPipelineWithOptionsAsync(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消任务</para>
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
        /// CancelTaskResponse
        /// </returns>
        public CancelTaskResponse CancelTaskWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/cancel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CancelTaskResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CancelTaskResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消任务</para>
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
        /// CancelTaskResponse
        /// </returns>
        public async Task<CancelTaskResponse> CancelTaskWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/cancel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CancelTaskResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CancelTaskResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// CancelTaskResponse
        /// </returns>
        public CancelTaskResponse CancelTask(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelTaskWithOptions(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// CancelTaskResponse
        /// </returns>
        public async Task<CancelTaskResponse> CancelTaskAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelTaskWithOptionsAsync(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建交付物存储</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateArtifactRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactResponse
        /// </returns>
        public CreateArtifactResponse CreateArtifactWithOptions(CreateArtifactRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateArtifact",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/artifacts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateArtifactResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateArtifactResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建交付物存储</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateArtifactRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactResponse
        /// </returns>
        public async Task<CreateArtifactResponse> CreateArtifactWithOptionsAsync(CreateArtifactRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateArtifact",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/artifacts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateArtifactResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateArtifactResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建交付物存储</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateArtifactRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactResponse
        /// </returns>
        public CreateArtifactResponse CreateArtifact(CreateArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateArtifactWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建交付物存储</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateArtifactRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateArtifactResponse
        /// </returns>
        public async Task<CreateArtifactResponse> CreateArtifactAsync(CreateArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateArtifactWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建环境</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEnvironmentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEnvironmentResponse
        /// </returns>
        public CreateEnvironmentResponse CreateEnvironmentWithOptions(string projectName, CreateEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/environments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateEnvironmentResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateEnvironmentResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建环境</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEnvironmentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEnvironmentResponse
        /// </returns>
        public async Task<CreateEnvironmentResponse> CreateEnvironmentWithOptionsAsync(string projectName, CreateEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/environments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateEnvironmentResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建环境</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEnvironmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEnvironmentResponse
        /// </returns>
        public CreateEnvironmentResponse CreateEnvironment(string projectName, CreateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateEnvironmentWithOptions(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建环境</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEnvironmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEnvironmentResponse
        /// </returns>
        public async Task<CreateEnvironmentResponse> CreateEnvironmentAsync(string projectName, CreateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateEnvironmentWithOptionsAsync(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePipelineResponse
        /// </returns>
        public CreatePipelineResponse CreatePipelineWithOptions(CreatePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePipeline",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreatePipelineResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreatePipelineResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePipelineResponse
        /// </returns>
        public async Task<CreatePipelineResponse> CreatePipelineWithOptionsAsync(CreatePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePipeline",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreatePipelineResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreatePipelineResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePipelineResponse
        /// </returns>
        public CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePipelineWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePipelineResponse
        /// </returns>
        public async Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePipelineWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateProjectResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateProjectResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateProjectResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateProjectResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProjectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public CreateTaskResponse CreateTaskWithOptions(CreateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateTaskResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateTaskResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public async Task<CreateTaskResponse> CreateTaskWithOptionsAsync(CreateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateTaskResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateTaskResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public CreateTaskResponse CreateTask(CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public async Task<CreateTaskResponse> CreateTaskAsync(CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除交付物</para>
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
        /// DeleteArtifactResponse
        /// </returns>
        public DeleteArtifactResponse DeleteArtifactWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteArtifact",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/artifacts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteArtifactResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteArtifactResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除交付物</para>
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
        /// DeleteArtifactResponse
        /// </returns>
        public async Task<DeleteArtifactResponse> DeleteArtifactWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteArtifact",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/artifacts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteArtifactResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteArtifactResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除交付物</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteArtifactResponse
        /// </returns>
        public DeleteArtifactResponse DeleteArtifact(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteArtifactWithOptions(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除交付物</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteArtifactResponse
        /// </returns>
        public async Task<DeleteArtifactResponse> DeleteArtifactAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteArtifactWithOptionsAsync(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除身份绑定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteConnectionResponse
        /// </returns>
        public DeleteConnectionResponse DeleteConnectionWithOptions(string name, DeleteConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConnection",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteConnectionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteConnectionResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除身份绑定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteConnectionResponse
        /// </returns>
        public async Task<DeleteConnectionResponse> DeleteConnectionWithOptionsAsync(string name, DeleteConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConnection",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteConnectionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteConnectionResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除身份绑定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteConnectionResponse
        /// </returns>
        public DeleteConnectionResponse DeleteConnection(string name, DeleteConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConnectionWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除身份绑定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteConnectionResponse
        /// </returns>
        public async Task<DeleteConnectionResponse> DeleteConnectionAsync(string name, DeleteConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConnectionWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除环境</para>
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
        /// DeleteEnvironmentResponse
        /// </returns>
        public DeleteEnvironmentResponse DeleteEnvironmentWithOptions(string projectName, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteEnvironmentResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteEnvironmentResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除环境</para>
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
        /// DeleteEnvironmentResponse
        /// </returns>
        public async Task<DeleteEnvironmentResponse> DeleteEnvironmentWithOptionsAsync(string projectName, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteEnvironmentResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除环境</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteEnvironmentResponse
        /// </returns>
        public DeleteEnvironmentResponse DeleteEnvironment(string projectName, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEnvironmentWithOptions(projectName, name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除环境</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteEnvironmentResponse
        /// </returns>
        public async Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(string projectName, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEnvironmentWithOptionsAsync(projectName, name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProjectResponse
        /// </returns>
        public DeleteProjectResponse DeleteProjectWithOptions(string name, DeleteProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteProjectResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteProjectResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProjectResponse
        /// </returns>
        public async Task<DeleteProjectResponse> DeleteProjectWithOptionsAsync(string name, DeleteProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteProjectResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteProjectResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteProjectResponse
        /// </returns>
        public DeleteProjectResponse DeleteProject(string name, DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProjectWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteProjectResponse
        /// </returns>
        public async Task<DeleteProjectResponse> DeleteProjectAsync(string name, DeleteProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProjectWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>手动触发环境部署</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployEnvironmentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeployEnvironmentResponse
        /// </returns>
        public DeployEnvironmentResponse DeployEnvironmentWithOptions(string projectName, string name, DeployEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/deploy",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeployEnvironmentResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeployEnvironmentResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>手动触发环境部署</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployEnvironmentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeployEnvironmentResponse
        /// </returns>
        public async Task<DeployEnvironmentResponse> DeployEnvironmentWithOptionsAsync(string projectName, string name, DeployEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/deploy",
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeployEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeployEnvironmentResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>手动触发环境部署</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployEnvironmentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeployEnvironmentResponse
        /// </returns>
        public DeployEnvironmentResponse DeployEnvironment(string projectName, string name, DeployEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeployEnvironmentWithOptions(projectName, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>手动触发环境部署</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployEnvironmentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeployEnvironmentResponse
        /// </returns>
        public async Task<DeployEnvironmentResponse> DeployEnvironmentAsync(string projectName, string name, DeployEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeployEnvironmentWithOptionsAsync(projectName, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取交付物的zip包临时下载地址url</para>
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
        /// FetchArtifactDownloadUrlResponse
        /// </returns>
        public FetchArtifactDownloadUrlResponse FetchArtifactDownloadUrlWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchArtifactDownloadUrl",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/artifacts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/fetchCode",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<FetchArtifactDownloadUrlResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<FetchArtifactDownloadUrlResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取交付物的zip包临时下载地址url</para>
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
        /// FetchArtifactDownloadUrlResponse
        /// </returns>
        public async Task<FetchArtifactDownloadUrlResponse> FetchArtifactDownloadUrlWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchArtifactDownloadUrl",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/artifacts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/fetchCode",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<FetchArtifactDownloadUrlResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<FetchArtifactDownloadUrlResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取交付物的zip包临时下载地址url</para>
        /// </summary>
        /// 
        /// <returns>
        /// FetchArtifactDownloadUrlResponse
        /// </returns>
        public FetchArtifactDownloadUrlResponse FetchArtifactDownloadUrl(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FetchArtifactDownloadUrlWithOptions(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取交付物的zip包临时下载地址url</para>
        /// </summary>
        /// 
        /// <returns>
        /// FetchArtifactDownloadUrlResponse
        /// </returns>
        public async Task<FetchArtifactDownloadUrlResponse> FetchArtifactDownloadUrlAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FetchArtifactDownloadUrlWithOptionsAsync(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取交付物临时上传的bucket、object和临时sts</para>
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
        /// FetchArtifactTempBucketTokenResponse
        /// </returns>
        public FetchArtifactTempBucketTokenResponse FetchArtifactTempBucketTokenWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchArtifactTempBucketToken",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/artifacts/action/fetchTempBucketToken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<FetchArtifactTempBucketTokenResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<FetchArtifactTempBucketTokenResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取交付物临时上传的bucket、object和临时sts</para>
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
        /// FetchArtifactTempBucketTokenResponse
        /// </returns>
        public async Task<FetchArtifactTempBucketTokenResponse> FetchArtifactTempBucketTokenWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchArtifactTempBucketToken",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/artifacts/action/fetchTempBucketToken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<FetchArtifactTempBucketTokenResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<FetchArtifactTempBucketTokenResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取交付物临时上传的bucket、object和临时sts</para>
        /// </summary>
        /// 
        /// <returns>
        /// FetchArtifactTempBucketTokenResponse
        /// </returns>
        public FetchArtifactTempBucketTokenResponse FetchArtifactTempBucketToken()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FetchArtifactTempBucketTokenWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取交付物临时上传的bucket、object和临时sts</para>
        /// </summary>
        /// 
        /// <returns>
        /// FetchArtifactTempBucketTokenResponse
        /// </returns>
        public async Task<FetchArtifactTempBucketTokenResponse> FetchArtifactTempBucketTokenAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FetchArtifactTempBucketTokenWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询身份绑定中的凭证信息</para>
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
        /// FetchConnectionCredentialResponse
        /// </returns>
        public FetchConnectionCredentialResponse FetchConnectionCredentialWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchConnectionCredential",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/fetchCredential",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<FetchConnectionCredentialResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<FetchConnectionCredentialResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询身份绑定中的凭证信息</para>
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
        /// FetchConnectionCredentialResponse
        /// </returns>
        public async Task<FetchConnectionCredentialResponse> FetchConnectionCredentialWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FetchConnectionCredential",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/fetchCredential",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<FetchConnectionCredentialResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<FetchConnectionCredentialResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询身份绑定中的凭证信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// FetchConnectionCredentialResponse
        /// </returns>
        public FetchConnectionCredentialResponse FetchConnectionCredential(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FetchConnectionCredentialWithOptions(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询身份绑定中的凭证信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// FetchConnectionCredentialResponse
        /// </returns>
        public async Task<FetchConnectionCredentialResponse> FetchConnectionCredentialAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FetchConnectionCredentialWithOptionsAsync(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询交付物</para>
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
        /// GetArtifactResponse
        /// </returns>
        public GetArtifactResponse GetArtifactWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifact",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/artifacts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetArtifactResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetArtifactResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询交付物</para>
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
        /// GetArtifactResponse
        /// </returns>
        public async Task<GetArtifactResponse> GetArtifactWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArtifact",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/artifacts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetArtifactResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetArtifactResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询交付物</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetArtifactResponse
        /// </returns>
        public GetArtifactResponse GetArtifact(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetArtifactWithOptions(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询交付物</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetArtifactResponse
        /// </returns>
        public async Task<GetArtifactResponse> GetArtifactAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetArtifactWithOptionsAsync(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取环境信息</para>
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
        /// GetEnvironmentResponse
        /// </returns>
        public GetEnvironmentResponse GetEnvironmentWithOptions(string projectName, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetEnvironmentResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetEnvironmentResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取环境信息</para>
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
        /// GetEnvironmentResponse
        /// </returns>
        public async Task<GetEnvironmentResponse> GetEnvironmentWithOptionsAsync(string projectName, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetEnvironmentResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取环境信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetEnvironmentResponse
        /// </returns>
        public GetEnvironmentResponse GetEnvironment(string projectName, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEnvironmentWithOptions(projectName, name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取环境信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetEnvironmentResponse
        /// </returns>
        public async Task<GetEnvironmentResponse> GetEnvironmentAsync(string projectName, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEnvironmentWithOptionsAsync(projectName, name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询环境部署信息</para>
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
        /// GetEnvironmentDeploymentResponse
        /// </returns>
        public GetEnvironmentDeploymentResponse GetEnvironmentDeploymentWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnvironmentDeployment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/environmentdeployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetEnvironmentDeploymentResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetEnvironmentDeploymentResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询环境部署信息</para>
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
        /// GetEnvironmentDeploymentResponse
        /// </returns>
        public async Task<GetEnvironmentDeploymentResponse> GetEnvironmentDeploymentWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnvironmentDeployment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/environmentdeployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetEnvironmentDeploymentResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetEnvironmentDeploymentResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询环境部署信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetEnvironmentDeploymentResponse
        /// </returns>
        public GetEnvironmentDeploymentResponse GetEnvironmentDeployment(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEnvironmentDeploymentWithOptions(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询环境部署信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetEnvironmentDeploymentResponse
        /// </returns>
        public async Task<GetEnvironmentDeploymentResponse> GetEnvironmentDeploymentAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEnvironmentDeploymentWithOptionsAsync(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线</para>
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
        /// GetPipelineResponse
        /// </returns>
        public GetPipelineResponse GetPipelineWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipeline",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetPipelineResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetPipelineResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线</para>
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
        /// GetPipelineResponse
        /// </returns>
        public async Task<GetPipelineResponse> GetPipelineWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPipeline",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetPipelineResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetPipelineResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPipelineResponse
        /// </returns>
        public GetPipelineResponse GetPipeline(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPipelineWithOptions(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询流水线</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetPipelineResponse
        /// </returns>
        public async Task<GetPipelineResponse> GetPipelineAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPipelineWithOptionsAsync(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询项目</para>
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
        /// GetProjectResponse
        /// </returns>
        public GetProjectResponse GetProjectWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetProjectResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetProjectResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询项目</para>
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
        /// GetProjectResponse
        /// </returns>
        public async Task<GetProjectResponse> GetProjectWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetProjectResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetProjectResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询项目</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetProjectResponse
        /// </returns>
        public GetProjectResponse GetProject(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectWithOptions(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询项目</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetProjectResponse
        /// </returns>
        public async Task<GetProjectResponse> GetProjectAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectWithOptionsAsync(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询仓库绑定</para>
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
        /// GetRepositoryResponse
        /// </returns>
        public GetRepositoryResponse GetRepositoryWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepository",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/repositories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetRepositoryResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetRepositoryResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询仓库绑定</para>
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
        /// GetRepositoryResponse
        /// </returns>
        public async Task<GetRepositoryResponse> GetRepositoryWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRepository",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/repositories/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetRepositoryResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetRepositoryResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询仓库绑定</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRepositoryResponse
        /// </returns>
        public GetRepositoryResponse GetRepository(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRepositoryWithOptions(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询仓库绑定</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRepositoryResponse
        /// </returns>
        public async Task<GetRepositoryResponse> GetRepositoryAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRepositoryWithOptionsAsync(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务部署信息</para>
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
        /// GetServiceDeploymentResponse
        /// </returns>
        public GetServiceDeploymentResponse GetServiceDeploymentWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceDeployment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/servicedeployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetServiceDeploymentResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetServiceDeploymentResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务部署信息</para>
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
        /// GetServiceDeploymentResponse
        /// </returns>
        public async Task<GetServiceDeploymentResponse> GetServiceDeploymentWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceDeployment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/servicedeployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetServiceDeploymentResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetServiceDeploymentResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务部署信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceDeploymentResponse
        /// </returns>
        public GetServiceDeploymentResponse GetServiceDeployment(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetServiceDeploymentWithOptions(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询服务部署信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetServiceDeploymentResponse
        /// </returns>
        public async Task<GetServiceDeploymentResponse> GetServiceDeploymentAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetServiceDeploymentWithOptionsAsync(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务</para>
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
        /// GetTaskResponse
        /// </returns>
        public GetTaskResponse GetTaskWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetTaskResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetTaskResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务</para>
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
        /// GetTaskResponse
        /// </returns>
        public async Task<GetTaskResponse> GetTaskWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<GetTaskResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetTaskResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTaskResponse
        /// </returns>
        public GetTaskResponse GetTask(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskWithOptions(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTaskResponse
        /// </returns>
        public async Task<GetTaskResponse> GetTaskAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskWithOptionsAsync(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询身份绑定</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListConnectionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConnectionsResponse
        /// </returns>
        public ListConnectionsResponse ListConnectionsWithOptions(ListConnectionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListConnectionsShrinkRequest request = new ListConnectionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConnections",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListConnectionsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListConnectionsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询身份绑定</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListConnectionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConnectionsResponse
        /// </returns>
        public async Task<ListConnectionsResponse> ListConnectionsWithOptionsAsync(ListConnectionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListConnectionsShrinkRequest request = new ListConnectionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConnections",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/connections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListConnectionsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListConnectionsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询身份绑定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConnectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConnectionsResponse
        /// </returns>
        public ListConnectionsResponse ListConnections(ListConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConnectionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询身份绑定</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConnectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConnectionsResponse
        /// </returns>
        public async Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConnectionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询环境列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListEnvironmentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEnvironmentsResponse
        /// </returns>
        public ListEnvironmentsResponse ListEnvironmentsWithOptions(string projectName, ListEnvironmentsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListEnvironmentsShrinkRequest request = new ListEnvironmentsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnvironments",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/environments/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListEnvironmentsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListEnvironmentsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询环境列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListEnvironmentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEnvironmentsResponse
        /// </returns>
        public async Task<ListEnvironmentsResponse> ListEnvironmentsWithOptionsAsync(string projectName, ListEnvironmentsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListEnvironmentsShrinkRequest request = new ListEnvironmentsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnvironments",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/environments/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListEnvironmentsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListEnvironmentsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询环境列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnvironmentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEnvironmentsResponse
        /// </returns>
        public ListEnvironmentsResponse ListEnvironments(string projectName, ListEnvironmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEnvironmentsWithOptions(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询环境列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnvironmentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEnvironmentsResponse
        /// </returns>
        public async Task<ListEnvironmentsResponse> ListEnvironmentsAsync(string projectName, ListEnvironmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEnvironmentsWithOptionsAsync(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询流水线</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListPipelinesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPipelinesResponse
        /// </returns>
        public ListPipelinesResponse ListPipelinesWithOptions(ListPipelinesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPipelinesShrinkRequest request = new ListPipelinesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelines",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListPipelinesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListPipelinesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询流水线</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListPipelinesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPipelinesResponse
        /// </returns>
        public async Task<ListPipelinesResponse> ListPipelinesWithOptionsAsync(ListPipelinesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPipelinesShrinkRequest request = new ListPipelinesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPipelines",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListPipelinesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListPipelinesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPipelinesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPipelinesResponse
        /// </returns>
        public ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPipelinesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询流水线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPipelinesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPipelinesResponse
        /// </returns>
        public async Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPipelinesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询项目</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListProjectsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProjectsResponse
        /// </returns>
        public ListProjectsResponse ListProjectsWithOptions(ListProjectsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProjectsShrinkRequest request = new ListProjectsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListProjectsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListProjectsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询项目</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListProjectsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProjectsResponse
        /// </returns>
        public async Task<ListProjectsResponse> ListProjectsWithOptionsAsync(ListProjectsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProjectsShrinkRequest request = new ListProjectsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListProjectsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListProjectsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProjectsResponse
        /// </returns>
        public ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProjectsResponse
        /// </returns>
        public async Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询服务部署信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListServiceDeploymentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServiceDeploymentsResponse
        /// </returns>
        public ListServiceDeploymentsResponse ListServiceDeploymentsWithOptions(ListServiceDeploymentsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListServiceDeploymentsShrinkRequest request = new ListServiceDeploymentsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceDeployments",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/servicedeployments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListServiceDeploymentsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListServiceDeploymentsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询服务部署信息</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListServiceDeploymentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServiceDeploymentsResponse
        /// </returns>
        public async Task<ListServiceDeploymentsResponse> ListServiceDeploymentsWithOptionsAsync(ListServiceDeploymentsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListServiceDeploymentsShrinkRequest request = new ListServiceDeploymentsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceDeployments",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/servicedeployments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListServiceDeploymentsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListServiceDeploymentsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询服务部署信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServiceDeploymentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServiceDeploymentsResponse
        /// </returns>
        public ListServiceDeploymentsResponse ListServiceDeployments(ListServiceDeploymentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServiceDeploymentsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询服务部署信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServiceDeploymentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServiceDeploymentsResponse
        /// </returns>
        public async Task<ListServiceDeploymentsResponse> ListServiceDeploymentsAsync(ListServiceDeploymentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServiceDeploymentsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
        public ListTasksResponse ListTasksWithOptions(ListTasksRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTasksShrinkRequest request = new ListTasksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTasksResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTasksResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
        public async Task<ListTasksResponse> ListTasksWithOptionsAsync(ListTasksRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTasksShrinkRequest request = new ListTasksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSelector))
            {
                request.LabelSelectorShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSelector, "labelSelector", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSelectorShrink))
            {
                query["labelSelector"] = request.LabelSelectorShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTasksResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTasksResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
        public ListTasksResponse ListTasks(ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTasksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
        public async Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTasksWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览环境变更信息</para>
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
        /// PreviewEnvironmentResponse
        /// </returns>
        public PreviewEnvironmentResponse PreviewEnvironmentWithOptions(string projectName, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/preview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PreviewEnvironmentResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PreviewEnvironmentResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览环境变更信息</para>
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
        /// PreviewEnvironmentResponse
        /// </returns>
        public async Task<PreviewEnvironmentResponse> PreviewEnvironmentWithOptionsAsync(string projectName, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/preview",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PreviewEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PreviewEnvironmentResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览环境变更信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// PreviewEnvironmentResponse
        /// </returns>
        public PreviewEnvironmentResponse PreviewEnvironment(string projectName, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PreviewEnvironmentWithOptions(projectName, name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预览环境变更信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// PreviewEnvironmentResponse
        /// </returns>
        public async Task<PreviewEnvironmentResponse> PreviewEnvironmentAsync(string projectName, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PreviewEnvironmentWithOptionsAsync(projectName, name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新交付物</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutArtifactRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutArtifactResponse
        /// </returns>
        public PutArtifactResponse PutArtifactWithOptions(string name, PutArtifactRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutArtifact",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/artifacts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PutArtifactResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PutArtifactResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新交付物</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutArtifactRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutArtifactResponse
        /// </returns>
        public async Task<PutArtifactResponse> PutArtifactWithOptionsAsync(string name, PutArtifactRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutArtifact",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/artifacts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PutArtifactResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PutArtifactResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新交付物</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutArtifactRequest
        /// </param>
        /// 
        /// <returns>
        /// PutArtifactResponse
        /// </returns>
        public PutArtifactResponse PutArtifact(string name, PutArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutArtifactWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新交付物</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutArtifactRequest
        /// </param>
        /// 
        /// <returns>
        /// PutArtifactResponse
        /// </returns>
        public async Task<PutArtifactResponse> PutArtifactAsync(string name, PutArtifactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutArtifactWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流水线状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutPipelineStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutPipelineStatusResponse
        /// </returns>
        public PutPipelineStatusResponse PutPipelineStatusWithOptions(string name, PutPipelineStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutPipelineStatus",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/status",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PutPipelineStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PutPipelineStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流水线状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutPipelineStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutPipelineStatusResponse
        /// </returns>
        public async Task<PutPipelineStatusResponse> PutPipelineStatusWithOptionsAsync(string name, PutPipelineStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutPipelineStatus",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/status",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PutPipelineStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PutPipelineStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流水线状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutPipelineStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// PutPipelineStatusResponse
        /// </returns>
        public PutPipelineStatusResponse PutPipelineStatus(string name, PutPipelineStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutPipelineStatusWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新流水线状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutPipelineStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// PutPipelineStatusResponse
        /// </returns>
        public async Task<PutPipelineStatusResponse> PutPipelineStatusAsync(string name, PutPipelineStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutPipelineStatusWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新替换任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutTaskStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutTaskStatusResponse
        /// </returns>
        public PutTaskStatusResponse PutTaskStatusWithOptions(string name, PutTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutTaskStatus",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/status",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PutTaskStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PutTaskStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新替换任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutTaskStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutTaskStatusResponse
        /// </returns>
        public async Task<PutTaskStatusResponse> PutTaskStatusWithOptionsAsync(string name, PutTaskStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutTaskStatus",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/status",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<PutTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PutTaskStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新替换任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// PutTaskStatusResponse
        /// </returns>
        public PutTaskStatusResponse PutTaskStatus(string name, PutTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutTaskStatusWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新替换任务状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PutTaskStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// PutTaskStatusResponse
        /// </returns>
        public async Task<PutTaskStatusResponse> PutTaskStatusAsync(string name, PutTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutTaskStatusWithOptionsAsync(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解析模板中的服务、变量配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenderServicesByTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenderServicesByTemplateResponse
        /// </returns>
        public RenderServicesByTemplateResponse RenderServicesByTemplateWithOptions(RenderServicesByTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["projectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceNameChanges))
            {
                body["serviceNameChanges"] = request.ServiceNameChanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["templateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VariableValues))
            {
                body["variableValues"] = request.VariableValues;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenderServicesByTemplate",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/templates/action/renderServices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RenderServicesByTemplateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RenderServicesByTemplateResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解析模板中的服务、变量配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenderServicesByTemplateRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenderServicesByTemplateResponse
        /// </returns>
        public async Task<RenderServicesByTemplateResponse> RenderServicesByTemplateWithOptionsAsync(RenderServicesByTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["projectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceNameChanges))
            {
                body["serviceNameChanges"] = request.ServiceNameChanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                body["templateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VariableValues))
            {
                body["variableValues"] = request.VariableValues;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenderServicesByTemplate",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/templates/action/renderServices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RenderServicesByTemplateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RenderServicesByTemplateResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解析模板中的服务、变量配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenderServicesByTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// RenderServicesByTemplateResponse
        /// </returns>
        public RenderServicesByTemplateResponse RenderServicesByTemplate(RenderServicesByTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RenderServicesByTemplateWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解析模板中的服务、变量配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenderServicesByTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// RenderServicesByTemplateResponse
        /// </returns>
        public async Task<RenderServicesByTemplateResponse> RenderServicesByTemplateAsync(RenderServicesByTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RenderServicesByTemplateWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认并继续执行任务</para>
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
        /// ResumeTaskResponse
        /// </returns>
        public ResumeTaskResponse ResumeTaskWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/resume",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ResumeTaskResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ResumeTaskResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认并继续执行任务</para>
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
        /// ResumeTaskResponse
        /// </returns>
        public async Task<ResumeTaskResponse> ResumeTaskWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/resume",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ResumeTaskResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ResumeTaskResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认并继续执行任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// ResumeTaskResponse
        /// </returns>
        public ResumeTaskResponse ResumeTask(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResumeTaskWithOptions(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认并继续执行任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// ResumeTaskResponse
        /// </returns>
        public async Task<ResumeTaskResponse> ResumeTaskAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResumeTaskWithOptionsAsync(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重试执行任务</para>
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
        /// RetryTaskResponse
        /// </returns>
        public RetryTaskResponse RetryTaskWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/retry",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RetryTaskResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RetryTaskResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重试执行任务</para>
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
        /// RetryTaskResponse
        /// </returns>
        public async Task<RetryTaskResponse> RetryTaskWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/retry",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RetryTaskResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RetryTaskResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重试执行任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// RetryTaskResponse
        /// </returns>
        public RetryTaskResponse RetryTask(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RetryTaskWithOptions(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重试执行任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// RetryTaskResponse
        /// </returns>
        public async Task<RetryTaskResponse> RetryTaskAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RetryTaskWithOptionsAsync(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开始执行流水线</para>
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
        /// StartPipelineResponse
        /// </returns>
        public StartPipelineResponse StartPipelineWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartPipeline",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<StartPipelineResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<StartPipelineResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开始执行流水线</para>
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
        /// StartPipelineResponse
        /// </returns>
        public async Task<StartPipelineResponse> StartPipelineWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartPipeline",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/pipelines/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<StartPipelineResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<StartPipelineResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开始执行流水线</para>
        /// </summary>
        /// 
        /// <returns>
        /// StartPipelineResponse
        /// </returns>
        public StartPipelineResponse StartPipeline(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartPipelineWithOptions(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开始执行流水线</para>
        /// </summary>
        /// 
        /// <returns>
        /// StartPipelineResponse
        /// </returns>
        public async Task<StartPipelineResponse> StartPipelineAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartPipelineWithOptionsAsync(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开始执行任务</para>
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
        /// StartTaskResponse
        /// </returns>
        public StartTaskResponse StartTaskWithOptions(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<StartTaskResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<StartTaskResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开始执行任务</para>
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
        /// StartTaskResponse
        /// </returns>
        public async Task<StartTaskResponse> StartTaskWithOptionsAsync(string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartTask",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name) + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<StartTaskResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<StartTaskResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开始执行任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// StartTaskResponse
        /// </returns>
        public StartTaskResponse StartTask(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartTaskWithOptions(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开始执行任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// StartTaskResponse
        /// </returns>
        public async Task<StartTaskResponse> StartTaskAsync(string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartTaskWithOptionsAsync(name, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新环境（局部更新）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEnvironmentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEnvironmentResponse
        /// </returns>
        public UpdateEnvironmentResponse UpdateEnvironmentWithOptions(string projectName, string name, UpdateEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateEnvironmentResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateEnvironmentResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新环境（局部更新）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEnvironmentRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEnvironmentResponse
        /// </returns>
        public async Task<UpdateEnvironmentResponse> UpdateEnvironmentWithOptionsAsync(string projectName, string name, UpdateEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEnvironment",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateEnvironmentResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新环境（局部更新）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEnvironmentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEnvironmentResponse
        /// </returns>
        public UpdateEnvironmentResponse UpdateEnvironment(string projectName, string name, UpdateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateEnvironmentWithOptions(projectName, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新环境（局部更新）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEnvironmentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEnvironmentResponse
        /// </returns>
        public async Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(string projectName, string name, UpdateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateEnvironmentWithOptionsAsync(projectName, name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新替换应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectResponse
        /// </returns>
        public UpdateProjectResponse UpdateProjectWithOptions(string name, UpdateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProject",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateProjectResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateProjectResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新替换应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectResponse
        /// </returns>
        public async Task<UpdateProjectResponse> UpdateProjectWithOptionsAsync(string name, UpdateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProject",
                Version = "2023-07-14",
                Protocol = "HTTPS",
                Pathname = "/2023-07-14/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(name),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateProjectResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateProjectResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新替换应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectResponse
        /// </returns>
        public UpdateProjectResponse UpdateProject(string name, UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProjectWithOptions(name, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新替换应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectResponse
        /// </returns>
        public async Task<UpdateProjectResponse> UpdateProjectAsync(string name, UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProjectWithOptionsAsync(name, request, headers, runtime);
        }

    }
}
