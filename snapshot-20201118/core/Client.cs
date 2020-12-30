// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Snapshot20201118.Models;

namespace AlibabaCloud.SDK.Snapshot20201118
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
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
            return TeaModel.ToObject<ListChangedBlocksResponse>(DoROARequest("ListChangedBlocks", "2020-11-18", "HTTPS", "GET", "AK", "/snapshots/changedblocks", "json", req, runtime));
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
            return TeaModel.ToObject<ListChangedBlocksResponse>(await DoROARequestAsync("ListChangedBlocks", "2020-11-18", "HTTPS", "GET", "AK", "/snapshots/changedblocks", "json", req, runtime));
        }

    }
}
