// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CodeSec20260401.Models;

namespace AlibabaCloud.SDK.CodeSec20260401
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("codesec", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Finalize code bundle after client PUT to OSS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CompleteCodeBundleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CompleteCodeBundleResponse
        /// </returns>
        public CompleteCodeBundleResponse CompleteCodeBundleWithOptions(string projectId, string codeBundleId, CompleteCodeBundleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ByteSize))
            {
                query["byteSize"] = request.ByteSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                query["contentType"] = request.ContentType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompleteCodeBundle",
                Version = "2026-04-01",
                Protocol = "HTTPS",
                Pathname = "/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/codeBundles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(codeBundleId) + "/complete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompleteCodeBundleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Finalize code bundle after client PUT to OSS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CompleteCodeBundleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CompleteCodeBundleResponse
        /// </returns>
        public async Task<CompleteCodeBundleResponse> CompleteCodeBundleWithOptionsAsync(string projectId, string codeBundleId, CompleteCodeBundleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ByteSize))
            {
                query["byteSize"] = request.ByteSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                query["contentType"] = request.ContentType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CompleteCodeBundle",
                Version = "2026-04-01",
                Protocol = "HTTPS",
                Pathname = "/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/codeBundles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(codeBundleId) + "/complete",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CompleteCodeBundleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Finalize code bundle after client PUT to OSS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CompleteCodeBundleRequest
        /// </param>
        /// 
        /// <returns>
        /// CompleteCodeBundleResponse
        /// </returns>
        public CompleteCodeBundleResponse CompleteCodeBundle(string projectId, string codeBundleId, CompleteCodeBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CompleteCodeBundleWithOptions(projectId, codeBundleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Finalize code bundle after client PUT to OSS</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CompleteCodeBundleRequest
        /// </param>
        /// 
        /// <returns>
        /// CompleteCodeBundleResponse
        /// </returns>
        public async Task<CompleteCodeBundleResponse> CompleteCodeBundleAsync(string projectId, string codeBundleId, CompleteCodeBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CompleteCodeBundleWithOptionsAsync(projectId, codeBundleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create pending code bundle with CI metadata and issue direct-to-OSS PUT credentials</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCodeBundleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCodeBundleResponse
        /// </returns>
        public CreateCodeBundleResponse CreateCodeBundleWithOptions(string projectId, CreateCodeBundleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CiMetadata))
            {
                query["ciMetadata"] = request.CiMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filename))
            {
                query["filename"] = request.Filename;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCodeBundle",
                Version = "2026-04-01",
                Protocol = "HTTPS",
                Pathname = "/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/codeBundles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCodeBundleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create pending code bundle with CI metadata and issue direct-to-OSS PUT credentials</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCodeBundleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCodeBundleResponse
        /// </returns>
        public async Task<CreateCodeBundleResponse> CreateCodeBundleWithOptionsAsync(string projectId, CreateCodeBundleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CiMetadata))
            {
                query["ciMetadata"] = request.CiMetadata;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filename))
            {
                query["filename"] = request.Filename;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCodeBundle",
                Version = "2026-04-01",
                Protocol = "HTTPS",
                Pathname = "/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/codeBundles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCodeBundleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create pending code bundle with CI metadata and issue direct-to-OSS PUT credentials</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCodeBundleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCodeBundleResponse
        /// </returns>
        public CreateCodeBundleResponse CreateCodeBundle(string projectId, CreateCodeBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCodeBundleWithOptions(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create pending code bundle with CI metadata and issue direct-to-OSS PUT credentials</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCodeBundleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCodeBundleResponse
        /// </returns>
        public async Task<CreateCodeBundleResponse> CreateCodeBundleAsync(string projectId, CreateCodeBundleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCodeBundleWithOptionsAsync(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create project</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
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
        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateProjectShrinkRequest request = new CreateProjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Engines))
            {
                request.EnginesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Engines, "engines", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Source))
            {
                request.SourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Source, "source", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnginesShrink))
            {
                query["engines"] = request.EnginesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstructionPrompt))
            {
                query["instructionPrompt"] = request.InstructionPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceShrink))
            {
                query["source"] = request.SourceShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2026-04-01",
                Protocol = "HTTPS",
                Pathname = "/v1/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create project</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
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
        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateProjectShrinkRequest request = new CreateProjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Engines))
            {
                request.EnginesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Engines, "engines", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Source))
            {
                request.SourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Source, "source", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnginesShrink))
            {
                query["engines"] = request.EnginesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstructionPrompt))
            {
                query["instructionPrompt"] = request.InstructionPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceShrink))
            {
                query["source"] = request.SourceShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2026-04-01",
                Protocol = "HTTPS",
                Pathname = "/v1/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create project</para>
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
        /// <para>Create project</para>
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
        /// <para>Create scan</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScanResponse
        /// </returns>
        public CreateScanResponse CreateScanWithOptions(string projectId, CreateScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeBundleId))
            {
                query["codeBundleId"] = request.CodeBundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kind))
            {
                query["kind"] = request.Kind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["taskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScan",
                Version = "2026-04-01",
                Protocol = "HTTPS",
                Pathname = "/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/scans",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create scan</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScanResponse
        /// </returns>
        public async Task<CreateScanResponse> CreateScanWithOptionsAsync(string projectId, CreateScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeBundleId))
            {
                query["codeBundleId"] = request.CodeBundleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Kind))
            {
                query["kind"] = request.Kind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["taskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScan",
                Version = "2026-04-01",
                Protocol = "HTTPS",
                Pathname = "/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/scans",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create scan</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScanResponse
        /// </returns>
        public CreateScanResponse CreateScan(string projectId, CreateScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateScanWithOptions(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create scan</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateScanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScanResponse
        /// </returns>
        public async Task<CreateScanResponse> CreateScanAsync(string projectId, CreateScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateScanWithOptionsAsync(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists projects under the current tenant with pagination. Supports fuzzy match by name or prompt.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectsResponse
        /// </returns>
        public DescribeProjectsResponse DescribeProjectsWithOptions(DescribeProjectsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["sortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["sortOrder"] = request.SortOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProjects",
                Version = "2026-04-01",
                Protocol = "HTTPS",
                Pathname = "/v1/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists projects under the current tenant with pagination. Supports fuzzy match by name or prompt.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectsResponse
        /// </returns>
        public async Task<DescribeProjectsResponse> DescribeProjectsWithOptionsAsync(DescribeProjectsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["sortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["sortOrder"] = request.SortOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProjects",
                Version = "2026-04-01",
                Protocol = "HTTPS",
                Pathname = "/v1/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists projects under the current tenant with pagination. Supports fuzzy match by name or prompt.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectsResponse
        /// </returns>
        public DescribeProjectsResponse DescribeProjects(DescribeProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeProjectsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists projects under the current tenant with pagination. Supports fuzzy match by name or prompt.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProjectsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProjectsResponse
        /// </returns>
        public async Task<DescribeProjectsResponse> DescribeProjectsAsync(DescribeProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeProjectsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get scan</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeScanResponse
        /// </returns>
        public DescribeScanResponse DescribeScanWithOptions(string projectId, string scanId, DescribeScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScan",
                Version = "2026-04-01",
                Protocol = "HTTPS",
                Pathname = "/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/scans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scanId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get scan</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeScanResponse
        /// </returns>
        public async Task<DescribeScanResponse> DescribeScanWithOptionsAsync(string projectId, string scanId, DescribeScanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScan",
                Version = "2026-04-01",
                Protocol = "HTTPS",
                Pathname = "/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/scans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scanId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get scan</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScanRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeScanResponse
        /// </returns>
        public DescribeScanResponse DescribeScan(string projectId, string scanId, DescribeScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeScanWithOptions(projectId, scanId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get scan</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScanRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeScanResponse
        /// </returns>
        public async Task<DescribeScanResponse> DescribeScanAsync(string projectId, string scanId, DescribeScanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeScanWithOptionsAsync(projectId, scanId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the task result list to retrieve detailed SAST or SCA results for a specific scan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScanResultsByEngineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeScanResultsByEngineResponse
        /// </returns>
        public DescribeScanResultsByEngineResponse DescribeScanResultsByEngineWithOptions(string projectId, string scanId, string engine, DescribeScanResultsByEngineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineState))
            {
                query["baselineState"] = request.BaselineState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageName))
            {
                query["packageName"] = request.PackageName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScanResultsByEngine",
                Version = "2026-04-01",
                Protocol = "HTTPS",
                Pathname = "/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/scans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scanId) + "/results/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(engine),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScanResultsByEngineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the task result list to retrieve detailed SAST or SCA results for a specific scan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScanResultsByEngineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeScanResultsByEngineResponse
        /// </returns>
        public async Task<DescribeScanResultsByEngineResponse> DescribeScanResultsByEngineWithOptionsAsync(string projectId, string scanId, string engine, DescribeScanResultsByEngineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaselineState))
            {
                query["baselineState"] = request.BaselineState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageName))
            {
                query["packageName"] = request.PackageName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScanResultsByEngine",
                Version = "2026-04-01",
                Protocol = "HTTPS",
                Pathname = "/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/scans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scanId) + "/results/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(engine),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScanResultsByEngineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the task result list to retrieve detailed SAST or SCA results for a specific scan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScanResultsByEngineRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeScanResultsByEngineResponse
        /// </returns>
        public DescribeScanResultsByEngineResponse DescribeScanResultsByEngine(string projectId, string scanId, string engine, DescribeScanResultsByEngineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeScanResultsByEngineWithOptions(projectId, scanId, engine, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the task result list to retrieve detailed SAST or SCA results for a specific scan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScanResultsByEngineRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeScanResultsByEngineResponse
        /// </returns>
        public async Task<DescribeScanResultsByEngineResponse> DescribeScanResultsByEngineAsync(string projectId, string scanId, string engine, DescribeScanResultsByEngineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeScanResultsByEngineWithOptionsAsync(projectId, scanId, engine, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists scan tasks under a specified project with pagination.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScansRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeScansResponse
        /// </returns>
        public DescribeScansResponse DescribeScansWithOptions(string projectId, DescribeScansRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["taskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScans",
                Version = "2026-04-01",
                Protocol = "HTTPS",
                Pathname = "/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/scans",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScansResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists scan tasks under a specified project with pagination.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScansRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeScansResponse
        /// </returns>
        public async Task<DescribeScansResponse> DescribeScansWithOptionsAsync(string projectId, DescribeScansRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["taskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeScans",
                Version = "2026-04-01",
                Protocol = "HTTPS",
                Pathname = "/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/scans",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeScansResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists scan tasks under a specified project with pagination.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScansRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeScansResponse
        /// </returns>
        public DescribeScansResponse DescribeScans(string projectId, DescribeScansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeScansWithOptions(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists scan tasks under a specified project with pagination.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeScansRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeScansResponse
        /// </returns>
        public async Task<DescribeScansResponse> DescribeScansAsync(string projectId, DescribeScansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeScansWithOptionsAsync(projectId, request, headers, runtime);
        }

    }
}
