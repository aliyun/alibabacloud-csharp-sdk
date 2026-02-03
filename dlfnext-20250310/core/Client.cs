// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.DlfNext20250310.Models;

namespace AlibabaCloud.SDK.DlfNext20250310
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dlfnext", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>更新数据目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterCatalogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AlterCatalogResponse
        /// </returns>
        public AlterCatalogResponse AlterCatalogWithOptions(string catalog, AlterCatalogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Removals))
            {
                body["removals"] = request.Removals;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Updates))
            {
                body["updates"] = request.Updates;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AlterCatalog",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/catalogs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalog),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AlterCatalogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterCatalogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AlterCatalogResponse
        /// </returns>
        public async Task<AlterCatalogResponse> AlterCatalogWithOptionsAsync(string catalog, AlterCatalogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Removals))
            {
                body["removals"] = request.Removals;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Updates))
            {
                body["updates"] = request.Updates;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AlterCatalog",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/catalogs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalog),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AlterCatalogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterCatalogRequest
        /// </param>
        /// 
        /// <returns>
        /// AlterCatalogResponse
        /// </returns>
        public AlterCatalogResponse AlterCatalog(string catalog, AlterCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AlterCatalogWithOptions(catalog, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterCatalogRequest
        /// </param>
        /// 
        /// <returns>
        /// AlterCatalogResponse
        /// </returns>
        public async Task<AlterCatalogResponse> AlterCatalogAsync(string catalog, AlterCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AlterCatalogWithOptionsAsync(catalog, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterDatabaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AlterDatabaseResponse
        /// </returns>
        public AlterDatabaseResponse AlterDatabaseWithOptions(string catalogId, string database, AlterDatabaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Removals))
            {
                body["removals"] = request.Removals;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Updates))
            {
                body["updates"] = request.Updates;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AlterDatabase",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AlterDatabaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterDatabaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AlterDatabaseResponse
        /// </returns>
        public async Task<AlterDatabaseResponse> AlterDatabaseWithOptionsAsync(string catalogId, string database, AlterDatabaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Removals))
            {
                body["removals"] = request.Removals;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Updates))
            {
                body["updates"] = request.Updates;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AlterDatabase",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AlterDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterDatabaseRequest
        /// </param>
        /// 
        /// <returns>
        /// AlterDatabaseResponse
        /// </returns>
        public AlterDatabaseResponse AlterDatabase(string catalogId, string database, AlterDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AlterDatabaseWithOptions(catalogId, database, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterDatabaseRequest
        /// </param>
        /// 
        /// <returns>
        /// AlterDatabaseResponse
        /// </returns>
        public async Task<AlterDatabaseResponse> AlterDatabaseAsync(string catalogId, string database, AlterDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AlterDatabaseWithOptionsAsync(catalogId, database, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新接收者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterReceiverRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AlterReceiverResponse
        /// </returns>
        public AlterReceiverResponse AlterReceiverWithOptions(string receiver, AlterReceiverRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                body["comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverName))
            {
                body["receiverName"] = request.ReceiverName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AlterReceiver",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/receivers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(receiver),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<AlterReceiverResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新接收者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterReceiverRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AlterReceiverResponse
        /// </returns>
        public async Task<AlterReceiverResponse> AlterReceiverWithOptionsAsync(string receiver, AlterReceiverRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                body["comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverName))
            {
                body["receiverName"] = request.ReceiverName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AlterReceiver",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/receivers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(receiver),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<AlterReceiverResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新接收者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterReceiverRequest
        /// </param>
        /// 
        /// <returns>
        /// AlterReceiverResponse
        /// </returns>
        public AlterReceiverResponse AlterReceiver(string receiver, AlterReceiverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AlterReceiverWithOptions(receiver, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新接收者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterReceiverRequest
        /// </param>
        /// 
        /// <returns>
        /// AlterReceiverResponse
        /// </returns>
        public async Task<AlterReceiverResponse> AlterReceiverAsync(string receiver, AlterReceiverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AlterReceiverWithOptionsAsync(receiver, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新共享</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterShareRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AlterShareResponse
        /// </returns>
        public AlterShareResponse AlterShareWithOptions(string share, AlterShareRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                body["comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableWrite))
            {
                body["enableWrite"] = request.EnableWrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareName))
            {
                body["shareName"] = request.ShareName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AlterShare",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(share),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<AlterShareResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新共享</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterShareRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AlterShareResponse
        /// </returns>
        public async Task<AlterShareResponse> AlterShareWithOptionsAsync(string share, AlterShareRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                body["comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableWrite))
            {
                body["enableWrite"] = request.EnableWrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareName))
            {
                body["shareName"] = request.ShareName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AlterShare",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(share),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<AlterShareResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新共享</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterShareRequest
        /// </param>
        /// 
        /// <returns>
        /// AlterShareResponse
        /// </returns>
        public AlterShareResponse AlterShare(string share, AlterShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AlterShareWithOptions(share, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新共享</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterShareRequest
        /// </param>
        /// 
        /// <returns>
        /// AlterShareResponse
        /// </returns>
        public async Task<AlterShareResponse> AlterShareAsync(string share, AlterShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AlterShareWithOptionsAsync(share, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新共享中的接收者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterShareReceiversRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AlterShareReceiversResponse
        /// </returns>
        public AlterShareReceiversResponse AlterShareReceiversWithOptions(string share, AlterShareReceiversRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddedReceivers))
            {
                body["addedReceivers"] = request.AddedReceivers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemovedReceivers))
            {
                body["removedReceivers"] = request.RemovedReceivers;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AlterShareReceivers",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(share) + "/receivers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<AlterShareReceiversResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新共享中的接收者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterShareReceiversRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AlterShareReceiversResponse
        /// </returns>
        public async Task<AlterShareReceiversResponse> AlterShareReceiversWithOptionsAsync(string share, AlterShareReceiversRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddedReceivers))
            {
                body["addedReceivers"] = request.AddedReceivers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemovedReceivers))
            {
                body["removedReceivers"] = request.RemovedReceivers;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AlterShareReceivers",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(share) + "/receivers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<AlterShareReceiversResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新共享中的接收者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterShareReceiversRequest
        /// </param>
        /// 
        /// <returns>
        /// AlterShareReceiversResponse
        /// </returns>
        public AlterShareReceiversResponse AlterShareReceivers(string share, AlterShareReceiversRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AlterShareReceiversWithOptions(share, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新共享中的接收者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterShareReceiversRequest
        /// </param>
        /// 
        /// <returns>
        /// AlterShareReceiversResponse
        /// </returns>
        public async Task<AlterShareReceiversResponse> AlterShareReceiversAsync(string share, AlterShareReceiversRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AlterShareReceiversWithOptionsAsync(share, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改共享资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterShareResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AlterShareResourcesResponse
        /// </returns>
        public AlterShareResourcesResponse AlterShareResourcesWithOptions(string share, AlterShareResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["catalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareResourceList))
            {
                body["shareResourceList"] = request.ShareResourceList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AlterShareResources",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(share) + "/resources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<AlterShareResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改共享资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterShareResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AlterShareResourcesResponse
        /// </returns>
        public async Task<AlterShareResourcesResponse> AlterShareResourcesWithOptionsAsync(string share, AlterShareResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogId))
            {
                body["catalogId"] = request.CatalogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareResourceList))
            {
                body["shareResourceList"] = request.ShareResourceList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AlterShareResources",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(share) + "/resources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<AlterShareResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改共享资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterShareResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// AlterShareResourcesResponse
        /// </returns>
        public AlterShareResourcesResponse AlterShareResources(string share, AlterShareResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AlterShareResourcesWithOptions(share, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改共享资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterShareResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// AlterShareResourcesResponse
        /// </returns>
        public async Task<AlterShareResourcesResponse> AlterShareResourcesAsync(string share, AlterShareResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AlterShareResourcesWithOptionsAsync(share, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改Table</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterTableRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AlterTableResponse
        /// </returns>
        public AlterTableResponse AlterTableWithOptions(string catalogId, string database, string table, AlterTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Changes))
            {
                body["changes"] = request.Changes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AlterTable",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<AlterTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改Table</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterTableRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AlterTableResponse
        /// </returns>
        public async Task<AlterTableResponse> AlterTableWithOptionsAsync(string catalogId, string database, string table, AlterTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Changes))
            {
                body["changes"] = request.Changes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AlterTable",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<AlterTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改Table</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterTableRequest
        /// </param>
        /// 
        /// <returns>
        /// AlterTableResponse
        /// </returns>
        public AlterTableResponse AlterTable(string catalogId, string database, string table, AlterTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AlterTableWithOptions(catalogId, database, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更改Table</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AlterTableRequest
        /// </param>
        /// 
        /// <returns>
        /// AlterTableResponse
        /// </returns>
        public async Task<AlterTableResponse> AlterTableAsync(string catalogId, string database, string table, AlterTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AlterTableWithOptionsAsync(catalogId, database, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGrantPermissionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGrantPermissionsResponse
        /// </returns>
        public BatchGrantPermissionsResponse BatchGrantPermissionsWithOptions(string catalogId, BatchGrantPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                body["permissions"] = request.Permissions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGrantPermissions",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/permissions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/batchgrant",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGrantPermissionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGrantPermissionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchGrantPermissionsResponse
        /// </returns>
        public async Task<BatchGrantPermissionsResponse> BatchGrantPermissionsWithOptionsAsync(string catalogId, BatchGrantPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                body["permissions"] = request.Permissions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchGrantPermissions",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/permissions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/batchgrant",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchGrantPermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGrantPermissionsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGrantPermissionsResponse
        /// </returns>
        public BatchGrantPermissionsResponse BatchGrantPermissions(string catalogId, BatchGrantPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchGrantPermissionsWithOptions(catalogId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchGrantPermissionsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchGrantPermissionsResponse
        /// </returns>
        public async Task<BatchGrantPermissionsResponse> BatchGrantPermissionsAsync(string catalogId, BatchGrantPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchGrantPermissionsWithOptionsAsync(catalogId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量取消授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRevokePermissionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRevokePermissionsResponse
        /// </returns>
        public BatchRevokePermissionsResponse BatchRevokePermissionsWithOptions(string catalogId, BatchRevokePermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                body["permissions"] = request.Permissions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchRevokePermissions",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/permissions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/batchrevoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRevokePermissionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量取消授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRevokePermissionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRevokePermissionsResponse
        /// </returns>
        public async Task<BatchRevokePermissionsResponse> BatchRevokePermissionsWithOptionsAsync(string catalogId, BatchRevokePermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                body["permissions"] = request.Permissions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchRevokePermissions",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/permissions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/batchrevoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRevokePermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量取消授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRevokePermissionsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRevokePermissionsResponse
        /// </returns>
        public BatchRevokePermissionsResponse BatchRevokePermissions(string catalogId, BatchRevokePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchRevokePermissionsWithOptions(catalogId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量取消授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRevokePermissionsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRevokePermissionsResponse
        /// </returns>
        public async Task<BatchRevokePermissionsResponse> BatchRevokePermissionsAsync(string catalogId, BatchRevokePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchRevokePermissionsWithOptionsAsync(catalogId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCatalogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCatalogResponse
        /// </returns>
        public CreateCatalogResponse CreateCatalogWithOptions(CreateCatalogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsShared))
            {
                body["isShared"] = request.IsShared;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["shareId"] = request.ShareId;
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
                Action = "CreateCatalog",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/catalogs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateCatalogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCatalogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCatalogResponse
        /// </returns>
        public async Task<CreateCatalogResponse> CreateCatalogWithOptionsAsync(CreateCatalogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsShared))
            {
                body["isShared"] = request.IsShared;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareId))
            {
                body["shareId"] = request.ShareId;
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
                Action = "CreateCatalog",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/catalogs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateCatalogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCatalogRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCatalogResponse
        /// </returns>
        public CreateCatalogResponse CreateCatalog(CreateCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateCatalogWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据目录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCatalogRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCatalogResponse
        /// </returns>
        public async Task<CreateCatalogResponse> CreateCatalogAsync(CreateCatalogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateCatalogWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatabaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatabaseResponse
        /// </returns>
        public CreateDatabaseResponse CreateDatabaseWithOptions(string catalogId, CreateDatabaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatabase",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateDatabaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatabaseRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatabaseResponse
        /// </returns>
        public async Task<CreateDatabaseResponse> CreateDatabaseWithOptionsAsync(string catalogId, CreateDatabaseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatabase",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatabaseRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatabaseResponse
        /// </returns>
        public CreateDatabaseResponse CreateDatabase(string catalogId, CreateDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDatabaseWithOptions(catalogId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据库</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatabaseRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatabaseResponse
        /// </returns>
        public async Task<CreateDatabaseResponse> CreateDatabaseAsync(string catalogId, CreateDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDatabaseWithOptionsAsync(catalogId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建接收者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateReceiverRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateReceiverResponse
        /// </returns>
        public CreateReceiverResponse CreateReceiverWithOptions(CreateReceiverRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                body["comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverName))
            {
                body["receiverName"] = request.ReceiverName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverTenantId))
            {
                body["receiverTenantId"] = request.ReceiverTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateReceiver",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/receivers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateReceiverResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建接收者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateReceiverRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateReceiverResponse
        /// </returns>
        public async Task<CreateReceiverResponse> CreateReceiverWithOptionsAsync(CreateReceiverRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                body["comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverName))
            {
                body["receiverName"] = request.ReceiverName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverTenantId))
            {
                body["receiverTenantId"] = request.ReceiverTenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateReceiver",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/receivers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateReceiverResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建接收者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateReceiverRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateReceiverResponse
        /// </returns>
        public CreateReceiverResponse CreateReceiver(CreateReceiverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateReceiverWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建接收者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateReceiverRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateReceiverResponse
        /// </returns>
        public async Task<CreateReceiverResponse> CreateReceiverAsync(CreateReceiverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateReceiverWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRoleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRoleResponse
        /// </returns>
        public CreateRoleResponse CreateRoleWithOptions(CreateRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["roleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRole",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/roles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRoleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRoleResponse
        /// </returns>
        public async Task<CreateRoleResponse> CreateRoleWithOptionsAsync(CreateRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                body["roleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRole",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/roles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRoleResponse
        /// </returns>
        public CreateRoleResponse CreateRole(CreateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRoleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRoleResponse
        /// </returns>
        public async Task<CreateRoleResponse> CreateRoleAsync(CreateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRoleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建共享</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateShareRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateShareResponse
        /// </returns>
        public CreateShareResponse CreateShareWithOptions(CreateShareRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                body["comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableWrite))
            {
                body["enableWrite"] = request.EnableWrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareName))
            {
                body["shareName"] = request.ShareName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateShare",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateShareResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建共享</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateShareRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateShareResponse
        /// </returns>
        public async Task<CreateShareResponse> CreateShareWithOptionsAsync(CreateShareRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                body["comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableWrite))
            {
                body["enableWrite"] = request.EnableWrite;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareName))
            {
                body["shareName"] = request.ShareName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateShare",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateShareResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建共享</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateShareRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateShareResponse
        /// </returns>
        public CreateShareResponse CreateShare(CreateShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateShareWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建共享</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateShareRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateShareResponse
        /// </returns>
        public async Task<CreateShareResponse> CreateShareAsync(CreateShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateShareWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTableRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTableResponse
        /// </returns>
        public CreateTableResponse CreateTableWithOptions(string catalogId, string database, CreateTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                body["schema"] = request.Schema;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTable",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTableRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTableResponse
        /// </returns>
        public async Task<CreateTableResponse> CreateTableWithOptionsAsync(string catalogId, string database, CreateTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                body["identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                body["schema"] = request.Schema;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTable",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTableRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTableResponse
        /// </returns>
        public CreateTableResponse CreateTable(string catalogId, string database, CreateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTableWithOptions(catalogId, database, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTableRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTableResponse
        /// </returns>
        public async Task<CreateTableResponse> CreateTableAsync(string catalogId, string database, CreateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTableWithOptionsAsync(catalogId, database, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRoleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRoleResponse
        /// </returns>
        public DeleteRoleResponse DeleteRoleWithOptions(DeleteRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RolePrincipal))
            {
                query["rolePrincipal"] = request.RolePrincipal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRole",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/roles",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRoleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRoleResponse
        /// </returns>
        public async Task<DeleteRoleResponse> DeleteRoleWithOptionsAsync(DeleteRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RolePrincipal))
            {
                query["rolePrincipal"] = request.RolePrincipal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRole",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/roles",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRoleResponse
        /// </returns>
        public DeleteRoleResponse DeleteRole(DeleteRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRoleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRoleResponse
        /// </returns>
        public async Task<DeleteRoleResponse> DeleteRoleAsync(DeleteRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRoleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 DLF 开通地域</para>
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
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegionsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/service/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 DLF 开通地域</para>
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
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/service/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 DLF 开通地域</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRegionsWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 DLF 开通地域</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRegionsWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据湖Catalog</para>
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
        /// DropCatalogResponse
        /// </returns>
        public DropCatalogResponse DropCatalogWithOptions(string catalog, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DropCatalog",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/catalogs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalog),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DropCatalogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据湖Catalog</para>
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
        /// DropCatalogResponse
        /// </returns>
        public async Task<DropCatalogResponse> DropCatalogWithOptionsAsync(string catalog, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DropCatalog",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/catalogs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalog),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DropCatalogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据湖Catalog</para>
        /// </summary>
        /// 
        /// <returns>
        /// DropCatalogResponse
        /// </returns>
        public DropCatalogResponse DropCatalog(string catalog)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DropCatalogWithOptions(catalog, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据湖Catalog</para>
        /// </summary>
        /// 
        /// <returns>
        /// DropCatalogResponse
        /// </returns>
        public async Task<DropCatalogResponse> DropCatalogAsync(string catalog)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DropCatalogWithOptionsAsync(catalog, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据库</para>
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
        /// DropDatabaseResponse
        /// </returns>
        public DropDatabaseResponse DropDatabaseWithOptions(string catalogId, string database, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DropDatabase",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DropDatabaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据库</para>
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
        /// DropDatabaseResponse
        /// </returns>
        public async Task<DropDatabaseResponse> DropDatabaseWithOptionsAsync(string catalogId, string database, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DropDatabase",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DropDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据库</para>
        /// </summary>
        /// 
        /// <returns>
        /// DropDatabaseResponse
        /// </returns>
        public DropDatabaseResponse DropDatabase(string catalogId, string database)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DropDatabaseWithOptions(catalogId, database, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据库</para>
        /// </summary>
        /// 
        /// <returns>
        /// DropDatabaseResponse
        /// </returns>
        public async Task<DropDatabaseResponse> DropDatabaseAsync(string catalogId, string database)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DropDatabaseWithOptionsAsync(catalogId, database, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除接收者</para>
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
        /// DropReceiverResponse
        /// </returns>
        public DropReceiverResponse DropReceiverWithOptions(string receiver, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DropReceiver",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/receivers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(receiver),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DropReceiverResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除接收者</para>
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
        /// DropReceiverResponse
        /// </returns>
        public async Task<DropReceiverResponse> DropReceiverWithOptionsAsync(string receiver, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DropReceiver",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/receivers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(receiver),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DropReceiverResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除接收者</para>
        /// </summary>
        /// 
        /// <returns>
        /// DropReceiverResponse
        /// </returns>
        public DropReceiverResponse DropReceiver(string receiver)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DropReceiverWithOptions(receiver, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除接收者</para>
        /// </summary>
        /// 
        /// <returns>
        /// DropReceiverResponse
        /// </returns>
        public async Task<DropReceiverResponse> DropReceiverAsync(string receiver)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DropReceiverWithOptionsAsync(receiver, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除共享</para>
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
        /// DropShareResponse
        /// </returns>
        public DropShareResponse DropShareWithOptions(string share, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DropShare",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(share),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DropShareResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除共享</para>
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
        /// DropShareResponse
        /// </returns>
        public async Task<DropShareResponse> DropShareWithOptionsAsync(string share, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DropShare",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(share),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DropShareResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除共享</para>
        /// </summary>
        /// 
        /// <returns>
        /// DropShareResponse
        /// </returns>
        public DropShareResponse DropShare(string share)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DropShareWithOptions(share, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除共享</para>
        /// </summary>
        /// 
        /// <returns>
        /// DropShareResponse
        /// </returns>
        public async Task<DropShareResponse> DropShareAsync(string share)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DropShareWithOptionsAsync(share, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除表</para>
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
        /// DropTableResponse
        /// </returns>
        public DropTableResponse DropTableWithOptions(string catalogId, string database, string table, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DropTable",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DropTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除表</para>
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
        /// DropTableResponse
        /// </returns>
        public async Task<DropTableResponse> DropTableWithOptionsAsync(string catalogId, string database, string table, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DropTable",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DropTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除表</para>
        /// </summary>
        /// 
        /// <returns>
        /// DropTableResponse
        /// </returns>
        public DropTableResponse DropTable(string catalogId, string database, string table)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DropTableWithOptions(catalogId, database, table, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除表</para>
        /// </summary>
        /// 
        /// <returns>
        /// DropTableResponse
        /// </returns>
        public async Task<DropTableResponse> DropTableAsync(string catalogId, string database, string table)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DropTableWithOptionsAsync(catalogId, database, table, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据湖Catalog</para>
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
        /// GetCatalogResponse
        /// </returns>
        public GetCatalogResponse GetCatalogWithOptions(string catalog, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalog",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/catalogs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalog),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据湖Catalog</para>
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
        /// GetCatalogResponse
        /// </returns>
        public async Task<GetCatalogResponse> GetCatalogWithOptionsAsync(string catalog, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalog",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/catalogs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalog),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据湖Catalog</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCatalogResponse
        /// </returns>
        public GetCatalogResponse GetCatalog(string catalog)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCatalogWithOptions(catalog, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据湖Catalog</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCatalogResponse
        /// </returns>
        public async Task<GetCatalogResponse> GetCatalogAsync(string catalog)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCatalogWithOptionsAsync(catalog, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据湖Catalog</para>
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
        /// GetCatalogByIdResponse
        /// </returns>
        public GetCatalogByIdResponse GetCatalogByIdWithOptions(string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalogById",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/catalogs/id/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogByIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据湖Catalog</para>
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
        /// GetCatalogByIdResponse
        /// </returns>
        public async Task<GetCatalogByIdResponse> GetCatalogByIdWithOptionsAsync(string id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalogById",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/catalogs/id/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(id),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据湖Catalog</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCatalogByIdResponse
        /// </returns>
        public GetCatalogByIdResponse GetCatalogById(string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCatalogByIdWithOptions(id, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据湖Catalog</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCatalogByIdResponse
        /// </returns>
        public async Task<GetCatalogByIdResponse> GetCatalogByIdAsync(string id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCatalogByIdWithOptionsAsync(id, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCatalogSummaryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCatalogSummaryResponse
        /// </returns>
        public GetCatalogSummaryResponse GetCatalogSummaryWithOptions(string catalogId, GetCatalogSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["date"] = request.Date;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalogSummary",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/storage-summary",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCatalogSummaryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCatalogSummaryResponse
        /// </returns>
        public async Task<GetCatalogSummaryResponse> GetCatalogSummaryWithOptionsAsync(string catalogId, GetCatalogSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["date"] = request.Date;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalogSummary",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/storage-summary",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCatalogSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCatalogSummaryResponse
        /// </returns>
        public GetCatalogSummaryResponse GetCatalogSummary(string catalogId, GetCatalogSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCatalogSummaryWithOptions(catalogId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCatalogSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCatalogSummaryResponse
        /// </returns>
        public async Task<GetCatalogSummaryResponse> GetCatalogSummaryAsync(string catalogId, GetCatalogSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCatalogSummaryWithOptionsAsync(catalogId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCatalogSummaryTrendRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCatalogSummaryTrendResponse
        /// </returns>
        public GetCatalogSummaryTrendResponse GetCatalogSummaryTrendWithOptions(string catalogId, GetCatalogSummaryTrendRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["startDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalogSummaryTrend",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/storage-summary/trend",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogSummaryTrendResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCatalogSummaryTrendRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCatalogSummaryTrendResponse
        /// </returns>
        public async Task<GetCatalogSummaryTrendResponse> GetCatalogSummaryTrendWithOptionsAsync(string catalogId, GetCatalogSummaryTrendRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["startDate"] = request.StartDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalogSummaryTrend",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/storage-summary/trend",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogSummaryTrendResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCatalogSummaryTrendRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCatalogSummaryTrendResponse
        /// </returns>
        public GetCatalogSummaryTrendResponse GetCatalogSummaryTrend(string catalogId, GetCatalogSummaryTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCatalogSummaryTrendWithOptions(catalogId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCatalogSummaryTrendRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCatalogSummaryTrendResponse
        /// </returns>
        public async Task<GetCatalogSummaryTrendResponse> GetCatalogSummaryTrendAsync(string catalogId, GetCatalogSummaryTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCatalogSummaryTrendWithOptionsAsync(catalogId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖Catalog的临时访问凭证</para>
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
        /// GetCatalogTokenResponse
        /// </returns>
        public GetCatalogTokenResponse GetCatalogTokenWithOptions(string catalog, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalogToken",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/catalogs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalog) + "/token",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖Catalog的临时访问凭证</para>
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
        /// GetCatalogTokenResponse
        /// </returns>
        public async Task<GetCatalogTokenResponse> GetCatalogTokenWithOptionsAsync(string catalog, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCatalogToken",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/catalogs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalog) + "/token",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCatalogTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖Catalog的临时访问凭证</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCatalogTokenResponse
        /// </returns>
        public GetCatalogTokenResponse GetCatalogToken(string catalog)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCatalogTokenWithOptions(catalog, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖Catalog的临时访问凭证</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCatalogTokenResponse
        /// </returns>
        public async Task<GetCatalogTokenResponse> GetCatalogTokenAsync(string catalog)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCatalogTokenWithOptionsAsync(catalog, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据库</para>
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
        /// GetDatabaseResponse
        /// </returns>
        public GetDatabaseResponse GetDatabaseWithOptions(string catalogId, string database, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatabase",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatabaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据库</para>
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
        /// GetDatabaseResponse
        /// </returns>
        public async Task<GetDatabaseResponse> GetDatabaseWithOptionsAsync(string catalogId, string database, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatabase",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据库</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDatabaseResponse
        /// </returns>
        public GetDatabaseResponse GetDatabase(string catalogId, string database)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDatabaseWithOptions(catalogId, database, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据库</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDatabaseResponse
        /// </returns>
        public async Task<GetDatabaseResponse> GetDatabaseAsync(string catalogId, string database)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDatabaseWithOptionsAsync(catalogId, database, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatabaseSummaryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatabaseSummaryResponse
        /// </returns>
        public GetDatabaseSummaryResponse GetDatabaseSummaryWithOptions(string catalogId, string database, GetDatabaseSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["date"] = request.Date;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatabaseSummary",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/storage-summary",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatabaseSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatabaseSummaryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDatabaseSummaryResponse
        /// </returns>
        public async Task<GetDatabaseSummaryResponse> GetDatabaseSummaryWithOptionsAsync(string catalogId, string database, GetDatabaseSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["date"] = request.Date;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDatabaseSummary",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/storage-summary",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDatabaseSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatabaseSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatabaseSummaryResponse
        /// </returns>
        public GetDatabaseSummaryResponse GetDatabaseSummary(string catalogId, string database, GetDatabaseSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDatabaseSummaryWithOptions(catalogId, database, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDatabaseSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDatabaseSummaryResponse
        /// </returns>
        public async Task<GetDatabaseSummaryResponse> GetDatabaseSummaryAsync(string catalogId, string database, GetDatabaseSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDatabaseSummaryWithOptionsAsync(catalogId, database, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看iceberg数据库</para>
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
        /// GetIcebergNamespaceResponse
        /// </returns>
        public GetIcebergNamespaceResponse GetIcebergNamespaceWithOptions(string catalogId, string namespace_, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIcebergNamespace",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/iceberg/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIcebergNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看iceberg数据库</para>
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
        /// GetIcebergNamespaceResponse
        /// </returns>
        public async Task<GetIcebergNamespaceResponse> GetIcebergNamespaceWithOptionsAsync(string catalogId, string namespace_, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIcebergNamespace",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/iceberg/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIcebergNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看iceberg数据库</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetIcebergNamespaceResponse
        /// </returns>
        public GetIcebergNamespaceResponse GetIcebergNamespace(string catalogId, string namespace_)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIcebergNamespaceWithOptions(catalogId, namespace_, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看iceberg数据库</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetIcebergNamespaceResponse
        /// </returns>
        public async Task<GetIcebergNamespaceResponse> GetIcebergNamespaceAsync(string catalogId, string namespace_)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIcebergNamespaceWithOptionsAsync(catalogId, namespace_, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
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
        /// GetIcebergTableResponse
        /// </returns>
        public GetIcebergTableResponse GetIcebergTableWithOptions(string catalogId, string namespace_, string table, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIcebergTable",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/iceberg/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIcebergTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
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
        /// GetIcebergTableResponse
        /// </returns>
        public async Task<GetIcebergTableResponse> GetIcebergTableWithOptionsAsync(string catalogId, string namespace_, string table, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIcebergTable",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/iceberg/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIcebergTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetIcebergTableResponse
        /// </returns>
        public GetIcebergTableResponse GetIcebergTable(string catalogId, string namespace_, string table)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIcebergTableWithOptions(catalogId, namespace_, table, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetIcebergTableResponse
        /// </returns>
        public async Task<GetIcebergTableResponse> GetIcebergTableAsync(string catalogId, string namespace_, string table)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIcebergTableWithOptionsAsync(catalogId, namespace_, table, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接收者</para>
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
        /// GetReceiverResponse
        /// </returns>
        public GetReceiverResponse GetReceiverWithOptions(string receiver, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReceiver",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/receivers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(receiver),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReceiverResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接收者</para>
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
        /// GetReceiverResponse
        /// </returns>
        public async Task<GetReceiverResponse> GetReceiverWithOptionsAsync(string receiver, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReceiver",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/receivers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(receiver),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReceiverResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接收者</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetReceiverResponse
        /// </returns>
        public GetReceiverResponse GetReceiver(string receiver)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetReceiverWithOptions(receiver, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接收者</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetReceiverResponse
        /// </returns>
        public async Task<GetReceiverResponse> GetReceiverAsync(string receiver)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetReceiverWithOptionsAsync(receiver, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 DLF 当前地域开通状态</para>
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
        /// GetRegionStatusResponse
        /// </returns>
        public GetRegionStatusResponse GetRegionStatusWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegionStatus",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/service/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegionStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 DLF 当前地域开通状态</para>
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
        /// GetRegionStatusResponse
        /// </returns>
        public async Task<GetRegionStatusResponse> GetRegionStatusWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegionStatus",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/service/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegionStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 DLF 当前地域开通状态</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRegionStatusResponse
        /// </returns>
        public GetRegionStatusResponse GetRegionStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRegionStatusWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 DLF 当前地域开通状态</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRegionStatusResponse
        /// </returns>
        public async Task<GetRegionStatusResponse> GetRegionStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRegionStatusWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRoleResponse
        /// </returns>
        public GetRoleResponse GetRoleWithOptions(GetRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RolePrincipal))
            {
                query["rolePrincipal"] = request.RolePrincipal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRole",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRoleResponse
        /// </returns>
        public async Task<GetRoleResponse> GetRoleWithOptionsAsync(GetRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RolePrincipal))
            {
                query["rolePrincipal"] = request.RolePrincipal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRole",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRoleResponse
        /// </returns>
        public GetRoleResponse GetRole(GetRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRoleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRoleResponse
        /// </returns>
        public async Task<GetRoleResponse> GetRoleAsync(GetRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRoleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取共享</para>
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
        /// GetShareResponse
        /// </returns>
        public GetShareResponse GetShareWithOptions(string share, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetShare",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(share),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShareResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取共享</para>
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
        /// GetShareResponse
        /// </returns>
        public async Task<GetShareResponse> GetShareWithOptionsAsync(string share, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetShare",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(share),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShareResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取共享</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetShareResponse
        /// </returns>
        public GetShareResponse GetShare(string share)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetShareWithOptions(share, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取共享</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetShareResponse
        /// </returns>
        public async Task<GetShareResponse> GetShareAsync(string share)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetShareWithOptionsAsync(share, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
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
        /// GetTableResponse
        /// </returns>
        public GetTableResponse GetTableWithOptions(string catalogId, string database, string table, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTable",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
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
        /// GetTableResponse
        /// </returns>
        public async Task<GetTableResponse> GetTableWithOptionsAsync(string catalogId, string database, string table, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTable",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTableResponse
        /// </returns>
        public GetTableResponse GetTable(string catalogId, string database, string table)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableWithOptions(catalogId, database, table, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTableResponse
        /// </returns>
        public async Task<GetTableResponse> GetTableAsync(string catalogId, string database, string table)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableWithOptionsAsync(catalogId, database, table, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表Compaction详情</para>
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
        /// GetTableCompactionResponse
        /// </returns>
        public GetTableCompactionResponse GetTableCompactionWithOptions(string catalogId, string database, string table, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableCompaction",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/compaction",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableCompactionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表Compaction详情</para>
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
        /// GetTableCompactionResponse
        /// </returns>
        public async Task<GetTableCompactionResponse> GetTableCompactionWithOptionsAsync(string catalogId, string database, string table, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableCompaction",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/compaction",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableCompactionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表Compaction详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTableCompactionResponse
        /// </returns>
        public GetTableCompactionResponse GetTableCompaction(string catalogId, string database, string table)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableCompactionWithOptions(catalogId, database, table, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表Compaction详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTableCompactionResponse
        /// </returns>
        public async Task<GetTableCompactionResponse> GetTableCompactionAsync(string catalogId, string database, string table)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableCompactionWithOptionsAsync(catalogId, database, table, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表快照</para>
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
        /// GetTableSnapshotResponse
        /// </returns>
        public GetTableSnapshotResponse GetTableSnapshotWithOptions(string catalogId, string database, string table, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableSnapshot",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/snapshot",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableSnapshotResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表快照</para>
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
        /// GetTableSnapshotResponse
        /// </returns>
        public async Task<GetTableSnapshotResponse> GetTableSnapshotWithOptionsAsync(string catalogId, string database, string table, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableSnapshot",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/snapshot",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表快照</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTableSnapshotResponse
        /// </returns>
        public GetTableSnapshotResponse GetTableSnapshot(string catalogId, string database, string table)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableSnapshotWithOptions(catalogId, database, table, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表快照</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTableSnapshotResponse
        /// </returns>
        public async Task<GetTableSnapshotResponse> GetTableSnapshotAsync(string catalogId, string database, string table)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableSnapshotWithOptionsAsync(catalogId, database, table, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableSummaryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableSummaryResponse
        /// </returns>
        public GetTableSummaryResponse GetTableSummaryWithOptions(string catalogId, string database, string table, GetTableSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["date"] = request.Date;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableSummary",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/storage-summary",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableSummaryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableSummaryResponse
        /// </returns>
        public async Task<GetTableSummaryResponse> GetTableSummaryWithOptionsAsync(string catalogId, string database, string table, GetTableSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["date"] = request.Date;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableSummary",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/storage-summary",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTableSummaryResponse
        /// </returns>
        public GetTableSummaryResponse GetTableSummary(string catalogId, string database, string table, GetTableSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableSummaryWithOptions(catalogId, database, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTableSummaryResponse
        /// </returns>
        public async Task<GetTableSummaryResponse> GetTableSummaryAsync(string catalogId, string database, string table, GetTableSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableSummaryWithOptionsAsync(catalogId, database, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表的临时访问凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableTokenResponse
        /// </returns>
        public GetTableTokenResponse GetTableTokenWithOptions(string catalogId, string database, string table, GetTableTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsInternal))
            {
                query["isInternal"] = request.IsInternal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableToken",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/token",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表的临时访问凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableTokenResponse
        /// </returns>
        public async Task<GetTableTokenResponse> GetTableTokenWithOptionsAsync(string catalogId, string database, string table, GetTableTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsInternal))
            {
                query["isInternal"] = request.IsInternal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableToken",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/token",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表的临时访问凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTableTokenResponse
        /// </returns>
        public GetTableTokenResponse GetTableToken(string catalogId, string database, string table, GetTableTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableTokenWithOptions(catalogId, database, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据湖表的临时访问凭证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTableTokenResponse
        /// </returns>
        public async Task<GetTableTokenResponse> GetTableTokenAsync(string catalogId, string database, string table, GetTableTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableTokenWithOptionsAsync(catalogId, database, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public GetUserResponse GetUserWithOptions(GetUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipal))
            {
                query["userPrincipal"] = request.UserPrincipal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipal))
            {
                query["userPrincipal"] = request.UserPrincipal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUser",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUserWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserResponse
        /// </returns>
        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUserWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量授予角色权限给用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantRoleToUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GrantRoleToUsersResponse
        /// </returns>
        public GrantRoleToUsersResponse GrantRoleToUsersWithOptions(GrantRoleToUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RolePrincipal))
            {
                body["rolePrincipal"] = request.RolePrincipal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipals))
            {
                body["userPrincipals"] = request.UserPrincipals;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantRoleToUsers",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/roles/grant",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<GrantRoleToUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量授予角色权限给用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantRoleToUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GrantRoleToUsersResponse
        /// </returns>
        public async Task<GrantRoleToUsersResponse> GrantRoleToUsersWithOptionsAsync(GrantRoleToUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RolePrincipal))
            {
                body["rolePrincipal"] = request.RolePrincipal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipals))
            {
                body["userPrincipals"] = request.UserPrincipals;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantRoleToUsers",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/roles/grant",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<GrantRoleToUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量授予角色权限给用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantRoleToUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// GrantRoleToUsersResponse
        /// </returns>
        public GrantRoleToUsersResponse GrantRoleToUsers(GrantRoleToUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GrantRoleToUsersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量授予角色权限给用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GrantRoleToUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// GrantRoleToUsersResponse
        /// </returns>
        public async Task<GrantRoleToUsersResponse> GrantRoleToUsersAsync(GrantRoleToUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GrantRoleToUsersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据目录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCatalogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCatalogsResponse
        /// </returns>
        public ListCatalogsResponse ListCatalogsWithOptions(ListCatalogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogNamePattern))
            {
                query["catalogNamePattern"] = request.CatalogNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCatalogs",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/catalogs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCatalogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据目录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCatalogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCatalogsResponse
        /// </returns>
        public async Task<ListCatalogsResponse> ListCatalogsWithOptionsAsync(ListCatalogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogNamePattern))
            {
                query["catalogNamePattern"] = request.CatalogNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCatalogs",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/catalogs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCatalogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据目录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCatalogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCatalogsResponse
        /// </returns>
        public ListCatalogsResponse ListCatalogs(ListCatalogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCatalogsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据目录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCatalogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCatalogsResponse
        /// </returns>
        public async Task<ListCatalogsResponse> ListCatalogsAsync(ListCatalogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCatalogsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatabaseDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatabaseDetailsResponse
        /// </returns>
        public ListDatabaseDetailsResponse ListDatabaseDetailsWithOptions(string catalogId, ListDatabaseDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseNamePattern))
            {
                query["databaseNamePattern"] = request.DatabaseNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatabaseDetails",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/database-details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatabaseDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatabaseDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatabaseDetailsResponse
        /// </returns>
        public async Task<ListDatabaseDetailsResponse> ListDatabaseDetailsWithOptionsAsync(string catalogId, ListDatabaseDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseNamePattern))
            {
                query["databaseNamePattern"] = request.DatabaseNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatabaseDetails",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/database-details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatabaseDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatabaseDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatabaseDetailsResponse
        /// </returns>
        public ListDatabaseDetailsResponse ListDatabaseDetails(string catalogId, ListDatabaseDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDatabaseDetailsWithOptions(catalogId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatabaseDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatabaseDetailsResponse
        /// </returns>
        public async Task<ListDatabaseDetailsResponse> ListDatabaseDetailsAsync(string catalogId, ListDatabaseDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDatabaseDetailsWithOptionsAsync(catalogId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatabasesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatabasesResponse
        /// </returns>
        public ListDatabasesResponse ListDatabasesWithOptions(string catalogId, ListDatabasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseNamePattern))
            {
                query["databaseNamePattern"] = request.DatabaseNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatabases",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatabasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatabasesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDatabasesResponse
        /// </returns>
        public async Task<ListDatabasesResponse> ListDatabasesWithOptionsAsync(string catalogId, ListDatabasesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseNamePattern))
            {
                query["databaseNamePattern"] = request.DatabaseNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDatabases",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDatabasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatabasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatabasesResponse
        /// </returns>
        public ListDatabasesResponse ListDatabases(string catalogId, ListDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDatabasesWithOptions(catalogId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看数据库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDatabasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDatabasesResponse
        /// </returns>
        public async Task<ListDatabasesResponse> ListDatabasesAsync(string catalogId, ListDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDatabasesWithOptionsAsync(catalogId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看函数列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFunctionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFunctionsResponse
        /// </returns>
        public ListFunctionsResponse ListFunctionsWithOptions(string catalogId, string database, ListFunctionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNamePattern))
            {
                query["functionNamePattern"] = request.FunctionNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctions",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/functions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看函数列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFunctionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFunctionsResponse
        /// </returns>
        public async Task<ListFunctionsResponse> ListFunctionsWithOptionsAsync(string catalogId, string database, ListFunctionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FunctionNamePattern))
            {
                query["functionNamePattern"] = request.FunctionNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctions",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/functions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看函数列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFunctionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFunctionsResponse
        /// </returns>
        public ListFunctionsResponse ListFunctions(string catalogId, string database, ListFunctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFunctionsWithOptions(catalogId, database, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看函数列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFunctionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFunctionsResponse
        /// </returns>
        public async Task<ListFunctionsResponse> ListFunctionsAsync(string catalogId, string database, ListFunctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFunctionsWithOptionsAsync(catalogId, database, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看iceberg数据库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIcebergNamespaceDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIcebergNamespaceDetailsResponse
        /// </returns>
        public ListIcebergNamespaceDetailsResponse ListIcebergNamespaceDetailsWithOptions(string catalogId, ListIcebergNamespaceDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceNamePattern))
            {
                query["namespaceNamePattern"] = request.NamespaceNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIcebergNamespaceDetails",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/iceberg/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/namespace-details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIcebergNamespaceDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看iceberg数据库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIcebergNamespaceDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIcebergNamespaceDetailsResponse
        /// </returns>
        public async Task<ListIcebergNamespaceDetailsResponse> ListIcebergNamespaceDetailsWithOptionsAsync(string catalogId, ListIcebergNamespaceDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceNamePattern))
            {
                query["namespaceNamePattern"] = request.NamespaceNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIcebergNamespaceDetails",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/iceberg/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/namespace-details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIcebergNamespaceDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看iceberg数据库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIcebergNamespaceDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIcebergNamespaceDetailsResponse
        /// </returns>
        public ListIcebergNamespaceDetailsResponse ListIcebergNamespaceDetails(string catalogId, ListIcebergNamespaceDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIcebergNamespaceDetailsWithOptions(catalogId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看iceberg数据库列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIcebergNamespaceDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIcebergNamespaceDetailsResponse
        /// </returns>
        public async Task<ListIcebergNamespaceDetailsResponse> ListIcebergNamespaceDetailsAsync(string catalogId, ListIcebergNamespaceDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIcebergNamespaceDetailsWithOptionsAsync(catalogId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看iceberg表快照列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIcebergSnapshotsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIcebergSnapshotsResponse
        /// </returns>
        public ListIcebergSnapshotsResponse ListIcebergSnapshotsWithOptions(string catalogId, string namespace_, string table, ListIcebergSnapshotsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIcebergSnapshots",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/iceberg/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/snapshots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIcebergSnapshotsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看iceberg表快照列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIcebergSnapshotsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIcebergSnapshotsResponse
        /// </returns>
        public async Task<ListIcebergSnapshotsResponse> ListIcebergSnapshotsWithOptionsAsync(string catalogId, string namespace_, string table, ListIcebergSnapshotsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIcebergSnapshots",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/iceberg/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/snapshots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIcebergSnapshotsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看iceberg表快照列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIcebergSnapshotsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIcebergSnapshotsResponse
        /// </returns>
        public ListIcebergSnapshotsResponse ListIcebergSnapshots(string catalogId, string namespace_, string table, ListIcebergSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIcebergSnapshotsWithOptions(catalogId, namespace_, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看iceberg表快照列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIcebergSnapshotsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIcebergSnapshotsResponse
        /// </returns>
        public async Task<ListIcebergSnapshotsResponse> ListIcebergSnapshotsAsync(string catalogId, string namespace_, string table, ListIcebergSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIcebergSnapshotsWithOptionsAsync(catalogId, namespace_, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看iceberg表详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIcebergTableDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIcebergTableDetailsResponse
        /// </returns>
        public ListIcebergTableDetailsResponse ListIcebergTableDetailsWithOptions(string catalogId, string namespace_, ListIcebergTableDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNamePattern))
            {
                query["tableNamePattern"] = request.TableNamePattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIcebergTableDetails",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/iceberg/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/table-details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIcebergTableDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看iceberg表详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIcebergTableDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIcebergTableDetailsResponse
        /// </returns>
        public async Task<ListIcebergTableDetailsResponse> ListIcebergTableDetailsWithOptionsAsync(string catalogId, string namespace_, ListIcebergTableDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNamePattern))
            {
                query["tableNamePattern"] = request.TableNamePattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIcebergTableDetails",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/iceberg/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/namespaces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(namespace_) + "/table-details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIcebergTableDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看iceberg表详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIcebergTableDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIcebergTableDetailsResponse
        /// </returns>
        public ListIcebergTableDetailsResponse ListIcebergTableDetails(string catalogId, string namespace_, ListIcebergTableDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIcebergTableDetailsWithOptions(catalogId, namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看iceberg表详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIcebergTableDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIcebergTableDetailsResponse
        /// </returns>
        public async Task<ListIcebergTableDetailsResponse> ListIcebergTableDetailsAsync(string catalogId, string namespace_, ListIcebergTableDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIcebergTableDetailsWithOptionsAsync(catalogId, namespace_, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPartitionSummariesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPartitionSummariesResponse
        /// </returns>
        public ListPartitionSummariesResponse ListPartitionSummariesWithOptions(string catalogId, string database, string table, ListPartitionSummariesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNamePattern))
            {
                query["partitionNamePattern"] = request.PartitionNamePattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPartitionSummaries",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/partitions/storage-summary",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPartitionSummariesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPartitionSummariesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPartitionSummariesResponse
        /// </returns>
        public async Task<ListPartitionSummariesResponse> ListPartitionSummariesWithOptionsAsync(string catalogId, string database, string table, ListPartitionSummariesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNamePattern))
            {
                query["partitionNamePattern"] = request.PartitionNamePattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPartitionSummaries",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/partitions/storage-summary",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPartitionSummariesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPartitionSummariesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPartitionSummariesResponse
        /// </returns>
        public ListPartitionSummariesResponse ListPartitionSummaries(string catalogId, string database, string table, ListPartitionSummariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPartitionSummariesWithOptions(catalogId, database, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPartitionSummariesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPartitionSummariesResponse
        /// </returns>
        public async Task<ListPartitionSummariesResponse> ListPartitionSummariesAsync(string catalogId, string database, string table, ListPartitionSummariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPartitionSummariesWithOptionsAsync(catalogId, database, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>listPartitions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPartitionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPartitionsResponse
        /// </returns>
        public ListPartitionsResponse ListPartitionsWithOptions(string catalogId, string database, string table, ListPartitionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNamePattern))
            {
                query["partitionNamePattern"] = request.PartitionNamePattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPartitions",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/partitions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPartitionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>listPartitions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPartitionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPartitionsResponse
        /// </returns>
        public async Task<ListPartitionsResponse> ListPartitionsWithOptionsAsync(string catalogId, string database, string table, ListPartitionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNamePattern))
            {
                query["partitionNamePattern"] = request.PartitionNamePattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPartitions",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/partitions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPartitionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>listPartitions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPartitionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPartitionsResponse
        /// </returns>
        public ListPartitionsResponse ListPartitions(string catalogId, string database, string table, ListPartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPartitionsWithOptions(catalogId, database, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>listPartitions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPartitionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPartitionsResponse
        /// </returns>
        public async Task<ListPartitionsResponse> ListPartitionsAsync(string catalogId, string database, string table, ListPartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPartitionsWithOptionsAsync(catalogId, database, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定资源或指定Principal的权限信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPermissionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionsResponse
        /// </returns>
        public ListPermissionsResponse ListPermissionsWithOptions(string catalogId, ListPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Function))
            {
                query["function"] = request.Function;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Principal))
            {
                query["principal"] = request.Principal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                query["table"] = request.Table;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.View))
            {
                query["view"] = request.View;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPermissions",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/permissions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPermissionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定资源或指定Principal的权限信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPermissionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionsResponse
        /// </returns>
        public async Task<ListPermissionsResponse> ListPermissionsWithOptionsAsync(string catalogId, ListPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Function))
            {
                query["function"] = request.Function;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Principal))
            {
                query["principal"] = request.Principal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Table))
            {
                query["table"] = request.Table;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.View))
            {
                query["view"] = request.View;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPermissions",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/permissions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定资源或指定Principal的权限信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPermissionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionsResponse
        /// </returns>
        public ListPermissionsResponse ListPermissions(string catalogId, ListPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPermissionsWithOptions(catalogId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定资源或指定Principal的权限信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPermissionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionsResponse
        /// </returns>
        public async Task<ListPermissionsResponse> ListPermissionsAsync(string catalogId, ListPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPermissionsWithOptionsAsync(catalogId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取提供的共享列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProvidedSharesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProvidedSharesResponse
        /// </returns>
        public ListProvidedSharesResponse ListProvidedSharesWithOptions(ListProvidedSharesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProvidedShares",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares/list/provided",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProvidedSharesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取提供的共享列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProvidedSharesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProvidedSharesResponse
        /// </returns>
        public async Task<ListProvidedSharesResponse> ListProvidedSharesWithOptionsAsync(ListProvidedSharesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProvidedShares",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares/list/provided",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProvidedSharesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取提供的共享列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProvidedSharesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProvidedSharesResponse
        /// </returns>
        public ListProvidedSharesResponse ListProvidedShares(ListProvidedSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProvidedSharesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取提供的共享列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProvidedSharesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProvidedSharesResponse
        /// </returns>
        public async Task<ListProvidedSharesResponse> ListProvidedSharesAsync(ListProvidedSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProvidedSharesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接收的共享列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReceivedSharesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListReceivedSharesResponse
        /// </returns>
        public ListReceivedSharesResponse ListReceivedSharesWithOptions(ListReceivedSharesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListReceivedShares",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares/list/received",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListReceivedSharesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接收的共享列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReceivedSharesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListReceivedSharesResponse
        /// </returns>
        public async Task<ListReceivedSharesResponse> ListReceivedSharesWithOptionsAsync(ListReceivedSharesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListReceivedShares",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares/list/received",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListReceivedSharesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接收的共享列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReceivedSharesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListReceivedSharesResponse
        /// </returns>
        public ListReceivedSharesResponse ListReceivedShares(ListReceivedSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListReceivedSharesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接收的共享列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReceivedSharesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListReceivedSharesResponse
        /// </returns>
        public async Task<ListReceivedSharesResponse> ListReceivedSharesAsync(ListReceivedSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListReceivedSharesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接收者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReceiversRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListReceiversResponse
        /// </returns>
        public ListReceiversResponse ListReceiversWithOptions(ListReceiversRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverName))
            {
                query["receiverName"] = request.ReceiverName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListReceivers",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/receivers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListReceiversResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接收者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReceiversRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListReceiversResponse
        /// </returns>
        public async Task<ListReceiversResponse> ListReceiversWithOptionsAsync(ListReceiversRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverName))
            {
                query["receiverName"] = request.ReceiverName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListReceivers",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/receivers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListReceiversResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接收者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReceiversRequest
        /// </param>
        /// 
        /// <returns>
        /// ListReceiversResponse
        /// </returns>
        public ListReceiversResponse ListReceivers(ListReceiversRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListReceiversWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取接收者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListReceiversRequest
        /// </param>
        /// 
        /// <returns>
        /// ListReceiversResponse
        /// </returns>
        public async Task<ListReceiversResponse> ListReceiversAsync(ListReceiversRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListReceiversWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRoleUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRoleUsersResponse
        /// </returns>
        public ListRoleUsersResponse ListRoleUsersWithOptions(ListRoleUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RolePrincipal))
            {
                query["rolePrincipal"] = request.RolePrincipal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoleUsers",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/roles/users/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRoleUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRoleUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRoleUsersResponse
        /// </returns>
        public async Task<ListRoleUsersResponse> ListRoleUsersWithOptionsAsync(ListRoleUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RolePrincipal))
            {
                query["rolePrincipal"] = request.RolePrincipal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoleUsers",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/roles/users/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRoleUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRoleUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRoleUsersResponse
        /// </returns>
        public ListRoleUsersResponse ListRoleUsers(ListRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRoleUsersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRoleUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRoleUsersResponse
        /// </returns>
        public async Task<ListRoleUsersResponse> ListRoleUsersAsync(ListRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRoleUsersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRolesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public ListRolesResponse ListRolesWithOptions(ListRolesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["roleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/roles/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRolesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public async Task<ListRolesResponse> ListRolesWithOptionsAsync(ListRolesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["roleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/roles/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public ListRolesResponse ListRoles(ListRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRolesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public async Task<ListRolesResponse> ListRolesAsync(ListRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRolesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取共享中的接收者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListShareReceiversRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListShareReceiversResponse
        /// </returns>
        public ListShareReceiversResponse ListShareReceiversWithOptions(string share, ListShareReceiversRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListShareReceivers",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(share) + "/receivers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListShareReceiversResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取共享中的接收者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListShareReceiversRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListShareReceiversResponse
        /// </returns>
        public async Task<ListShareReceiversResponse> ListShareReceiversWithOptionsAsync(string share, ListShareReceiversRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListShareReceivers",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(share) + "/receivers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListShareReceiversResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取共享中的接收者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListShareReceiversRequest
        /// </param>
        /// 
        /// <returns>
        /// ListShareReceiversResponse
        /// </returns>
        public ListShareReceiversResponse ListShareReceivers(string share, ListShareReceiversRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListShareReceiversWithOptions(share, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取共享中的接收者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListShareReceiversRequest
        /// </param>
        /// 
        /// <returns>
        /// ListShareReceiversResponse
        /// </returns>
        public async Task<ListShareReceiversResponse> ListShareReceiversAsync(string share, ListShareReceiversRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListShareReceiversWithOptionsAsync(share, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取共享资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListShareResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListShareResourcesResponse
        /// </returns>
        public ListShareResourcesResponse ListShareResourcesWithOptions(string share, ListShareResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListShareResources",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(share) + "/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListShareResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取共享资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListShareResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListShareResourcesResponse
        /// </returns>
        public async Task<ListShareResourcesResponse> ListShareResourcesWithOptionsAsync(string share, ListShareResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListShareResources",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/share/shares/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(share) + "/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListShareResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取共享资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListShareResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListShareResourcesResponse
        /// </returns>
        public ListShareResourcesResponse ListShareResources(string share, ListShareResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListShareResourcesWithOptions(share, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取共享资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListShareResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListShareResourcesResponse
        /// </returns>
        public async Task<ListShareResourcesResponse> ListShareResourcesAsync(string share, ListShareResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListShareResourcesWithOptionsAsync(share, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表快照列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSnapshotsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSnapshotsResponse
        /// </returns>
        public ListSnapshotsResponse ListSnapshotsWithOptions(string catalogId, string database, string table, ListSnapshotsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSnapshots",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/snapshots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSnapshotsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表快照列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSnapshotsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSnapshotsResponse
        /// </returns>
        public async Task<ListSnapshotsResponse> ListSnapshotsWithOptionsAsync(string catalogId, string database, string table, ListSnapshotsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSnapshots",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/snapshots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSnapshotsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表快照列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSnapshotsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSnapshotsResponse
        /// </returns>
        public ListSnapshotsResponse ListSnapshots(string catalogId, string database, string table, ListSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSnapshotsWithOptions(catalogId, database, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表快照列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSnapshotsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSnapshotsResponse
        /// </returns>
        public async Task<ListSnapshotsResponse> ListSnapshotsAsync(string catalogId, string database, string table, ListSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSnapshotsWithOptionsAsync(catalogId, database, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTableDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTableDetailsResponse
        /// </returns>
        public ListTableDetailsResponse ListTableDetailsWithOptions(string catalogId, string database, ListTableDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNamePattern))
            {
                query["tableNamePattern"] = request.TableNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTableDetails",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/table-details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTableDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTableDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTableDetailsResponse
        /// </returns>
        public async Task<ListTableDetailsResponse> ListTableDetailsWithOptionsAsync(string catalogId, string database, ListTableDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNamePattern))
            {
                query["tableNamePattern"] = request.TableNamePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTableDetails",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/table-details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTableDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTableDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTableDetailsResponse
        /// </returns>
        public ListTableDetailsResponse ListTableDetails(string catalogId, string database, ListTableDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTableDetailsWithOptions(catalogId, database, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTableDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTableDetailsResponse
        /// </returns>
        public async Task<ListTableDetailsResponse> ListTableDetailsAsync(string catalogId, string database, ListTableDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTableDetailsWithOptionsAsync(catalogId, database, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
        public ListTablesResponse ListTablesWithOptions(string catalogId, string database, ListTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNamePattern))
            {
                query["tableNamePattern"] = request.TableNamePattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTables",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTablesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
        public async Task<ListTablesResponse> ListTablesWithOptionsAsync(string catalogId, string database, ListTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNamePattern))
            {
                query["tableNamePattern"] = request.TableNamePattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTables",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
        public ListTablesResponse ListTables(string catalogId, string database, ListTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTablesWithOptions(catalogId, database, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看表详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
        public async Task<ListTablesResponse> ListTablesAsync(string catalogId, string database, ListTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTablesWithOptionsAsync(catalogId, database, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserRolesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserRolesResponse
        /// </returns>
        public ListUserRolesResponse ListUserRolesWithOptions(ListUserRolesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipal))
            {
                query["userPrincipal"] = request.UserPrincipal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserRoles",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/users/roles/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserRolesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserRolesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserRolesResponse
        /// </returns>
        public async Task<ListUserRolesResponse> ListUserRolesWithOptionsAsync(ListUserRolesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipal))
            {
                query["userPrincipal"] = request.UserPrincipal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserRoles",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/users/roles/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserRolesResponse
        /// </returns>
        public ListUserRolesResponse ListUserRoles(ListUserRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUserRolesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户角色列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserRolesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserRolesResponse
        /// </returns>
        public async Task<ListUserRolesResponse> ListUserRolesAsync(ListUserRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUserRolesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["userName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/users/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["userName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/users/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUsersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUsersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看视图详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListViewDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListViewDetailsResponse
        /// </returns>
        public ListViewDetailsResponse ListViewDetailsWithOptions(string catalogId, string database, ListViewDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewNamePattern))
            {
                query["viewNamePattern"] = request.ViewNamePattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListViewDetails",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/view-details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListViewDetailsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看视图详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListViewDetailsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListViewDetailsResponse
        /// </returns>
        public async Task<ListViewDetailsResponse> ListViewDetailsWithOptionsAsync(string catalogId, string database, ListViewDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewNamePattern))
            {
                query["viewNamePattern"] = request.ViewNamePattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListViewDetails",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/view-details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListViewDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看视图详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListViewDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListViewDetailsResponse
        /// </returns>
        public ListViewDetailsResponse ListViewDetails(string catalogId, string database, ListViewDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListViewDetailsWithOptions(catalogId, database, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看视图详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListViewDetailsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListViewDetailsResponse
        /// </returns>
        public async Task<ListViewDetailsResponse> ListViewDetailsAsync(string catalogId, string database, ListViewDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListViewDetailsWithOptionsAsync(catalogId, database, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看视图详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListViewsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListViewsResponse
        /// </returns>
        public ListViewsResponse ListViewsWithOptions(string catalogId, string database, ListViewsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewNamePattern))
            {
                query["viewNamePattern"] = request.ViewNamePattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListViews",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/views",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListViewsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看视图详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListViewsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListViewsResponse
        /// </returns>
        public async Task<ListViewsResponse> ListViewsWithOptionsAsync(string catalogId, string database, ListViewsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageToken))
            {
                query["pageToken"] = request.PageToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ViewNamePattern))
            {
                query["viewNamePattern"] = request.ViewNamePattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListViews",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/views",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListViewsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看视图详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListViewsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListViewsResponse
        /// </returns>
        public ListViewsResponse ListViews(string catalogId, string database, ListViewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListViewsWithOptions(catalogId, database, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看视图详情列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListViewsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListViewsResponse
        /// </returns>
        public async Task<ListViewsResponse> ListViewsAsync(string catalogId, string database, ListViewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListViewsWithOptionsAsync(catalogId, database, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>刷新用户同步</para>
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
        /// RefreshUserSyncResponse
        /// </returns>
        public RefreshUserSyncResponse RefreshUserSyncWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshUserSync",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/usersync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<RefreshUserSyncResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>刷新用户同步</para>
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
        /// RefreshUserSyncResponse
        /// </returns>
        public async Task<RefreshUserSyncResponse> RefreshUserSyncWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshUserSync",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/usersync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<RefreshUserSyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>刷新用户同步</para>
        /// </summary>
        /// 
        /// <returns>
        /// RefreshUserSyncResponse
        /// </returns>
        public RefreshUserSyncResponse RefreshUserSync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RefreshUserSyncWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>刷新用户同步</para>
        /// </summary>
        /// 
        /// <returns>
        /// RefreshUserSyncResponse
        /// </returns>
        public async Task<RefreshUserSyncResponse> RefreshUserSyncAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RefreshUserSyncWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量取消授予角色权限给用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeRoleFromUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeRoleFromUsersResponse
        /// </returns>
        public RevokeRoleFromUsersResponse RevokeRoleFromUsersWithOptions(RevokeRoleFromUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RolePrincipal))
            {
                body["rolePrincipal"] = request.RolePrincipal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipals))
            {
                body["userPrincipals"] = request.UserPrincipals;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeRoleFromUsers",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/roles/revoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<RevokeRoleFromUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量取消授予角色权限给用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeRoleFromUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeRoleFromUsersResponse
        /// </returns>
        public async Task<RevokeRoleFromUsersResponse> RevokeRoleFromUsersWithOptionsAsync(RevokeRoleFromUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RolePrincipal))
            {
                body["rolePrincipal"] = request.RolePrincipal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipals))
            {
                body["userPrincipals"] = request.UserPrincipals;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeRoleFromUsers",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/roles/revoke",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<RevokeRoleFromUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量取消授予角色权限给用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeRoleFromUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokeRoleFromUsersResponse
        /// </returns>
        public RevokeRoleFromUsersResponse RevokeRoleFromUsers(RevokeRoleFromUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RevokeRoleFromUsersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量取消授予角色权限给用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeRoleFromUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokeRoleFromUsersResponse
        /// </returns>
        public async Task<RevokeRoleFromUsersResponse> RevokeRoleFromUsersAsync(RevokeRoleFromUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RevokeRoleFromUsersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回滚表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackTableRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RollbackTableResponse
        /// </returns>
        public RollbackTableResponse RollbackTableWithOptions(string catalogId, string database, string table, RollbackTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instant))
            {
                body["instant"] = request.Instant;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackTable",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/rollback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<RollbackTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回滚表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackTableRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RollbackTableResponse
        /// </returns>
        public async Task<RollbackTableResponse> RollbackTableWithOptionsAsync(string catalogId, string database, string table, RollbackTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instant))
            {
                body["instant"] = request.Instant;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackTable",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(catalogId) + "/databases/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(database) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/rollback",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<RollbackTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回滚表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackTableRequest
        /// </param>
        /// 
        /// <returns>
        /// RollbackTableResponse
        /// </returns>
        public RollbackTableResponse RollbackTable(string catalogId, string database, string table, RollbackTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RollbackTableWithOptions(catalogId, database, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>回滚表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackTableRequest
        /// </param>
        /// 
        /// <returns>
        /// RollbackTableResponse
        /// </returns>
        public async Task<RollbackTableResponse> RollbackTableAsync(string catalogId, string database, string table, RollbackTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RollbackTableWithOptionsAsync(catalogId, database, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅当前地域的 DLF</para>
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
        /// SubscribeResponse
        /// </returns>
        public SubscribeResponse SubscribeWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Subscribe",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/service/subscribe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<SubscribeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅当前地域的 DLF</para>
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
        /// SubscribeResponse
        /// </returns>
        public async Task<SubscribeResponse> SubscribeWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Subscribe",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/service/subscribe",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<SubscribeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅当前地域的 DLF</para>
        /// </summary>
        /// 
        /// <returns>
        /// SubscribeResponse
        /// </returns>
        public SubscribeResponse Subscribe()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubscribeWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>订阅当前地域的 DLF</para>
        /// </summary>
        /// 
        /// <returns>
        /// SubscribeResponse
        /// </returns>
        public async Task<SubscribeResponse> SubscribeAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubscribeWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRoleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRoleResponse
        /// </returns>
        public UpdateRoleResponse UpdateRoleWithOptions(UpdateRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RolePrincipal))
            {
                body["rolePrincipal"] = request.RolePrincipal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRole",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/roles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRoleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRoleResponse
        /// </returns>
        public async Task<UpdateRoleResponse> UpdateRoleWithOptionsAsync(UpdateRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RolePrincipal))
            {
                body["rolePrincipal"] = request.RolePrincipal;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRole",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/roles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRoleResponse
        /// </returns>
        public UpdateRoleResponse UpdateRole(UpdateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRoleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRoleResponse
        /// </returns>
        public async Task<UpdateRoleResponse> UpdateRoleAsync(UpdateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRoleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新角色用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRoleUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRoleUsersResponse
        /// </returns>
        public UpdateRoleUsersResponse UpdateRoleUsersWithOptions(UpdateRoleUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RolePrincipal))
            {
                body["rolePrincipal"] = request.RolePrincipal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipals))
            {
                body["userPrincipals"] = request.UserPrincipals;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRoleUsers",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/roles/users",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateRoleUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新角色用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRoleUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRoleUsersResponse
        /// </returns>
        public async Task<UpdateRoleUsersResponse> UpdateRoleUsersWithOptionsAsync(UpdateRoleUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RolePrincipal))
            {
                body["rolePrincipal"] = request.RolePrincipal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPrincipals))
            {
                body["userPrincipals"] = request.UserPrincipals;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRoleUsers",
                Version = "2025-03-10",
                Protocol = "HTTPS",
                Pathname = "/dlf/v1/auth/roles/users",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateRoleUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新角色用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRoleUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRoleUsersResponse
        /// </returns>
        public UpdateRoleUsersResponse UpdateRoleUsers(UpdateRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRoleUsersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新角色用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRoleUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRoleUsersResponse
        /// </returns>
        public async Task<UpdateRoleUsersResponse> UpdateRoleUsersAsync(UpdateRoleUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRoleUsersWithOptionsAsync(request, headers, runtime);
        }

    }
}
