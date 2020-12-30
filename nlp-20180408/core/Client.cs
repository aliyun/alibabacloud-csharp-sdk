// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Nlp20180408.Models;

namespace AlibabaCloud.SDK.Nlp20180408
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("nlp", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public EntityResponse Entity(string Domain)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EntityWithOptions(Domain, headers, runtime);
        }

        public async Task<EntityResponse> EntityAsync(string Domain)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EntityWithOptionsAsync(Domain, headers, runtime);
        }

        public EntityResponse EntityWithOptions(string Domain, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<EntityResponse>(DoROARequest("Entity", "2018-04-08", "HTTPS", "POST", "AK", "/nlp/api/entity/" + Domain, "none", req, runtime));
        }

        public async Task<EntityResponse> EntityWithOptionsAsync(string Domain, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<EntityResponse>(await DoROARequestAsync("Entity", "2018-04-08", "HTTPS", "POST", "AK", "/nlp/api/entity/" + Domain, "none", req, runtime));
        }

        public IEResponse IE(string Domain)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return IEWithOptions(Domain, headers, runtime);
        }

        public async Task<IEResponse> IEAsync(string Domain)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await IEWithOptionsAsync(Domain, headers, runtime);
        }

        public IEResponse IEWithOptions(string Domain, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<IEResponse>(DoROARequest("IE", "2018-04-08", "HTTPS", "POST", "AK", "/nlp/api/ie/" + Domain, "none", req, runtime));
        }

        public async Task<IEResponse> IEWithOptionsAsync(string Domain, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<IEResponse>(await DoROARequestAsync("IE", "2018-04-08", "HTTPS", "POST", "AK", "/nlp/api/ie/" + Domain, "none", req, runtime));
        }

        public KWEResponse KWE(string Domain)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return KWEWithOptions(Domain, headers, runtime);
        }

        public async Task<KWEResponse> KWEAsync(string Domain)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await KWEWithOptionsAsync(Domain, headers, runtime);
        }

        public KWEResponse KWEWithOptions(string Domain, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<KWEResponse>(DoROARequest("KWE", "2018-04-08", "HTTPS", "POST", "AK", "/nlp/api/kwe/" + Domain, "none", req, runtime));
        }

        public async Task<KWEResponse> KWEWithOptionsAsync(string Domain, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<KWEResponse>(await DoROARequestAsync("KWE", "2018-04-08", "HTTPS", "POST", "AK", "/nlp/api/kwe/" + Domain, "none", req, runtime));
        }

        public ReviewAnalysisResponse ReviewAnalysis(string Domain)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReviewAnalysisWithOptions(Domain, headers, runtime);
        }

        public async Task<ReviewAnalysisResponse> ReviewAnalysisAsync(string Domain)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReviewAnalysisWithOptionsAsync(Domain, headers, runtime);
        }

        public ReviewAnalysisResponse ReviewAnalysisWithOptions(string Domain, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ReviewAnalysisResponse>(DoROARequest("ReviewAnalysis", "2018-04-08", "HTTPS", "POST", "AK", "/nlp/api/reviewanalysis/" + Domain, "none", req, runtime));
        }

        public async Task<ReviewAnalysisResponse> ReviewAnalysisWithOptionsAsync(string Domain, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ReviewAnalysisResponse>(await DoROARequestAsync("ReviewAnalysis", "2018-04-08", "HTTPS", "POST", "AK", "/nlp/api/reviewanalysis/" + Domain, "none", req, runtime));
        }

        public SentimentResponse Sentiment(string Domain)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SentimentWithOptions(Domain, headers, runtime);
        }

        public async Task<SentimentResponse> SentimentAsync(string Domain)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SentimentWithOptionsAsync(Domain, headers, runtime);
        }

        public SentimentResponse SentimentWithOptions(string Domain, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<SentimentResponse>(DoROARequest("Sentiment", "2018-04-08", "HTTPS", "POST", "AK", "/nlp/api/sentiment/" + Domain, "none", req, runtime));
        }

        public async Task<SentimentResponse> SentimentWithOptionsAsync(string Domain, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<SentimentResponse>(await DoROARequestAsync("Sentiment", "2018-04-08", "HTTPS", "POST", "AK", "/nlp/api/sentiment/" + Domain, "none", req, runtime));
        }

        public TextStructureResponse TextStructure(string Domain)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TextStructureWithOptions(Domain, headers, runtime);
        }

        public async Task<TextStructureResponse> TextStructureAsync(string Domain)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TextStructureWithOptionsAsync(Domain, headers, runtime);
        }

        public TextStructureResponse TextStructureWithOptions(string Domain, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<TextStructureResponse>(DoROARequest("TextStructure", "2018-04-08", "HTTPS", "POST", "AK", "/nlp/api/textstructure/" + Domain, "none", req, runtime));
        }

        public async Task<TextStructureResponse> TextStructureWithOptionsAsync(string Domain, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<TextStructureResponse>(await DoROARequestAsync("TextStructure", "2018-04-08", "HTTPS", "POST", "AK", "/nlp/api/textstructure/" + Domain, "none", req, runtime));
        }

        public TranslateResponse Translate(string Domain)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TranslateWithOptions(Domain, headers, runtime);
        }

        public async Task<TranslateResponse> TranslateAsync(string Domain)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TranslateWithOptionsAsync(Domain, headers, runtime);
        }

        public TranslateResponse TranslateWithOptions(string Domain, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<TranslateResponse>(DoROARequest("Translate", "2018-04-08", "HTTP", "POST", "AK", "/nlp/api/translate/" + Domain, "none", req, runtime));
        }

        public async Task<TranslateResponse> TranslateWithOptionsAsync(string Domain, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<TranslateResponse>(await DoROARequestAsync("Translate", "2018-04-08", "HTTP", "POST", "AK", "/nlp/api/translate/" + Domain, "none", req, runtime));
        }

        public WordPosResponse WordPos(string Domain)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return WordPosWithOptions(Domain, headers, runtime);
        }

        public async Task<WordPosResponse> WordPosAsync(string Domain)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await WordPosWithOptionsAsync(Domain, headers, runtime);
        }

        public WordPosResponse WordPosWithOptions(string Domain, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<WordPosResponse>(DoROARequest("WordPos", "2018-04-08", "HTTPS", "POST", "AK", "/nlp/api/wordpos/" + Domain, "none", req, runtime));
        }

        public async Task<WordPosResponse> WordPosWithOptionsAsync(string Domain, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<WordPosResponse>(await DoROARequestAsync("WordPos", "2018-04-08", "HTTPS", "POST", "AK", "/nlp/api/wordpos/" + Domain, "none", req, runtime));
        }

        public WordSegmentResponse WordSegment(string Domain)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return WordSegmentWithOptions(Domain, headers, runtime);
        }

        public async Task<WordSegmentResponse> WordSegmentAsync(string Domain)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await WordSegmentWithOptionsAsync(Domain, headers, runtime);
        }

        public WordSegmentResponse WordSegmentWithOptions(string Domain, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<WordSegmentResponse>(DoROARequest("WordSegment", "2018-04-08", "HTTPS", "POST", "AK", "/nlp/api/wordsegment/" + Domain, "none", req, runtime));
        }

        public async Task<WordSegmentResponse> WordSegmentWithOptionsAsync(string Domain, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<WordSegmentResponse>(await DoROARequestAsync("WordSegment", "2018-04-08", "HTTPS", "POST", "AK", "/nlp/api/wordsegment/" + Domain, "none", req, runtime));
        }

    }
}
