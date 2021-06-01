// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Snapshot20210315.Models;

namespace AlibabaCloud.SDK.Snapshot20210315
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("snapshot", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public GetSnapshotInfoResponse GetSnapshotInfo(GetSnapshotInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSnapshotInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetSnapshotInfoResponse> GetSnapshotInfoAsync(GetSnapshotInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSnapshotInfoWithOptionsAsync(request, headers, runtime);
        }

        public GetSnapshotInfoResponse GetSnapshotInfoWithOptions(GetSnapshotInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDetail))
            {
                query["ShowDetail"] = request.ShowDetail;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetSnapshotInfoResponse>(DoROARequest("GetSnapshotInfo", "2021-03-15", "HTTPS", "GET", "AK", "/snapshots/info", "json", req, runtime));
        }

        public async Task<GetSnapshotInfoResponse> GetSnapshotInfoWithOptionsAsync(GetSnapshotInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDetail))
            {
                query["ShowDetail"] = request.ShowDetail;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetSnapshotInfoResponse>(await DoROARequestAsync("GetSnapshotInfo", "2021-03-15", "HTTPS", "GET", "AK", "/snapshots/info", "json", req, runtime));
        }

        public GetSnapshotBlockResponse GetSnapshotBlock(GetSnapshotBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSnapshotBlockWithOptions(request, headers, runtime);
        }

        public async Task<GetSnapshotBlockResponse> GetSnapshotBlockAsync(GetSnapshotBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSnapshotBlockWithOptionsAsync(request, headers, runtime);
        }

        public GetSnapshotBlockResponse GetSnapshotBlockWithOptions(GetSnapshotBlockRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockIndex))
            {
                query["BlockIndex"] = request.BlockIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockToken))
            {
                query["BlockToken"] = request.BlockToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            GetSnapshotBlockResponse res = new GetSnapshotBlockResponse();
            Dictionary<string, object> tmp = AlibabaCloud.TeaUtil.Common.AssertAsMap(DoROARequest("GetSnapshotBlock", "2021-03-15", "HTTPS", "GET", "AK", "/snapshots/block", "binary", req, runtime));
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Get("body")))
            {
                Stream respBody = AlibabaCloud.TeaUtil.Common.AssertAsReadable(tmp.Get("body"));
                res.Body = respBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Get("headers")))
            {
                Dictionary<string, object> respHeaders = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmp.Get("headers"));
                res.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(respHeaders);
            }
            return res;
        }

        public async Task<GetSnapshotBlockResponse> GetSnapshotBlockWithOptionsAsync(GetSnapshotBlockRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockIndex))
            {
                query["BlockIndex"] = request.BlockIndex;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockToken))
            {
                query["BlockToken"] = request.BlockToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            GetSnapshotBlockResponse res = new GetSnapshotBlockResponse();
            Dictionary<string, object> tmp = AlibabaCloud.TeaUtil.Common.AssertAsMap(await DoROARequestAsync("GetSnapshotBlock", "2021-03-15", "HTTPS", "GET", "AK", "/snapshots/block", "binary", req, runtime));
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Get("body")))
            {
                Stream respBody = AlibabaCloud.TeaUtil.Common.AssertAsReadable(tmp.Get("body"));
                res.Body = respBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Get("headers")))
            {
                Dictionary<string, object> respHeaders = AlibabaCloud.TeaUtil.Common.AssertAsMap(tmp.Get("headers"));
                res.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(respHeaders);
            }
            return res;
        }

        public ListSnapshotBlocksResponse ListSnapshotBlocks(ListSnapshotBlocksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSnapshotBlocksWithOptions(request, headers, runtime);
        }

        public async Task<ListSnapshotBlocksResponse> ListSnapshotBlocksAsync(ListSnapshotBlocksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSnapshotBlocksWithOptionsAsync(request, headers, runtime);
        }

        public ListSnapshotBlocksResponse ListSnapshotBlocksWithOptions(ListSnapshotBlocksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartingBlockIndex))
            {
                query["StartingBlockIndex"] = request.StartingBlockIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListSnapshotBlocksResponse>(DoROARequest("ListSnapshotBlocks", "2021-03-15", "HTTPS", "GET", "AK", "/snapshots/listblocks", "json", req, runtime));
        }

        public async Task<ListSnapshotBlocksResponse> ListSnapshotBlocksWithOptionsAsync(ListSnapshotBlocksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartingBlockIndex))
            {
                query["StartingBlockIndex"] = request.StartingBlockIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListSnapshotBlocksResponse>(await DoROARequestAsync("ListSnapshotBlocks", "2021-03-15", "HTTPS", "GET", "AK", "/snapshots/listblocks", "json", req, runtime));
        }

        public ListChangedBlocksResponse ListChangedBlocks(ListChangedBlocksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListChangedBlocksWithOptions(request, headers, runtime);
        }

        public async Task<ListChangedBlocksResponse> ListChangedBlocksAsync(ListChangedBlocksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListChangedBlocksWithOptionsAsync(request, headers, runtime);
        }

        public ListChangedBlocksResponse ListChangedBlocksWithOptions(ListChangedBlocksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstSnapshotId))
            {
                query["FirstSnapshotId"] = request.FirstSnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondSnapshotId))
            {
                query["SecondSnapshotId"] = request.SecondSnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartingBlockIndex))
            {
                query["StartingBlockIndex"] = request.StartingBlockIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListChangedBlocksResponse>(DoROARequest("ListChangedBlocks", "2021-03-15", "HTTPS", "GET", "AK", "/snapshots/changedblocks", "json", req, runtime));
        }

        public async Task<ListChangedBlocksResponse> ListChangedBlocksWithOptionsAsync(ListChangedBlocksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstSnapshotId))
            {
                query["FirstSnapshotId"] = request.FirstSnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondSnapshotId))
            {
                query["SecondSnapshotId"] = request.SecondSnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartingBlockIndex))
            {
                query["StartingBlockIndex"] = request.StartingBlockIndex;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListChangedBlocksResponse>(await DoROARequestAsync("ListChangedBlocks", "2021-03-15", "HTTPS", "GET", "AK", "/snapshots/changedblocks", "json", req, runtime));
        }

    }
}
