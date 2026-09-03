// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Aidge20260428.Models;

namespace AlibabaCloud.SDK.Aidge20260428
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("aidge", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Provides a one-click cross-platform product listing optimization service for cross-border e-commerce sellers (minimum cost edition). Accepts a source platform product URL and outputs all listing assets adapted to the target platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting. Uses an officially pre-built minimum-cost workflow that primarily filters and applies lightweight processing without calling expensive image translation capabilities, maximizing cost control while ensuring listing compliance. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A one-click cross-platform product listing optimization service for cross-border e-commerce sellers (minimum cost edition). Accepts a source platform product URL and outputs all listing assets adapted to the target platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting. Uses an officially pre-built minimum-cost workflow that primarily filters and applies lightweight processing without calling expensive image translation capabilities, maximizing cost control while ensuring listing compliance. (Asynchronous)</para>
        /// <h2>Scenarios</h2>
        /// <para>Suitable for cost-sensitive cross-platform listing scenarios where &quot;fast, high-volume, and cheap&quot; is the priority. Examples include bulk listing from 1688 to TEMU, batch uploading of high-SKU inventory, entry-level AI processing for top sellers and ERP/SaaS platforms, and merchants with high daily processing volumes but low requirements for marketing performance.
        /// By filtering images that contain watermarks or non-compliant elements and prioritizing clean original images, the service reduces AI generation steps and helps merchants complete cross-platform listings at minimal cost.</para>
        /// <h2>Features</h2>
        /// <para>This service uses an officially pre-built &quot;minimum cost&quot; product optimization workflow that covers the entire pipeline from asset retrieval, compliance filtering, and text optimization to image processing:</para>
        /// <ol>
        /// <item><description>Automatically parses 1688 product URLs and extracts multiple asset types including titles, SKUs, main images, detail images, and attributes.</description></item>
        /// <item><description>Performs text filtering and SEO optimization based on the TEMU platform blacklist and compliance rules.</description></item>
        /// <item><description>Intelligently identifies watermarks, logos, and Chinese text in images, prioritizing clean original images through filtering. SKU images and a small number of main images are processed using image translation capabilities to comply with platform standards (high-conversion images with marketing text may be filtered out).</description></item>
        /// <item><description>Completes category matching, attribute filling, and localized rewriting based on target platform requirements.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// AssetOptimizeLiteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssetOptimizeLiteResponse
        /// </returns>
        public AssetOptimizeLiteResponse AssetOptimizeLiteWithOptions(AssetOptimizeLiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Glossary))
            {
                query["Glossary"] = request.Glossary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludingProductArea))
            {
                query["IncludingProductArea"] = request.IncludingProductArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTrans))
            {
                query["NeedTrans"] = request.NeedTrans;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductUrl))
            {
                query["ProductUrl"] = request.ProductUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                query["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePlatform))
            {
                query["SourcePlatform"] = request.SourcePlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                query["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPlatform))
            {
                query["TargetPlatform"] = request.TargetPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslatingBrandInTheProduct))
            {
                query["TranslatingBrandInTheProduct"] = request.TranslatingBrandInTheProduct;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssetOptimizeLite",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssetOptimizeLiteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a one-click cross-platform product listing optimization service for cross-border e-commerce sellers (minimum cost edition). Accepts a source platform product URL and outputs all listing assets adapted to the target platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting. Uses an officially pre-built minimum-cost workflow that primarily filters and applies lightweight processing without calling expensive image translation capabilities, maximizing cost control while ensuring listing compliance. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A one-click cross-platform product listing optimization service for cross-border e-commerce sellers (minimum cost edition). Accepts a source platform product URL and outputs all listing assets adapted to the target platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting. Uses an officially pre-built minimum-cost workflow that primarily filters and applies lightweight processing without calling expensive image translation capabilities, maximizing cost control while ensuring listing compliance. (Asynchronous)</para>
        /// <h2>Scenarios</h2>
        /// <para>Suitable for cost-sensitive cross-platform listing scenarios where &quot;fast, high-volume, and cheap&quot; is the priority. Examples include bulk listing from 1688 to TEMU, batch uploading of high-SKU inventory, entry-level AI processing for top sellers and ERP/SaaS platforms, and merchants with high daily processing volumes but low requirements for marketing performance.
        /// By filtering images that contain watermarks or non-compliant elements and prioritizing clean original images, the service reduces AI generation steps and helps merchants complete cross-platform listings at minimal cost.</para>
        /// <h2>Features</h2>
        /// <para>This service uses an officially pre-built &quot;minimum cost&quot; product optimization workflow that covers the entire pipeline from asset retrieval, compliance filtering, and text optimization to image processing:</para>
        /// <ol>
        /// <item><description>Automatically parses 1688 product URLs and extracts multiple asset types including titles, SKUs, main images, detail images, and attributes.</description></item>
        /// <item><description>Performs text filtering and SEO optimization based on the TEMU platform blacklist and compliance rules.</description></item>
        /// <item><description>Intelligently identifies watermarks, logos, and Chinese text in images, prioritizing clean original images through filtering. SKU images and a small number of main images are processed using image translation capabilities to comply with platform standards (high-conversion images with marketing text may be filtered out).</description></item>
        /// <item><description>Completes category matching, attribute filling, and localized rewriting based on target platform requirements.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// AssetOptimizeLiteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssetOptimizeLiteResponse
        /// </returns>
        public async Task<AssetOptimizeLiteResponse> AssetOptimizeLiteWithOptionsAsync(AssetOptimizeLiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Glossary))
            {
                query["Glossary"] = request.Glossary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludingProductArea))
            {
                query["IncludingProductArea"] = request.IncludingProductArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTrans))
            {
                query["NeedTrans"] = request.NeedTrans;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductUrl))
            {
                query["ProductUrl"] = request.ProductUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                query["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePlatform))
            {
                query["SourcePlatform"] = request.SourcePlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                query["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPlatform))
            {
                query["TargetPlatform"] = request.TargetPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslatingBrandInTheProduct))
            {
                query["TranslatingBrandInTheProduct"] = request.TranslatingBrandInTheProduct;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssetOptimizeLite",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssetOptimizeLiteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a one-click cross-platform product listing optimization service for cross-border e-commerce sellers (minimum cost edition). Accepts a source platform product URL and outputs all listing assets adapted to the target platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting. Uses an officially pre-built minimum-cost workflow that primarily filters and applies lightweight processing without calling expensive image translation capabilities, maximizing cost control while ensuring listing compliance. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A one-click cross-platform product listing optimization service for cross-border e-commerce sellers (minimum cost edition). Accepts a source platform product URL and outputs all listing assets adapted to the target platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting. Uses an officially pre-built minimum-cost workflow that primarily filters and applies lightweight processing without calling expensive image translation capabilities, maximizing cost control while ensuring listing compliance. (Asynchronous)</para>
        /// <h2>Scenarios</h2>
        /// <para>Suitable for cost-sensitive cross-platform listing scenarios where &quot;fast, high-volume, and cheap&quot; is the priority. Examples include bulk listing from 1688 to TEMU, batch uploading of high-SKU inventory, entry-level AI processing for top sellers and ERP/SaaS platforms, and merchants with high daily processing volumes but low requirements for marketing performance.
        /// By filtering images that contain watermarks or non-compliant elements and prioritizing clean original images, the service reduces AI generation steps and helps merchants complete cross-platform listings at minimal cost.</para>
        /// <h2>Features</h2>
        /// <para>This service uses an officially pre-built &quot;minimum cost&quot; product optimization workflow that covers the entire pipeline from asset retrieval, compliance filtering, and text optimization to image processing:</para>
        /// <ol>
        /// <item><description>Automatically parses 1688 product URLs and extracts multiple asset types including titles, SKUs, main images, detail images, and attributes.</description></item>
        /// <item><description>Performs text filtering and SEO optimization based on the TEMU platform blacklist and compliance rules.</description></item>
        /// <item><description>Intelligently identifies watermarks, logos, and Chinese text in images, prioritizing clean original images through filtering. SKU images and a small number of main images are processed using image translation capabilities to comply with platform standards (high-conversion images with marketing text may be filtered out).</description></item>
        /// <item><description>Completes category matching, attribute filling, and localized rewriting based on target platform requirements.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// AssetOptimizeLiteRequest
        /// </param>
        /// 
        /// <returns>
        /// AssetOptimizeLiteResponse
        /// </returns>
        public AssetOptimizeLiteResponse AssetOptimizeLite(AssetOptimizeLiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssetOptimizeLiteWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a one-click cross-platform product listing optimization service for cross-border e-commerce sellers (minimum cost edition). Accepts a source platform product URL and outputs all listing assets adapted to the target platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting. Uses an officially pre-built minimum-cost workflow that primarily filters and applies lightweight processing without calling expensive image translation capabilities, maximizing cost control while ensuring listing compliance. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A one-click cross-platform product listing optimization service for cross-border e-commerce sellers (minimum cost edition). Accepts a source platform product URL and outputs all listing assets adapted to the target platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting. Uses an officially pre-built minimum-cost workflow that primarily filters and applies lightweight processing without calling expensive image translation capabilities, maximizing cost control while ensuring listing compliance. (Asynchronous)</para>
        /// <h2>Scenarios</h2>
        /// <para>Suitable for cost-sensitive cross-platform listing scenarios where &quot;fast, high-volume, and cheap&quot; is the priority. Examples include bulk listing from 1688 to TEMU, batch uploading of high-SKU inventory, entry-level AI processing for top sellers and ERP/SaaS platforms, and merchants with high daily processing volumes but low requirements for marketing performance.
        /// By filtering images that contain watermarks or non-compliant elements and prioritizing clean original images, the service reduces AI generation steps and helps merchants complete cross-platform listings at minimal cost.</para>
        /// <h2>Features</h2>
        /// <para>This service uses an officially pre-built &quot;minimum cost&quot; product optimization workflow that covers the entire pipeline from asset retrieval, compliance filtering, and text optimization to image processing:</para>
        /// <ol>
        /// <item><description>Automatically parses 1688 product URLs and extracts multiple asset types including titles, SKUs, main images, detail images, and attributes.</description></item>
        /// <item><description>Performs text filtering and SEO optimization based on the TEMU platform blacklist and compliance rules.</description></item>
        /// <item><description>Intelligently identifies watermarks, logos, and Chinese text in images, prioritizing clean original images through filtering. SKU images and a small number of main images are processed using image translation capabilities to comply with platform standards (high-conversion images with marketing text may be filtered out).</description></item>
        /// <item><description>Completes category matching, attribute filling, and localized rewriting based on target platform requirements.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// AssetOptimizeLiteRequest
        /// </param>
        /// 
        /// <returns>
        /// AssetOptimizeLiteResponse
        /// </returns>
        public async Task<AssetOptimizeLiteResponse> AssetOptimizeLiteAsync(AssetOptimizeLiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssetOptimizeLiteWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a one-click cross-platform product listing optimization service for cross-border e-commerce sellers (best performance edition). Accepts a 1688 product link as input and outputs a complete set of assets adapted to TEMU platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting. Uses the officially pre-built best-performance workflow to maximize AI capabilities, retains and localizes brand marketing assets, and outputs category-specific assets such as size charts for apparel categories. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A one-click cross-platform product listing optimization service for cross-border e-commerce sellers (best performance edition). Accepts a 1688 product link as input and outputs a complete set of assets adapted to TEMU platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting.</para>
        /// <h2>Scenarios</h2>
        /// <para>Suitable for scenarios that require high-quality cross-platform product listing assets and strong conversion performance. Examples include categories with high dependency on marketing assets such as apparel, accessories, beauty, and home goods. Also suitable for brand merchants and high-value products that need to retain marketing images with copywriting. Ideal for top sellers and ERP/SaaS platforms conducting localized operations across multiple languages and markets, as well as scenarios that require category-specific assets (such as size charts and package weight/dimensions) to improve listing quality and conversion rates.</para>
        /// <h2>Features</h2>
        /// <para>This service uses the officially pre-built &quot;Best Performance&quot; product optimization workflow, covering the entire pipeline from asset acquisition, diagnosis, filtering, and optimization to output:</para>
        /// <ol>
        /// <item><description>Automatically parses 1688 product links to extract all assets including titles, SKUs, main images, detail images, and attributes. Intelligently diagnoses missing assets and optimization opportunities.</description></item>
        /// <item><description>Uses LLM for text compliance filtering, SEO keyword optimization, five-point description generation, and multilingual localization rewriting.</description></item>
        /// <item><description>Invokes multiple image processing capabilities including intelligent recognition, intelligent background removal, intelligent erasure, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling.</description></item>
        /// <item><description>Outputs category-specific assets such as size charts and package weight/dimensions for apparel categories.</description></item>
        /// <item><description>Outputs a standardized product asset package ready for direct listing.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AssetOptimizeProRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssetOptimizeProResponse
        /// </returns>
        public AssetOptimizeProResponse AssetOptimizeProWithOptions(AssetOptimizeProRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AssetOptimizeProShrinkRequest request = new AssetOptimizeProShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ColumnNameList))
            {
                request.ColumnNameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ColumnNameList, "ColumnNameList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnNameListShrink))
            {
                query["ColumnNameList"] = request.ColumnNameListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Glossary))
            {
                query["Glossary"] = request.Glossary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludingProductArea))
            {
                query["IncludingProductArea"] = request.IncludingProductArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageModel))
            {
                query["LanguageModel"] = request.LanguageModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTrans))
            {
                query["NeedTrans"] = request.NeedTrans;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductUrl))
            {
                query["ProductUrl"] = request.ProductUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                query["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePlatform))
            {
                query["SourcePlatform"] = request.SourcePlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                query["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPlatform))
            {
                query["TargetPlatform"] = request.TargetPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslatingBrandInTheProduct))
            {
                query["TranslatingBrandInTheProduct"] = request.TranslatingBrandInTheProduct;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssetOptimizePro",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssetOptimizeProResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a one-click cross-platform product listing optimization service for cross-border e-commerce sellers (best performance edition). Accepts a 1688 product link as input and outputs a complete set of assets adapted to TEMU platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting. Uses the officially pre-built best-performance workflow to maximize AI capabilities, retains and localizes brand marketing assets, and outputs category-specific assets such as size charts for apparel categories. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A one-click cross-platform product listing optimization service for cross-border e-commerce sellers (best performance edition). Accepts a 1688 product link as input and outputs a complete set of assets adapted to TEMU platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting.</para>
        /// <h2>Scenarios</h2>
        /// <para>Suitable for scenarios that require high-quality cross-platform product listing assets and strong conversion performance. Examples include categories with high dependency on marketing assets such as apparel, accessories, beauty, and home goods. Also suitable for brand merchants and high-value products that need to retain marketing images with copywriting. Ideal for top sellers and ERP/SaaS platforms conducting localized operations across multiple languages and markets, as well as scenarios that require category-specific assets (such as size charts and package weight/dimensions) to improve listing quality and conversion rates.</para>
        /// <h2>Features</h2>
        /// <para>This service uses the officially pre-built &quot;Best Performance&quot; product optimization workflow, covering the entire pipeline from asset acquisition, diagnosis, filtering, and optimization to output:</para>
        /// <ol>
        /// <item><description>Automatically parses 1688 product links to extract all assets including titles, SKUs, main images, detail images, and attributes. Intelligently diagnoses missing assets and optimization opportunities.</description></item>
        /// <item><description>Uses LLM for text compliance filtering, SEO keyword optimization, five-point description generation, and multilingual localization rewriting.</description></item>
        /// <item><description>Invokes multiple image processing capabilities including intelligent recognition, intelligent background removal, intelligent erasure, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling.</description></item>
        /// <item><description>Outputs category-specific assets such as size charts and package weight/dimensions for apparel categories.</description></item>
        /// <item><description>Outputs a standardized product asset package ready for direct listing.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AssetOptimizeProRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssetOptimizeProResponse
        /// </returns>
        public async Task<AssetOptimizeProResponse> AssetOptimizeProWithOptionsAsync(AssetOptimizeProRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AssetOptimizeProShrinkRequest request = new AssetOptimizeProShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ColumnNameList))
            {
                request.ColumnNameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ColumnNameList, "ColumnNameList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnNameListShrink))
            {
                query["ColumnNameList"] = request.ColumnNameListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Glossary))
            {
                query["Glossary"] = request.Glossary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludingProductArea))
            {
                query["IncludingProductArea"] = request.IncludingProductArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageModel))
            {
                query["LanguageModel"] = request.LanguageModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedTrans))
            {
                query["NeedTrans"] = request.NeedTrans;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductUrl))
            {
                query["ProductUrl"] = request.ProductUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                query["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePlatform))
            {
                query["SourcePlatform"] = request.SourcePlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                query["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPlatform))
            {
                query["TargetPlatform"] = request.TargetPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslatingBrandInTheProduct))
            {
                query["TranslatingBrandInTheProduct"] = request.TranslatingBrandInTheProduct;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssetOptimizePro",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssetOptimizeProResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a one-click cross-platform product listing optimization service for cross-border e-commerce sellers (best performance edition). Accepts a 1688 product link as input and outputs a complete set of assets adapted to TEMU platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting. Uses the officially pre-built best-performance workflow to maximize AI capabilities, retains and localizes brand marketing assets, and outputs category-specific assets such as size charts for apparel categories. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A one-click cross-platform product listing optimization service for cross-border e-commerce sellers (best performance edition). Accepts a 1688 product link as input and outputs a complete set of assets adapted to TEMU platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting.</para>
        /// <h2>Scenarios</h2>
        /// <para>Suitable for scenarios that require high-quality cross-platform product listing assets and strong conversion performance. Examples include categories with high dependency on marketing assets such as apparel, accessories, beauty, and home goods. Also suitable for brand merchants and high-value products that need to retain marketing images with copywriting. Ideal for top sellers and ERP/SaaS platforms conducting localized operations across multiple languages and markets, as well as scenarios that require category-specific assets (such as size charts and package weight/dimensions) to improve listing quality and conversion rates.</para>
        /// <h2>Features</h2>
        /// <para>This service uses the officially pre-built &quot;Best Performance&quot; product optimization workflow, covering the entire pipeline from asset acquisition, diagnosis, filtering, and optimization to output:</para>
        /// <ol>
        /// <item><description>Automatically parses 1688 product links to extract all assets including titles, SKUs, main images, detail images, and attributes. Intelligently diagnoses missing assets and optimization opportunities.</description></item>
        /// <item><description>Uses LLM for text compliance filtering, SEO keyword optimization, five-point description generation, and multilingual localization rewriting.</description></item>
        /// <item><description>Invokes multiple image processing capabilities including intelligent recognition, intelligent background removal, intelligent erasure, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling.</description></item>
        /// <item><description>Outputs category-specific assets such as size charts and package weight/dimensions for apparel categories.</description></item>
        /// <item><description>Outputs a standardized product asset package ready for direct listing.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// AssetOptimizeProRequest
        /// </param>
        /// 
        /// <returns>
        /// AssetOptimizeProResponse
        /// </returns>
        public AssetOptimizeProResponse AssetOptimizePro(AssetOptimizeProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssetOptimizeProWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a one-click cross-platform product listing optimization service for cross-border e-commerce sellers (best performance edition). Accepts a 1688 product link as input and outputs a complete set of assets adapted to TEMU platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting. Uses the officially pre-built best-performance workflow to maximize AI capabilities, retains and localizes brand marketing assets, and outputs category-specific assets such as size charts for apparel categories. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A one-click cross-platform product listing optimization service for cross-border e-commerce sellers (best performance edition). Accepts a 1688 product link as input and outputs a complete set of assets adapted to TEMU platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting.</para>
        /// <h2>Scenarios</h2>
        /// <para>Suitable for scenarios that require high-quality cross-platform product listing assets and strong conversion performance. Examples include categories with high dependency on marketing assets such as apparel, accessories, beauty, and home goods. Also suitable for brand merchants and high-value products that need to retain marketing images with copywriting. Ideal for top sellers and ERP/SaaS platforms conducting localized operations across multiple languages and markets, as well as scenarios that require category-specific assets (such as size charts and package weight/dimensions) to improve listing quality and conversion rates.</para>
        /// <h2>Features</h2>
        /// <para>This service uses the officially pre-built &quot;Best Performance&quot; product optimization workflow, covering the entire pipeline from asset acquisition, diagnosis, filtering, and optimization to output:</para>
        /// <ol>
        /// <item><description>Automatically parses 1688 product links to extract all assets including titles, SKUs, main images, detail images, and attributes. Intelligently diagnoses missing assets and optimization opportunities.</description></item>
        /// <item><description>Uses LLM for text compliance filtering, SEO keyword optimization, five-point description generation, and multilingual localization rewriting.</description></item>
        /// <item><description>Invokes multiple image processing capabilities including intelligent recognition, intelligent background removal, intelligent erasure, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling.</description></item>
        /// <item><description>Outputs category-specific assets such as size charts and package weight/dimensions for apparel categories.</description></item>
        /// <item><description>Outputs a standardized product asset package ready for direct listing.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// AssetOptimizeProRequest
        /// </param>
        /// 
        /// <returns>
        /// AssetOptimizeProResponse
        /// </returns>
        public async Task<AssetOptimizeProResponse> AssetOptimizeProAsync(AssetOptimizeProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssetOptimizeProWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a cross-platform product category and attribute intelligent filling service based on multimodal large models. Takes product information from a source platform, automatically matches the category on the target listing platform, and intelligently fills in all required attribute fields under that category, offering a one-stop solution for category selection and attribute filling during product listing. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Applicable scenarios</h1>
        /// <para>Cross-platform product listing attribute filling: When merchants list products across platforms, the attribute fields required by different platforms (source platform, TEMU platform) vary significantly, with complex hierarchical options (such as material → wood type → density). Manual filling is time-consuming and error-prone. This service automatically understands product information and intelligently fills in attributes. It is suitable for scenarios such as automated bulk listing for top sellers, ERP/SaaS platform integration, and quick product listing for SMB merchants.</para>
        /// <h1>Feature overview</h1>
        /// <para>Users input the product title, source category, product details, SKU, product attributes, and product images (up to 10). The system uses multimodal AI to understand product semantics and visual features, completing two core tasks: ① Matching the precise category path for the product on the TEMU platform. ② Automatically filling in the required attributes under that category (such as material, battery properties, size, connectivity), and returning the confidence level and reasoning for each attribute. The API operates in synchronous mode and returns results immediately upon invocation.</para>
        /// <h1>Comparison</h1>
        /// <para>The following example shows the attributes of a USB fan:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>1688 Attribute</b></th>
        /// <th><b>1688 Attribute Value</b></th>
        /// <th><b>TEMU Attribute</b></th>
        /// <th><b>TEMU Attribute Value</b></th>
        /// <th><b>Existing in 1688</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Brand</td>
        /// <td>Other</td>
        /// <td>Power Mode</td>
        /// <td>USB Charging (Built-in Battery)</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Battery Life</td>
        /// <td>3-6h (inclusive)</td>
        /// <td>Rechargeable Battery</td>
        /// <td>Lithium Battery</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Additional Features</td>
        /// <td>Digital Display</td>
        /// <td>Battery Capacity (mAh)</td>
        /// <td>4000</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>Built-in Battery Capacity</td>
        /// <td>2000mAh-4000mAh (inclusive)</td>
        /// <td>Fan Features</td>
        /// <td>High Speed</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Item Number</td>
        /// <td>X699</td>
        /// <td>Control Method</td>
        /// <td>Button</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>Main Downstream Platforms</td>
        /// <td>eBay, Amazon, Wish, AliExpress, Independent Sites, LAZADA, Other</td>
        /// <td>Finish Type</td>
        /// <td>Painted</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>Has Licensable Own Brand</td>
        /// <td>No</td>
        /// <td>Recommended Use</td>
        /// <td>Cooling</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Dimensions</td>
        /// <td>65\*60\*171</td>
        /// <td>Fan Design</td>
        /// <td>Wearable Fan</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Applicable Gift Occasions</td>
        /// <td>Personal Gifts</td>
        /// <td>Included Components</td>
        /// <td>None</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Shell Process</td>
        /// <td>Spray Coating (UV Paint, Rubber Paint, Metallic Paint, Piano Lacquer, Pearl Powder)</td>
        /// <td>Material</td>
        /// <td>Plastic</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Package Volume</td>
        /// <td>65\*60\*171</td>
        /// <td>Special Features</td>
        /// <td>Portable</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Appearance Dimensions</td>
        /// <td>51\*36\*34</td>
        /// <td>Indoor/Outdoor Use</td>
        /// <td>Both Indoor and Outdoor</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Wind Speed Levels</td>
        /// <td>3 Levels</td>
        /// <td>Brand Name</td>
        /// <td>None</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Operation Method</td>
        /// <td>Standard Button</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Blade Material</td>
        /// <td>ABS</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Power Mode</td>
        /// <td>USB</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Built-in Battery</td>
        /// <td>Yes</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Patented Source</td>
        /// <td>No</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Color</td>
        /// <td>X699 Fan-Yellow, X699 Fan-Light Purple, X699 Fan-Sky Blue, X699 Fan-Orange, X699 Fan-Light Green, Standard Small Fan</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Main Sales Regions</td>
        /// <td>Japan/Korea, Africa, Korea, Japan, Europe, South America, Southeast Asia, North America, Northeast Asia, Middle East, Latin America, Europe/America, Other</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Cross-border Export Exclusive</td>
        /// <td>Yes</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Style</td>
        /// <td>Fresh</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Motor Type</td>
        /// <td>Brushless Motor</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Noise</td>
        /// <td>36dB(A)-45dB(A) (inclusive)</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Net Weight</td>
        /// <td>125g</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Number of Blades</td>
        /// <td>6 or more</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Fan Category</td>
        /// <td>Handheld Fan</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CategoryAttributeMatchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CategoryAttributeMatchResponse
        /// </returns>
        public CategoryAttributeMatchResponse CategoryAttributeMatchWithOptions(CategoryAttributeMatchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CategoryAttributeMatchShrinkRequest request = new CategoryAttributeMatchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageUrl))
            {
                request.ImageUrlShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageUrl, "ImageUrl", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlShrink))
            {
                body["ImageUrl"] = request.ImageUrlShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemSpec))
            {
                body["ItemSpec"] = request.ItemSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sku))
            {
                body["Sku"] = request.Sku;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCategory))
            {
                body["SourceCategory"] = request.SourceCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePlatform))
            {
                body["SourcePlatform"] = request.SourcePlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPlatform))
            {
                body["TargetPlatform"] = request.TargetPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CategoryAttributeMatch",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CategoryAttributeMatchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a cross-platform product category and attribute intelligent filling service based on multimodal large models. Takes product information from a source platform, automatically matches the category on the target listing platform, and intelligently fills in all required attribute fields under that category, offering a one-stop solution for category selection and attribute filling during product listing. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Applicable scenarios</h1>
        /// <para>Cross-platform product listing attribute filling: When merchants list products across platforms, the attribute fields required by different platforms (source platform, TEMU platform) vary significantly, with complex hierarchical options (such as material → wood type → density). Manual filling is time-consuming and error-prone. This service automatically understands product information and intelligently fills in attributes. It is suitable for scenarios such as automated bulk listing for top sellers, ERP/SaaS platform integration, and quick product listing for SMB merchants.</para>
        /// <h1>Feature overview</h1>
        /// <para>Users input the product title, source category, product details, SKU, product attributes, and product images (up to 10). The system uses multimodal AI to understand product semantics and visual features, completing two core tasks: ① Matching the precise category path for the product on the TEMU platform. ② Automatically filling in the required attributes under that category (such as material, battery properties, size, connectivity), and returning the confidence level and reasoning for each attribute. The API operates in synchronous mode and returns results immediately upon invocation.</para>
        /// <h1>Comparison</h1>
        /// <para>The following example shows the attributes of a USB fan:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>1688 Attribute</b></th>
        /// <th><b>1688 Attribute Value</b></th>
        /// <th><b>TEMU Attribute</b></th>
        /// <th><b>TEMU Attribute Value</b></th>
        /// <th><b>Existing in 1688</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Brand</td>
        /// <td>Other</td>
        /// <td>Power Mode</td>
        /// <td>USB Charging (Built-in Battery)</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Battery Life</td>
        /// <td>3-6h (inclusive)</td>
        /// <td>Rechargeable Battery</td>
        /// <td>Lithium Battery</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Additional Features</td>
        /// <td>Digital Display</td>
        /// <td>Battery Capacity (mAh)</td>
        /// <td>4000</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>Built-in Battery Capacity</td>
        /// <td>2000mAh-4000mAh (inclusive)</td>
        /// <td>Fan Features</td>
        /// <td>High Speed</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Item Number</td>
        /// <td>X699</td>
        /// <td>Control Method</td>
        /// <td>Button</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>Main Downstream Platforms</td>
        /// <td>eBay, Amazon, Wish, AliExpress, Independent Sites, LAZADA, Other</td>
        /// <td>Finish Type</td>
        /// <td>Painted</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>Has Licensable Own Brand</td>
        /// <td>No</td>
        /// <td>Recommended Use</td>
        /// <td>Cooling</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Dimensions</td>
        /// <td>65\*60\*171</td>
        /// <td>Fan Design</td>
        /// <td>Wearable Fan</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Applicable Gift Occasions</td>
        /// <td>Personal Gifts</td>
        /// <td>Included Components</td>
        /// <td>None</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Shell Process</td>
        /// <td>Spray Coating (UV Paint, Rubber Paint, Metallic Paint, Piano Lacquer, Pearl Powder)</td>
        /// <td>Material</td>
        /// <td>Plastic</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Package Volume</td>
        /// <td>65\*60\*171</td>
        /// <td>Special Features</td>
        /// <td>Portable</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Appearance Dimensions</td>
        /// <td>51\*36\*34</td>
        /// <td>Indoor/Outdoor Use</td>
        /// <td>Both Indoor and Outdoor</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Wind Speed Levels</td>
        /// <td>3 Levels</td>
        /// <td>Brand Name</td>
        /// <td>None</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Operation Method</td>
        /// <td>Standard Button</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Blade Material</td>
        /// <td>ABS</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Power Mode</td>
        /// <td>USB</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Built-in Battery</td>
        /// <td>Yes</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Patented Source</td>
        /// <td>No</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Color</td>
        /// <td>X699 Fan-Yellow, X699 Fan-Light Purple, X699 Fan-Sky Blue, X699 Fan-Orange, X699 Fan-Light Green, Standard Small Fan</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Main Sales Regions</td>
        /// <td>Japan/Korea, Africa, Korea, Japan, Europe, South America, Southeast Asia, North America, Northeast Asia, Middle East, Latin America, Europe/America, Other</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Cross-border Export Exclusive</td>
        /// <td>Yes</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Style</td>
        /// <td>Fresh</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Motor Type</td>
        /// <td>Brushless Motor</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Noise</td>
        /// <td>36dB(A)-45dB(A) (inclusive)</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Net Weight</td>
        /// <td>125g</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Number of Blades</td>
        /// <td>6 or more</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Fan Category</td>
        /// <td>Handheld Fan</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CategoryAttributeMatchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CategoryAttributeMatchResponse
        /// </returns>
        public async Task<CategoryAttributeMatchResponse> CategoryAttributeMatchWithOptionsAsync(CategoryAttributeMatchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CategoryAttributeMatchShrinkRequest request = new CategoryAttributeMatchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ImageUrl))
            {
                request.ImageUrlShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ImageUrl, "ImageUrl", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlShrink))
            {
                body["ImageUrl"] = request.ImageUrlShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemSpec))
            {
                body["ItemSpec"] = request.ItemSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sku))
            {
                body["Sku"] = request.Sku;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCategory))
            {
                body["SourceCategory"] = request.SourceCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePlatform))
            {
                body["SourcePlatform"] = request.SourcePlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPlatform))
            {
                body["TargetPlatform"] = request.TargetPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CategoryAttributeMatch",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CategoryAttributeMatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a cross-platform product category and attribute intelligent filling service based on multimodal large models. Takes product information from a source platform, automatically matches the category on the target listing platform, and intelligently fills in all required attribute fields under that category, offering a one-stop solution for category selection and attribute filling during product listing. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Applicable scenarios</h1>
        /// <para>Cross-platform product listing attribute filling: When merchants list products across platforms, the attribute fields required by different platforms (source platform, TEMU platform) vary significantly, with complex hierarchical options (such as material → wood type → density). Manual filling is time-consuming and error-prone. This service automatically understands product information and intelligently fills in attributes. It is suitable for scenarios such as automated bulk listing for top sellers, ERP/SaaS platform integration, and quick product listing for SMB merchants.</para>
        /// <h1>Feature overview</h1>
        /// <para>Users input the product title, source category, product details, SKU, product attributes, and product images (up to 10). The system uses multimodal AI to understand product semantics and visual features, completing two core tasks: ① Matching the precise category path for the product on the TEMU platform. ② Automatically filling in the required attributes under that category (such as material, battery properties, size, connectivity), and returning the confidence level and reasoning for each attribute. The API operates in synchronous mode and returns results immediately upon invocation.</para>
        /// <h1>Comparison</h1>
        /// <para>The following example shows the attributes of a USB fan:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>1688 Attribute</b></th>
        /// <th><b>1688 Attribute Value</b></th>
        /// <th><b>TEMU Attribute</b></th>
        /// <th><b>TEMU Attribute Value</b></th>
        /// <th><b>Existing in 1688</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Brand</td>
        /// <td>Other</td>
        /// <td>Power Mode</td>
        /// <td>USB Charging (Built-in Battery)</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Battery Life</td>
        /// <td>3-6h (inclusive)</td>
        /// <td>Rechargeable Battery</td>
        /// <td>Lithium Battery</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Additional Features</td>
        /// <td>Digital Display</td>
        /// <td>Battery Capacity (mAh)</td>
        /// <td>4000</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>Built-in Battery Capacity</td>
        /// <td>2000mAh-4000mAh (inclusive)</td>
        /// <td>Fan Features</td>
        /// <td>High Speed</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Item Number</td>
        /// <td>X699</td>
        /// <td>Control Method</td>
        /// <td>Button</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>Main Downstream Platforms</td>
        /// <td>eBay, Amazon, Wish, AliExpress, Independent Sites, LAZADA, Other</td>
        /// <td>Finish Type</td>
        /// <td>Painted</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>Has Licensable Own Brand</td>
        /// <td>No</td>
        /// <td>Recommended Use</td>
        /// <td>Cooling</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Dimensions</td>
        /// <td>65\*60\*171</td>
        /// <td>Fan Design</td>
        /// <td>Wearable Fan</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Applicable Gift Occasions</td>
        /// <td>Personal Gifts</td>
        /// <td>Included Components</td>
        /// <td>None</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Shell Process</td>
        /// <td>Spray Coating (UV Paint, Rubber Paint, Metallic Paint, Piano Lacquer, Pearl Powder)</td>
        /// <td>Material</td>
        /// <td>Plastic</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Package Volume</td>
        /// <td>65\*60\*171</td>
        /// <td>Special Features</td>
        /// <td>Portable</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Appearance Dimensions</td>
        /// <td>51\*36\*34</td>
        /// <td>Indoor/Outdoor Use</td>
        /// <td>Both Indoor and Outdoor</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Wind Speed Levels</td>
        /// <td>3 Levels</td>
        /// <td>Brand Name</td>
        /// <td>None</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Operation Method</td>
        /// <td>Standard Button</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Blade Material</td>
        /// <td>ABS</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Power Mode</td>
        /// <td>USB</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Built-in Battery</td>
        /// <td>Yes</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Patented Source</td>
        /// <td>No</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Color</td>
        /// <td>X699 Fan-Yellow, X699 Fan-Light Purple, X699 Fan-Sky Blue, X699 Fan-Orange, X699 Fan-Light Green, Standard Small Fan</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Main Sales Regions</td>
        /// <td>Japan/Korea, Africa, Korea, Japan, Europe, South America, Southeast Asia, North America, Northeast Asia, Middle East, Latin America, Europe/America, Other</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Cross-border Export Exclusive</td>
        /// <td>Yes</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Style</td>
        /// <td>Fresh</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Motor Type</td>
        /// <td>Brushless Motor</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Noise</td>
        /// <td>36dB(A)-45dB(A) (inclusive)</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Net Weight</td>
        /// <td>125g</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Number of Blades</td>
        /// <td>6 or more</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Fan Category</td>
        /// <td>Handheld Fan</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CategoryAttributeMatchRequest
        /// </param>
        /// 
        /// <returns>
        /// CategoryAttributeMatchResponse
        /// </returns>
        public CategoryAttributeMatchResponse CategoryAttributeMatch(CategoryAttributeMatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CategoryAttributeMatchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a cross-platform product category and attribute intelligent filling service based on multimodal large models. Takes product information from a source platform, automatically matches the category on the target listing platform, and intelligently fills in all required attribute fields under that category, offering a one-stop solution for category selection and attribute filling during product listing. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Applicable scenarios</h1>
        /// <para>Cross-platform product listing attribute filling: When merchants list products across platforms, the attribute fields required by different platforms (source platform, TEMU platform) vary significantly, with complex hierarchical options (such as material → wood type → density). Manual filling is time-consuming and error-prone. This service automatically understands product information and intelligently fills in attributes. It is suitable for scenarios such as automated bulk listing for top sellers, ERP/SaaS platform integration, and quick product listing for SMB merchants.</para>
        /// <h1>Feature overview</h1>
        /// <para>Users input the product title, source category, product details, SKU, product attributes, and product images (up to 10). The system uses multimodal AI to understand product semantics and visual features, completing two core tasks: ① Matching the precise category path for the product on the TEMU platform. ② Automatically filling in the required attributes under that category (such as material, battery properties, size, connectivity), and returning the confidence level and reasoning for each attribute. The API operates in synchronous mode and returns results immediately upon invocation.</para>
        /// <h1>Comparison</h1>
        /// <para>The following example shows the attributes of a USB fan:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>1688 Attribute</b></th>
        /// <th><b>1688 Attribute Value</b></th>
        /// <th><b>TEMU Attribute</b></th>
        /// <th><b>TEMU Attribute Value</b></th>
        /// <th><b>Existing in 1688</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Brand</td>
        /// <td>Other</td>
        /// <td>Power Mode</td>
        /// <td>USB Charging (Built-in Battery)</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Battery Life</td>
        /// <td>3-6h (inclusive)</td>
        /// <td>Rechargeable Battery</td>
        /// <td>Lithium Battery</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Additional Features</td>
        /// <td>Digital Display</td>
        /// <td>Battery Capacity (mAh)</td>
        /// <td>4000</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>Built-in Battery Capacity</td>
        /// <td>2000mAh-4000mAh (inclusive)</td>
        /// <td>Fan Features</td>
        /// <td>High Speed</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Item Number</td>
        /// <td>X699</td>
        /// <td>Control Method</td>
        /// <td>Button</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>Main Downstream Platforms</td>
        /// <td>eBay, Amazon, Wish, AliExpress, Independent Sites, LAZADA, Other</td>
        /// <td>Finish Type</td>
        /// <td>Painted</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>Has Licensable Own Brand</td>
        /// <td>No</td>
        /// <td>Recommended Use</td>
        /// <td>Cooling</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Dimensions</td>
        /// <td>65\*60\*171</td>
        /// <td>Fan Design</td>
        /// <td>Wearable Fan</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Applicable Gift Occasions</td>
        /// <td>Personal Gifts</td>
        /// <td>Included Components</td>
        /// <td>None</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Shell Process</td>
        /// <td>Spray Coating (UV Paint, Rubber Paint, Metallic Paint, Piano Lacquer, Pearl Powder)</td>
        /// <td>Material</td>
        /// <td>Plastic</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Package Volume</td>
        /// <td>65\*60\*171</td>
        /// <td>Special Features</td>
        /// <td>Portable</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Appearance Dimensions</td>
        /// <td>51\*36\*34</td>
        /// <td>Indoor/Outdoor Use</td>
        /// <td>Both Indoor and Outdoor</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Wind Speed Levels</td>
        /// <td>3 Levels</td>
        /// <td>Brand Name</td>
        /// <td>None</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>Operation Method</td>
        /// <td>Standard Button</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Blade Material</td>
        /// <td>ABS</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Power Mode</td>
        /// <td>USB</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Built-in Battery</td>
        /// <td>Yes</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Patented Source</td>
        /// <td>No</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Color</td>
        /// <td>X699 Fan-Yellow, X699 Fan-Light Purple, X699 Fan-Sky Blue, X699 Fan-Orange, X699 Fan-Light Green, Standard Small Fan</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Main Sales Regions</td>
        /// <td>Japan/Korea, Africa, Korea, Japan, Europe, South America, Southeast Asia, North America, Northeast Asia, Middle East, Latin America, Europe/America, Other</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Cross-border Export Exclusive</td>
        /// <td>Yes</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Style</td>
        /// <td>Fresh</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Motor Type</td>
        /// <td>Brushless Motor</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Noise</td>
        /// <td>36dB(A)-45dB(A) (inclusive)</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Net Weight</td>
        /// <td>125g</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Number of Blades</td>
        /// <td>6 or more</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Fan Category</td>
        /// <td>Handheld Fan</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CategoryAttributeMatchRequest
        /// </param>
        /// 
        /// <returns>
        /// CategoryAttributeMatchResponse
        /// </returns>
        public async Task<CategoryAttributeMatchResponse> CategoryAttributeMatchAsync(CategoryAttributeMatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CategoryAttributeMatchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a large language model-based intelligent cross-platform product category matching service. Accepts product information from a source platform, automatically matches the best category on the target listing platform, and returns a confidence level score with matching reasons to help merchants quickly select categories during cross-platform product listing. (Synchronization)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A large language model-based intelligent cross-platform product category matching service. Accepts product information from a source platform, automatically matches the best category on the target listing platform, and returns a confidence level score with matching reasons to help merchants quickly select categories during cross-platform product listing. (Synchronization)</para>
        /// <h2>Common scenarios</h2>
        /// <para>Cross-platform product listing: After sourcing products, merchants list them on a target platform and need to match products to the correct category in the target platform\&quot;s category tree. Manually selecting categories requires familiarity with the target platform\&quot;s complete category system, which is time-consuming, labor-intensive, and error-prone. Incorrect category matching can cause product delisting and other issues.
        /// This service automates category mapping and is suitable for bulk API calls from top sellers\&quot; self-built systems, ERP/SaaS platform integration for automated listing workflows, and quick single-product listing for SMB merchants.
        /// The current version only supports TEMU as the target listing platform. Currently, automatic product information retrieval from source platforms is not supported and users must manually provide input parameters. This capability will be added in future versions, along with support for more source and target platforms.</para>
        /// <h2>Functions and features</h2>
        /// <para>Users input fields such as product title, source category, product description, SKU information, and product attributes. The system uses an AI model to understand product semantics and matches the most appropriate category path from the TEMU platform\&quot;s full category tree. The response includes the complete category path (CategoryPath), category name (CategoryName), confidence score (0-100), and matching reason. The API uses synchronous mode and returns results immediately after invocation, making it suitable for embedding in real-time business workflows.</para>
        /// <h2>Demo</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Source platform</b></th>
        /// <th><b>Image</b></th>
        /// <th><b>Source platform category</b></th>
        /// <th><b>Target platform</b></th>
        /// <th><b>Target platform category</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>1688</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/jP2lRYjv7234mO8g/img/69a226e8-aff1-4891-bb0a-c47c1ea397ae.png" alt="done-image-245c58c8-a9fc-4e32-b959-8b4bcd52b264.png"></td>
        /// <td>USB fan, mini fan</td>
        /// <td>TEMU</td>
        /// <td>Home Appliances</td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Heating, Cooling &amp; Air Quality Appliances</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Electric Fans</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;USB Fans</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>1688</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/jP2lRYjv7234mO8g/img/8a546f7d-826e-43d6-b5f3-12d1edef8897.png" alt="image.png"></td>
        /// <td>Bracelet</td>
        /// <td>TEMU</td>
        /// <td>Clothing, Shoes &amp; Jewelry</td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Jewelry</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion Bracelets &amp; Bangles</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion Charms &amp; Charm Bracelets</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion Charm Bracelets</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion Chain Charm Bracelets</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CategoryMatchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CategoryMatchResponse
        /// </returns>
        public CategoryMatchResponse CategoryMatchWithOptions(CategoryMatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemSpec))
            {
                query["ItemSpec"] = request.ItemSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sku))
            {
                query["Sku"] = request.Sku;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCategory))
            {
                query["SourceCategory"] = request.SourceCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePlatform))
            {
                query["SourcePlatform"] = request.SourcePlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPlatform))
            {
                query["TargetPlatform"] = request.TargetPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CategoryMatch",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CategoryMatchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a large language model-based intelligent cross-platform product category matching service. Accepts product information from a source platform, automatically matches the best category on the target listing platform, and returns a confidence level score with matching reasons to help merchants quickly select categories during cross-platform product listing. (Synchronization)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A large language model-based intelligent cross-platform product category matching service. Accepts product information from a source platform, automatically matches the best category on the target listing platform, and returns a confidence level score with matching reasons to help merchants quickly select categories during cross-platform product listing. (Synchronization)</para>
        /// <h2>Common scenarios</h2>
        /// <para>Cross-platform product listing: After sourcing products, merchants list them on a target platform and need to match products to the correct category in the target platform\&quot;s category tree. Manually selecting categories requires familiarity with the target platform\&quot;s complete category system, which is time-consuming, labor-intensive, and error-prone. Incorrect category matching can cause product delisting and other issues.
        /// This service automates category mapping and is suitable for bulk API calls from top sellers\&quot; self-built systems, ERP/SaaS platform integration for automated listing workflows, and quick single-product listing for SMB merchants.
        /// The current version only supports TEMU as the target listing platform. Currently, automatic product information retrieval from source platforms is not supported and users must manually provide input parameters. This capability will be added in future versions, along with support for more source and target platforms.</para>
        /// <h2>Functions and features</h2>
        /// <para>Users input fields such as product title, source category, product description, SKU information, and product attributes. The system uses an AI model to understand product semantics and matches the most appropriate category path from the TEMU platform\&quot;s full category tree. The response includes the complete category path (CategoryPath), category name (CategoryName), confidence score (0-100), and matching reason. The API uses synchronous mode and returns results immediately after invocation, making it suitable for embedding in real-time business workflows.</para>
        /// <h2>Demo</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Source platform</b></th>
        /// <th><b>Image</b></th>
        /// <th><b>Source platform category</b></th>
        /// <th><b>Target platform</b></th>
        /// <th><b>Target platform category</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>1688</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/jP2lRYjv7234mO8g/img/69a226e8-aff1-4891-bb0a-c47c1ea397ae.png" alt="done-image-245c58c8-a9fc-4e32-b959-8b4bcd52b264.png"></td>
        /// <td>USB fan, mini fan</td>
        /// <td>TEMU</td>
        /// <td>Home Appliances</td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Heating, Cooling &amp; Air Quality Appliances</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Electric Fans</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;USB Fans</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>1688</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/jP2lRYjv7234mO8g/img/8a546f7d-826e-43d6-b5f3-12d1edef8897.png" alt="image.png"></td>
        /// <td>Bracelet</td>
        /// <td>TEMU</td>
        /// <td>Clothing, Shoes &amp; Jewelry</td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Jewelry</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion Bracelets &amp; Bangles</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion Charms &amp; Charm Bracelets</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion Charm Bracelets</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion Chain Charm Bracelets</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CategoryMatchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CategoryMatchResponse
        /// </returns>
        public async Task<CategoryMatchResponse> CategoryMatchWithOptionsAsync(CategoryMatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemSpec))
            {
                query["ItemSpec"] = request.ItemSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sku))
            {
                query["Sku"] = request.Sku;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCategory))
            {
                query["SourceCategory"] = request.SourceCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePlatform))
            {
                query["SourcePlatform"] = request.SourcePlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPlatform))
            {
                query["TargetPlatform"] = request.TargetPlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CategoryMatch",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CategoryMatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a large language model-based intelligent cross-platform product category matching service. Accepts product information from a source platform, automatically matches the best category on the target listing platform, and returns a confidence level score with matching reasons to help merchants quickly select categories during cross-platform product listing. (Synchronization)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A large language model-based intelligent cross-platform product category matching service. Accepts product information from a source platform, automatically matches the best category on the target listing platform, and returns a confidence level score with matching reasons to help merchants quickly select categories during cross-platform product listing. (Synchronization)</para>
        /// <h2>Common scenarios</h2>
        /// <para>Cross-platform product listing: After sourcing products, merchants list them on a target platform and need to match products to the correct category in the target platform\&quot;s category tree. Manually selecting categories requires familiarity with the target platform\&quot;s complete category system, which is time-consuming, labor-intensive, and error-prone. Incorrect category matching can cause product delisting and other issues.
        /// This service automates category mapping and is suitable for bulk API calls from top sellers\&quot; self-built systems, ERP/SaaS platform integration for automated listing workflows, and quick single-product listing for SMB merchants.
        /// The current version only supports TEMU as the target listing platform. Currently, automatic product information retrieval from source platforms is not supported and users must manually provide input parameters. This capability will be added in future versions, along with support for more source and target platforms.</para>
        /// <h2>Functions and features</h2>
        /// <para>Users input fields such as product title, source category, product description, SKU information, and product attributes. The system uses an AI model to understand product semantics and matches the most appropriate category path from the TEMU platform\&quot;s full category tree. The response includes the complete category path (CategoryPath), category name (CategoryName), confidence score (0-100), and matching reason. The API uses synchronous mode and returns results immediately after invocation, making it suitable for embedding in real-time business workflows.</para>
        /// <h2>Demo</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Source platform</b></th>
        /// <th><b>Image</b></th>
        /// <th><b>Source platform category</b></th>
        /// <th><b>Target platform</b></th>
        /// <th><b>Target platform category</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>1688</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/jP2lRYjv7234mO8g/img/69a226e8-aff1-4891-bb0a-c47c1ea397ae.png" alt="done-image-245c58c8-a9fc-4e32-b959-8b4bcd52b264.png"></td>
        /// <td>USB fan, mini fan</td>
        /// <td>TEMU</td>
        /// <td>Home Appliances</td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Heating, Cooling &amp; Air Quality Appliances</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Electric Fans</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;USB Fans</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>1688</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/jP2lRYjv7234mO8g/img/8a546f7d-826e-43d6-b5f3-12d1edef8897.png" alt="image.png"></td>
        /// <td>Bracelet</td>
        /// <td>TEMU</td>
        /// <td>Clothing, Shoes &amp; Jewelry</td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Jewelry</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion Bracelets &amp; Bangles</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion Charms &amp; Charm Bracelets</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion Charm Bracelets</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion Chain Charm Bracelets</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CategoryMatchRequest
        /// </param>
        /// 
        /// <returns>
        /// CategoryMatchResponse
        /// </returns>
        public CategoryMatchResponse CategoryMatch(CategoryMatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CategoryMatchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a large language model-based intelligent cross-platform product category matching service. Accepts product information from a source platform, automatically matches the best category on the target listing platform, and returns a confidence level score with matching reasons to help merchants quickly select categories during cross-platform product listing. (Synchronization)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A large language model-based intelligent cross-platform product category matching service. Accepts product information from a source platform, automatically matches the best category on the target listing platform, and returns a confidence level score with matching reasons to help merchants quickly select categories during cross-platform product listing. (Synchronization)</para>
        /// <h2>Common scenarios</h2>
        /// <para>Cross-platform product listing: After sourcing products, merchants list them on a target platform and need to match products to the correct category in the target platform\&quot;s category tree. Manually selecting categories requires familiarity with the target platform\&quot;s complete category system, which is time-consuming, labor-intensive, and error-prone. Incorrect category matching can cause product delisting and other issues.
        /// This service automates category mapping and is suitable for bulk API calls from top sellers\&quot; self-built systems, ERP/SaaS platform integration for automated listing workflows, and quick single-product listing for SMB merchants.
        /// The current version only supports TEMU as the target listing platform. Currently, automatic product information retrieval from source platforms is not supported and users must manually provide input parameters. This capability will be added in future versions, along with support for more source and target platforms.</para>
        /// <h2>Functions and features</h2>
        /// <para>Users input fields such as product title, source category, product description, SKU information, and product attributes. The system uses an AI model to understand product semantics and matches the most appropriate category path from the TEMU platform\&quot;s full category tree. The response includes the complete category path (CategoryPath), category name (CategoryName), confidence score (0-100), and matching reason. The API uses synchronous mode and returns results immediately after invocation, making it suitable for embedding in real-time business workflows.</para>
        /// <h2>Demo</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Source platform</b></th>
        /// <th><b>Image</b></th>
        /// <th><b>Source platform category</b></th>
        /// <th><b>Target platform</b></th>
        /// <th><b>Target platform category</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>1688</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/jP2lRYjv7234mO8g/img/69a226e8-aff1-4891-bb0a-c47c1ea397ae.png" alt="done-image-245c58c8-a9fc-4e32-b959-8b4bcd52b264.png"></td>
        /// <td>USB fan, mini fan</td>
        /// <td>TEMU</td>
        /// <td>Home Appliances</td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Heating, Cooling &amp; Air Quality Appliances</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Electric Fans</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;USB Fans</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>1688</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/jP2lRYjv7234mO8g/img/8a546f7d-826e-43d6-b5f3-12d1edef8897.png" alt="image.png"></td>
        /// <td>Bracelet</td>
        /// <td>TEMU</td>
        /// <td>Clothing, Shoes &amp; Jewelry</td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Jewelry</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion Bracelets &amp; Bangles</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion Charms &amp; Charm Bracelets</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion Charm Bracelets</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;Women\&quot;s Fashion Chain Charm Bracelets</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CategoryMatchRequest
        /// </param>
        /// 
        /// <returns>
        /// CategoryMatchResponse
        /// </returns>
        public async Task<CategoryMatchResponse> CategoryMatchAsync(CategoryMatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CategoryMatchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calculates the edge lengths and floor area of a floor display based on the display image and product detection boxes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para><b>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.aliyun.com/price/product#/ecs/detail">pricing</a> of the floor display area inference service.</b></para>
        /// <list type="bullet">
        /// <item><description>This operation infers the actual dimensions (lengths of two edges) and floor area of a floor display based on the provided overall display image, SKU knowledge base, and product location information in the image.</description></item>
        /// <item><description>Make sure that the knowledge base corresponding to the specified <c>RagId</c> belongs to the caller and is in the available (<c>AVAILABLE</c>) state.</description></item>
        /// <item><description>The <c>Products</c> array must contain at least one product item, and each product item must have at least one bounding box defined in <c>Boxes</c>.</description></item>
        /// <item><description>All coordinate values are represented in a normalized coordinate system ranging from 0 to 1000. Make sure that the input satisfies the relationships <c>Left &lt; Right</c> and <c>Top &lt; Bottom</c>.</description></item>
        /// <item><description>Set a reasonable timeout period when calling this operation (no more than 300 seconds recommended) to avoid failures caused by network latency or high processing complexity.</description></item>
        /// <item><description>For production environments, use the POP Action method for access. The internal REST address is primarily used for integration testing during the development phase.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DiduiAreaDeductionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DiduiAreaDeductionResponse
        /// </returns>
        public DiduiAreaDeductionResponse DiduiAreaDeductionWithOptions(DiduiAreaDeductionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DiduiAreaDeductionShrinkRequest request = new DiduiAreaDeductionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Products))
            {
                request.ProductsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Products, "Products", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductsShrink))
            {
                query["Products"] = request.ProductsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RagId))
            {
                query["RagId"] = request.RagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetImageUrl))
            {
                query["TargetImageUrl"] = request.TargetImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DiduiAreaDeduction",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DiduiAreaDeductionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calculates the edge lengths and floor area of a floor display based on the display image and product detection boxes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para><b>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.aliyun.com/price/product#/ecs/detail">pricing</a> of the floor display area inference service.</b></para>
        /// <list type="bullet">
        /// <item><description>This operation infers the actual dimensions (lengths of two edges) and floor area of a floor display based on the provided overall display image, SKU knowledge base, and product location information in the image.</description></item>
        /// <item><description>Make sure that the knowledge base corresponding to the specified <c>RagId</c> belongs to the caller and is in the available (<c>AVAILABLE</c>) state.</description></item>
        /// <item><description>The <c>Products</c> array must contain at least one product item, and each product item must have at least one bounding box defined in <c>Boxes</c>.</description></item>
        /// <item><description>All coordinate values are represented in a normalized coordinate system ranging from 0 to 1000. Make sure that the input satisfies the relationships <c>Left &lt; Right</c> and <c>Top &lt; Bottom</c>.</description></item>
        /// <item><description>Set a reasonable timeout period when calling this operation (no more than 300 seconds recommended) to avoid failures caused by network latency or high processing complexity.</description></item>
        /// <item><description>For production environments, use the POP Action method for access. The internal REST address is primarily used for integration testing during the development phase.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DiduiAreaDeductionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DiduiAreaDeductionResponse
        /// </returns>
        public async Task<DiduiAreaDeductionResponse> DiduiAreaDeductionWithOptionsAsync(DiduiAreaDeductionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DiduiAreaDeductionShrinkRequest request = new DiduiAreaDeductionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Products))
            {
                request.ProductsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Products, "Products", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductsShrink))
            {
                query["Products"] = request.ProductsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RagId))
            {
                query["RagId"] = request.RagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetImageUrl))
            {
                query["TargetImageUrl"] = request.TargetImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DiduiAreaDeduction",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DiduiAreaDeductionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calculates the edge lengths and floor area of a floor display based on the display image and product detection boxes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para><b>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.aliyun.com/price/product#/ecs/detail">pricing</a> of the floor display area inference service.</b></para>
        /// <list type="bullet">
        /// <item><description>This operation infers the actual dimensions (lengths of two edges) and floor area of a floor display based on the provided overall display image, SKU knowledge base, and product location information in the image.</description></item>
        /// <item><description>Make sure that the knowledge base corresponding to the specified <c>RagId</c> belongs to the caller and is in the available (<c>AVAILABLE</c>) state.</description></item>
        /// <item><description>The <c>Products</c> array must contain at least one product item, and each product item must have at least one bounding box defined in <c>Boxes</c>.</description></item>
        /// <item><description>All coordinate values are represented in a normalized coordinate system ranging from 0 to 1000. Make sure that the input satisfies the relationships <c>Left &lt; Right</c> and <c>Top &lt; Bottom</c>.</description></item>
        /// <item><description>Set a reasonable timeout period when calling this operation (no more than 300 seconds recommended) to avoid failures caused by network latency or high processing complexity.</description></item>
        /// <item><description>For production environments, use the POP Action method for access. The internal REST address is primarily used for integration testing during the development phase.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DiduiAreaDeductionRequest
        /// </param>
        /// 
        /// <returns>
        /// DiduiAreaDeductionResponse
        /// </returns>
        public DiduiAreaDeductionResponse DiduiAreaDeduction(DiduiAreaDeductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DiduiAreaDeductionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calculates the edge lengths and floor area of a floor display based on the display image and product detection boxes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Description</h2>
        /// <para><b>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.aliyun.com/price/product#/ecs/detail">pricing</a> of the floor display area inference service.</b></para>
        /// <list type="bullet">
        /// <item><description>This operation infers the actual dimensions (lengths of two edges) and floor area of a floor display based on the provided overall display image, SKU knowledge base, and product location information in the image.</description></item>
        /// <item><description>Make sure that the knowledge base corresponding to the specified <c>RagId</c> belongs to the caller and is in the available (<c>AVAILABLE</c>) state.</description></item>
        /// <item><description>The <c>Products</c> array must contain at least one product item, and each product item must have at least one bounding box defined in <c>Boxes</c>.</description></item>
        /// <item><description>All coordinate values are represented in a normalized coordinate system ranging from 0 to 1000. Make sure that the input satisfies the relationships <c>Left &lt; Right</c> and <c>Top &lt; Bottom</c>.</description></item>
        /// <item><description>Set a reasonable timeout period when calling this operation (no more than 300 seconds recommended) to avoid failures caused by network latency or high processing complexity.</description></item>
        /// <item><description>For production environments, use the POP Action method for access. The internal REST address is primarily used for integration testing during the development phase.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DiduiAreaDeductionRequest
        /// </param>
        /// 
        /// <returns>
        /// DiduiAreaDeductionResponse
        /// </returns>
        public async Task<DiduiAreaDeductionResponse> DiduiAreaDeductionAsync(DiduiAreaDeductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DiduiAreaDeductionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Designed specifically for document translation. Supports translation between more than 100 language pairs (including bridged pairs) to handle multi-scenario, multi-page, and highly complex document translation. Scanned documents are not currently supported.
        /// Excels in the following areas:</para>
        /// <list type="bullet">
        /// <item><description>Content accuracy: translation accuracy, parameter and unit accuracy.</description></item>
        /// <item><description>Structural integrity: overall layout continuity, page margin and layout restoration.</description></item>
        /// </list>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Designed specifically for document translation. Supports translation between more than 100 language pairs (including bridged pairs) to handle multi-scenario, multi-page, and highly complex document translation. Scanned documents are not currently supported.
        /// Excels in the following areas:</para>
        /// <list type="bullet">
        /// <item><description>Content accuracy: translation accuracy, parameter and unit accuracy</description></item>
        /// <item><description>Structural integrity: overall layout continuity, page margin and layout restoration</description></item>
        /// </list>
        /// <h2>Common scenarios</h2>
        /// <para>Cross-border e-commerce product manuals, contracts, agreements, business proposals, qualification documents, textbooks and courseware, and many other scenarios.</para>
        /// <h2>Functions and features</h2>
        /// <list type="bullet">
        /// <item><description>Supports PDF and Word formats. Supports source documents that contain multiple languages. For a detailed language list, see section 4.5.</description></item>
        /// <item><description>Supports translation of text within images in documents, as well as complex translation scenarios such as charts and special symbols.</description></item>
        /// <item><description>Supports high-fidelity layout restoration after translation.</description></item>
        /// <item><description>A single PDF supports up to 100 pages. A single Word document supports up to 100 pages.</description></item>
        /// <item><description>Supports custom translation results, including do-not-translate (ABC-ABC), specified translation (ABC-DEF), and skip translation (ABC-empty value). This is commonly used for scenarios such as brand name protection. Simply pass the corresponding glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 glossary entries. If you need more, contact the platform for assistance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DocumentTranslateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocumentTranslateResponse
        /// </returns>
        public DocumentTranslateResponse DocumentTranslateWithOptions(DocumentTranslateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Glossary))
            {
                query["Glossary"] = request.Glossary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                query["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocumentTranslate",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocumentTranslateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Designed specifically for document translation. Supports translation between more than 100 language pairs (including bridged pairs) to handle multi-scenario, multi-page, and highly complex document translation. Scanned documents are not currently supported.
        /// Excels in the following areas:</para>
        /// <list type="bullet">
        /// <item><description>Content accuracy: translation accuracy, parameter and unit accuracy.</description></item>
        /// <item><description>Structural integrity: overall layout continuity, page margin and layout restoration.</description></item>
        /// </list>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Designed specifically for document translation. Supports translation between more than 100 language pairs (including bridged pairs) to handle multi-scenario, multi-page, and highly complex document translation. Scanned documents are not currently supported.
        /// Excels in the following areas:</para>
        /// <list type="bullet">
        /// <item><description>Content accuracy: translation accuracy, parameter and unit accuracy</description></item>
        /// <item><description>Structural integrity: overall layout continuity, page margin and layout restoration</description></item>
        /// </list>
        /// <h2>Common scenarios</h2>
        /// <para>Cross-border e-commerce product manuals, contracts, agreements, business proposals, qualification documents, textbooks and courseware, and many other scenarios.</para>
        /// <h2>Functions and features</h2>
        /// <list type="bullet">
        /// <item><description>Supports PDF and Word formats. Supports source documents that contain multiple languages. For a detailed language list, see section 4.5.</description></item>
        /// <item><description>Supports translation of text within images in documents, as well as complex translation scenarios such as charts and special symbols.</description></item>
        /// <item><description>Supports high-fidelity layout restoration after translation.</description></item>
        /// <item><description>A single PDF supports up to 100 pages. A single Word document supports up to 100 pages.</description></item>
        /// <item><description>Supports custom translation results, including do-not-translate (ABC-ABC), specified translation (ABC-DEF), and skip translation (ABC-empty value). This is commonly used for scenarios such as brand name protection. Simply pass the corresponding glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 glossary entries. If you need more, contact the platform for assistance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DocumentTranslateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DocumentTranslateResponse
        /// </returns>
        public async Task<DocumentTranslateResponse> DocumentTranslateWithOptionsAsync(DocumentTranslateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Glossary))
            {
                query["Glossary"] = request.Glossary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                query["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DocumentTranslate",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DocumentTranslateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Designed specifically for document translation. Supports translation between more than 100 language pairs (including bridged pairs) to handle multi-scenario, multi-page, and highly complex document translation. Scanned documents are not currently supported.
        /// Excels in the following areas:</para>
        /// <list type="bullet">
        /// <item><description>Content accuracy: translation accuracy, parameter and unit accuracy.</description></item>
        /// <item><description>Structural integrity: overall layout continuity, page margin and layout restoration.</description></item>
        /// </list>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Designed specifically for document translation. Supports translation between more than 100 language pairs (including bridged pairs) to handle multi-scenario, multi-page, and highly complex document translation. Scanned documents are not currently supported.
        /// Excels in the following areas:</para>
        /// <list type="bullet">
        /// <item><description>Content accuracy: translation accuracy, parameter and unit accuracy</description></item>
        /// <item><description>Structural integrity: overall layout continuity, page margin and layout restoration</description></item>
        /// </list>
        /// <h2>Common scenarios</h2>
        /// <para>Cross-border e-commerce product manuals, contracts, agreements, business proposals, qualification documents, textbooks and courseware, and many other scenarios.</para>
        /// <h2>Functions and features</h2>
        /// <list type="bullet">
        /// <item><description>Supports PDF and Word formats. Supports source documents that contain multiple languages. For a detailed language list, see section 4.5.</description></item>
        /// <item><description>Supports translation of text within images in documents, as well as complex translation scenarios such as charts and special symbols.</description></item>
        /// <item><description>Supports high-fidelity layout restoration after translation.</description></item>
        /// <item><description>A single PDF supports up to 100 pages. A single Word document supports up to 100 pages.</description></item>
        /// <item><description>Supports custom translation results, including do-not-translate (ABC-ABC), specified translation (ABC-DEF), and skip translation (ABC-empty value). This is commonly used for scenarios such as brand name protection. Simply pass the corresponding glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 glossary entries. If you need more, contact the platform for assistance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DocumentTranslateRequest
        /// </param>
        /// 
        /// <returns>
        /// DocumentTranslateResponse
        /// </returns>
        public DocumentTranslateResponse DocumentTranslate(DocumentTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DocumentTranslateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Designed specifically for document translation. Supports translation between more than 100 language pairs (including bridged pairs) to handle multi-scenario, multi-page, and highly complex document translation. Scanned documents are not currently supported.
        /// Excels in the following areas:</para>
        /// <list type="bullet">
        /// <item><description>Content accuracy: translation accuracy, parameter and unit accuracy.</description></item>
        /// <item><description>Structural integrity: overall layout continuity, page margin and layout restoration.</description></item>
        /// </list>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Designed specifically for document translation. Supports translation between more than 100 language pairs (including bridged pairs) to handle multi-scenario, multi-page, and highly complex document translation. Scanned documents are not currently supported.
        /// Excels in the following areas:</para>
        /// <list type="bullet">
        /// <item><description>Content accuracy: translation accuracy, parameter and unit accuracy</description></item>
        /// <item><description>Structural integrity: overall layout continuity, page margin and layout restoration</description></item>
        /// </list>
        /// <h2>Common scenarios</h2>
        /// <para>Cross-border e-commerce product manuals, contracts, agreements, business proposals, qualification documents, textbooks and courseware, and many other scenarios.</para>
        /// <h2>Functions and features</h2>
        /// <list type="bullet">
        /// <item><description>Supports PDF and Word formats. Supports source documents that contain multiple languages. For a detailed language list, see section 4.5.</description></item>
        /// <item><description>Supports translation of text within images in documents, as well as complex translation scenarios such as charts and special symbols.</description></item>
        /// <item><description>Supports high-fidelity layout restoration after translation.</description></item>
        /// <item><description>A single PDF supports up to 100 pages. A single Word document supports up to 100 pages.</description></item>
        /// <item><description>Supports custom translation results, including do-not-translate (ABC-ABC), specified translation (ABC-DEF), and skip translation (ABC-empty value). This is commonly used for scenarios such as brand name protection. Simply pass the corresponding glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 glossary entries. If you need more, contact the platform for assistance.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DocumentTranslateRequest
        /// </param>
        /// 
        /// <returns>
        /// DocumentTranslateResponse
        /// </returns>
        public async Task<DocumentTranslateResponse> DocumentTranslateAsync(DocumentTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DocumentTranslateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>E-commerce Video Remix is an AI video service designed for product content production. It covers video understanding, element replacement, quality verification, and result delivery. The service focuses on product and person consistency, detail restoration, conversion-oriented expression, and large-scale production. It supports targeted replacement of products or persons based on hit video templates while preserving the original actions, shot rhythm, and marketing structure to rapidly generate multi-version content and reduce shooting, editing, and adaptation costs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Product Introduction</b></h2>
        /// <para>E-commerce Video Remix is an AI video service designed for product content production. It covers video understanding, element replacement, quality verification, and result delivery. The service focuses on product and person consistency, detail restoration, conversion-oriented expression, and large-scale production. It supports targeted replacement of products or persons based on hit video templates while preserving the original actions, shot rhythm, and marketing structure to rapidly generate multi-version content and reduce shooting, editing, and adaptation costs.</para>
        /// <h2><b>Scenarios</b></h2>
        /// <list type="bullet">
        /// <item><description><b>Video asset remix:</b> Use an existing e-commerce video as a template and replace only the specified product or person while preserving the original shots, rhythm, and marketing expression. This is suitable for multi-SKU, multi-model, multi-region, and multi-version asset production.</description></item>
        /// <item><description><b>New product launch with rapid asset generation:</b> For products launched in batches, reduce the need for live shooting, studio time, post-production editing, and repetitive production. Quickly generate video assets for new products and help merchants shorten the cycle from discovering a hit video to scripting and publishing new content.</description></item>
        /// <item><description><b>Product presentation and selling point expression:</b> Suitable for apparel, beauty and personal care, food and beverages, home and daily essentials, 3C electronics, and small appliances. Based on the selling point structure, display actions, and shot rhythm of the original video, generate presentation videos optimized for new product conversion.</description></item>
        /// <item><description><b>Multi-selling-point and multi-version testing:</b> Rapidly generate multiple versions based on different product selling points, target audiences, scripts, shots, and visual styles to support content testing and ad creative iteration.</description></item>
        /// </list>
        /// <h2><b>Capabilities</b></h2>
        /// <h3><b>Core capabilities</b></h3>
        /// <para>Two replacement modes are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>Product replacement (product_replacement):</b> Preserves the original video host identity, actions, scene, and selling structure while replacing the original product with the target product.</description></item>
        /// <item><description><b>Person replacement (person_replacement):</b> Preserves the original video product, actions, scene, and selling structure while replacing the on-screen person with the target person from a reference image or description.</description></item>
        /// <item><description><b>Fully automated end-to-end generation with zero prompt requirements:</b> Simply provide a reference video and a target product image or person image. The system automatically completes the entire pipeline including video understanding, script planning, storyboard design, first-frame generation, and video synthesis.</description></item>
        /// <item><description><b>Product understanding and information structuring:</b> Identifies product category, appearance, material, color, structure, and key components, and combines merchant-provided titles, attributes, and selling points to generate usable video expression information.</description></item>
        /// <item><description><b>Template video element replacement:</b> Supports replacing products or persons within the authorized scope, with configurable replacement and protection ranges to minimize changes in non-target areas.</description></item>
        /// <item><description><b>Product subject consistency:</b> Maintains stable product shape, color, texture, pattern, packaging, and logo across different shots, angles, actions, and scenes.</description></item>
        /// <item><description><b>Product fidelity:</b> Multi-round VL quality inspection locks product state (color, texture, structure, and print) throughout the process to prevent product feature drift.</description></item>
        /// <item><description><b>Strength category — Apparel:</b> Faithfully restores apparel details with attention to silhouette, wrinkles, drape, fabric texture, buttons, zippers, prints, and accessories, reducing clipping, deformation, texture loss, and detail artifacts.</description></item>
        /// <item><description><b>Selling point script and storyboard replication:</b> Replicates the selling point structure, video composition, shot sequence, display actions, voiceover content, and closing style of the original video.</description></item>
        /// <item><description><b>Commercial model matching:</b> Supports matching model appearance and display style based on product style, silhouette, target audience, and market requirements.</description></item>
        /// <item><description><b>Quality verification and result feedback:</b> Performs multi-dimensional checks on product subject, person, apparel, text, frame completeness, audio, and overall usability, and outputs result information for manual review.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// EcomVideoRecreationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EcomVideoRecreationResponse
        /// </returns>
        public EcomVideoRecreationResponse EcomVideoRecreationWithOptions(EcomVideoRecreationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EcomVideoRecreationShrinkRequest request = new EcomVideoRecreationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Output))
            {
                request.OutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Output, "Output", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputShrink))
            {
                query["Output"] = request.OutputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EcomVideoRecreation",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EcomVideoRecreationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>E-commerce Video Remix is an AI video service designed for product content production. It covers video understanding, element replacement, quality verification, and result delivery. The service focuses on product and person consistency, detail restoration, conversion-oriented expression, and large-scale production. It supports targeted replacement of products or persons based on hit video templates while preserving the original actions, shot rhythm, and marketing structure to rapidly generate multi-version content and reduce shooting, editing, and adaptation costs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Product Introduction</b></h2>
        /// <para>E-commerce Video Remix is an AI video service designed for product content production. It covers video understanding, element replacement, quality verification, and result delivery. The service focuses on product and person consistency, detail restoration, conversion-oriented expression, and large-scale production. It supports targeted replacement of products or persons based on hit video templates while preserving the original actions, shot rhythm, and marketing structure to rapidly generate multi-version content and reduce shooting, editing, and adaptation costs.</para>
        /// <h2><b>Scenarios</b></h2>
        /// <list type="bullet">
        /// <item><description><b>Video asset remix:</b> Use an existing e-commerce video as a template and replace only the specified product or person while preserving the original shots, rhythm, and marketing expression. This is suitable for multi-SKU, multi-model, multi-region, and multi-version asset production.</description></item>
        /// <item><description><b>New product launch with rapid asset generation:</b> For products launched in batches, reduce the need for live shooting, studio time, post-production editing, and repetitive production. Quickly generate video assets for new products and help merchants shorten the cycle from discovering a hit video to scripting and publishing new content.</description></item>
        /// <item><description><b>Product presentation and selling point expression:</b> Suitable for apparel, beauty and personal care, food and beverages, home and daily essentials, 3C electronics, and small appliances. Based on the selling point structure, display actions, and shot rhythm of the original video, generate presentation videos optimized for new product conversion.</description></item>
        /// <item><description><b>Multi-selling-point and multi-version testing:</b> Rapidly generate multiple versions based on different product selling points, target audiences, scripts, shots, and visual styles to support content testing and ad creative iteration.</description></item>
        /// </list>
        /// <h2><b>Capabilities</b></h2>
        /// <h3><b>Core capabilities</b></h3>
        /// <para>Two replacement modes are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>Product replacement (product_replacement):</b> Preserves the original video host identity, actions, scene, and selling structure while replacing the original product with the target product.</description></item>
        /// <item><description><b>Person replacement (person_replacement):</b> Preserves the original video product, actions, scene, and selling structure while replacing the on-screen person with the target person from a reference image or description.</description></item>
        /// <item><description><b>Fully automated end-to-end generation with zero prompt requirements:</b> Simply provide a reference video and a target product image or person image. The system automatically completes the entire pipeline including video understanding, script planning, storyboard design, first-frame generation, and video synthesis.</description></item>
        /// <item><description><b>Product understanding and information structuring:</b> Identifies product category, appearance, material, color, structure, and key components, and combines merchant-provided titles, attributes, and selling points to generate usable video expression information.</description></item>
        /// <item><description><b>Template video element replacement:</b> Supports replacing products or persons within the authorized scope, with configurable replacement and protection ranges to minimize changes in non-target areas.</description></item>
        /// <item><description><b>Product subject consistency:</b> Maintains stable product shape, color, texture, pattern, packaging, and logo across different shots, angles, actions, and scenes.</description></item>
        /// <item><description><b>Product fidelity:</b> Multi-round VL quality inspection locks product state (color, texture, structure, and print) throughout the process to prevent product feature drift.</description></item>
        /// <item><description><b>Strength category — Apparel:</b> Faithfully restores apparel details with attention to silhouette, wrinkles, drape, fabric texture, buttons, zippers, prints, and accessories, reducing clipping, deformation, texture loss, and detail artifacts.</description></item>
        /// <item><description><b>Selling point script and storyboard replication:</b> Replicates the selling point structure, video composition, shot sequence, display actions, voiceover content, and closing style of the original video.</description></item>
        /// <item><description><b>Commercial model matching:</b> Supports matching model appearance and display style based on product style, silhouette, target audience, and market requirements.</description></item>
        /// <item><description><b>Quality verification and result feedback:</b> Performs multi-dimensional checks on product subject, person, apparel, text, frame completeness, audio, and overall usability, and outputs result information for manual review.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// EcomVideoRecreationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EcomVideoRecreationResponse
        /// </returns>
        public async Task<EcomVideoRecreationResponse> EcomVideoRecreationWithOptionsAsync(EcomVideoRecreationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EcomVideoRecreationShrinkRequest request = new EcomVideoRecreationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Output))
            {
                request.OutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Output, "Output", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputShrink))
            {
                query["Output"] = request.OutputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EcomVideoRecreation",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EcomVideoRecreationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>E-commerce Video Remix is an AI video service designed for product content production. It covers video understanding, element replacement, quality verification, and result delivery. The service focuses on product and person consistency, detail restoration, conversion-oriented expression, and large-scale production. It supports targeted replacement of products or persons based on hit video templates while preserving the original actions, shot rhythm, and marketing structure to rapidly generate multi-version content and reduce shooting, editing, and adaptation costs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Product Introduction</b></h2>
        /// <para>E-commerce Video Remix is an AI video service designed for product content production. It covers video understanding, element replacement, quality verification, and result delivery. The service focuses on product and person consistency, detail restoration, conversion-oriented expression, and large-scale production. It supports targeted replacement of products or persons based on hit video templates while preserving the original actions, shot rhythm, and marketing structure to rapidly generate multi-version content and reduce shooting, editing, and adaptation costs.</para>
        /// <h2><b>Scenarios</b></h2>
        /// <list type="bullet">
        /// <item><description><b>Video asset remix:</b> Use an existing e-commerce video as a template and replace only the specified product or person while preserving the original shots, rhythm, and marketing expression. This is suitable for multi-SKU, multi-model, multi-region, and multi-version asset production.</description></item>
        /// <item><description><b>New product launch with rapid asset generation:</b> For products launched in batches, reduce the need for live shooting, studio time, post-production editing, and repetitive production. Quickly generate video assets for new products and help merchants shorten the cycle from discovering a hit video to scripting and publishing new content.</description></item>
        /// <item><description><b>Product presentation and selling point expression:</b> Suitable for apparel, beauty and personal care, food and beverages, home and daily essentials, 3C electronics, and small appliances. Based on the selling point structure, display actions, and shot rhythm of the original video, generate presentation videos optimized for new product conversion.</description></item>
        /// <item><description><b>Multi-selling-point and multi-version testing:</b> Rapidly generate multiple versions based on different product selling points, target audiences, scripts, shots, and visual styles to support content testing and ad creative iteration.</description></item>
        /// </list>
        /// <h2><b>Capabilities</b></h2>
        /// <h3><b>Core capabilities</b></h3>
        /// <para>Two replacement modes are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>Product replacement (product_replacement):</b> Preserves the original video host identity, actions, scene, and selling structure while replacing the original product with the target product.</description></item>
        /// <item><description><b>Person replacement (person_replacement):</b> Preserves the original video product, actions, scene, and selling structure while replacing the on-screen person with the target person from a reference image or description.</description></item>
        /// <item><description><b>Fully automated end-to-end generation with zero prompt requirements:</b> Simply provide a reference video and a target product image or person image. The system automatically completes the entire pipeline including video understanding, script planning, storyboard design, first-frame generation, and video synthesis.</description></item>
        /// <item><description><b>Product understanding and information structuring:</b> Identifies product category, appearance, material, color, structure, and key components, and combines merchant-provided titles, attributes, and selling points to generate usable video expression information.</description></item>
        /// <item><description><b>Template video element replacement:</b> Supports replacing products or persons within the authorized scope, with configurable replacement and protection ranges to minimize changes in non-target areas.</description></item>
        /// <item><description><b>Product subject consistency:</b> Maintains stable product shape, color, texture, pattern, packaging, and logo across different shots, angles, actions, and scenes.</description></item>
        /// <item><description><b>Product fidelity:</b> Multi-round VL quality inspection locks product state (color, texture, structure, and print) throughout the process to prevent product feature drift.</description></item>
        /// <item><description><b>Strength category — Apparel:</b> Faithfully restores apparel details with attention to silhouette, wrinkles, drape, fabric texture, buttons, zippers, prints, and accessories, reducing clipping, deformation, texture loss, and detail artifacts.</description></item>
        /// <item><description><b>Selling point script and storyboard replication:</b> Replicates the selling point structure, video composition, shot sequence, display actions, voiceover content, and closing style of the original video.</description></item>
        /// <item><description><b>Commercial model matching:</b> Supports matching model appearance and display style based on product style, silhouette, target audience, and market requirements.</description></item>
        /// <item><description><b>Quality verification and result feedback:</b> Performs multi-dimensional checks on product subject, person, apparel, text, frame completeness, audio, and overall usability, and outputs result information for manual review.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EcomVideoRecreationRequest
        /// </param>
        /// 
        /// <returns>
        /// EcomVideoRecreationResponse
        /// </returns>
        public EcomVideoRecreationResponse EcomVideoRecreation(EcomVideoRecreationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EcomVideoRecreationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>E-commerce Video Remix is an AI video service designed for product content production. It covers video understanding, element replacement, quality verification, and result delivery. The service focuses on product and person consistency, detail restoration, conversion-oriented expression, and large-scale production. It supports targeted replacement of products or persons based on hit video templates while preserving the original actions, shot rhythm, and marketing structure to rapidly generate multi-version content and reduce shooting, editing, and adaptation costs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Product Introduction</b></h2>
        /// <para>E-commerce Video Remix is an AI video service designed for product content production. It covers video understanding, element replacement, quality verification, and result delivery. The service focuses on product and person consistency, detail restoration, conversion-oriented expression, and large-scale production. It supports targeted replacement of products or persons based on hit video templates while preserving the original actions, shot rhythm, and marketing structure to rapidly generate multi-version content and reduce shooting, editing, and adaptation costs.</para>
        /// <h2><b>Scenarios</b></h2>
        /// <list type="bullet">
        /// <item><description><b>Video asset remix:</b> Use an existing e-commerce video as a template and replace only the specified product or person while preserving the original shots, rhythm, and marketing expression. This is suitable for multi-SKU, multi-model, multi-region, and multi-version asset production.</description></item>
        /// <item><description><b>New product launch with rapid asset generation:</b> For products launched in batches, reduce the need for live shooting, studio time, post-production editing, and repetitive production. Quickly generate video assets for new products and help merchants shorten the cycle from discovering a hit video to scripting and publishing new content.</description></item>
        /// <item><description><b>Product presentation and selling point expression:</b> Suitable for apparel, beauty and personal care, food and beverages, home and daily essentials, 3C electronics, and small appliances. Based on the selling point structure, display actions, and shot rhythm of the original video, generate presentation videos optimized for new product conversion.</description></item>
        /// <item><description><b>Multi-selling-point and multi-version testing:</b> Rapidly generate multiple versions based on different product selling points, target audiences, scripts, shots, and visual styles to support content testing and ad creative iteration.</description></item>
        /// </list>
        /// <h2><b>Capabilities</b></h2>
        /// <h3><b>Core capabilities</b></h3>
        /// <para>Two replacement modes are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>Product replacement (product_replacement):</b> Preserves the original video host identity, actions, scene, and selling structure while replacing the original product with the target product.</description></item>
        /// <item><description><b>Person replacement (person_replacement):</b> Preserves the original video product, actions, scene, and selling structure while replacing the on-screen person with the target person from a reference image or description.</description></item>
        /// <item><description><b>Fully automated end-to-end generation with zero prompt requirements:</b> Simply provide a reference video and a target product image or person image. The system automatically completes the entire pipeline including video understanding, script planning, storyboard design, first-frame generation, and video synthesis.</description></item>
        /// <item><description><b>Product understanding and information structuring:</b> Identifies product category, appearance, material, color, structure, and key components, and combines merchant-provided titles, attributes, and selling points to generate usable video expression information.</description></item>
        /// <item><description><b>Template video element replacement:</b> Supports replacing products or persons within the authorized scope, with configurable replacement and protection ranges to minimize changes in non-target areas.</description></item>
        /// <item><description><b>Product subject consistency:</b> Maintains stable product shape, color, texture, pattern, packaging, and logo across different shots, angles, actions, and scenes.</description></item>
        /// <item><description><b>Product fidelity:</b> Multi-round VL quality inspection locks product state (color, texture, structure, and print) throughout the process to prevent product feature drift.</description></item>
        /// <item><description><b>Strength category — Apparel:</b> Faithfully restores apparel details with attention to silhouette, wrinkles, drape, fabric texture, buttons, zippers, prints, and accessories, reducing clipping, deformation, texture loss, and detail artifacts.</description></item>
        /// <item><description><b>Selling point script and storyboard replication:</b> Replicates the selling point structure, video composition, shot sequence, display actions, voiceover content, and closing style of the original video.</description></item>
        /// <item><description><b>Commercial model matching:</b> Supports matching model appearance and display style based on product style, silhouette, target audience, and market requirements.</description></item>
        /// <item><description><b>Quality verification and result feedback:</b> Performs multi-dimensional checks on product subject, person, apparel, text, frame completeness, audio, and overall usability, and outputs result information for manual review.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EcomVideoRecreationRequest
        /// </param>
        /// 
        /// <returns>
        /// EcomVideoRecreationResponse
        /// </returns>
        public async Task<EcomVideoRecreationResponse> EcomVideoRecreationAsync(EcomVideoRecreationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EcomVideoRecreationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Intelligently crops images to specified dimensions, automatically identifies the main subject area, and precisely crops to various sizes to meet design requirements across different scenarios. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>The image cropping service resizes input images to specified dimensions. It automatically identifies the main subject area and precisely crops to various sizes to meet design requirements across different scenarios. (Synchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Multi-platform content distribution</b>: Automatically generates content in multiple sizes to meet the different image size requirements of various platforms and scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>Content placement</b>: Automatically adjusts sizes for different ad slots across platforms, highlights the main subject, reduces whitespace, and emphasizes product features.</para>
        /// </description></item>
        /// </list>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><para>Automatically identifies the main subject area of an image for precise cropping.</para>
        /// </description></item>
        /// <item><description><para>Supports custom cropping dimensions to adapt to different platforms and devices.</para>
        /// </description></item>
        /// </list>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image</b></th>
        /// <th><b>Cropped to 1000×1000</b></th>
        /// <th><b>Cropped to 3000×2000</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/b356e8a7-cc18-41f7-8da5-dd25f48c6338.png" alt="done-image-5e6abdf1-3c64-48db-9301-a5a9db1f8cb1.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/969e0fb6-435c-47f9-aeb6-1624b5a43f3c.png" alt="a715a30a-b594-40db-9f7a-d620add9081c.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/cd6bbde6-e923-4fd1-b252-e5f299377fb8.png" alt="1e6569f3-a494-4e7c-94c8-439748992deb.png"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/6c4d02ea-c3bc-4865-9655-afc8c5f5c2ef.png" alt="done-image-0ff8edc4-5bd5-48ca-90ac-38e1701a4573.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/ac6b07f3-0dbf-48de-9fcc-f1450792f75f.png" alt="d026cfbc-207c-425b-b8c7-67cc7396c9c9.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/a3486b31-4cc3-4f23-b326-41ab0780a84e.png" alt="b9f62dd8-7379-45be-b130-eb534506e77a.png"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/a42cb77c-6f1c-4474-aeff-939f16d5f8dc.png" alt="done-image-8eade64e-c849-46f8-b2e3-29122e280e8c.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/62a89676-a424-4d2a-a174-72ed4ae107ed.png" alt="5d88645b-91b3-4e46-9ba4-5a16189d3ff8.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/ea22ead8-0eb8-4224-8f1e-319f64173912.png" alt="2afdf6cb-44ae-41f3-8d85-7416d2c8fc3c.png"></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageCroppingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageCroppingResponse
        /// </returns>
        public ImageCroppingResponse ImageCroppingWithOptions(ImageCroppingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetHeight))
            {
                query["TargetHeight"] = request.TargetHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetWidth))
            {
                query["TargetWidth"] = request.TargetWidth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageCropping",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageCroppingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Intelligently crops images to specified dimensions, automatically identifies the main subject area, and precisely crops to various sizes to meet design requirements across different scenarios. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>The image cropping service resizes input images to specified dimensions. It automatically identifies the main subject area and precisely crops to various sizes to meet design requirements across different scenarios. (Synchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Multi-platform content distribution</b>: Automatically generates content in multiple sizes to meet the different image size requirements of various platforms and scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>Content placement</b>: Automatically adjusts sizes for different ad slots across platforms, highlights the main subject, reduces whitespace, and emphasizes product features.</para>
        /// </description></item>
        /// </list>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><para>Automatically identifies the main subject area of an image for precise cropping.</para>
        /// </description></item>
        /// <item><description><para>Supports custom cropping dimensions to adapt to different platforms and devices.</para>
        /// </description></item>
        /// </list>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image</b></th>
        /// <th><b>Cropped to 1000×1000</b></th>
        /// <th><b>Cropped to 3000×2000</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/b356e8a7-cc18-41f7-8da5-dd25f48c6338.png" alt="done-image-5e6abdf1-3c64-48db-9301-a5a9db1f8cb1.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/969e0fb6-435c-47f9-aeb6-1624b5a43f3c.png" alt="a715a30a-b594-40db-9f7a-d620add9081c.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/cd6bbde6-e923-4fd1-b252-e5f299377fb8.png" alt="1e6569f3-a494-4e7c-94c8-439748992deb.png"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/6c4d02ea-c3bc-4865-9655-afc8c5f5c2ef.png" alt="done-image-0ff8edc4-5bd5-48ca-90ac-38e1701a4573.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/ac6b07f3-0dbf-48de-9fcc-f1450792f75f.png" alt="d026cfbc-207c-425b-b8c7-67cc7396c9c9.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/a3486b31-4cc3-4f23-b326-41ab0780a84e.png" alt="b9f62dd8-7379-45be-b130-eb534506e77a.png"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/a42cb77c-6f1c-4474-aeff-939f16d5f8dc.png" alt="done-image-8eade64e-c849-46f8-b2e3-29122e280e8c.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/62a89676-a424-4d2a-a174-72ed4ae107ed.png" alt="5d88645b-91b3-4e46-9ba4-5a16189d3ff8.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/ea22ead8-0eb8-4224-8f1e-319f64173912.png" alt="2afdf6cb-44ae-41f3-8d85-7416d2c8fc3c.png"></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageCroppingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageCroppingResponse
        /// </returns>
        public async Task<ImageCroppingResponse> ImageCroppingWithOptionsAsync(ImageCroppingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetHeight))
            {
                query["TargetHeight"] = request.TargetHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetWidth))
            {
                query["TargetWidth"] = request.TargetWidth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageCropping",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageCroppingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Intelligently crops images to specified dimensions, automatically identifies the main subject area, and precisely crops to various sizes to meet design requirements across different scenarios. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>The image cropping service resizes input images to specified dimensions. It automatically identifies the main subject area and precisely crops to various sizes to meet design requirements across different scenarios. (Synchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Multi-platform content distribution</b>: Automatically generates content in multiple sizes to meet the different image size requirements of various platforms and scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>Content placement</b>: Automatically adjusts sizes for different ad slots across platforms, highlights the main subject, reduces whitespace, and emphasizes product features.</para>
        /// </description></item>
        /// </list>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><para>Automatically identifies the main subject area of an image for precise cropping.</para>
        /// </description></item>
        /// <item><description><para>Supports custom cropping dimensions to adapt to different platforms and devices.</para>
        /// </description></item>
        /// </list>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image</b></th>
        /// <th><b>Cropped to 1000×1000</b></th>
        /// <th><b>Cropped to 3000×2000</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/b356e8a7-cc18-41f7-8da5-dd25f48c6338.png" alt="done-image-5e6abdf1-3c64-48db-9301-a5a9db1f8cb1.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/969e0fb6-435c-47f9-aeb6-1624b5a43f3c.png" alt="a715a30a-b594-40db-9f7a-d620add9081c.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/cd6bbde6-e923-4fd1-b252-e5f299377fb8.png" alt="1e6569f3-a494-4e7c-94c8-439748992deb.png"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/6c4d02ea-c3bc-4865-9655-afc8c5f5c2ef.png" alt="done-image-0ff8edc4-5bd5-48ca-90ac-38e1701a4573.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/ac6b07f3-0dbf-48de-9fcc-f1450792f75f.png" alt="d026cfbc-207c-425b-b8c7-67cc7396c9c9.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/a3486b31-4cc3-4f23-b326-41ab0780a84e.png" alt="b9f62dd8-7379-45be-b130-eb534506e77a.png"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/a42cb77c-6f1c-4474-aeff-939f16d5f8dc.png" alt="done-image-8eade64e-c849-46f8-b2e3-29122e280e8c.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/62a89676-a424-4d2a-a174-72ed4ae107ed.png" alt="5d88645b-91b3-4e46-9ba4-5a16189d3ff8.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/ea22ead8-0eb8-4224-8f1e-319f64173912.png" alt="2afdf6cb-44ae-41f3-8d85-7416d2c8fc3c.png"></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageCroppingRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageCroppingResponse
        /// </returns>
        public ImageCroppingResponse ImageCropping(ImageCroppingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImageCroppingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Intelligently crops images to specified dimensions, automatically identifies the main subject area, and precisely crops to various sizes to meet design requirements across different scenarios. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>The image cropping service resizes input images to specified dimensions. It automatically identifies the main subject area and precisely crops to various sizes to meet design requirements across different scenarios. (Synchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Multi-platform content distribution</b>: Automatically generates content in multiple sizes to meet the different image size requirements of various platforms and scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>Content placement</b>: Automatically adjusts sizes for different ad slots across platforms, highlights the main subject, reduces whitespace, and emphasizes product features.</para>
        /// </description></item>
        /// </list>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><para>Automatically identifies the main subject area of an image for precise cropping.</para>
        /// </description></item>
        /// <item><description><para>Supports custom cropping dimensions to adapt to different platforms and devices.</para>
        /// </description></item>
        /// </list>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image</b></th>
        /// <th><b>Cropped to 1000×1000</b></th>
        /// <th><b>Cropped to 3000×2000</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/b356e8a7-cc18-41f7-8da5-dd25f48c6338.png" alt="done-image-5e6abdf1-3c64-48db-9301-a5a9db1f8cb1.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/969e0fb6-435c-47f9-aeb6-1624b5a43f3c.png" alt="a715a30a-b594-40db-9f7a-d620add9081c.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/cd6bbde6-e923-4fd1-b252-e5f299377fb8.png" alt="1e6569f3-a494-4e7c-94c8-439748992deb.png"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/6c4d02ea-c3bc-4865-9655-afc8c5f5c2ef.png" alt="done-image-0ff8edc4-5bd5-48ca-90ac-38e1701a4573.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/ac6b07f3-0dbf-48de-9fcc-f1450792f75f.png" alt="d026cfbc-207c-425b-b8c7-67cc7396c9c9.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/a3486b31-4cc3-4f23-b326-41ab0780a84e.png" alt="b9f62dd8-7379-45be-b130-eb534506e77a.png"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/a42cb77c-6f1c-4474-aeff-939f16d5f8dc.png" alt="done-image-8eade64e-c849-46f8-b2e3-29122e280e8c.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/62a89676-a424-4d2a-a174-72ed4ae107ed.png" alt="5d88645b-91b3-4e46-9ba4-5a16189d3ff8.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/eYVOL5jBbQ7QJlpz/img/ea22ead8-0eb8-4224-8f1e-319f64173912.png" alt="2afdf6cb-44ae-41f3-8d85-7416d2c8fc3c.png"></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageCroppingRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageCroppingResponse
        /// </returns>
        public async Task<ImageCroppingResponse> ImageCroppingAsync(ImageCroppingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImageCroppingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Automatically identifies the salient subject in an image, separates the subject from the background, and returns the subject image with the background removed. This product also provides multiple background options and custom size selections to optimize product display. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>The intelligent image matting product automatically identifies the salient subject in an image, separates the subject from the background, and returns the subject image with the background removed. This product also provides multiple background options and custom size selections to optimize product display. (Synchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Secondary editing of materials</b>: After separating the image subject from the background, users can further edit the image.</para>
        /// </description></item>
        /// <item><description><para><b>Improved material processing efficiency</b>: Quickly extracts the subject from various material images for easy background replacement, improving the production efficiency of advertising visuals and marketing posters.</para>
        /// </description></item>
        /// </list>
        /// <h2>Functions and features.</h2>
        /// <h4>1. One-click precise subject recognition</h4>
        /// <list type="bullet">
        /// <item><description><para><b>AI automatic recognition</b>: Based on deep learning models, intelligently distinguishes foreground subjects (portraits, products, objects, etc.) from backgrounds without manual tracing.</para>
        /// </description></item>
        /// <item><description><para><b>Multi-scenario adaptation</b>: Supports precise segmentation in complex scenarios (such as hair strands, transparent objects, and fur edges) with accuracy exceeding 95%.</para>
        /// </description></item>
        /// </list>
        /// <h4>2. Intelligent edge optimization</h4>
        /// <list type="bullet">
        /// <item><description><b>Detail-level processing</b>: Performs automatic optimization of edge aliasing and semi-transparent areas (such as smoke and glass), preserving natural transition effects.</description></item>
        /// </list>
        /// <h4>3. Multi-format output and background operations</h4>
        /// <list type="bullet">
        /// <item><description><para><b>Transparent background export</b>: Directly generates PNG images with transparent backgrounds and white backgrounds, suitable for e-commerce, design, and other scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>Custom background color support</b></para>
        /// </description></item>
        /// </list>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image (input)</b></th>
        /// <th><b>Result image (output)</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/62b39e16-5b30-469f-88cd-7f31ba790008.jpeg" alt="主图3.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/bfad041f-a8e0-4d6f-a2bf-999292ea9ebc.jpeg" alt="ae4cd8ce912c4d9fa171dc5217be576d_202605251928_0.5899999737739563.jpeg"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/b201b356-24b8-4f98-babc-c7fe918bdc37.jpeg" alt="主图2.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/8b266603-e80a-42dd-9d3d-6fa9f0948e52.jpeg" alt="52033655bd054737960a87518655d935_202605251926_5.959999978542328.jpeg"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/d3c0d876-42a0-4294-8ce5-2a20df2deab9.jpeg" alt="主图6.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/5677f55e-4fe3-4978-a676-1ce71ad604b0.jpeg" alt="abdecd31cc45450f83b33f9baf4499c6_202605251930_7.9700000286102295.jpeg"></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageMattingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageMattingResponse
        /// </returns>
        public ImageMattingResponse ImageMattingWithOptions(ImageMattingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackGroundType))
            {
                query["BackGroundType"] = request.BackGroundType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgColor))
            {
                query["BgColor"] = request.BgColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetHeight))
            {
                query["TargetHeight"] = request.TargetHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetWidth))
            {
                query["TargetWidth"] = request.TargetWidth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageMatting",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageMattingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Automatically identifies the salient subject in an image, separates the subject from the background, and returns the subject image with the background removed. This product also provides multiple background options and custom size selections to optimize product display. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>The intelligent image matting product automatically identifies the salient subject in an image, separates the subject from the background, and returns the subject image with the background removed. This product also provides multiple background options and custom size selections to optimize product display. (Synchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Secondary editing of materials</b>: After separating the image subject from the background, users can further edit the image.</para>
        /// </description></item>
        /// <item><description><para><b>Improved material processing efficiency</b>: Quickly extracts the subject from various material images for easy background replacement, improving the production efficiency of advertising visuals and marketing posters.</para>
        /// </description></item>
        /// </list>
        /// <h2>Functions and features.</h2>
        /// <h4>1. One-click precise subject recognition</h4>
        /// <list type="bullet">
        /// <item><description><para><b>AI automatic recognition</b>: Based on deep learning models, intelligently distinguishes foreground subjects (portraits, products, objects, etc.) from backgrounds without manual tracing.</para>
        /// </description></item>
        /// <item><description><para><b>Multi-scenario adaptation</b>: Supports precise segmentation in complex scenarios (such as hair strands, transparent objects, and fur edges) with accuracy exceeding 95%.</para>
        /// </description></item>
        /// </list>
        /// <h4>2. Intelligent edge optimization</h4>
        /// <list type="bullet">
        /// <item><description><b>Detail-level processing</b>: Performs automatic optimization of edge aliasing and semi-transparent areas (such as smoke and glass), preserving natural transition effects.</description></item>
        /// </list>
        /// <h4>3. Multi-format output and background operations</h4>
        /// <list type="bullet">
        /// <item><description><para><b>Transparent background export</b>: Directly generates PNG images with transparent backgrounds and white backgrounds, suitable for e-commerce, design, and other scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>Custom background color support</b></para>
        /// </description></item>
        /// </list>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image (input)</b></th>
        /// <th><b>Result image (output)</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/62b39e16-5b30-469f-88cd-7f31ba790008.jpeg" alt="主图3.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/bfad041f-a8e0-4d6f-a2bf-999292ea9ebc.jpeg" alt="ae4cd8ce912c4d9fa171dc5217be576d_202605251928_0.5899999737739563.jpeg"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/b201b356-24b8-4f98-babc-c7fe918bdc37.jpeg" alt="主图2.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/8b266603-e80a-42dd-9d3d-6fa9f0948e52.jpeg" alt="52033655bd054737960a87518655d935_202605251926_5.959999978542328.jpeg"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/d3c0d876-42a0-4294-8ce5-2a20df2deab9.jpeg" alt="主图6.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/5677f55e-4fe3-4978-a676-1ce71ad604b0.jpeg" alt="abdecd31cc45450f83b33f9baf4499c6_202605251930_7.9700000286102295.jpeg"></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageMattingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageMattingResponse
        /// </returns>
        public async Task<ImageMattingResponse> ImageMattingWithOptionsAsync(ImageMattingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackGroundType))
            {
                query["BackGroundType"] = request.BackGroundType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BgColor))
            {
                query["BgColor"] = request.BgColor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetHeight))
            {
                query["TargetHeight"] = request.TargetHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetWidth))
            {
                query["TargetWidth"] = request.TargetWidth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageMatting",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageMattingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Automatically identifies the salient subject in an image, separates the subject from the background, and returns the subject image with the background removed. This product also provides multiple background options and custom size selections to optimize product display. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>The intelligent image matting product automatically identifies the salient subject in an image, separates the subject from the background, and returns the subject image with the background removed. This product also provides multiple background options and custom size selections to optimize product display. (Synchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Secondary editing of materials</b>: After separating the image subject from the background, users can further edit the image.</para>
        /// </description></item>
        /// <item><description><para><b>Improved material processing efficiency</b>: Quickly extracts the subject from various material images for easy background replacement, improving the production efficiency of advertising visuals and marketing posters.</para>
        /// </description></item>
        /// </list>
        /// <h2>Functions and features.</h2>
        /// <h4>1. One-click precise subject recognition</h4>
        /// <list type="bullet">
        /// <item><description><para><b>AI automatic recognition</b>: Based on deep learning models, intelligently distinguishes foreground subjects (portraits, products, objects, etc.) from backgrounds without manual tracing.</para>
        /// </description></item>
        /// <item><description><para><b>Multi-scenario adaptation</b>: Supports precise segmentation in complex scenarios (such as hair strands, transparent objects, and fur edges) with accuracy exceeding 95%.</para>
        /// </description></item>
        /// </list>
        /// <h4>2. Intelligent edge optimization</h4>
        /// <list type="bullet">
        /// <item><description><b>Detail-level processing</b>: Performs automatic optimization of edge aliasing and semi-transparent areas (such as smoke and glass), preserving natural transition effects.</description></item>
        /// </list>
        /// <h4>3. Multi-format output and background operations</h4>
        /// <list type="bullet">
        /// <item><description><para><b>Transparent background export</b>: Directly generates PNG images with transparent backgrounds and white backgrounds, suitable for e-commerce, design, and other scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>Custom background color support</b></para>
        /// </description></item>
        /// </list>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image (input)</b></th>
        /// <th><b>Result image (output)</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/62b39e16-5b30-469f-88cd-7f31ba790008.jpeg" alt="主图3.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/bfad041f-a8e0-4d6f-a2bf-999292ea9ebc.jpeg" alt="ae4cd8ce912c4d9fa171dc5217be576d_202605251928_0.5899999737739563.jpeg"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/b201b356-24b8-4f98-babc-c7fe918bdc37.jpeg" alt="主图2.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/8b266603-e80a-42dd-9d3d-6fa9f0948e52.jpeg" alt="52033655bd054737960a87518655d935_202605251926_5.959999978542328.jpeg"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/d3c0d876-42a0-4294-8ce5-2a20df2deab9.jpeg" alt="主图6.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/5677f55e-4fe3-4978-a676-1ce71ad604b0.jpeg" alt="abdecd31cc45450f83b33f9baf4499c6_202605251930_7.9700000286102295.jpeg"></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageMattingRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageMattingResponse
        /// </returns>
        public ImageMattingResponse ImageMatting(ImageMattingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImageMattingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Automatically identifies the salient subject in an image, separates the subject from the background, and returns the subject image with the background removed. This product also provides multiple background options and custom size selections to optimize product display. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>The intelligent image matting product automatically identifies the salient subject in an image, separates the subject from the background, and returns the subject image with the background removed. This product also provides multiple background options and custom size selections to optimize product display. (Synchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Secondary editing of materials</b>: After separating the image subject from the background, users can further edit the image.</para>
        /// </description></item>
        /// <item><description><para><b>Improved material processing efficiency</b>: Quickly extracts the subject from various material images for easy background replacement, improving the production efficiency of advertising visuals and marketing posters.</para>
        /// </description></item>
        /// </list>
        /// <h2>Functions and features.</h2>
        /// <h4>1. One-click precise subject recognition</h4>
        /// <list type="bullet">
        /// <item><description><para><b>AI automatic recognition</b>: Based on deep learning models, intelligently distinguishes foreground subjects (portraits, products, objects, etc.) from backgrounds without manual tracing.</para>
        /// </description></item>
        /// <item><description><para><b>Multi-scenario adaptation</b>: Supports precise segmentation in complex scenarios (such as hair strands, transparent objects, and fur edges) with accuracy exceeding 95%.</para>
        /// </description></item>
        /// </list>
        /// <h4>2. Intelligent edge optimization</h4>
        /// <list type="bullet">
        /// <item><description><b>Detail-level processing</b>: Performs automatic optimization of edge aliasing and semi-transparent areas (such as smoke and glass), preserving natural transition effects.</description></item>
        /// </list>
        /// <h4>3. Multi-format output and background operations</h4>
        /// <list type="bullet">
        /// <item><description><para><b>Transparent background export</b>: Directly generates PNG images with transparent backgrounds and white backgrounds, suitable for e-commerce, design, and other scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>Custom background color support</b></para>
        /// </description></item>
        /// </list>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image (input)</b></th>
        /// <th><b>Result image (output)</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/62b39e16-5b30-469f-88cd-7f31ba790008.jpeg" alt="主图3.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/bfad041f-a8e0-4d6f-a2bf-999292ea9ebc.jpeg" alt="ae4cd8ce912c4d9fa171dc5217be576d_202605251928_0.5899999737739563.jpeg"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/b201b356-24b8-4f98-babc-c7fe918bdc37.jpeg" alt="主图2.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/8b266603-e80a-42dd-9d3d-6fa9f0948e52.jpeg" alt="52033655bd054737960a87518655d935_202605251926_5.959999978542328.jpeg"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/d3c0d876-42a0-4294-8ce5-2a20df2deab9.jpeg" alt="主图6.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/a2QnV4jwexAy7O4X/img/5677f55e-4fe3-4978-a676-1ce71ad604b0.jpeg" alt="abdecd31cc45450f83b33f9baf4499c6_202605251930_7.9700000286102295.jpeg"></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageMattingRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageMattingResponse
        /// </returns>
        public async Task<ImageMattingResponse> ImageMattingAsync(ImageMattingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImageMattingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Identifies intelligent elements in e-commerce images.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>The Intelligent Element Recognition API is designed specifically for identifying specific elements in e-commerce images. It can deeply analyze image details, helping users quickly identify elements such as text, logos, watermarks, and text-containing color blocks in both the subject and background of images. This greatly improves the efficiency and accuracy of image screening. (Synchronous)</para>
        /// <h2>Scenarios</h2>
        /// <para><b>1. Intelligent image screening and optimization:</b>
        /// Merchants and platforms can use the Intelligent Element Recognition API for image screening to automatically identify images containing specific elements (such as watermarks and logos). After screening, you can call the Intelligent Removal API to optimize these images, improve image quality, and shorten the product release cycle.
        /// <b>2. Automated image processing and efficiency improvement:</b>
        /// With the Intelligent Element Recognition API, merchants and platforms can automate the image processing workflow by automatically identifying and marking image elements that need optimization. This process reduces manual intervention and improves image processing efficiency.</para>
        /// <h2>Features</h2>
        /// <para><b>1. Definitions of image subject, image background, text, logo, watermark, and text-containing color block: For details, refer to the related examples in the removal documentation (reserved text link)</b></para>
        /// <list type="bullet">
        /// <item><description><para>Image subject: The core product area in the image</para>
        /// </description></item>
        /// <item><description><para>Image background: The remaining part of the image other than the product subject</para>
        /// </description></item>
        /// <item><description><para>Text: Horizontal/vertical/diagonal English/Chinese text</para>
        /// </description></item>
        /// <item><description><para>Logo: An emblem or trademark</para>
        /// </description></item>
        /// <item><description><para>Watermark: Monochrome transparent text, emblems, images, URLs, or store names</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: A color block containing text outside the subject area</para>
        /// </description></item>
        /// </list>
        /// <para><b>2. The main features of the Intelligent Element Recognition API include:</b></para>
        /// <list type="bullet">
        /// <item><description><para>Element recognition: Identifies whether text, logos, watermarks, and text-containing color blocks exist in the image subject and background.</para>
        /// </description></item>
        /// <item><description><para>Workflow coordination: Used in combination with the Intelligent Removal API. First, the Intelligent Element Recognition API identifies elements that need to be removed, and then the Intelligent Removal API effectively removes them, ensuring the accuracy and efficiency of image processing.</para>
        /// </description></item>
        /// </list>
        /// <h2>Technical advantages</h2>
        /// <list type="bullet">
        /// <item><description><para>Synchronous batch processing: As a synchronous API, the Intelligent Element Recognition API can process large volumes of images while maintaining fast response times, adapting to business needs of different scales.</para>
        /// </description></item>
        /// <item><description><para>Flexibility: Users can select the element types to identify as needed, including elements in both subject and non-subject areas such as watermarks, logos, and text, meeting personalized recognition requirements.</para>
        /// </description></item>
        /// </list>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image</b></th>
        /// <th><b>Recognition result</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/vBPlN5j4yM2KVOdG/img/bbd3dbca-9f91-4b57-a382-2701e90c0d46.png" alt="done-image-30091469-e1be-4d31-85de-18983a358a61.png"></td>
        /// <td>[Subject]</td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><para>Watermark: false</para>
        /// </description></item>
        /// <item><description><para>Logo: false</para>
        /// </description></item>
        /// <item><description><para>Text: false</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: false</para>
        /// </description></item>
        /// </list>
        /// <para>[Non-subject]</para>
        /// <list type="bullet">
        /// <item><description><para>Watermark: false</para>
        /// </description></item>
        /// <item><description><para>Logo: true</para>
        /// </description></item>
        /// <item><description><para>Text: true</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: false |
        /// | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/vBPlN5j4yM2KVOdG/img/6bcbd976-0de1-4b5e-855b-56e20a9c675c.png" alt="image-1781169602620.png"> | [Subject]</para>
        /// </description></item>
        /// <item><description><para>Watermark: false</para>
        /// </description></item>
        /// <item><description><para>Logo: false</para>
        /// </description></item>
        /// <item><description><para>Text: false</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: false</para>
        /// </description></item>
        /// </list>
        /// <para>[Non-subject]</para>
        /// <list type="bullet">
        /// <item><description><para>Watermark: true</para>
        /// </description></item>
        /// <item><description><para>Logo: false</para>
        /// </description></item>
        /// <item><description><para>Text: true</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: true |</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ImageRecognitionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageRecognitionResponse
        /// </returns>
        public ImageRecognitionResponse ImageRecognitionWithOptions(ImageRecognitionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImageRecognitionShrinkRequest request = new ImageRecognitionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NonObjectDetectElements))
            {
                request.NonObjectDetectElementsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NonObjectDetectElements, "NonObjectDetectElements", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ObjectDetectElements))
            {
                request.ObjectDetectElementsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ObjectDetectElements, "ObjectDetectElements", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonObjectDetectElementsShrink))
            {
                query["NonObjectDetectElements"] = request.NonObjectDetectElementsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectDetectElementsShrink))
            {
                query["ObjectDetectElements"] = request.ObjectDetectElementsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnBorderPixel))
            {
                query["ReturnBorderPixel"] = request.ReturnBorderPixel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnCharacter))
            {
                query["ReturnCharacter"] = request.ReturnCharacter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnCharacterProp))
            {
                query["ReturnCharacterProp"] = request.ReturnCharacterProp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnProductNum))
            {
                query["ReturnProductNum"] = request.ReturnProductNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnProductProp))
            {
                query["ReturnProductProp"] = request.ReturnProductProp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageRecognition",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageRecognitionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Identifies intelligent elements in e-commerce images.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>The Intelligent Element Recognition API is designed specifically for identifying specific elements in e-commerce images. It can deeply analyze image details, helping users quickly identify elements such as text, logos, watermarks, and text-containing color blocks in both the subject and background of images. This greatly improves the efficiency and accuracy of image screening. (Synchronous)</para>
        /// <h2>Scenarios</h2>
        /// <para><b>1. Intelligent image screening and optimization:</b>
        /// Merchants and platforms can use the Intelligent Element Recognition API for image screening to automatically identify images containing specific elements (such as watermarks and logos). After screening, you can call the Intelligent Removal API to optimize these images, improve image quality, and shorten the product release cycle.
        /// <b>2. Automated image processing and efficiency improvement:</b>
        /// With the Intelligent Element Recognition API, merchants and platforms can automate the image processing workflow by automatically identifying and marking image elements that need optimization. This process reduces manual intervention and improves image processing efficiency.</para>
        /// <h2>Features</h2>
        /// <para><b>1. Definitions of image subject, image background, text, logo, watermark, and text-containing color block: For details, refer to the related examples in the removal documentation (reserved text link)</b></para>
        /// <list type="bullet">
        /// <item><description><para>Image subject: The core product area in the image</para>
        /// </description></item>
        /// <item><description><para>Image background: The remaining part of the image other than the product subject</para>
        /// </description></item>
        /// <item><description><para>Text: Horizontal/vertical/diagonal English/Chinese text</para>
        /// </description></item>
        /// <item><description><para>Logo: An emblem or trademark</para>
        /// </description></item>
        /// <item><description><para>Watermark: Monochrome transparent text, emblems, images, URLs, or store names</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: A color block containing text outside the subject area</para>
        /// </description></item>
        /// </list>
        /// <para><b>2. The main features of the Intelligent Element Recognition API include:</b></para>
        /// <list type="bullet">
        /// <item><description><para>Element recognition: Identifies whether text, logos, watermarks, and text-containing color blocks exist in the image subject and background.</para>
        /// </description></item>
        /// <item><description><para>Workflow coordination: Used in combination with the Intelligent Removal API. First, the Intelligent Element Recognition API identifies elements that need to be removed, and then the Intelligent Removal API effectively removes them, ensuring the accuracy and efficiency of image processing.</para>
        /// </description></item>
        /// </list>
        /// <h2>Technical advantages</h2>
        /// <list type="bullet">
        /// <item><description><para>Synchronous batch processing: As a synchronous API, the Intelligent Element Recognition API can process large volumes of images while maintaining fast response times, adapting to business needs of different scales.</para>
        /// </description></item>
        /// <item><description><para>Flexibility: Users can select the element types to identify as needed, including elements in both subject and non-subject areas such as watermarks, logos, and text, meeting personalized recognition requirements.</para>
        /// </description></item>
        /// </list>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image</b></th>
        /// <th><b>Recognition result</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/vBPlN5j4yM2KVOdG/img/bbd3dbca-9f91-4b57-a382-2701e90c0d46.png" alt="done-image-30091469-e1be-4d31-85de-18983a358a61.png"></td>
        /// <td>[Subject]</td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><para>Watermark: false</para>
        /// </description></item>
        /// <item><description><para>Logo: false</para>
        /// </description></item>
        /// <item><description><para>Text: false</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: false</para>
        /// </description></item>
        /// </list>
        /// <para>[Non-subject]</para>
        /// <list type="bullet">
        /// <item><description><para>Watermark: false</para>
        /// </description></item>
        /// <item><description><para>Logo: true</para>
        /// </description></item>
        /// <item><description><para>Text: true</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: false |
        /// | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/vBPlN5j4yM2KVOdG/img/6bcbd976-0de1-4b5e-855b-56e20a9c675c.png" alt="image-1781169602620.png"> | [Subject]</para>
        /// </description></item>
        /// <item><description><para>Watermark: false</para>
        /// </description></item>
        /// <item><description><para>Logo: false</para>
        /// </description></item>
        /// <item><description><para>Text: false</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: false</para>
        /// </description></item>
        /// </list>
        /// <para>[Non-subject]</para>
        /// <list type="bullet">
        /// <item><description><para>Watermark: true</para>
        /// </description></item>
        /// <item><description><para>Logo: false</para>
        /// </description></item>
        /// <item><description><para>Text: true</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: true |</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ImageRecognitionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageRecognitionResponse
        /// </returns>
        public async Task<ImageRecognitionResponse> ImageRecognitionWithOptionsAsync(ImageRecognitionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImageRecognitionShrinkRequest request = new ImageRecognitionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NonObjectDetectElements))
            {
                request.NonObjectDetectElementsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NonObjectDetectElements, "NonObjectDetectElements", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ObjectDetectElements))
            {
                request.ObjectDetectElementsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ObjectDetectElements, "ObjectDetectElements", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonObjectDetectElementsShrink))
            {
                query["NonObjectDetectElements"] = request.NonObjectDetectElementsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectDetectElementsShrink))
            {
                query["ObjectDetectElements"] = request.ObjectDetectElementsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnBorderPixel))
            {
                query["ReturnBorderPixel"] = request.ReturnBorderPixel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnCharacter))
            {
                query["ReturnCharacter"] = request.ReturnCharacter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnCharacterProp))
            {
                query["ReturnCharacterProp"] = request.ReturnCharacterProp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnProductNum))
            {
                query["ReturnProductNum"] = request.ReturnProductNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnProductProp))
            {
                query["ReturnProductProp"] = request.ReturnProductProp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageRecognition",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageRecognitionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Identifies intelligent elements in e-commerce images.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>The Intelligent Element Recognition API is designed specifically for identifying specific elements in e-commerce images. It can deeply analyze image details, helping users quickly identify elements such as text, logos, watermarks, and text-containing color blocks in both the subject and background of images. This greatly improves the efficiency and accuracy of image screening. (Synchronous)</para>
        /// <h2>Scenarios</h2>
        /// <para><b>1. Intelligent image screening and optimization:</b>
        /// Merchants and platforms can use the Intelligent Element Recognition API for image screening to automatically identify images containing specific elements (such as watermarks and logos). After screening, you can call the Intelligent Removal API to optimize these images, improve image quality, and shorten the product release cycle.
        /// <b>2. Automated image processing and efficiency improvement:</b>
        /// With the Intelligent Element Recognition API, merchants and platforms can automate the image processing workflow by automatically identifying and marking image elements that need optimization. This process reduces manual intervention and improves image processing efficiency.</para>
        /// <h2>Features</h2>
        /// <para><b>1. Definitions of image subject, image background, text, logo, watermark, and text-containing color block: For details, refer to the related examples in the removal documentation (reserved text link)</b></para>
        /// <list type="bullet">
        /// <item><description><para>Image subject: The core product area in the image</para>
        /// </description></item>
        /// <item><description><para>Image background: The remaining part of the image other than the product subject</para>
        /// </description></item>
        /// <item><description><para>Text: Horizontal/vertical/diagonal English/Chinese text</para>
        /// </description></item>
        /// <item><description><para>Logo: An emblem or trademark</para>
        /// </description></item>
        /// <item><description><para>Watermark: Monochrome transparent text, emblems, images, URLs, or store names</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: A color block containing text outside the subject area</para>
        /// </description></item>
        /// </list>
        /// <para><b>2. The main features of the Intelligent Element Recognition API include:</b></para>
        /// <list type="bullet">
        /// <item><description><para>Element recognition: Identifies whether text, logos, watermarks, and text-containing color blocks exist in the image subject and background.</para>
        /// </description></item>
        /// <item><description><para>Workflow coordination: Used in combination with the Intelligent Removal API. First, the Intelligent Element Recognition API identifies elements that need to be removed, and then the Intelligent Removal API effectively removes them, ensuring the accuracy and efficiency of image processing.</para>
        /// </description></item>
        /// </list>
        /// <h2>Technical advantages</h2>
        /// <list type="bullet">
        /// <item><description><para>Synchronous batch processing: As a synchronous API, the Intelligent Element Recognition API can process large volumes of images while maintaining fast response times, adapting to business needs of different scales.</para>
        /// </description></item>
        /// <item><description><para>Flexibility: Users can select the element types to identify as needed, including elements in both subject and non-subject areas such as watermarks, logos, and text, meeting personalized recognition requirements.</para>
        /// </description></item>
        /// </list>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image</b></th>
        /// <th><b>Recognition result</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/vBPlN5j4yM2KVOdG/img/bbd3dbca-9f91-4b57-a382-2701e90c0d46.png" alt="done-image-30091469-e1be-4d31-85de-18983a358a61.png"></td>
        /// <td>[Subject]</td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><para>Watermark: false</para>
        /// </description></item>
        /// <item><description><para>Logo: false</para>
        /// </description></item>
        /// <item><description><para>Text: false</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: false</para>
        /// </description></item>
        /// </list>
        /// <para>[Non-subject]</para>
        /// <list type="bullet">
        /// <item><description><para>Watermark: false</para>
        /// </description></item>
        /// <item><description><para>Logo: true</para>
        /// </description></item>
        /// <item><description><para>Text: true</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: false |
        /// | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/vBPlN5j4yM2KVOdG/img/6bcbd976-0de1-4b5e-855b-56e20a9c675c.png" alt="image-1781169602620.png"> | [Subject]</para>
        /// </description></item>
        /// <item><description><para>Watermark: false</para>
        /// </description></item>
        /// <item><description><para>Logo: false</para>
        /// </description></item>
        /// <item><description><para>Text: false</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: false</para>
        /// </description></item>
        /// </list>
        /// <para>[Non-subject]</para>
        /// <list type="bullet">
        /// <item><description><para>Watermark: true</para>
        /// </description></item>
        /// <item><description><para>Logo: false</para>
        /// </description></item>
        /// <item><description><para>Text: true</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: true |</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageRecognitionRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageRecognitionResponse
        /// </returns>
        public ImageRecognitionResponse ImageRecognition(ImageRecognitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImageRecognitionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Identifies intelligent elements in e-commerce images.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>The Intelligent Element Recognition API is designed specifically for identifying specific elements in e-commerce images. It can deeply analyze image details, helping users quickly identify elements such as text, logos, watermarks, and text-containing color blocks in both the subject and background of images. This greatly improves the efficiency and accuracy of image screening. (Synchronous)</para>
        /// <h2>Scenarios</h2>
        /// <para><b>1. Intelligent image screening and optimization:</b>
        /// Merchants and platforms can use the Intelligent Element Recognition API for image screening to automatically identify images containing specific elements (such as watermarks and logos). After screening, you can call the Intelligent Removal API to optimize these images, improve image quality, and shorten the product release cycle.
        /// <b>2. Automated image processing and efficiency improvement:</b>
        /// With the Intelligent Element Recognition API, merchants and platforms can automate the image processing workflow by automatically identifying and marking image elements that need optimization. This process reduces manual intervention and improves image processing efficiency.</para>
        /// <h2>Features</h2>
        /// <para><b>1. Definitions of image subject, image background, text, logo, watermark, and text-containing color block: For details, refer to the related examples in the removal documentation (reserved text link)</b></para>
        /// <list type="bullet">
        /// <item><description><para>Image subject: The core product area in the image</para>
        /// </description></item>
        /// <item><description><para>Image background: The remaining part of the image other than the product subject</para>
        /// </description></item>
        /// <item><description><para>Text: Horizontal/vertical/diagonal English/Chinese text</para>
        /// </description></item>
        /// <item><description><para>Logo: An emblem or trademark</para>
        /// </description></item>
        /// <item><description><para>Watermark: Monochrome transparent text, emblems, images, URLs, or store names</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: A color block containing text outside the subject area</para>
        /// </description></item>
        /// </list>
        /// <para><b>2. The main features of the Intelligent Element Recognition API include:</b></para>
        /// <list type="bullet">
        /// <item><description><para>Element recognition: Identifies whether text, logos, watermarks, and text-containing color blocks exist in the image subject and background.</para>
        /// </description></item>
        /// <item><description><para>Workflow coordination: Used in combination with the Intelligent Removal API. First, the Intelligent Element Recognition API identifies elements that need to be removed, and then the Intelligent Removal API effectively removes them, ensuring the accuracy and efficiency of image processing.</para>
        /// </description></item>
        /// </list>
        /// <h2>Technical advantages</h2>
        /// <list type="bullet">
        /// <item><description><para>Synchronous batch processing: As a synchronous API, the Intelligent Element Recognition API can process large volumes of images while maintaining fast response times, adapting to business needs of different scales.</para>
        /// </description></item>
        /// <item><description><para>Flexibility: Users can select the element types to identify as needed, including elements in both subject and non-subject areas such as watermarks, logos, and text, meeting personalized recognition requirements.</para>
        /// </description></item>
        /// </list>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image</b></th>
        /// <th><b>Recognition result</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/vBPlN5j4yM2KVOdG/img/bbd3dbca-9f91-4b57-a382-2701e90c0d46.png" alt="done-image-30091469-e1be-4d31-85de-18983a358a61.png"></td>
        /// <td>[Subject]</td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><para>Watermark: false</para>
        /// </description></item>
        /// <item><description><para>Logo: false</para>
        /// </description></item>
        /// <item><description><para>Text: false</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: false</para>
        /// </description></item>
        /// </list>
        /// <para>[Non-subject]</para>
        /// <list type="bullet">
        /// <item><description><para>Watermark: false</para>
        /// </description></item>
        /// <item><description><para>Logo: true</para>
        /// </description></item>
        /// <item><description><para>Text: true</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: false |
        /// | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/vBPlN5j4yM2KVOdG/img/6bcbd976-0de1-4b5e-855b-56e20a9c675c.png" alt="image-1781169602620.png"> | [Subject]</para>
        /// </description></item>
        /// <item><description><para>Watermark: false</para>
        /// </description></item>
        /// <item><description><para>Logo: false</para>
        /// </description></item>
        /// <item><description><para>Text: false</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: false</para>
        /// </description></item>
        /// </list>
        /// <para>[Non-subject]</para>
        /// <list type="bullet">
        /// <item><description><para>Watermark: true</para>
        /// </description></item>
        /// <item><description><para>Logo: false</para>
        /// </description></item>
        /// <item><description><para>Text: true</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: true |</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageRecognitionRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageRecognitionResponse
        /// </returns>
        public async Task<ImageRecognitionResponse> ImageRecognitionAsync(ImageRecognitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImageRecognitionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Intelligently identifies and removes text, specific names, transparent text blocks, and watermarks from e-commerce images, supports specifying objects to remove as needed, enables efficient and precise batch processing of images, and simplifies image editing workflows (synchronous/asynchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product introduction</h2>
        /// <para>The intelligent image removal product is designed specifically for e-commerce images. It automatically identifies and removes text, specific names, transparent text blocks, and watermarks from e-commerce images. You can specify objects to remove as needed, enabling efficient and precise batch processing of images and simplifying image editing workflows. (Synchronous/Asynchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><b>Efficient e-commerce image processing:</b></description></item>
        /// </list>
        /// <para>Remove irrelevant visual elements to provide clearer, more focused product displays and enhance the shopping experience.</para>
        /// <list type="bullet">
        /// <item><description><b>Multi-platform product information synchronization:</b></description></item>
        /// </list>
        /// <para>When merchants list products across different e-commerce platforms, they can quickly remove specific text and watermarks to comply with image specifications of different platforms.</para>
        /// <h2>Features</h2>
        /// <ol>
        /// <item><description><para>First, clarify the definitions of image subject and image background. When specifying objects to remove, you can choose whether the removal scope is the image subject or the image background area. Both API and editor access methods are supported to meet different types of requirements.</para>
        /// <ol>
        /// <item><description><para>Image subject: the core product area in the image.</para>
        /// </description></item>
        /// <item><description><para>Image background: the remaining part of the image other than the product subject.</para>
        /// </description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><para>Second, the following four types of objects can be removed: text, specific names, transparent text blocks, and watermarks. Refer to the following examples to clarify your requirements and perform targeted operations:</para>
        /// </description></item>
        /// </ol>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image</b></th>
        /// <th><b>Image after removal</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/AJdl65AyryVZyOke/img/4bd2c812-ed3c-45da-8a86-ebd29102f4b1.jpeg" alt="Main image 1 - Leopard print large capacity millennium crossbody canvas bag.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/5VLqXLbGJZd3VqX1/img/eff0eb1b-36df-431d-a010-3bb3b7348ff9.png" alt="image.png"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/5VLqXLbGJZd3VqX1/img/c44ac17b-3fa4-4a6f-b411-90f1062b183b.jpeg" alt="Main image 1 - Short round-tip French false nails with handle.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/5VLqXLbGJZd3VqX1/img/af779684-4aa5-49b0-8668-34ab8bd4bcc1.png" alt="image.png"></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageRemovalProRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageRemovalProResponse
        /// </returns>
        public ImageRemovalProResponse ImageRemovalProWithOptions(ImageRemovalProRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Async))
            {
                query["Async"] = request.Async;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageRemovalPro",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageRemovalProResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Intelligently identifies and removes text, specific names, transparent text blocks, and watermarks from e-commerce images, supports specifying objects to remove as needed, enables efficient and precise batch processing of images, and simplifies image editing workflows (synchronous/asynchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product introduction</h2>
        /// <para>The intelligent image removal product is designed specifically for e-commerce images. It automatically identifies and removes text, specific names, transparent text blocks, and watermarks from e-commerce images. You can specify objects to remove as needed, enabling efficient and precise batch processing of images and simplifying image editing workflows. (Synchronous/Asynchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><b>Efficient e-commerce image processing:</b></description></item>
        /// </list>
        /// <para>Remove irrelevant visual elements to provide clearer, more focused product displays and enhance the shopping experience.</para>
        /// <list type="bullet">
        /// <item><description><b>Multi-platform product information synchronization:</b></description></item>
        /// </list>
        /// <para>When merchants list products across different e-commerce platforms, they can quickly remove specific text and watermarks to comply with image specifications of different platforms.</para>
        /// <h2>Features</h2>
        /// <ol>
        /// <item><description><para>First, clarify the definitions of image subject and image background. When specifying objects to remove, you can choose whether the removal scope is the image subject or the image background area. Both API and editor access methods are supported to meet different types of requirements.</para>
        /// <ol>
        /// <item><description><para>Image subject: the core product area in the image.</para>
        /// </description></item>
        /// <item><description><para>Image background: the remaining part of the image other than the product subject.</para>
        /// </description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><para>Second, the following four types of objects can be removed: text, specific names, transparent text blocks, and watermarks. Refer to the following examples to clarify your requirements and perform targeted operations:</para>
        /// </description></item>
        /// </ol>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image</b></th>
        /// <th><b>Image after removal</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/AJdl65AyryVZyOke/img/4bd2c812-ed3c-45da-8a86-ebd29102f4b1.jpeg" alt="Main image 1 - Leopard print large capacity millennium crossbody canvas bag.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/5VLqXLbGJZd3VqX1/img/eff0eb1b-36df-431d-a010-3bb3b7348ff9.png" alt="image.png"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/5VLqXLbGJZd3VqX1/img/c44ac17b-3fa4-4a6f-b411-90f1062b183b.jpeg" alt="Main image 1 - Short round-tip French false nails with handle.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/5VLqXLbGJZd3VqX1/img/af779684-4aa5-49b0-8668-34ab8bd4bcc1.png" alt="image.png"></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageRemovalProRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageRemovalProResponse
        /// </returns>
        public async Task<ImageRemovalProResponse> ImageRemovalProWithOptionsAsync(ImageRemovalProRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Async))
            {
                query["Async"] = request.Async;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageRemovalPro",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageRemovalProResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Intelligently identifies and removes text, specific names, transparent text blocks, and watermarks from e-commerce images, supports specifying objects to remove as needed, enables efficient and precise batch processing of images, and simplifies image editing workflows (synchronous/asynchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product introduction</h2>
        /// <para>The intelligent image removal product is designed specifically for e-commerce images. It automatically identifies and removes text, specific names, transparent text blocks, and watermarks from e-commerce images. You can specify objects to remove as needed, enabling efficient and precise batch processing of images and simplifying image editing workflows. (Synchronous/Asynchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><b>Efficient e-commerce image processing:</b></description></item>
        /// </list>
        /// <para>Remove irrelevant visual elements to provide clearer, more focused product displays and enhance the shopping experience.</para>
        /// <list type="bullet">
        /// <item><description><b>Multi-platform product information synchronization:</b></description></item>
        /// </list>
        /// <para>When merchants list products across different e-commerce platforms, they can quickly remove specific text and watermarks to comply with image specifications of different platforms.</para>
        /// <h2>Features</h2>
        /// <ol>
        /// <item><description><para>First, clarify the definitions of image subject and image background. When specifying objects to remove, you can choose whether the removal scope is the image subject or the image background area. Both API and editor access methods are supported to meet different types of requirements.</para>
        /// <ol>
        /// <item><description><para>Image subject: the core product area in the image.</para>
        /// </description></item>
        /// <item><description><para>Image background: the remaining part of the image other than the product subject.</para>
        /// </description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><para>Second, the following four types of objects can be removed: text, specific names, transparent text blocks, and watermarks. Refer to the following examples to clarify your requirements and perform targeted operations:</para>
        /// </description></item>
        /// </ol>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image</b></th>
        /// <th><b>Image after removal</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/AJdl65AyryVZyOke/img/4bd2c812-ed3c-45da-8a86-ebd29102f4b1.jpeg" alt="Main image 1 - Leopard print large capacity millennium crossbody canvas bag.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/5VLqXLbGJZd3VqX1/img/eff0eb1b-36df-431d-a010-3bb3b7348ff9.png" alt="image.png"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/5VLqXLbGJZd3VqX1/img/c44ac17b-3fa4-4a6f-b411-90f1062b183b.jpeg" alt="Main image 1 - Short round-tip French false nails with handle.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/5VLqXLbGJZd3VqX1/img/af779684-4aa5-49b0-8668-34ab8bd4bcc1.png" alt="image.png"></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageRemovalProRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageRemovalProResponse
        /// </returns>
        public ImageRemovalProResponse ImageRemovalPro(ImageRemovalProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImageRemovalProWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Intelligently identifies and removes text, specific names, transparent text blocks, and watermarks from e-commerce images, supports specifying objects to remove as needed, enables efficient and precise batch processing of images, and simplifies image editing workflows (synchronous/asynchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product introduction</h2>
        /// <para>The intelligent image removal product is designed specifically for e-commerce images. It automatically identifies and removes text, specific names, transparent text blocks, and watermarks from e-commerce images. You can specify objects to remove as needed, enabling efficient and precise batch processing of images and simplifying image editing workflows. (Synchronous/Asynchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><b>Efficient e-commerce image processing:</b></description></item>
        /// </list>
        /// <para>Remove irrelevant visual elements to provide clearer, more focused product displays and enhance the shopping experience.</para>
        /// <list type="bullet">
        /// <item><description><b>Multi-platform product information synchronization:</b></description></item>
        /// </list>
        /// <para>When merchants list products across different e-commerce platforms, they can quickly remove specific text and watermarks to comply with image specifications of different platforms.</para>
        /// <h2>Features</h2>
        /// <ol>
        /// <item><description><para>First, clarify the definitions of image subject and image background. When specifying objects to remove, you can choose whether the removal scope is the image subject or the image background area. Both API and editor access methods are supported to meet different types of requirements.</para>
        /// <ol>
        /// <item><description><para>Image subject: the core product area in the image.</para>
        /// </description></item>
        /// <item><description><para>Image background: the remaining part of the image other than the product subject.</para>
        /// </description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><para>Second, the following four types of objects can be removed: text, specific names, transparent text blocks, and watermarks. Refer to the following examples to clarify your requirements and perform targeted operations:</para>
        /// </description></item>
        /// </ol>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image</b></th>
        /// <th><b>Image after removal</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/AJdl65AyryVZyOke/img/4bd2c812-ed3c-45da-8a86-ebd29102f4b1.jpeg" alt="Main image 1 - Leopard print large capacity millennium crossbody canvas bag.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/5VLqXLbGJZd3VqX1/img/eff0eb1b-36df-431d-a010-3bb3b7348ff9.png" alt="image.png"></td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/5VLqXLbGJZd3VqX1/img/c44ac17b-3fa4-4a6f-b411-90f1062b183b.jpeg" alt="Main image 1 - Short round-tip French false nails with handle.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/5VLqXLbGJZd3VqX1/img/af779684-4aa5-49b0-8668-34ab8bd4bcc1.png" alt="image.png"></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageRemovalProRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageRemovalProResponse
        /// </returns>
        public async Task<ImageRemovalProResponse> ImageRemovalProAsync(ImageRemovalProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImageRemovalProWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Intelligently removes unwanted elements from e-commerce images, automatically detecting and erasing text, specific names, transparent text blocks, and visual clutter. Supports specifying objects to remove on demand, enabling efficient and precise batch processing of large volumes of images to simplify image editing workflows. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Product Introduction</h1>
        /// <para>The intelligent image removal product is designed specifically for e-commerce images. It automatically detects and removes text, specific names, transparent text blocks, and visual clutter from e-commerce images. You can specify objects to remove on demand, enabling efficient and precise batch processing of large volumes of images to simplify image editing workflows. (Synchronous)</para>
        /// <h1>Common scenarios</h1>
        /// <list type="bullet">
        /// <item><description><b>Efficient e-commerce image processing:</b></description></item>
        /// </list>
        /// <para>Remove irrelevant visual elements to provide clearer, more focused product displays and enhance the shopping experience.</para>
        /// <list type="bullet">
        /// <item><description><b>Multi-platform product information synchronization:</b></description></item>
        /// </list>
        /// <para>When listing products across different e-commerce platforms, quickly remove specific text and visual clutter to comply with image specifications of different platforms.</para>
        /// <list type="bullet">
        /// <item><description><b>Marketing material preparation:</b></description></item>
        /// </list>
        /// <para>Easily remove existing promotional information and quickly update images with the latest campaign details.</para>
        /// <remarks>
        /// <para>Note: Merchants or platforms can batch-remove impurities from images to optimize image quality. We recommend using this in combination with the &quot;Intelligent Recognition API&quot; (coming soon). First, filter out images containing text, specific names, transparent text blocks, and visual clutter, then use the &quot;Intelligent Removal API&quot; for batch removal. The Intelligent Recognition API focuses on &quot;recognition,&quot; while the Intelligent Removal API focuses on &quot;removal.&quot; By calling them sequentially, you can maximize removal effectiveness and reduce false removals and false identifications.</para>
        /// </remarks>
        /// <h1>Features</h1>
        /// <ol>
        /// <item><description><para>First, understand the definitions of image subject and image background. When specifying removal targets, you can choose whether the removal scope is the image subject or the image background area. Both API and editor access methods are supported to meet different requirements.</para>
        /// <ol>
        /// <item><description><para>Image subject: The core product area in the image.</para>
        /// </description></item>
        /// <item><description><para>Image background: The remaining portion of the image excluding the product subject.</para>
        /// </description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><para>The following three removal target options are supported:</para>
        /// <ol>
        /// <item><description><para>Select by type only. Supported types include text, specific names, transparent text blocks, and visual clutter. Refer to the following examples to clarify your requirements and perform targeted operations.</para>
        /// </description></item>
        /// <item><description><para>(Upgrade) Specify images to remove. You can specify multiple images at a time.</para>
        /// </description></item>
        /// <item><description><para>(Upgrade) Specify text to remove. You can specify multiple text strings at a time.</para>
        /// </description></item>
        /// </ol>
        /// </description></item>
        /// </ol>
        /// <para>Processing workflow: User submits original image URL → OCR+VLM model detects text or image positions → Determines coordinates of areas to repair → AI repairs and generates a clean image → Returns the result image URL.</para>
        /// <h1>4. Effect comparison</h1>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Removable objects in images</b></th>
        /// <th><b>Original image</b></th>
        /// <th><b>Image after removal</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Text</td>
        /// <td>*   Involving the image subject area</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <pre><c>![done-image-4a2a96c2-9ac6-4b35-b76b-a6eac303740f (1).png](https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/d72a7982-e761-4b45-af1e-f8f90b3f1fc3.png)
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/47428227-7523-432e-89ce-eba263e5ebda.png" alt="image.png"> | *   Involving the image subject area</para>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/d69e38e4-5657-471d-aff6-1e6a4c269455.png" alt="359ddfcf-a2b1-4e59-ae54-5e76705d0adf.png"></para>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/365024b4-4863-46d4-9013-bdd9408ea6b9.png" alt="c35611f8-dab4-4df2-8942-36d7375ed55f.png"> |
        /// | Specific names | *   Involving the image subject area</para>
        /// <pre><c>![done-image-aca80515-aca6-4f4e-9429-47c5dd6b811f.png](https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/ac35f8bc-d527-49de-8fba-cdeb71e3b058.png)
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/2db445c8-6bdd-424e-b6a7-2ddb46e6786d.png" alt="done-image-29a89f03-964a-455e-968c-7c8d5282ebbb.png"> | *   Involving the image subject area</para>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/36ace8aa-3b3b-4b1c-81e6-b691104262f0.png" alt="fd2db0ab-1b89-4085-b91d-99f40a1aea77.png"></para>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/a7653a0c-d14e-4f97-9c2f-83327b43203f.png" alt="8726b148-ab74-4409-a6c1-4c50fcac3887.png"> |
        /// | Transparent text blocks | *   Involving the image subject area</para>
        /// <pre><c>![image.png](https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/0f6068f0-168a-47bd-9fcd-c38b9e520506.png)
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/c9ac2a4c-0aa3-40ee-8855-62a262364dbe.png" alt="image.png"> | *   Involving the image subject area</para>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/06ac537f-875a-48e2-8934-a84a79dfd8ff.jpeg" alt="8e84a5d6-da8c-4e3e-a705-71a66d0c78a2.jpeg"></para>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/05759aef-1720-41cd-8800-f7d0801e4d95.jpeg" alt="b05173e7-2ae5-494e-99d2-7111fc966fd5.jpeg"> |
        /// | Visual clutter | *   Involving the image subject area</para>
        /// <pre><c>![2.jpeg](https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/bf1442f8-a9fa-40d3-bcb0-7a8a41b49b5d.jpeg)
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/0d68612e-845d-466f-8a4a-b85facea095b.png" alt="image.png"> | *   Involving the image subject area</para>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/621daadc-454f-41b4-9ac4-752d457034b6.jpeg" alt="b6ef803f-743f-4e61-b901-d1f68167186f.jpeg"></para>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/caa6994b-2f97-484d-a807-671a0dc75947.jpeg" alt="dee0c7cf-8b0d-4d6d-9677-d5f2e6099834.jpeg"> |
        /// | Specified image element removal (supports multiple image links) | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/9297951f-53c1-4476-8c69-5c31df3fce21.png" alt="image.png"> | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/ef3f35aa-609f-454c-bba0-dd1710c83945.png" alt="image.png"> |
        /// | Specified text removal (supports multiple text strings) | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/c784d8be-4b4d-4972-8b99-828c742b8f03.png" alt="image.png"> | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/805423ca-bd0d-4d44-a18e-a7d7bfe88587.png" alt="image.png"> |</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ImageRemoveRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageRemoveResponse
        /// </returns>
        public ImageRemoveResponse ImageRemoveWithOptions(ImageRemoveRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImageRemoveShrinkRequest request = new ImageRemoveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NonObjectRemoveElements))
            {
                request.NonObjectRemoveElementsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NonObjectRemoveElements, "NonObjectRemoveElements", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ObjectRemoveElements))
            {
                request.ObjectRemoveElementsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ObjectRemoveElements, "ObjectRemoveElements", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserImage))
            {
                request.UserImageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserImage, "UserImage", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserText))
            {
                request.UserTextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserText, "UserText", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonObjectRemoveElementsShrink))
            {
                query["NonObjectRemoveElements"] = request.NonObjectRemoveElementsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectRemoveElementsShrink))
            {
                query["ObjectRemoveElements"] = request.ObjectRemoveElementsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Position))
            {
                query["Position"] = request.Position;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserImageShrink))
            {
                query["UserImage"] = request.UserImageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTextShrink))
            {
                query["UserText"] = request.UserTextShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageRemove",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageRemoveResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Intelligently removes unwanted elements from e-commerce images, automatically detecting and erasing text, specific names, transparent text blocks, and visual clutter. Supports specifying objects to remove on demand, enabling efficient and precise batch processing of large volumes of images to simplify image editing workflows. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Product Introduction</h1>
        /// <para>The intelligent image removal product is designed specifically for e-commerce images. It automatically detects and removes text, specific names, transparent text blocks, and visual clutter from e-commerce images. You can specify objects to remove on demand, enabling efficient and precise batch processing of large volumes of images to simplify image editing workflows. (Synchronous)</para>
        /// <h1>Common scenarios</h1>
        /// <list type="bullet">
        /// <item><description><b>Efficient e-commerce image processing:</b></description></item>
        /// </list>
        /// <para>Remove irrelevant visual elements to provide clearer, more focused product displays and enhance the shopping experience.</para>
        /// <list type="bullet">
        /// <item><description><b>Multi-platform product information synchronization:</b></description></item>
        /// </list>
        /// <para>When listing products across different e-commerce platforms, quickly remove specific text and visual clutter to comply with image specifications of different platforms.</para>
        /// <list type="bullet">
        /// <item><description><b>Marketing material preparation:</b></description></item>
        /// </list>
        /// <para>Easily remove existing promotional information and quickly update images with the latest campaign details.</para>
        /// <remarks>
        /// <para>Note: Merchants or platforms can batch-remove impurities from images to optimize image quality. We recommend using this in combination with the &quot;Intelligent Recognition API&quot; (coming soon). First, filter out images containing text, specific names, transparent text blocks, and visual clutter, then use the &quot;Intelligent Removal API&quot; for batch removal. The Intelligent Recognition API focuses on &quot;recognition,&quot; while the Intelligent Removal API focuses on &quot;removal.&quot; By calling them sequentially, you can maximize removal effectiveness and reduce false removals and false identifications.</para>
        /// </remarks>
        /// <h1>Features</h1>
        /// <ol>
        /// <item><description><para>First, understand the definitions of image subject and image background. When specifying removal targets, you can choose whether the removal scope is the image subject or the image background area. Both API and editor access methods are supported to meet different requirements.</para>
        /// <ol>
        /// <item><description><para>Image subject: The core product area in the image.</para>
        /// </description></item>
        /// <item><description><para>Image background: The remaining portion of the image excluding the product subject.</para>
        /// </description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><para>The following three removal target options are supported:</para>
        /// <ol>
        /// <item><description><para>Select by type only. Supported types include text, specific names, transparent text blocks, and visual clutter. Refer to the following examples to clarify your requirements and perform targeted operations.</para>
        /// </description></item>
        /// <item><description><para>(Upgrade) Specify images to remove. You can specify multiple images at a time.</para>
        /// </description></item>
        /// <item><description><para>(Upgrade) Specify text to remove. You can specify multiple text strings at a time.</para>
        /// </description></item>
        /// </ol>
        /// </description></item>
        /// </ol>
        /// <para>Processing workflow: User submits original image URL → OCR+VLM model detects text or image positions → Determines coordinates of areas to repair → AI repairs and generates a clean image → Returns the result image URL.</para>
        /// <h1>4. Effect comparison</h1>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Removable objects in images</b></th>
        /// <th><b>Original image</b></th>
        /// <th><b>Image after removal</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Text</td>
        /// <td>*   Involving the image subject area</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <pre><c>![done-image-4a2a96c2-9ac6-4b35-b76b-a6eac303740f (1).png](https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/d72a7982-e761-4b45-af1e-f8f90b3f1fc3.png)
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/47428227-7523-432e-89ce-eba263e5ebda.png" alt="image.png"> | *   Involving the image subject area</para>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/d69e38e4-5657-471d-aff6-1e6a4c269455.png" alt="359ddfcf-a2b1-4e59-ae54-5e76705d0adf.png"></para>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/365024b4-4863-46d4-9013-bdd9408ea6b9.png" alt="c35611f8-dab4-4df2-8942-36d7375ed55f.png"> |
        /// | Specific names | *   Involving the image subject area</para>
        /// <pre><c>![done-image-aca80515-aca6-4f4e-9429-47c5dd6b811f.png](https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/ac35f8bc-d527-49de-8fba-cdeb71e3b058.png)
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/2db445c8-6bdd-424e-b6a7-2ddb46e6786d.png" alt="done-image-29a89f03-964a-455e-968c-7c8d5282ebbb.png"> | *   Involving the image subject area</para>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/36ace8aa-3b3b-4b1c-81e6-b691104262f0.png" alt="fd2db0ab-1b89-4085-b91d-99f40a1aea77.png"></para>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/a7653a0c-d14e-4f97-9c2f-83327b43203f.png" alt="8726b148-ab74-4409-a6c1-4c50fcac3887.png"> |
        /// | Transparent text blocks | *   Involving the image subject area</para>
        /// <pre><c>![image.png](https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/0f6068f0-168a-47bd-9fcd-c38b9e520506.png)
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/c9ac2a4c-0aa3-40ee-8855-62a262364dbe.png" alt="image.png"> | *   Involving the image subject area</para>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/06ac537f-875a-48e2-8934-a84a79dfd8ff.jpeg" alt="8e84a5d6-da8c-4e3e-a705-71a66d0c78a2.jpeg"></para>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/05759aef-1720-41cd-8800-f7d0801e4d95.jpeg" alt="b05173e7-2ae5-494e-99d2-7111fc966fd5.jpeg"> |
        /// | Visual clutter | *   Involving the image subject area</para>
        /// <pre><c>![2.jpeg](https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/bf1442f8-a9fa-40d3-bcb0-7a8a41b49b5d.jpeg)
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/0d68612e-845d-466f-8a4a-b85facea095b.png" alt="image.png"> | *   Involving the image subject area</para>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/621daadc-454f-41b4-9ac4-752d457034b6.jpeg" alt="b6ef803f-743f-4e61-b901-d1f68167186f.jpeg"></para>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/caa6994b-2f97-484d-a807-671a0dc75947.jpeg" alt="dee0c7cf-8b0d-4d6d-9677-d5f2e6099834.jpeg"> |
        /// | Specified image element removal (supports multiple image links) | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/9297951f-53c1-4476-8c69-5c31df3fce21.png" alt="image.png"> | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/ef3f35aa-609f-454c-bba0-dd1710c83945.png" alt="image.png"> |
        /// | Specified text removal (supports multiple text strings) | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/c784d8be-4b4d-4972-8b99-828c742b8f03.png" alt="image.png"> | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/805423ca-bd0d-4d44-a18e-a7d7bfe88587.png" alt="image.png"> |</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ImageRemoveRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageRemoveResponse
        /// </returns>
        public async Task<ImageRemoveResponse> ImageRemoveWithOptionsAsync(ImageRemoveRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImageRemoveShrinkRequest request = new ImageRemoveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NonObjectRemoveElements))
            {
                request.NonObjectRemoveElementsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NonObjectRemoveElements, "NonObjectRemoveElements", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ObjectRemoveElements))
            {
                request.ObjectRemoveElementsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ObjectRemoveElements, "ObjectRemoveElements", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserImage))
            {
                request.UserImageShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserImage, "UserImage", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserText))
            {
                request.UserTextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserText, "UserText", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonObjectRemoveElementsShrink))
            {
                query["NonObjectRemoveElements"] = request.NonObjectRemoveElementsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectRemoveElementsShrink))
            {
                query["ObjectRemoveElements"] = request.ObjectRemoveElementsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Position))
            {
                query["Position"] = request.Position;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserImageShrink))
            {
                query["UserImage"] = request.UserImageShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserTextShrink))
            {
                query["UserText"] = request.UserTextShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageRemove",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageRemoveResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Intelligently removes unwanted elements from e-commerce images, automatically detecting and erasing text, specific names, transparent text blocks, and visual clutter. Supports specifying objects to remove on demand, enabling efficient and precise batch processing of large volumes of images to simplify image editing workflows. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Product Introduction</h1>
        /// <para>The intelligent image removal product is designed specifically for e-commerce images. It automatically detects and removes text, specific names, transparent text blocks, and visual clutter from e-commerce images. You can specify objects to remove on demand, enabling efficient and precise batch processing of large volumes of images to simplify image editing workflows. (Synchronous)</para>
        /// <h1>Common scenarios</h1>
        /// <list type="bullet">
        /// <item><description><b>Efficient e-commerce image processing:</b></description></item>
        /// </list>
        /// <para>Remove irrelevant visual elements to provide clearer, more focused product displays and enhance the shopping experience.</para>
        /// <list type="bullet">
        /// <item><description><b>Multi-platform product information synchronization:</b></description></item>
        /// </list>
        /// <para>When listing products across different e-commerce platforms, quickly remove specific text and visual clutter to comply with image specifications of different platforms.</para>
        /// <list type="bullet">
        /// <item><description><b>Marketing material preparation:</b></description></item>
        /// </list>
        /// <para>Easily remove existing promotional information and quickly update images with the latest campaign details.</para>
        /// <remarks>
        /// <para>Note: Merchants or platforms can batch-remove impurities from images to optimize image quality. We recommend using this in combination with the &quot;Intelligent Recognition API&quot; (coming soon). First, filter out images containing text, specific names, transparent text blocks, and visual clutter, then use the &quot;Intelligent Removal API&quot; for batch removal. The Intelligent Recognition API focuses on &quot;recognition,&quot; while the Intelligent Removal API focuses on &quot;removal.&quot; By calling them sequentially, you can maximize removal effectiveness and reduce false removals and false identifications.</para>
        /// </remarks>
        /// <h1>Features</h1>
        /// <ol>
        /// <item><description><para>First, understand the definitions of image subject and image background. When specifying removal targets, you can choose whether the removal scope is the image subject or the image background area. Both API and editor access methods are supported to meet different requirements.</para>
        /// <ol>
        /// <item><description><para>Image subject: The core product area in the image.</para>
        /// </description></item>
        /// <item><description><para>Image background: The remaining portion of the image excluding the product subject.</para>
        /// </description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><para>The following three removal target options are supported:</para>
        /// <ol>
        /// <item><description><para>Select by type only. Supported types include text, specific names, transparent text blocks, and visual clutter. Refer to the following examples to clarify your requirements and perform targeted operations.</para>
        /// </description></item>
        /// <item><description><para>(Upgrade) Specify images to remove. You can specify multiple images at a time.</para>
        /// </description></item>
        /// <item><description><para>(Upgrade) Specify text to remove. You can specify multiple text strings at a time.</para>
        /// </description></item>
        /// </ol>
        /// </description></item>
        /// </ol>
        /// <para>Processing workflow: User submits original image URL → OCR+VLM model detects text or image positions → Determines coordinates of areas to repair → AI repairs and generates a clean image → Returns the result image URL.</para>
        /// <h1>4. Effect comparison</h1>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Removable objects in images</b></th>
        /// <th><b>Original image</b></th>
        /// <th><b>Image after removal</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Text</td>
        /// <td>*   Involving the image subject area</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <pre><c>![done-image-4a2a96c2-9ac6-4b35-b76b-a6eac303740f (1).png](https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/d72a7982-e761-4b45-af1e-f8f90b3f1fc3.png)
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/47428227-7523-432e-89ce-eba263e5ebda.png" alt="image.png"> | *   Involving the image subject area</para>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/d69e38e4-5657-471d-aff6-1e6a4c269455.png" alt="359ddfcf-a2b1-4e59-ae54-5e76705d0adf.png"></para>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/365024b4-4863-46d4-9013-bdd9408ea6b9.png" alt="c35611f8-dab4-4df2-8942-36d7375ed55f.png"> |
        /// | Specific names | *   Involving the image subject area</para>
        /// <pre><c>![done-image-aca80515-aca6-4f4e-9429-47c5dd6b811f.png](https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/ac35f8bc-d527-49de-8fba-cdeb71e3b058.png)
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/2db445c8-6bdd-424e-b6a7-2ddb46e6786d.png" alt="done-image-29a89f03-964a-455e-968c-7c8d5282ebbb.png"> | *   Involving the image subject area</para>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/36ace8aa-3b3b-4b1c-81e6-b691104262f0.png" alt="fd2db0ab-1b89-4085-b91d-99f40a1aea77.png"></para>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/a7653a0c-d14e-4f97-9c2f-83327b43203f.png" alt="8726b148-ab74-4409-a6c1-4c50fcac3887.png"> |
        /// | Transparent text blocks | *   Involving the image subject area</para>
        /// <pre><c>![image.png](https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/0f6068f0-168a-47bd-9fcd-c38b9e520506.png)
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/c9ac2a4c-0aa3-40ee-8855-62a262364dbe.png" alt="image.png"> | *   Involving the image subject area</para>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/06ac537f-875a-48e2-8934-a84a79dfd8ff.jpeg" alt="8e84a5d6-da8c-4e3e-a705-71a66d0c78a2.jpeg"></para>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/05759aef-1720-41cd-8800-f7d0801e4d95.jpeg" alt="b05173e7-2ae5-494e-99d2-7111fc966fd5.jpeg"> |
        /// | Visual clutter | *   Involving the image subject area</para>
        /// <pre><c>![2.jpeg](https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/bf1442f8-a9fa-40d3-bcb0-7a8a41b49b5d.jpeg)
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/0d68612e-845d-466f-8a4a-b85facea095b.png" alt="image.png"> | *   Involving the image subject area</para>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/621daadc-454f-41b4-9ac4-752d457034b6.jpeg" alt="b6ef803f-743f-4e61-b901-d1f68167186f.jpeg"></para>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/caa6994b-2f97-484d-a807-671a0dc75947.jpeg" alt="dee0c7cf-8b0d-4d6d-9677-d5f2e6099834.jpeg"> |
        /// | Specified image element removal (supports multiple image links) | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/9297951f-53c1-4476-8c69-5c31df3fce21.png" alt="image.png"> | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/ef3f35aa-609f-454c-bba0-dd1710c83945.png" alt="image.png"> |
        /// | Specified text removal (supports multiple text strings) | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/c784d8be-4b4d-4972-8b99-828c742b8f03.png" alt="image.png"> | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/805423ca-bd0d-4d44-a18e-a7d7bfe88587.png" alt="image.png"> |</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageRemoveRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageRemoveResponse
        /// </returns>
        public ImageRemoveResponse ImageRemove(ImageRemoveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImageRemoveWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Intelligently removes unwanted elements from e-commerce images, automatically detecting and erasing text, specific names, transparent text blocks, and visual clutter. Supports specifying objects to remove on demand, enabling efficient and precise batch processing of large volumes of images to simplify image editing workflows. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Product Introduction</h1>
        /// <para>The intelligent image removal product is designed specifically for e-commerce images. It automatically detects and removes text, specific names, transparent text blocks, and visual clutter from e-commerce images. You can specify objects to remove on demand, enabling efficient and precise batch processing of large volumes of images to simplify image editing workflows. (Synchronous)</para>
        /// <h1>Common scenarios</h1>
        /// <list type="bullet">
        /// <item><description><b>Efficient e-commerce image processing:</b></description></item>
        /// </list>
        /// <para>Remove irrelevant visual elements to provide clearer, more focused product displays and enhance the shopping experience.</para>
        /// <list type="bullet">
        /// <item><description><b>Multi-platform product information synchronization:</b></description></item>
        /// </list>
        /// <para>When listing products across different e-commerce platforms, quickly remove specific text and visual clutter to comply with image specifications of different platforms.</para>
        /// <list type="bullet">
        /// <item><description><b>Marketing material preparation:</b></description></item>
        /// </list>
        /// <para>Easily remove existing promotional information and quickly update images with the latest campaign details.</para>
        /// <remarks>
        /// <para>Note: Merchants or platforms can batch-remove impurities from images to optimize image quality. We recommend using this in combination with the &quot;Intelligent Recognition API&quot; (coming soon). First, filter out images containing text, specific names, transparent text blocks, and visual clutter, then use the &quot;Intelligent Removal API&quot; for batch removal. The Intelligent Recognition API focuses on &quot;recognition,&quot; while the Intelligent Removal API focuses on &quot;removal.&quot; By calling them sequentially, you can maximize removal effectiveness and reduce false removals and false identifications.</para>
        /// </remarks>
        /// <h1>Features</h1>
        /// <ol>
        /// <item><description><para>First, understand the definitions of image subject and image background. When specifying removal targets, you can choose whether the removal scope is the image subject or the image background area. Both API and editor access methods are supported to meet different requirements.</para>
        /// <ol>
        /// <item><description><para>Image subject: The core product area in the image.</para>
        /// </description></item>
        /// <item><description><para>Image background: The remaining portion of the image excluding the product subject.</para>
        /// </description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><para>The following three removal target options are supported:</para>
        /// <ol>
        /// <item><description><para>Select by type only. Supported types include text, specific names, transparent text blocks, and visual clutter. Refer to the following examples to clarify your requirements and perform targeted operations.</para>
        /// </description></item>
        /// <item><description><para>(Upgrade) Specify images to remove. You can specify multiple images at a time.</para>
        /// </description></item>
        /// <item><description><para>(Upgrade) Specify text to remove. You can specify multiple text strings at a time.</para>
        /// </description></item>
        /// </ol>
        /// </description></item>
        /// </ol>
        /// <para>Processing workflow: User submits original image URL → OCR+VLM model detects text or image positions → Determines coordinates of areas to repair → AI repairs and generates a clean image → Returns the result image URL.</para>
        /// <h1>4. Effect comparison</h1>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Removable objects in images</b></th>
        /// <th><b>Original image</b></th>
        /// <th><b>Image after removal</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Text</td>
        /// <td>*   Involving the image subject area</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <pre><c>![done-image-4a2a96c2-9ac6-4b35-b76b-a6eac303740f (1).png](https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/d72a7982-e761-4b45-af1e-f8f90b3f1fc3.png)
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/47428227-7523-432e-89ce-eba263e5ebda.png" alt="image.png"> | *   Involving the image subject area</para>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/d69e38e4-5657-471d-aff6-1e6a4c269455.png" alt="359ddfcf-a2b1-4e59-ae54-5e76705d0adf.png"></para>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/365024b4-4863-46d4-9013-bdd9408ea6b9.png" alt="c35611f8-dab4-4df2-8942-36d7375ed55f.png"> |
        /// | Specific names | *   Involving the image subject area</para>
        /// <pre><c>![done-image-aca80515-aca6-4f4e-9429-47c5dd6b811f.png](https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/ac35f8bc-d527-49de-8fba-cdeb71e3b058.png)
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/2db445c8-6bdd-424e-b6a7-2ddb46e6786d.png" alt="done-image-29a89f03-964a-455e-968c-7c8d5282ebbb.png"> | *   Involving the image subject area</para>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/36ace8aa-3b3b-4b1c-81e6-b691104262f0.png" alt="fd2db0ab-1b89-4085-b91d-99f40a1aea77.png"></para>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/a7653a0c-d14e-4f97-9c2f-83327b43203f.png" alt="8726b148-ab74-4409-a6c1-4c50fcac3887.png"> |
        /// | Transparent text blocks | *   Involving the image subject area</para>
        /// <pre><c>![image.png](https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/0f6068f0-168a-47bd-9fcd-c38b9e520506.png)
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/c9ac2a4c-0aa3-40ee-8855-62a262364dbe.png" alt="image.png"> | *   Involving the image subject area</para>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/06ac537f-875a-48e2-8934-a84a79dfd8ff.jpeg" alt="8e84a5d6-da8c-4e3e-a705-71a66d0c78a2.jpeg"></para>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/05759aef-1720-41cd-8800-f7d0801e4d95.jpeg" alt="b05173e7-2ae5-494e-99d2-7111fc966fd5.jpeg"> |
        /// | Visual clutter | *   Involving the image subject area</para>
        /// <pre><c>![2.jpeg](https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/bf1442f8-a9fa-40d3-bcb0-7a8a41b49b5d.jpeg)
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/0d68612e-845d-466f-8a4a-b85facea095b.png" alt="image.png"> | *   Involving the image subject area</para>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/621daadc-454f-41b4-9ac4-752d457034b6.jpeg" alt="b6ef803f-743f-4e61-b901-d1f68167186f.jpeg"></para>
        /// <list type="bullet">
        /// <item><description>Not involving the image subject area</description></item>
        /// </list>
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/caa6994b-2f97-484d-a807-671a0dc75947.jpeg" alt="dee0c7cf-8b0d-4d6d-9677-d5f2e6099834.jpeg"> |
        /// | Specified image element removal (supports multiple image links) | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/9297951f-53c1-4476-8c69-5c31df3fce21.png" alt="image.png"> | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/ef3f35aa-609f-454c-bba0-dd1710c83945.png" alt="image.png"> |
        /// | Specified text removal (supports multiple text strings) | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/c784d8be-4b4d-4972-8b99-828c742b8f03.png" alt="image.png"> | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/805423ca-bd0d-4d44-a18e-a7d7bfe88587.png" alt="image.png"> |</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageRemoveRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageRemoveResponse
        /// </returns>
        public async Task<ImageRemoveResponse> ImageRemoveAsync(ImageRemoveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImageRemoveWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Translates text in images using the PLUS edition, which is designed specifically for e-commerce images and adopts a Mixture of Experts (MOE) architecture. Compared to the Lite and Pro editions of image translation, this edition delivers superior translation accuracy for multiple minority languages. We recommend using it for the following 8 language directions, with more language directions to be supported in the future.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Image Translation Plus is designed specifically for e-commerce images. It uses a Mixture of Experts (MOE) architecture and outperforms Image Translation Lite and Pro in translation accuracy for multiple minor languages. We recommend using it for the following language pairs, with more to be supported in the future.
        /// Supported language pairs:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>No.</b></th>
        /// <th><b>Source language</b></th>
        /// <th></th>
        /// <th><b>Target language</b></th>
        /// <th></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td></td>
        /// <td>Language code</td>
        /// <td>Language name</td>
        /// <td>Language code</td>
        /// <td>Language name</td>
        /// </tr>
        /// <tr>
        /// <td>1</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>ar</td>
        /// <td>Arabic</td>
        /// </tr>
        /// <tr>
        /// <td>2</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>id</td>
        /// <td>Indonesian</td>
        /// </tr>
        /// <tr>
        /// <td>3</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>th</td>
        /// <td>Thai</td>
        /// </tr>
        /// <tr>
        /// <td>4</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>ko</td>
        /// <td>Korean</td>
        /// </tr>
        /// <tr>
        /// <td>5</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>ja</td>
        /// <td>Japanese</td>
        /// </tr>
        /// <tr>
        /// <td>6</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>vi</td>
        /// <td>Vietnamese</td>
        /// </tr>
        /// <tr>
        /// <td>7</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>ru</td>
        /// <td>Russian</td>
        /// </tr>
        /// <tr>
        /// <td>8</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>tl</td>
        /// <td>Filipino</td>
        /// </tr>
        /// <tr>
        /// <td>9</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>es</td>
        /// <td>Spanish</td>
        /// </tr>
        /// <tr>
        /// <td>10</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>fr</td>
        /// <td>French</td>
        /// </tr>
        /// <tr>
        /// <td>11</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>de</td>
        /// <td>German</td>
        /// </tr>
        /// <tr>
        /// <td>12</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>pl</td>
        /// <td>Polish</td>
        /// </tr>
        /// </tbody></table>
        /// <h2>Common scenarios</h2>
        /// <para>Main product images and detail images for cross-border e-commerce.</para>
        /// <h2>Functions and features</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Product body information protection</b>: Allows you to choose whether to translate text on the product body, helping you protect body information such as embedded product names from being translated.</para>
        /// </description></item>
        /// <item><description><para><b>Brand name protection</b>: Allows you to choose whether to translate brand names on images, helping you protect brand name information from being translated.</para>
        /// </description></item>
        /// <item><description><para><b>Translation intervention support</b>: Allows you to customize translation results, including no translation (ABC-ABC), specified translation (ABC-DEF), and removal (ABC-empty value). This is commonly used for brand name protection scenarios. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs in different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageTranslationPlusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageTranslationPlusResponse
        /// </returns>
        public ImageTranslationPlusResponse ImageTranslationPlusWithOptions(ImageTranslationPlusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Glossary))
            {
                body["Glossary"] = request.Glossary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludingProductArea))
            {
                body["IncludingProductArea"] = request.IncludingProductArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                body["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                body["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslatingBrandInTheProduct))
            {
                body["TranslatingBrandInTheProduct"] = request.TranslatingBrandInTheProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseImageEditor))
            {
                body["UseImageEditor"] = request.UseImageEditor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageTranslationPlus",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageTranslationPlusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Translates text in images using the PLUS edition, which is designed specifically for e-commerce images and adopts a Mixture of Experts (MOE) architecture. Compared to the Lite and Pro editions of image translation, this edition delivers superior translation accuracy for multiple minority languages. We recommend using it for the following 8 language directions, with more language directions to be supported in the future.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Image Translation Plus is designed specifically for e-commerce images. It uses a Mixture of Experts (MOE) architecture and outperforms Image Translation Lite and Pro in translation accuracy for multiple minor languages. We recommend using it for the following language pairs, with more to be supported in the future.
        /// Supported language pairs:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>No.</b></th>
        /// <th><b>Source language</b></th>
        /// <th></th>
        /// <th><b>Target language</b></th>
        /// <th></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td></td>
        /// <td>Language code</td>
        /// <td>Language name</td>
        /// <td>Language code</td>
        /// <td>Language name</td>
        /// </tr>
        /// <tr>
        /// <td>1</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>ar</td>
        /// <td>Arabic</td>
        /// </tr>
        /// <tr>
        /// <td>2</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>id</td>
        /// <td>Indonesian</td>
        /// </tr>
        /// <tr>
        /// <td>3</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>th</td>
        /// <td>Thai</td>
        /// </tr>
        /// <tr>
        /// <td>4</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>ko</td>
        /// <td>Korean</td>
        /// </tr>
        /// <tr>
        /// <td>5</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>ja</td>
        /// <td>Japanese</td>
        /// </tr>
        /// <tr>
        /// <td>6</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>vi</td>
        /// <td>Vietnamese</td>
        /// </tr>
        /// <tr>
        /// <td>7</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>ru</td>
        /// <td>Russian</td>
        /// </tr>
        /// <tr>
        /// <td>8</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>tl</td>
        /// <td>Filipino</td>
        /// </tr>
        /// <tr>
        /// <td>9</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>es</td>
        /// <td>Spanish</td>
        /// </tr>
        /// <tr>
        /// <td>10</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>fr</td>
        /// <td>French</td>
        /// </tr>
        /// <tr>
        /// <td>11</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>de</td>
        /// <td>German</td>
        /// </tr>
        /// <tr>
        /// <td>12</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>pl</td>
        /// <td>Polish</td>
        /// </tr>
        /// </tbody></table>
        /// <h2>Common scenarios</h2>
        /// <para>Main product images and detail images for cross-border e-commerce.</para>
        /// <h2>Functions and features</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Product body information protection</b>: Allows you to choose whether to translate text on the product body, helping you protect body information such as embedded product names from being translated.</para>
        /// </description></item>
        /// <item><description><para><b>Brand name protection</b>: Allows you to choose whether to translate brand names on images, helping you protect brand name information from being translated.</para>
        /// </description></item>
        /// <item><description><para><b>Translation intervention support</b>: Allows you to customize translation results, including no translation (ABC-ABC), specified translation (ABC-DEF), and removal (ABC-empty value). This is commonly used for brand name protection scenarios. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs in different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageTranslationPlusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageTranslationPlusResponse
        /// </returns>
        public async Task<ImageTranslationPlusResponse> ImageTranslationPlusWithOptionsAsync(ImageTranslationPlusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Glossary))
            {
                body["Glossary"] = request.Glossary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludingProductArea))
            {
                body["IncludingProductArea"] = request.IncludingProductArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                body["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                body["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslatingBrandInTheProduct))
            {
                body["TranslatingBrandInTheProduct"] = request.TranslatingBrandInTheProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseImageEditor))
            {
                body["UseImageEditor"] = request.UseImageEditor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageTranslationPlus",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageTranslationPlusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Translates text in images using the PLUS edition, which is designed specifically for e-commerce images and adopts a Mixture of Experts (MOE) architecture. Compared to the Lite and Pro editions of image translation, this edition delivers superior translation accuracy for multiple minority languages. We recommend using it for the following 8 language directions, with more language directions to be supported in the future.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Image Translation Plus is designed specifically for e-commerce images. It uses a Mixture of Experts (MOE) architecture and outperforms Image Translation Lite and Pro in translation accuracy for multiple minor languages. We recommend using it for the following language pairs, with more to be supported in the future.
        /// Supported language pairs:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>No.</b></th>
        /// <th><b>Source language</b></th>
        /// <th></th>
        /// <th><b>Target language</b></th>
        /// <th></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td></td>
        /// <td>Language code</td>
        /// <td>Language name</td>
        /// <td>Language code</td>
        /// <td>Language name</td>
        /// </tr>
        /// <tr>
        /// <td>1</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>ar</td>
        /// <td>Arabic</td>
        /// </tr>
        /// <tr>
        /// <td>2</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>id</td>
        /// <td>Indonesian</td>
        /// </tr>
        /// <tr>
        /// <td>3</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>th</td>
        /// <td>Thai</td>
        /// </tr>
        /// <tr>
        /// <td>4</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>ko</td>
        /// <td>Korean</td>
        /// </tr>
        /// <tr>
        /// <td>5</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>ja</td>
        /// <td>Japanese</td>
        /// </tr>
        /// <tr>
        /// <td>6</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>vi</td>
        /// <td>Vietnamese</td>
        /// </tr>
        /// <tr>
        /// <td>7</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>ru</td>
        /// <td>Russian</td>
        /// </tr>
        /// <tr>
        /// <td>8</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>tl</td>
        /// <td>Filipino</td>
        /// </tr>
        /// <tr>
        /// <td>9</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>es</td>
        /// <td>Spanish</td>
        /// </tr>
        /// <tr>
        /// <td>10</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>fr</td>
        /// <td>French</td>
        /// </tr>
        /// <tr>
        /// <td>11</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>de</td>
        /// <td>German</td>
        /// </tr>
        /// <tr>
        /// <td>12</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>pl</td>
        /// <td>Polish</td>
        /// </tr>
        /// </tbody></table>
        /// <h2>Common scenarios</h2>
        /// <para>Main product images and detail images for cross-border e-commerce.</para>
        /// <h2>Functions and features</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Product body information protection</b>: Allows you to choose whether to translate text on the product body, helping you protect body information such as embedded product names from being translated.</para>
        /// </description></item>
        /// <item><description><para><b>Brand name protection</b>: Allows you to choose whether to translate brand names on images, helping you protect brand name information from being translated.</para>
        /// </description></item>
        /// <item><description><para><b>Translation intervention support</b>: Allows you to customize translation results, including no translation (ABC-ABC), specified translation (ABC-DEF), and removal (ABC-empty value). This is commonly used for brand name protection scenarios. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs in different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageTranslationPlusRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageTranslationPlusResponse
        /// </returns>
        public ImageTranslationPlusResponse ImageTranslationPlus(ImageTranslationPlusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImageTranslationPlusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Translates text in images using the PLUS edition, which is designed specifically for e-commerce images and adopts a Mixture of Experts (MOE) architecture. Compared to the Lite and Pro editions of image translation, this edition delivers superior translation accuracy for multiple minority languages. We recommend using it for the following 8 language directions, with more language directions to be supported in the future.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Image Translation Plus is designed specifically for e-commerce images. It uses a Mixture of Experts (MOE) architecture and outperforms Image Translation Lite and Pro in translation accuracy for multiple minor languages. We recommend using it for the following language pairs, with more to be supported in the future.
        /// Supported language pairs:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>No.</b></th>
        /// <th><b>Source language</b></th>
        /// <th></th>
        /// <th><b>Target language</b></th>
        /// <th></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td></td>
        /// <td>Language code</td>
        /// <td>Language name</td>
        /// <td>Language code</td>
        /// <td>Language name</td>
        /// </tr>
        /// <tr>
        /// <td>1</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>ar</td>
        /// <td>Arabic</td>
        /// </tr>
        /// <tr>
        /// <td>2</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>id</td>
        /// <td>Indonesian</td>
        /// </tr>
        /// <tr>
        /// <td>3</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>th</td>
        /// <td>Thai</td>
        /// </tr>
        /// <tr>
        /// <td>4</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>ko</td>
        /// <td>Korean</td>
        /// </tr>
        /// <tr>
        /// <td>5</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>ja</td>
        /// <td>Japanese</td>
        /// </tr>
        /// <tr>
        /// <td>6</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>vi</td>
        /// <td>Vietnamese</td>
        /// </tr>
        /// <tr>
        /// <td>7</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>ru</td>
        /// <td>Russian</td>
        /// </tr>
        /// <tr>
        /// <td>8</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>tl</td>
        /// <td>Filipino</td>
        /// </tr>
        /// <tr>
        /// <td>9</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>es</td>
        /// <td>Spanish</td>
        /// </tr>
        /// <tr>
        /// <td>10</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>fr</td>
        /// <td>French</td>
        /// </tr>
        /// <tr>
        /// <td>11</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>de</td>
        /// <td>German</td>
        /// </tr>
        /// <tr>
        /// <td>12</td>
        /// <td>en</td>
        /// <td>English</td>
        /// <td>pl</td>
        /// <td>Polish</td>
        /// </tr>
        /// </tbody></table>
        /// <h2>Common scenarios</h2>
        /// <para>Main product images and detail images for cross-border e-commerce.</para>
        /// <h2>Functions and features</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Product body information protection</b>: Allows you to choose whether to translate text on the product body, helping you protect body information such as embedded product names from being translated.</para>
        /// </description></item>
        /// <item><description><para><b>Brand name protection</b>: Allows you to choose whether to translate brand names on images, helping you protect brand name information from being translated.</para>
        /// </description></item>
        /// <item><description><para><b>Translation intervention support</b>: Allows you to customize translation results, including no translation (ABC-ABC), specified translation (ABC-DEF), and removal (ABC-empty value). This is commonly used for brand name protection scenarios. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs in different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageTranslationPlusRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageTranslationPlusResponse
        /// </returns>
        public async Task<ImageTranslationPlusResponse> ImageTranslationPlusAsync(ImageTranslationPlusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImageTranslationPlusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Image Translation Pro is designed for e-commerce images. It integrates multimodal foundation model technology to achieve more accurate image understanding, significantly improve translation quality, and continuously expand and optimize multilingual translation capabilities. It supports more than 100 language directions, including bridged translations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Image Translation Pro is designed for e-commerce images. It integrates multimodal foundation model technology to achieve more accurate image understanding, significantly improve translation quality, and continuously expand and optimize multilingual translation capabilities. It supports more than 100 language directions, including bridged translations.</para>
        /// <h2>Scenarios</h2>
        /// <para>E-commerce product images, marketing images, and images for various other scenarios.</para>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>Product subject protection</b>: Specify whether to translate text on the product subject. This helps protect subject information such as embedded product names from being translated.</description></item>
        /// <item><description><b>Post-translation editing</b>: Specify whether to return layout information such as text position, font, and color. This information can be used for secondary editing when integrated with an image editor. The editor SDK is not yet available. Follow platform notifications for updates.</description></item>
        /// <item><description><b>Brand name protection</b>: Specify whether to translate brand names on images. This helps protect brand name information from being translated.</description></item>
        /// <item><description><b>Translation intervention</b>: Customize translation results, including do-not-translate (ABC→ABC), specified translation (ABC→DEF), and remove text (ABC→empty value). This is commonly used for brand name protection and similar scenarios. Pass the corresponding intervention glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 intervention terms. Contact the platform if you need a higher limit.  </description></item>
        /// <item><description><b>Image editor integration</b>: For more information, see <a href="https://www.alibabacloud.com/help/en/document_detail/3042647.html">Image Translation Editor Protocol</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageTranslationProRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageTranslationProResponse
        /// </returns>
        public ImageTranslationProResponse ImageTranslationProWithOptions(ImageTranslationProRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Async))
            {
                body["Async"] = request.Async;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Glossary))
            {
                body["Glossary"] = request.Glossary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludingProductArea))
            {
                body["IncludingProductArea"] = request.IncludingProductArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                body["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                body["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslatingBrandInTheProduct))
            {
                body["TranslatingBrandInTheProduct"] = request.TranslatingBrandInTheProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseImageEditor))
            {
                body["UseImageEditor"] = request.UseImageEditor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageTranslationPro",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageTranslationProResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Image Translation Pro is designed for e-commerce images. It integrates multimodal foundation model technology to achieve more accurate image understanding, significantly improve translation quality, and continuously expand and optimize multilingual translation capabilities. It supports more than 100 language directions, including bridged translations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Image Translation Pro is designed for e-commerce images. It integrates multimodal foundation model technology to achieve more accurate image understanding, significantly improve translation quality, and continuously expand and optimize multilingual translation capabilities. It supports more than 100 language directions, including bridged translations.</para>
        /// <h2>Scenarios</h2>
        /// <para>E-commerce product images, marketing images, and images for various other scenarios.</para>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>Product subject protection</b>: Specify whether to translate text on the product subject. This helps protect subject information such as embedded product names from being translated.</description></item>
        /// <item><description><b>Post-translation editing</b>: Specify whether to return layout information such as text position, font, and color. This information can be used for secondary editing when integrated with an image editor. The editor SDK is not yet available. Follow platform notifications for updates.</description></item>
        /// <item><description><b>Brand name protection</b>: Specify whether to translate brand names on images. This helps protect brand name information from being translated.</description></item>
        /// <item><description><b>Translation intervention</b>: Customize translation results, including do-not-translate (ABC→ABC), specified translation (ABC→DEF), and remove text (ABC→empty value). This is commonly used for brand name protection and similar scenarios. Pass the corresponding intervention glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 intervention terms. Contact the platform if you need a higher limit.  </description></item>
        /// <item><description><b>Image editor integration</b>: For more information, see <a href="https://www.alibabacloud.com/help/en/document_detail/3042647.html">Image Translation Editor Protocol</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageTranslationProRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageTranslationProResponse
        /// </returns>
        public async Task<ImageTranslationProResponse> ImageTranslationProWithOptionsAsync(ImageTranslationProRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Async))
            {
                body["Async"] = request.Async;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Glossary))
            {
                body["Glossary"] = request.Glossary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludingProductArea))
            {
                body["IncludingProductArea"] = request.IncludingProductArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                body["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                body["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslatingBrandInTheProduct))
            {
                body["TranslatingBrandInTheProduct"] = request.TranslatingBrandInTheProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseImageEditor))
            {
                body["UseImageEditor"] = request.UseImageEditor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageTranslationPro",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageTranslationProResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Image Translation Pro is designed for e-commerce images. It integrates multimodal foundation model technology to achieve more accurate image understanding, significantly improve translation quality, and continuously expand and optimize multilingual translation capabilities. It supports more than 100 language directions, including bridged translations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Image Translation Pro is designed for e-commerce images. It integrates multimodal foundation model technology to achieve more accurate image understanding, significantly improve translation quality, and continuously expand and optimize multilingual translation capabilities. It supports more than 100 language directions, including bridged translations.</para>
        /// <h2>Scenarios</h2>
        /// <para>E-commerce product images, marketing images, and images for various other scenarios.</para>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>Product subject protection</b>: Specify whether to translate text on the product subject. This helps protect subject information such as embedded product names from being translated.</description></item>
        /// <item><description><b>Post-translation editing</b>: Specify whether to return layout information such as text position, font, and color. This information can be used for secondary editing when integrated with an image editor. The editor SDK is not yet available. Follow platform notifications for updates.</description></item>
        /// <item><description><b>Brand name protection</b>: Specify whether to translate brand names on images. This helps protect brand name information from being translated.</description></item>
        /// <item><description><b>Translation intervention</b>: Customize translation results, including do-not-translate (ABC→ABC), specified translation (ABC→DEF), and remove text (ABC→empty value). This is commonly used for brand name protection and similar scenarios. Pass the corresponding intervention glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 intervention terms. Contact the platform if you need a higher limit.  </description></item>
        /// <item><description><b>Image editor integration</b>: For more information, see <a href="https://www.alibabacloud.com/help/en/document_detail/3042647.html">Image Translation Editor Protocol</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageTranslationProRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageTranslationProResponse
        /// </returns>
        public ImageTranslationProResponse ImageTranslationPro(ImageTranslationProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImageTranslationProWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Image Translation Pro is designed for e-commerce images. It integrates multimodal foundation model technology to achieve more accurate image understanding, significantly improve translation quality, and continuously expand and optimize multilingual translation capabilities. It supports more than 100 language directions, including bridged translations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Image Translation Pro is designed for e-commerce images. It integrates multimodal foundation model technology to achieve more accurate image understanding, significantly improve translation quality, and continuously expand and optimize multilingual translation capabilities. It supports more than 100 language directions, including bridged translations.</para>
        /// <h2>Scenarios</h2>
        /// <para>E-commerce product images, marketing images, and images for various other scenarios.</para>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>Product subject protection</b>: Specify whether to translate text on the product subject. This helps protect subject information such as embedded product names from being translated.</description></item>
        /// <item><description><b>Post-translation editing</b>: Specify whether to return layout information such as text position, font, and color. This information can be used for secondary editing when integrated with an image editor. The editor SDK is not yet available. Follow platform notifications for updates.</description></item>
        /// <item><description><b>Brand name protection</b>: Specify whether to translate brand names on images. This helps protect brand name information from being translated.</description></item>
        /// <item><description><b>Translation intervention</b>: Customize translation results, including do-not-translate (ABC→ABC), specified translation (ABC→DEF), and remove text (ABC→empty value). This is commonly used for brand name protection and similar scenarios. Pass the corresponding intervention glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 intervention terms. Contact the platform if you need a higher limit.  </description></item>
        /// <item><description><b>Image editor integration</b>: For more information, see <a href="https://www.alibabacloud.com/help/en/document_detail/3042647.html">Image Translation Editor Protocol</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageTranslationProRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageTranslationProResponse
        /// </returns>
        public async Task<ImageTranslationProResponse> ImageTranslationProAsync(ImageTranslationProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImageTranslationProWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Image Translation is designed specifically for e-commerce images. It supports more than 100 language directions (including bridging), accurately processes complex text layouts within images, and ensures that translated content matches the image content. This helps e-commerce platforms and developers easily achieve multilingual conversion and rendering of image content. The product also returns layer information such as text position, font, and color within images, making it easy to integrate with image editors for secondary editing of translation results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>Image Translation is designed specifically for e-commerce images. It supports more than 100 language directions (including bridging), accurately processes complex text layouts within images, and ensures that translated content matches the image content. This helps e-commerce platforms and developers easily achieve multilingual conversion and rendering of image content. The product also returns layer information such as text position, font, and color within images, making it easy to integrate with image editors for secondary editing of translation results.</para>
        /// <h1>2. Applicable scenarios</h1>
        /// <para>E-commerce product images, marketing images, and images for various other scenarios.</para>
        /// <h1>3. Features</h1>
        /// <list type="bullet">
        /// <item><description><para><b>Product subject information protection</b>: You can choose whether to translate text on the product subject. This helps protect subject information from being translated, avoiding translation of embedded information such as product names.</para>
        /// </description></item>
        /// <item><description><para><b>Brand name protection</b>: You can choose whether to translate brand names on images. This helps protect brand name information from being translated.</para>
        /// </description></item>
        /// <item><description><para><b>Secondary editing after translation (layer information)</b>: You can choose whether to return layer information such as text position, font, and color. This information can be used to integrate with image editors for secondary editing of translation results. For the release progress of the editor SDK package, follow platform notifications.</para>
        /// </description></item>
        /// <item><description><para><b>Translation intervention support</b>: You can customize translation results, including no translation (ABC-ABC), specified translation (ABC-DEF), and skip translation (ABC-empty value). This is commonly used for scenarios such as brand term protection. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs in different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.  </para>
        /// </description></item>
        /// <item><description><para><b>Image editor integration support</b>: For more information, see <a href="https://www.alibabacloud.com/help/en/document_detail/3042647.html">Image Translation editor protocol</a>.</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageTranslationStandardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageTranslationStandardResponse
        /// </returns>
        public ImageTranslationStandardResponse ImageTranslationStandardWithOptions(ImageTranslationStandardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Glossary))
            {
                query["Glossary"] = request.Glossary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludingProductArea))
            {
                query["IncludingProductArea"] = request.IncludingProductArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                query["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                query["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslatingBrandInTheProduct))
            {
                query["TranslatingBrandInTheProduct"] = request.TranslatingBrandInTheProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseImageEditor))
            {
                query["UseImageEditor"] = request.UseImageEditor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageTranslationStandard",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageTranslationStandardResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Image Translation is designed specifically for e-commerce images. It supports more than 100 language directions (including bridging), accurately processes complex text layouts within images, and ensures that translated content matches the image content. This helps e-commerce platforms and developers easily achieve multilingual conversion and rendering of image content. The product also returns layer information such as text position, font, and color within images, making it easy to integrate with image editors for secondary editing of translation results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>Image Translation is designed specifically for e-commerce images. It supports more than 100 language directions (including bridging), accurately processes complex text layouts within images, and ensures that translated content matches the image content. This helps e-commerce platforms and developers easily achieve multilingual conversion and rendering of image content. The product also returns layer information such as text position, font, and color within images, making it easy to integrate with image editors for secondary editing of translation results.</para>
        /// <h1>2. Applicable scenarios</h1>
        /// <para>E-commerce product images, marketing images, and images for various other scenarios.</para>
        /// <h1>3. Features</h1>
        /// <list type="bullet">
        /// <item><description><para><b>Product subject information protection</b>: You can choose whether to translate text on the product subject. This helps protect subject information from being translated, avoiding translation of embedded information such as product names.</para>
        /// </description></item>
        /// <item><description><para><b>Brand name protection</b>: You can choose whether to translate brand names on images. This helps protect brand name information from being translated.</para>
        /// </description></item>
        /// <item><description><para><b>Secondary editing after translation (layer information)</b>: You can choose whether to return layer information such as text position, font, and color. This information can be used to integrate with image editors for secondary editing of translation results. For the release progress of the editor SDK package, follow platform notifications.</para>
        /// </description></item>
        /// <item><description><para><b>Translation intervention support</b>: You can customize translation results, including no translation (ABC-ABC), specified translation (ABC-DEF), and skip translation (ABC-empty value). This is commonly used for scenarios such as brand term protection. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs in different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.  </para>
        /// </description></item>
        /// <item><description><para><b>Image editor integration support</b>: For more information, see <a href="https://www.alibabacloud.com/help/en/document_detail/3042647.html">Image Translation editor protocol</a>.</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageTranslationStandardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageTranslationStandardResponse
        /// </returns>
        public async Task<ImageTranslationStandardResponse> ImageTranslationStandardWithOptionsAsync(ImageTranslationStandardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Glossary))
            {
                query["Glossary"] = request.Glossary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludingProductArea))
            {
                query["IncludingProductArea"] = request.IncludingProductArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                query["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                query["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslatingBrandInTheProduct))
            {
                query["TranslatingBrandInTheProduct"] = request.TranslatingBrandInTheProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseImageEditor))
            {
                query["UseImageEditor"] = request.UseImageEditor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageTranslationStandard",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageTranslationStandardResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Image Translation is designed specifically for e-commerce images. It supports more than 100 language directions (including bridging), accurately processes complex text layouts within images, and ensures that translated content matches the image content. This helps e-commerce platforms and developers easily achieve multilingual conversion and rendering of image content. The product also returns layer information such as text position, font, and color within images, making it easy to integrate with image editors for secondary editing of translation results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>Image Translation is designed specifically for e-commerce images. It supports more than 100 language directions (including bridging), accurately processes complex text layouts within images, and ensures that translated content matches the image content. This helps e-commerce platforms and developers easily achieve multilingual conversion and rendering of image content. The product also returns layer information such as text position, font, and color within images, making it easy to integrate with image editors for secondary editing of translation results.</para>
        /// <h1>2. Applicable scenarios</h1>
        /// <para>E-commerce product images, marketing images, and images for various other scenarios.</para>
        /// <h1>3. Features</h1>
        /// <list type="bullet">
        /// <item><description><para><b>Product subject information protection</b>: You can choose whether to translate text on the product subject. This helps protect subject information from being translated, avoiding translation of embedded information such as product names.</para>
        /// </description></item>
        /// <item><description><para><b>Brand name protection</b>: You can choose whether to translate brand names on images. This helps protect brand name information from being translated.</para>
        /// </description></item>
        /// <item><description><para><b>Secondary editing after translation (layer information)</b>: You can choose whether to return layer information such as text position, font, and color. This information can be used to integrate with image editors for secondary editing of translation results. For the release progress of the editor SDK package, follow platform notifications.</para>
        /// </description></item>
        /// <item><description><para><b>Translation intervention support</b>: You can customize translation results, including no translation (ABC-ABC), specified translation (ABC-DEF), and skip translation (ABC-empty value). This is commonly used for scenarios such as brand term protection. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs in different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.  </para>
        /// </description></item>
        /// <item><description><para><b>Image editor integration support</b>: For more information, see <a href="https://www.alibabacloud.com/help/en/document_detail/3042647.html">Image Translation editor protocol</a>.</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageTranslationStandardRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageTranslationStandardResponse
        /// </returns>
        public ImageTranslationStandardResponse ImageTranslationStandard(ImageTranslationStandardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImageTranslationStandardWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Image Translation is designed specifically for e-commerce images. It supports more than 100 language directions (including bridging), accurately processes complex text layouts within images, and ensures that translated content matches the image content. This helps e-commerce platforms and developers easily achieve multilingual conversion and rendering of image content. The product also returns layer information such as text position, font, and color within images, making it easy to integrate with image editors for secondary editing of translation results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>Image Translation is designed specifically for e-commerce images. It supports more than 100 language directions (including bridging), accurately processes complex text layouts within images, and ensures that translated content matches the image content. This helps e-commerce platforms and developers easily achieve multilingual conversion and rendering of image content. The product also returns layer information such as text position, font, and color within images, making it easy to integrate with image editors for secondary editing of translation results.</para>
        /// <h1>2. Applicable scenarios</h1>
        /// <para>E-commerce product images, marketing images, and images for various other scenarios.</para>
        /// <h1>3. Features</h1>
        /// <list type="bullet">
        /// <item><description><para><b>Product subject information protection</b>: You can choose whether to translate text on the product subject. This helps protect subject information from being translated, avoiding translation of embedded information such as product names.</para>
        /// </description></item>
        /// <item><description><para><b>Brand name protection</b>: You can choose whether to translate brand names on images. This helps protect brand name information from being translated.</para>
        /// </description></item>
        /// <item><description><para><b>Secondary editing after translation (layer information)</b>: You can choose whether to return layer information such as text position, font, and color. This information can be used to integrate with image editors for secondary editing of translation results. For the release progress of the editor SDK package, follow platform notifications.</para>
        /// </description></item>
        /// <item><description><para><b>Translation intervention support</b>: You can customize translation results, including no translation (ABC-ABC), specified translation (ABC-DEF), and skip translation (ABC-empty value). This is commonly used for scenarios such as brand term protection. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs in different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.  </para>
        /// </description></item>
        /// <item><description><para><b>Image editor integration support</b>: For more information, see <a href="https://www.alibabacloud.com/help/en/document_detail/3042647.html">Image Translation editor protocol</a>.</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageTranslationStandardRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageTranslationStandardResponse
        /// </returns>
        public async Task<ImageTranslationStandardResponse> ImageTranslationStandardAsync(ImageTranslationStandardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImageTranslationStandardWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Supports automatic language identification for 31 languages in query scenarios and 35 languages in general scenarios. Applicable to short text language identification such as search terms, titles, and conversations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Supports automatic language identification for 31 languages in query phrase scenarios and 35 languages in general scenarios. Applicable to short text language identification such as search terms, titles, and conversations. For supported language directions, refer to the <a href="https://www.alibabacloud.com/help/en/document_detail/3041883.html">Language Direction Mapping Table</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LanguageDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LanguageDetectResponse
        /// </returns>
        public LanguageDetectResponse LanguageDetectWithOptions(LanguageDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceText))
            {
                query["SourceText"] = request.SourceText;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LanguageDetect",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LanguageDetectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Supports automatic language identification for 31 languages in query scenarios and 35 languages in general scenarios. Applicable to short text language identification such as search terms, titles, and conversations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Supports automatic language identification for 31 languages in query phrase scenarios and 35 languages in general scenarios. Applicable to short text language identification such as search terms, titles, and conversations. For supported language directions, refer to the <a href="https://www.alibabacloud.com/help/en/document_detail/3041883.html">Language Direction Mapping Table</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LanguageDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LanguageDetectResponse
        /// </returns>
        public async Task<LanguageDetectResponse> LanguageDetectWithOptionsAsync(LanguageDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scene))
            {
                query["Scene"] = request.Scene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceText))
            {
                query["SourceText"] = request.SourceText;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LanguageDetect",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LanguageDetectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Supports automatic language identification for 31 languages in query scenarios and 35 languages in general scenarios. Applicable to short text language identification such as search terms, titles, and conversations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Supports automatic language identification for 31 languages in query phrase scenarios and 35 languages in general scenarios. Applicable to short text language identification such as search terms, titles, and conversations. For supported language directions, refer to the <a href="https://www.alibabacloud.com/help/en/document_detail/3041883.html">Language Direction Mapping Table</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LanguageDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// LanguageDetectResponse
        /// </returns>
        public LanguageDetectResponse LanguageDetect(LanguageDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LanguageDetectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Supports automatic language identification for 31 languages in query scenarios and 35 languages in general scenarios. Applicable to short text language identification such as search terms, titles, and conversations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Supports automatic language identification for 31 languages in query phrase scenarios and 35 languages in general scenarios. Applicable to short text language identification such as search terms, titles, and conversations. For supported language directions, refer to the <a href="https://www.alibabacloud.com/help/en/document_detail/3041883.html">Language Direction Mapping Table</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LanguageDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// LanguageDetectResponse
        /// </returns>
        public async Task<LanguageDetectResponse> LanguageDetectAsync(LanguageDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LanguageDetectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detects the compliance of marketing material displays in retail stores based on a multimodal large language model (MLLM). This API targets in-store marketing material inspection scenarios for offline retail and channel stores. It performs natural-language-level compliance checks on standard materials such as functional display cards, posters, and door-shaped display stands, as well as long-tail materials such as light cloth banners, KT boards, floor stickers, and light boxes in store photos, according to inspection rules. It outputs structured conclusions and Chinese-language evidence descriptions that can be directly integrated with business systems. This is a <b>synchronous</b> call that returns results in a single request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Scenarios</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>In-store marketing material compliance inspection</b>: Automatically determines whether marketing materials (functional display cards, posters, door-shaped display stands, etc.) are placed or posted according to the standard display guidelines issued by headquarters. Identifies typical issues such as &quot;not placed,&quot; &quot;placed incorrectly,&quot; or &quot;content mismatch.&quot;</para>
        /// </description></item>
        /// <item><description><para><b>New product/campaign material deployment verification</b>: During new product launches or sales promotions, automatically verifies in batch whether campaign materials in store photos have been deployed as required for listing, replacing manual spot checks.</para>
        /// </description></item>
        /// <item><description><para><b>Adaptive dual-image comparison and single-image detection</b>: The same API supports both &quot;reference image + target image&quot; dual-image comparison (Mode A) and &quot;target image only&quot; single-image detection (Mode B). The mode switches automatically based on whether <c>ImageRefer</c> is provided. Callers do not need to differentiate between invocation methods.</para>
        /// </description></item>
        /// </list>
        /// <h2><b>Features</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>Multi-mode intelligent routing</b>: Built-in material type parsing capability that automatically identifies the target material type based on <c>Rules</c> natural language text and routes to the corresponding material detection pipeline. Callers only need to provide image URLs and rule text. Currently, four detection routing pipelines are supported: &quot;functional display card,&quot; &quot;poster,&quot; &quot;door-shaped display stand,&quot; and &quot;other materials.&quot; Additional detection pipelines for specific marketing material types will be added over time.</para>
        /// </description></item>
        /// <item><description><para><b>MLLM semantic-level understanding + rule structuring collaboration</b>: Uses a multimodal large model for material recognition, content comparison, text OCR, and other semantic-level understanding tasks. Combined with rule cleaning and structuring models, natural language rules are decomposed into individually assessable steps (S1/S2...), ensuring accuracy while maintaining rule flexibility and traceability.</para>
        /// </description></item>
        /// <item><description><para><b>Structured audit conclusion output</b>: Output is unified into the <c>Result.OverallResult</c> + <c>Result.Steps[]</c> + <c>Result.Evidence</c> structure. The overall conclusion is derived from the logical AND of all steps. Each step is independently visible, facilitating direct integration with downstream business systems and supporting case-level manual review traceability.</para>
        /// </description></item>
        /// <item><description><para><b>Supported input formats</b>: Currently supports publicly accessible image URLs. Both single-image (Mode B) and dual-image (Mode A) calling modes are supported, with identical output structures.</para>
        /// </description></item>
        /// </list>
        /// <h2><b>Invocation method</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>Synchronous call</b>: A single request returns the detection result without polling. The response uses the unified envelope of <c>Code</c> / <c>Message</c> / <c>RequestId</c> / <c>Success</c> / <c>Data</c>.</para>
        /// </description></item>
        /// <item><description><para><b>Authentication and signing</b>: Invoked through the Aidge gateway. Authentication, signing, and common parameters follow the platform\&quot;s unified access method. Refer to the officially published API reference for the specific request path.</para>
        /// </description></item>
        /// <item><description><para><b>Timeout settings</b>: Set the request timeout to no less than the maximum response time of the API (refer to the official publication for the specific value).</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MaterialInspectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MaterialInspectionResponse
        /// </returns>
        public MaterialInspectionResponse MaterialInspectionWithOptions(MaterialInspectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiId))
            {
                query["ApiId"] = request.ApiId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRefer))
            {
                query["ImageRefer"] = request.ImageRefer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                query["Rules"] = request.Rules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MaterialInspection",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MaterialInspectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detects the compliance of marketing material displays in retail stores based on a multimodal large language model (MLLM). This API targets in-store marketing material inspection scenarios for offline retail and channel stores. It performs natural-language-level compliance checks on standard materials such as functional display cards, posters, and door-shaped display stands, as well as long-tail materials such as light cloth banners, KT boards, floor stickers, and light boxes in store photos, according to inspection rules. It outputs structured conclusions and Chinese-language evidence descriptions that can be directly integrated with business systems. This is a <b>synchronous</b> call that returns results in a single request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Scenarios</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>In-store marketing material compliance inspection</b>: Automatically determines whether marketing materials (functional display cards, posters, door-shaped display stands, etc.) are placed or posted according to the standard display guidelines issued by headquarters. Identifies typical issues such as &quot;not placed,&quot; &quot;placed incorrectly,&quot; or &quot;content mismatch.&quot;</para>
        /// </description></item>
        /// <item><description><para><b>New product/campaign material deployment verification</b>: During new product launches or sales promotions, automatically verifies in batch whether campaign materials in store photos have been deployed as required for listing, replacing manual spot checks.</para>
        /// </description></item>
        /// <item><description><para><b>Adaptive dual-image comparison and single-image detection</b>: The same API supports both &quot;reference image + target image&quot; dual-image comparison (Mode A) and &quot;target image only&quot; single-image detection (Mode B). The mode switches automatically based on whether <c>ImageRefer</c> is provided. Callers do not need to differentiate between invocation methods.</para>
        /// </description></item>
        /// </list>
        /// <h2><b>Features</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>Multi-mode intelligent routing</b>: Built-in material type parsing capability that automatically identifies the target material type based on <c>Rules</c> natural language text and routes to the corresponding material detection pipeline. Callers only need to provide image URLs and rule text. Currently, four detection routing pipelines are supported: &quot;functional display card,&quot; &quot;poster,&quot; &quot;door-shaped display stand,&quot; and &quot;other materials.&quot; Additional detection pipelines for specific marketing material types will be added over time.</para>
        /// </description></item>
        /// <item><description><para><b>MLLM semantic-level understanding + rule structuring collaboration</b>: Uses a multimodal large model for material recognition, content comparison, text OCR, and other semantic-level understanding tasks. Combined with rule cleaning and structuring models, natural language rules are decomposed into individually assessable steps (S1/S2...), ensuring accuracy while maintaining rule flexibility and traceability.</para>
        /// </description></item>
        /// <item><description><para><b>Structured audit conclusion output</b>: Output is unified into the <c>Result.OverallResult</c> + <c>Result.Steps[]</c> + <c>Result.Evidence</c> structure. The overall conclusion is derived from the logical AND of all steps. Each step is independently visible, facilitating direct integration with downstream business systems and supporting case-level manual review traceability.</para>
        /// </description></item>
        /// <item><description><para><b>Supported input formats</b>: Currently supports publicly accessible image URLs. Both single-image (Mode B) and dual-image (Mode A) calling modes are supported, with identical output structures.</para>
        /// </description></item>
        /// </list>
        /// <h2><b>Invocation method</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>Synchronous call</b>: A single request returns the detection result without polling. The response uses the unified envelope of <c>Code</c> / <c>Message</c> / <c>RequestId</c> / <c>Success</c> / <c>Data</c>.</para>
        /// </description></item>
        /// <item><description><para><b>Authentication and signing</b>: Invoked through the Aidge gateway. Authentication, signing, and common parameters follow the platform\&quot;s unified access method. Refer to the officially published API reference for the specific request path.</para>
        /// </description></item>
        /// <item><description><para><b>Timeout settings</b>: Set the request timeout to no less than the maximum response time of the API (refer to the official publication for the specific value).</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MaterialInspectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MaterialInspectionResponse
        /// </returns>
        public async Task<MaterialInspectionResponse> MaterialInspectionWithOptionsAsync(MaterialInspectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiId))
            {
                query["ApiId"] = request.ApiId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRefer))
            {
                query["ImageRefer"] = request.ImageRefer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                query["Rules"] = request.Rules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MaterialInspection",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MaterialInspectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detects the compliance of marketing material displays in retail stores based on a multimodal large language model (MLLM). This API targets in-store marketing material inspection scenarios for offline retail and channel stores. It performs natural-language-level compliance checks on standard materials such as functional display cards, posters, and door-shaped display stands, as well as long-tail materials such as light cloth banners, KT boards, floor stickers, and light boxes in store photos, according to inspection rules. It outputs structured conclusions and Chinese-language evidence descriptions that can be directly integrated with business systems. This is a <b>synchronous</b> call that returns results in a single request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Scenarios</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>In-store marketing material compliance inspection</b>: Automatically determines whether marketing materials (functional display cards, posters, door-shaped display stands, etc.) are placed or posted according to the standard display guidelines issued by headquarters. Identifies typical issues such as &quot;not placed,&quot; &quot;placed incorrectly,&quot; or &quot;content mismatch.&quot;</para>
        /// </description></item>
        /// <item><description><para><b>New product/campaign material deployment verification</b>: During new product launches or sales promotions, automatically verifies in batch whether campaign materials in store photos have been deployed as required for listing, replacing manual spot checks.</para>
        /// </description></item>
        /// <item><description><para><b>Adaptive dual-image comparison and single-image detection</b>: The same API supports both &quot;reference image + target image&quot; dual-image comparison (Mode A) and &quot;target image only&quot; single-image detection (Mode B). The mode switches automatically based on whether <c>ImageRefer</c> is provided. Callers do not need to differentiate between invocation methods.</para>
        /// </description></item>
        /// </list>
        /// <h2><b>Features</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>Multi-mode intelligent routing</b>: Built-in material type parsing capability that automatically identifies the target material type based on <c>Rules</c> natural language text and routes to the corresponding material detection pipeline. Callers only need to provide image URLs and rule text. Currently, four detection routing pipelines are supported: &quot;functional display card,&quot; &quot;poster,&quot; &quot;door-shaped display stand,&quot; and &quot;other materials.&quot; Additional detection pipelines for specific marketing material types will be added over time.</para>
        /// </description></item>
        /// <item><description><para><b>MLLM semantic-level understanding + rule structuring collaboration</b>: Uses a multimodal large model for material recognition, content comparison, text OCR, and other semantic-level understanding tasks. Combined with rule cleaning and structuring models, natural language rules are decomposed into individually assessable steps (S1/S2...), ensuring accuracy while maintaining rule flexibility and traceability.</para>
        /// </description></item>
        /// <item><description><para><b>Structured audit conclusion output</b>: Output is unified into the <c>Result.OverallResult</c> + <c>Result.Steps[]</c> + <c>Result.Evidence</c> structure. The overall conclusion is derived from the logical AND of all steps. Each step is independently visible, facilitating direct integration with downstream business systems and supporting case-level manual review traceability.</para>
        /// </description></item>
        /// <item><description><para><b>Supported input formats</b>: Currently supports publicly accessible image URLs. Both single-image (Mode B) and dual-image (Mode A) calling modes are supported, with identical output structures.</para>
        /// </description></item>
        /// </list>
        /// <h2><b>Invocation method</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>Synchronous call</b>: A single request returns the detection result without polling. The response uses the unified envelope of <c>Code</c> / <c>Message</c> / <c>RequestId</c> / <c>Success</c> / <c>Data</c>.</para>
        /// </description></item>
        /// <item><description><para><b>Authentication and signing</b>: Invoked through the Aidge gateway. Authentication, signing, and common parameters follow the platform\&quot;s unified access method. Refer to the officially published API reference for the specific request path.</para>
        /// </description></item>
        /// <item><description><para><b>Timeout settings</b>: Set the request timeout to no less than the maximum response time of the API (refer to the official publication for the specific value).</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MaterialInspectionRequest
        /// </param>
        /// 
        /// <returns>
        /// MaterialInspectionResponse
        /// </returns>
        public MaterialInspectionResponse MaterialInspection(MaterialInspectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MaterialInspectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detects the compliance of marketing material displays in retail stores based on a multimodal large language model (MLLM). This API targets in-store marketing material inspection scenarios for offline retail and channel stores. It performs natural-language-level compliance checks on standard materials such as functional display cards, posters, and door-shaped display stands, as well as long-tail materials such as light cloth banners, KT boards, floor stickers, and light boxes in store photos, according to inspection rules. It outputs structured conclusions and Chinese-language evidence descriptions that can be directly integrated with business systems. This is a <b>synchronous</b> call that returns results in a single request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Scenarios</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>In-store marketing material compliance inspection</b>: Automatically determines whether marketing materials (functional display cards, posters, door-shaped display stands, etc.) are placed or posted according to the standard display guidelines issued by headquarters. Identifies typical issues such as &quot;not placed,&quot; &quot;placed incorrectly,&quot; or &quot;content mismatch.&quot;</para>
        /// </description></item>
        /// <item><description><para><b>New product/campaign material deployment verification</b>: During new product launches or sales promotions, automatically verifies in batch whether campaign materials in store photos have been deployed as required for listing, replacing manual spot checks.</para>
        /// </description></item>
        /// <item><description><para><b>Adaptive dual-image comparison and single-image detection</b>: The same API supports both &quot;reference image + target image&quot; dual-image comparison (Mode A) and &quot;target image only&quot; single-image detection (Mode B). The mode switches automatically based on whether <c>ImageRefer</c> is provided. Callers do not need to differentiate between invocation methods.</para>
        /// </description></item>
        /// </list>
        /// <h2><b>Features</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>Multi-mode intelligent routing</b>: Built-in material type parsing capability that automatically identifies the target material type based on <c>Rules</c> natural language text and routes to the corresponding material detection pipeline. Callers only need to provide image URLs and rule text. Currently, four detection routing pipelines are supported: &quot;functional display card,&quot; &quot;poster,&quot; &quot;door-shaped display stand,&quot; and &quot;other materials.&quot; Additional detection pipelines for specific marketing material types will be added over time.</para>
        /// </description></item>
        /// <item><description><para><b>MLLM semantic-level understanding + rule structuring collaboration</b>: Uses a multimodal large model for material recognition, content comparison, text OCR, and other semantic-level understanding tasks. Combined with rule cleaning and structuring models, natural language rules are decomposed into individually assessable steps (S1/S2...), ensuring accuracy while maintaining rule flexibility and traceability.</para>
        /// </description></item>
        /// <item><description><para><b>Structured audit conclusion output</b>: Output is unified into the <c>Result.OverallResult</c> + <c>Result.Steps[]</c> + <c>Result.Evidence</c> structure. The overall conclusion is derived from the logical AND of all steps. Each step is independently visible, facilitating direct integration with downstream business systems and supporting case-level manual review traceability.</para>
        /// </description></item>
        /// <item><description><para><b>Supported input formats</b>: Currently supports publicly accessible image URLs. Both single-image (Mode B) and dual-image (Mode A) calling modes are supported, with identical output structures.</para>
        /// </description></item>
        /// </list>
        /// <h2><b>Invocation method</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>Synchronous call</b>: A single request returns the detection result without polling. The response uses the unified envelope of <c>Code</c> / <c>Message</c> / <c>RequestId</c> / <c>Success</c> / <c>Data</c>.</para>
        /// </description></item>
        /// <item><description><para><b>Authentication and signing</b>: Invoked through the Aidge gateway. Authentication, signing, and common parameters follow the platform\&quot;s unified access method. Refer to the officially published API reference for the specific request path.</para>
        /// </description></item>
        /// <item><description><para><b>Timeout settings</b>: Set the request timeout to no less than the maximum response time of the API (refer to the official publication for the specific value).</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MaterialInspectionRequest
        /// </param>
        /// 
        /// <returns>
        /// MaterialInspectionResponse
        /// </returns>
        public async Task<MaterialInspectionResponse> MaterialInspectionAsync(MaterialInspectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MaterialInspectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detects and identifies products displayed on store shelves or floor stacks by combining a multimodal large language model (MLLM) with visual vector recall, targeting shelf and floor-stack inspection scenarios in offline retail and channel stores. For photos of shelves or floor stacks taken in stores, the product first uses a multimodal large model to detect the bounding box and preliminary name of each product, then performs similarity recall against the customer\&quot;s dedicated SKU vector library to exactly match each product to the customer\&quot;s own SKUs. The output is per-product structured results that can be directly integrated with business systems. It is suitable for large-scale, high-concurrent visual recognition pipelines such as remote auditing of in-store displays by headquarters, SKU distribution verification, and display compliance inspection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Product Introduction</b></h2>
        /// <para>Display detection is an intelligent product display recognition capability built on a multimodal large language model (MLLM) combined with visual vector recall. It targets shelf and floor-stack inspection scenarios in offline retail and channel stores. For photos of shelves or floor stacks taken in stores, the product first uses a multimodal large model to detect the bounding box and preliminary name of each product, then performs similarity recall against the customer\&quot;s dedicated SKU vector library to exactly match each product to the customer\&quot;s own SKUs. The output is per-product structured results that can be directly integrated with business systems. It is suitable for large-scale, high-concurrent visual recognition pipelines such as remote auditing of in-store displays by headquarters, SKU distribution verification, and display compliance inspection.</para>
        /// <h2><b>Common scenarios</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>Shelf/floor-stack display recognition and inventory</b>: Identifies each product in a shelf or floor-stack image and matches it to the customer\&quot;s SKU library, outputting a per-product list (product name + position + similarity score) to replace manual counting.</para>
        /// </description></item>
        /// <item><description><para><b>Distribution verification/SKU compliance</b>: Verifies whether stores display specified SKUs as required by headquarters and whether out-of-stock or misplaced items exist, supporting batch automated verification during promotions or new product launches.</para>
        /// </description></item>
        /// <item><description><para><b>Customer-dedicated SKU library</b>: Customers upload their own SKU reference images to build a dedicated vector library (isolated by <c>RagId</c>). During recognition, retrieval is performed only within that customer\&quot;s library, ensuring name accuracy and data isolation between customers.</para>
        /// </description></item>
        /// </list>
        /// <h2><b>Functions and features</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>Two-stage detection + retrieval collaboration</b>: The multimodal large model detects each product bounding box and preliminary name on the full image (semantic-level understanding, adapted for dense displays and partial occlusion). Then visual embedding vectors perform similarity retrieval within the customer\&quot;s SKU library, overriding the preliminary name with the top-1 precise SKU name to balance recall rate and name accuracy.</para>
        /// </description></item>
        /// <item><description><para><b>Dedicated vector library with isolated retrieval</b>: A dedicated SKU vector library is maintained for each customer by <c>RagId</c>. Recognition retrieves only within the corresponding library with strict isolation between customers. Newly added or updated SKUs take effect in real time.</para>
        /// </description></item>
        /// <item><description><para><b>Per-product structured output</b>: Output is unified as <c>Result.Items[]</c>, with each product independently providing a bounding box, recalled SKU name, SKU code, and similarity score. This facilitates direct integration with downstream inventory/verification systems and supports case-level manual review and traceability.</para>
        /// </description></item>
        /// <item><description><para><b>Supported input formats</b>: Currently supports image URLs accessible over the public network or from OSS. A single shelf or floor-stack image is sufficient for recognition, and the output structure is consistent.</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MerchandisePlacementDetectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MerchandisePlacementDetectionResponse
        /// </returns>
        public MerchandisePlacementDetectionResponse MerchandisePlacementDetectionWithOptions(MerchandisePlacementDetectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiId))
            {
                query["ApiId"] = request.ApiId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RagId))
            {
                query["RagId"] = request.RagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MerchandisePlacementDetection",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MerchandisePlacementDetectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detects and identifies products displayed on store shelves or floor stacks by combining a multimodal large language model (MLLM) with visual vector recall, targeting shelf and floor-stack inspection scenarios in offline retail and channel stores. For photos of shelves or floor stacks taken in stores, the product first uses a multimodal large model to detect the bounding box and preliminary name of each product, then performs similarity recall against the customer\&quot;s dedicated SKU vector library to exactly match each product to the customer\&quot;s own SKUs. The output is per-product structured results that can be directly integrated with business systems. It is suitable for large-scale, high-concurrent visual recognition pipelines such as remote auditing of in-store displays by headquarters, SKU distribution verification, and display compliance inspection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Product Introduction</b></h2>
        /// <para>Display detection is an intelligent product display recognition capability built on a multimodal large language model (MLLM) combined with visual vector recall. It targets shelf and floor-stack inspection scenarios in offline retail and channel stores. For photos of shelves or floor stacks taken in stores, the product first uses a multimodal large model to detect the bounding box and preliminary name of each product, then performs similarity recall against the customer\&quot;s dedicated SKU vector library to exactly match each product to the customer\&quot;s own SKUs. The output is per-product structured results that can be directly integrated with business systems. It is suitable for large-scale, high-concurrent visual recognition pipelines such as remote auditing of in-store displays by headquarters, SKU distribution verification, and display compliance inspection.</para>
        /// <h2><b>Common scenarios</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>Shelf/floor-stack display recognition and inventory</b>: Identifies each product in a shelf or floor-stack image and matches it to the customer\&quot;s SKU library, outputting a per-product list (product name + position + similarity score) to replace manual counting.</para>
        /// </description></item>
        /// <item><description><para><b>Distribution verification/SKU compliance</b>: Verifies whether stores display specified SKUs as required by headquarters and whether out-of-stock or misplaced items exist, supporting batch automated verification during promotions or new product launches.</para>
        /// </description></item>
        /// <item><description><para><b>Customer-dedicated SKU library</b>: Customers upload their own SKU reference images to build a dedicated vector library (isolated by <c>RagId</c>). During recognition, retrieval is performed only within that customer\&quot;s library, ensuring name accuracy and data isolation between customers.</para>
        /// </description></item>
        /// </list>
        /// <h2><b>Functions and features</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>Two-stage detection + retrieval collaboration</b>: The multimodal large model detects each product bounding box and preliminary name on the full image (semantic-level understanding, adapted for dense displays and partial occlusion). Then visual embedding vectors perform similarity retrieval within the customer\&quot;s SKU library, overriding the preliminary name with the top-1 precise SKU name to balance recall rate and name accuracy.</para>
        /// </description></item>
        /// <item><description><para><b>Dedicated vector library with isolated retrieval</b>: A dedicated SKU vector library is maintained for each customer by <c>RagId</c>. Recognition retrieves only within the corresponding library with strict isolation between customers. Newly added or updated SKUs take effect in real time.</para>
        /// </description></item>
        /// <item><description><para><b>Per-product structured output</b>: Output is unified as <c>Result.Items[]</c>, with each product independently providing a bounding box, recalled SKU name, SKU code, and similarity score. This facilitates direct integration with downstream inventory/verification systems and supports case-level manual review and traceability.</para>
        /// </description></item>
        /// <item><description><para><b>Supported input formats</b>: Currently supports image URLs accessible over the public network or from OSS. A single shelf or floor-stack image is sufficient for recognition, and the output structure is consistent.</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MerchandisePlacementDetectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MerchandisePlacementDetectionResponse
        /// </returns>
        public async Task<MerchandisePlacementDetectionResponse> MerchandisePlacementDetectionWithOptionsAsync(MerchandisePlacementDetectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiId))
            {
                query["ApiId"] = request.ApiId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RagId))
            {
                query["RagId"] = request.RagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MerchandisePlacementDetection",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MerchandisePlacementDetectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detects and identifies products displayed on store shelves or floor stacks by combining a multimodal large language model (MLLM) with visual vector recall, targeting shelf and floor-stack inspection scenarios in offline retail and channel stores. For photos of shelves or floor stacks taken in stores, the product first uses a multimodal large model to detect the bounding box and preliminary name of each product, then performs similarity recall against the customer\&quot;s dedicated SKU vector library to exactly match each product to the customer\&quot;s own SKUs. The output is per-product structured results that can be directly integrated with business systems. It is suitable for large-scale, high-concurrent visual recognition pipelines such as remote auditing of in-store displays by headquarters, SKU distribution verification, and display compliance inspection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Product Introduction</b></h2>
        /// <para>Display detection is an intelligent product display recognition capability built on a multimodal large language model (MLLM) combined with visual vector recall. It targets shelf and floor-stack inspection scenarios in offline retail and channel stores. For photos of shelves or floor stacks taken in stores, the product first uses a multimodal large model to detect the bounding box and preliminary name of each product, then performs similarity recall against the customer\&quot;s dedicated SKU vector library to exactly match each product to the customer\&quot;s own SKUs. The output is per-product structured results that can be directly integrated with business systems. It is suitable for large-scale, high-concurrent visual recognition pipelines such as remote auditing of in-store displays by headquarters, SKU distribution verification, and display compliance inspection.</para>
        /// <h2><b>Common scenarios</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>Shelf/floor-stack display recognition and inventory</b>: Identifies each product in a shelf or floor-stack image and matches it to the customer\&quot;s SKU library, outputting a per-product list (product name + position + similarity score) to replace manual counting.</para>
        /// </description></item>
        /// <item><description><para><b>Distribution verification/SKU compliance</b>: Verifies whether stores display specified SKUs as required by headquarters and whether out-of-stock or misplaced items exist, supporting batch automated verification during promotions or new product launches.</para>
        /// </description></item>
        /// <item><description><para><b>Customer-dedicated SKU library</b>: Customers upload their own SKU reference images to build a dedicated vector library (isolated by <c>RagId</c>). During recognition, retrieval is performed only within that customer\&quot;s library, ensuring name accuracy and data isolation between customers.</para>
        /// </description></item>
        /// </list>
        /// <h2><b>Functions and features</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>Two-stage detection + retrieval collaboration</b>: The multimodal large model detects each product bounding box and preliminary name on the full image (semantic-level understanding, adapted for dense displays and partial occlusion). Then visual embedding vectors perform similarity retrieval within the customer\&quot;s SKU library, overriding the preliminary name with the top-1 precise SKU name to balance recall rate and name accuracy.</para>
        /// </description></item>
        /// <item><description><para><b>Dedicated vector library with isolated retrieval</b>: A dedicated SKU vector library is maintained for each customer by <c>RagId</c>. Recognition retrieves only within the corresponding library with strict isolation between customers. Newly added or updated SKUs take effect in real time.</para>
        /// </description></item>
        /// <item><description><para><b>Per-product structured output</b>: Output is unified as <c>Result.Items[]</c>, with each product independently providing a bounding box, recalled SKU name, SKU code, and similarity score. This facilitates direct integration with downstream inventory/verification systems and supports case-level manual review and traceability.</para>
        /// </description></item>
        /// <item><description><para><b>Supported input formats</b>: Currently supports image URLs accessible over the public network or from OSS. A single shelf or floor-stack image is sufficient for recognition, and the output structure is consistent.</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MerchandisePlacementDetectionRequest
        /// </param>
        /// 
        /// <returns>
        /// MerchandisePlacementDetectionResponse
        /// </returns>
        public MerchandisePlacementDetectionResponse MerchandisePlacementDetection(MerchandisePlacementDetectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MerchandisePlacementDetectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detects and identifies products displayed on store shelves or floor stacks by combining a multimodal large language model (MLLM) with visual vector recall, targeting shelf and floor-stack inspection scenarios in offline retail and channel stores. For photos of shelves or floor stacks taken in stores, the product first uses a multimodal large model to detect the bounding box and preliminary name of each product, then performs similarity recall against the customer\&quot;s dedicated SKU vector library to exactly match each product to the customer\&quot;s own SKUs. The output is per-product structured results that can be directly integrated with business systems. It is suitable for large-scale, high-concurrent visual recognition pipelines such as remote auditing of in-store displays by headquarters, SKU distribution verification, and display compliance inspection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><b>Product Introduction</b></h2>
        /// <para>Display detection is an intelligent product display recognition capability built on a multimodal large language model (MLLM) combined with visual vector recall. It targets shelf and floor-stack inspection scenarios in offline retail and channel stores. For photos of shelves or floor stacks taken in stores, the product first uses a multimodal large model to detect the bounding box and preliminary name of each product, then performs similarity recall against the customer\&quot;s dedicated SKU vector library to exactly match each product to the customer\&quot;s own SKUs. The output is per-product structured results that can be directly integrated with business systems. It is suitable for large-scale, high-concurrent visual recognition pipelines such as remote auditing of in-store displays by headquarters, SKU distribution verification, and display compliance inspection.</para>
        /// <h2><b>Common scenarios</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>Shelf/floor-stack display recognition and inventory</b>: Identifies each product in a shelf or floor-stack image and matches it to the customer\&quot;s SKU library, outputting a per-product list (product name + position + similarity score) to replace manual counting.</para>
        /// </description></item>
        /// <item><description><para><b>Distribution verification/SKU compliance</b>: Verifies whether stores display specified SKUs as required by headquarters and whether out-of-stock or misplaced items exist, supporting batch automated verification during promotions or new product launches.</para>
        /// </description></item>
        /// <item><description><para><b>Customer-dedicated SKU library</b>: Customers upload their own SKU reference images to build a dedicated vector library (isolated by <c>RagId</c>). During recognition, retrieval is performed only within that customer\&quot;s library, ensuring name accuracy and data isolation between customers.</para>
        /// </description></item>
        /// </list>
        /// <h2><b>Functions and features</b></h2>
        /// <list type="bullet">
        /// <item><description><para><b>Two-stage detection + retrieval collaboration</b>: The multimodal large model detects each product bounding box and preliminary name on the full image (semantic-level understanding, adapted for dense displays and partial occlusion). Then visual embedding vectors perform similarity retrieval within the customer\&quot;s SKU library, overriding the preliminary name with the top-1 precise SKU name to balance recall rate and name accuracy.</para>
        /// </description></item>
        /// <item><description><para><b>Dedicated vector library with isolated retrieval</b>: A dedicated SKU vector library is maintained for each customer by <c>RagId</c>. Recognition retrieves only within the corresponding library with strict isolation between customers. Newly added or updated SKUs take effect in real time.</para>
        /// </description></item>
        /// <item><description><para><b>Per-product structured output</b>: Output is unified as <c>Result.Items[]</c>, with each product independently providing a bounding box, recalled SKU name, SKU code, and similarity score. This facilitates direct integration with downstream inventory/verification systems and supports case-level manual review and traceability.</para>
        /// </description></item>
        /// <item><description><para><b>Supported input formats</b>: Currently supports image URLs accessible over the public network or from OSS. A single shelf or floor-stack image is sufficient for recognition, and the output structure is consistent.</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MerchandisePlacementDetectionRequest
        /// </param>
        /// 
        /// <returns>
        /// MerchandisePlacementDetectionResponse
        /// </returns>
        public async Task<MerchandisePlacementDetectionResponse> MerchandisePlacementDetectionAsync(MerchandisePlacementDetectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MerchandisePlacementDetectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An intelligent logistics parcel review product built on the collaboration of a multimodal large language model (MLLM) and dedicated vision algorithms, designed for automated compliance review in the &quot;piece-weight-dimension&quot; stage of e-commerce logistics. The product performs structured review across multiple dimensions including bounding box validity, bounding box fit accuracy, and foreign object interference for parcels on scanning platforms. It adapts to different hardware capture scenarios such as white and green background boards, and outputs Boolean review conclusions with Chinese reason descriptions that can directly interface with business systems. It is suitable for large-scale, high-concurrency inbound quality inspection pipelines.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>An intelligent logistics parcel review product built on the collaboration of a multimodal large language model (MLLM) and dedicated vision algorithms, designed for automated compliance review in the &quot;piece-weight-dimension&quot; stage of e-commerce logistics. The product performs structured review across multiple dimensions including <b>bounding box validity, bounding box fit accuracy, and foreign object interference</b> for parcels on scanning platforms. It adapts to different hardware capture scenarios such as white and green background boards, and outputs Boolean review conclusions with Chinese reason descriptions that can directly interface with business systems. It is suitable for large-scale, high-concurrency inbound quality inspection pipelines.</para>
        /// <h2>Scenarios</h2>
        /// <ol>
        /// <item><description><b>Parcel bounding box review</b>: Automatically determines whether the operator\&quot;s manual bounding box constitutes the &quot;minimum effective border rectangle&quot; for the parcel, identifying typical issues such as oversized or undersized bounding boxes.</description></item>
        /// <item><description><b>Foreign object interference detection</b>: Automatically identifies whether non-target objects such as fingers, keyboards, or supporting tools are present in the scanning area.</description></item>
        /// <item><description><b>Multi-capture environment adaptation</b>: A single API handles both white background board (blue frame) and green background board (blue frame + red frame) capture patterns without requiring the caller to distinguish between scenarios.</description></item>
        /// <item><description><b>Inbound quality inspection pipeline</b>: Used for automated compliance review in the piece-weight-dimension stage of the logistics warehouse new product inbound SOP, as a replacement for or supplement to manual outsourced review.
        /// The product is also applicable to general image &quot;frame-subject&quot; relationship review scenarios, such as product photography material review and document scanning quality verification.</description></item>
        /// </ol>
        /// <h2>Features</h2>
        /// <ol>
        /// <item><description><b>Multi-scenario intelligent routing</b>: The product has built-in scenario classification capabilities that automatically identify the background type (white/green) and bounding box type (none/single frame/double frame) in images, and route requests to the corresponding review sub-process. Callers only need to pass in the image URL without manually specifying the scenario.</description></item>
        /// <item><description><b>MLLM + dedicated CV model collaboration</b>: Uses a multimodal large language model for semantic-level scene understanding and foreign object recognition, and uses dedicated parcel segmentation and IoU evaluation models for pixel-level bounding box fit quantification, ensuring accuracy while controlling inference latency and cost.</description></item>
        /// <item><description><b>Structured review conclusions</b>: Output is unified as <c>result</c> (Boolean) + <c>info</c> (Chinese reason) structure. Supported reason types include &quot;Review passed&quot;, &quot;Review failed: bounding box too large&quot;, &quot;Review failed: bounding box too small&quot;, &quot;Review failed: foreign object detected&quot;, and others, enabling direct integration with downstream business systems.</description></item>
        /// <item><description><b>Supported input formats</b>: Currently supports publicly accessible image URLs.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// PackageWeightSizeCheckRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PackageWeightSizeCheckResponse
        /// </returns>
        public PackageWeightSizeCheckResponse PackageWeightSizeCheckWithOptions(PackageWeightSizeCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotatedImageUrl))
            {
                query["AnnotatedImageUrl"] = request.AnnotatedImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RawImageUrl))
            {
                query["RawImageUrl"] = request.RawImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PackageWeightSizeCheck",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PackageWeightSizeCheckResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An intelligent logistics parcel review product built on the collaboration of a multimodal large language model (MLLM) and dedicated vision algorithms, designed for automated compliance review in the &quot;piece-weight-dimension&quot; stage of e-commerce logistics. The product performs structured review across multiple dimensions including bounding box validity, bounding box fit accuracy, and foreign object interference for parcels on scanning platforms. It adapts to different hardware capture scenarios such as white and green background boards, and outputs Boolean review conclusions with Chinese reason descriptions that can directly interface with business systems. It is suitable for large-scale, high-concurrency inbound quality inspection pipelines.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>An intelligent logistics parcel review product built on the collaboration of a multimodal large language model (MLLM) and dedicated vision algorithms, designed for automated compliance review in the &quot;piece-weight-dimension&quot; stage of e-commerce logistics. The product performs structured review across multiple dimensions including <b>bounding box validity, bounding box fit accuracy, and foreign object interference</b> for parcels on scanning platforms. It adapts to different hardware capture scenarios such as white and green background boards, and outputs Boolean review conclusions with Chinese reason descriptions that can directly interface with business systems. It is suitable for large-scale, high-concurrency inbound quality inspection pipelines.</para>
        /// <h2>Scenarios</h2>
        /// <ol>
        /// <item><description><b>Parcel bounding box review</b>: Automatically determines whether the operator\&quot;s manual bounding box constitutes the &quot;minimum effective border rectangle&quot; for the parcel, identifying typical issues such as oversized or undersized bounding boxes.</description></item>
        /// <item><description><b>Foreign object interference detection</b>: Automatically identifies whether non-target objects such as fingers, keyboards, or supporting tools are present in the scanning area.</description></item>
        /// <item><description><b>Multi-capture environment adaptation</b>: A single API handles both white background board (blue frame) and green background board (blue frame + red frame) capture patterns without requiring the caller to distinguish between scenarios.</description></item>
        /// <item><description><b>Inbound quality inspection pipeline</b>: Used for automated compliance review in the piece-weight-dimension stage of the logistics warehouse new product inbound SOP, as a replacement for or supplement to manual outsourced review.
        /// The product is also applicable to general image &quot;frame-subject&quot; relationship review scenarios, such as product photography material review and document scanning quality verification.</description></item>
        /// </ol>
        /// <h2>Features</h2>
        /// <ol>
        /// <item><description><b>Multi-scenario intelligent routing</b>: The product has built-in scenario classification capabilities that automatically identify the background type (white/green) and bounding box type (none/single frame/double frame) in images, and route requests to the corresponding review sub-process. Callers only need to pass in the image URL without manually specifying the scenario.</description></item>
        /// <item><description><b>MLLM + dedicated CV model collaboration</b>: Uses a multimodal large language model for semantic-level scene understanding and foreign object recognition, and uses dedicated parcel segmentation and IoU evaluation models for pixel-level bounding box fit quantification, ensuring accuracy while controlling inference latency and cost.</description></item>
        /// <item><description><b>Structured review conclusions</b>: Output is unified as <c>result</c> (Boolean) + <c>info</c> (Chinese reason) structure. Supported reason types include &quot;Review passed&quot;, &quot;Review failed: bounding box too large&quot;, &quot;Review failed: bounding box too small&quot;, &quot;Review failed: foreign object detected&quot;, and others, enabling direct integration with downstream business systems.</description></item>
        /// <item><description><b>Supported input formats</b>: Currently supports publicly accessible image URLs.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// PackageWeightSizeCheckRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PackageWeightSizeCheckResponse
        /// </returns>
        public async Task<PackageWeightSizeCheckResponse> PackageWeightSizeCheckWithOptionsAsync(PackageWeightSizeCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotatedImageUrl))
            {
                query["AnnotatedImageUrl"] = request.AnnotatedImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RawImageUrl))
            {
                query["RawImageUrl"] = request.RawImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PackageWeightSizeCheck",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PackageWeightSizeCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An intelligent logistics parcel review product built on the collaboration of a multimodal large language model (MLLM) and dedicated vision algorithms, designed for automated compliance review in the &quot;piece-weight-dimension&quot; stage of e-commerce logistics. The product performs structured review across multiple dimensions including bounding box validity, bounding box fit accuracy, and foreign object interference for parcels on scanning platforms. It adapts to different hardware capture scenarios such as white and green background boards, and outputs Boolean review conclusions with Chinese reason descriptions that can directly interface with business systems. It is suitable for large-scale, high-concurrency inbound quality inspection pipelines.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>An intelligent logistics parcel review product built on the collaboration of a multimodal large language model (MLLM) and dedicated vision algorithms, designed for automated compliance review in the &quot;piece-weight-dimension&quot; stage of e-commerce logistics. The product performs structured review across multiple dimensions including <b>bounding box validity, bounding box fit accuracy, and foreign object interference</b> for parcels on scanning platforms. It adapts to different hardware capture scenarios such as white and green background boards, and outputs Boolean review conclusions with Chinese reason descriptions that can directly interface with business systems. It is suitable for large-scale, high-concurrency inbound quality inspection pipelines.</para>
        /// <h2>Scenarios</h2>
        /// <ol>
        /// <item><description><b>Parcel bounding box review</b>: Automatically determines whether the operator\&quot;s manual bounding box constitutes the &quot;minimum effective border rectangle&quot; for the parcel, identifying typical issues such as oversized or undersized bounding boxes.</description></item>
        /// <item><description><b>Foreign object interference detection</b>: Automatically identifies whether non-target objects such as fingers, keyboards, or supporting tools are present in the scanning area.</description></item>
        /// <item><description><b>Multi-capture environment adaptation</b>: A single API handles both white background board (blue frame) and green background board (blue frame + red frame) capture patterns without requiring the caller to distinguish between scenarios.</description></item>
        /// <item><description><b>Inbound quality inspection pipeline</b>: Used for automated compliance review in the piece-weight-dimension stage of the logistics warehouse new product inbound SOP, as a replacement for or supplement to manual outsourced review.
        /// The product is also applicable to general image &quot;frame-subject&quot; relationship review scenarios, such as product photography material review and document scanning quality verification.</description></item>
        /// </ol>
        /// <h2>Features</h2>
        /// <ol>
        /// <item><description><b>Multi-scenario intelligent routing</b>: The product has built-in scenario classification capabilities that automatically identify the background type (white/green) and bounding box type (none/single frame/double frame) in images, and route requests to the corresponding review sub-process. Callers only need to pass in the image URL without manually specifying the scenario.</description></item>
        /// <item><description><b>MLLM + dedicated CV model collaboration</b>: Uses a multimodal large language model for semantic-level scene understanding and foreign object recognition, and uses dedicated parcel segmentation and IoU evaluation models for pixel-level bounding box fit quantification, ensuring accuracy while controlling inference latency and cost.</description></item>
        /// <item><description><b>Structured review conclusions</b>: Output is unified as <c>result</c> (Boolean) + <c>info</c> (Chinese reason) structure. Supported reason types include &quot;Review passed&quot;, &quot;Review failed: bounding box too large&quot;, &quot;Review failed: bounding box too small&quot;, &quot;Review failed: foreign object detected&quot;, and others, enabling direct integration with downstream business systems.</description></item>
        /// <item><description><b>Supported input formats</b>: Currently supports publicly accessible image URLs.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// PackageWeightSizeCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// PackageWeightSizeCheckResponse
        /// </returns>
        public PackageWeightSizeCheckResponse PackageWeightSizeCheck(PackageWeightSizeCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PackageWeightSizeCheckWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An intelligent logistics parcel review product built on the collaboration of a multimodal large language model (MLLM) and dedicated vision algorithms, designed for automated compliance review in the &quot;piece-weight-dimension&quot; stage of e-commerce logistics. The product performs structured review across multiple dimensions including bounding box validity, bounding box fit accuracy, and foreign object interference for parcels on scanning platforms. It adapts to different hardware capture scenarios such as white and green background boards, and outputs Boolean review conclusions with Chinese reason descriptions that can directly interface with business systems. It is suitable for large-scale, high-concurrency inbound quality inspection pipelines.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>An intelligent logistics parcel review product built on the collaboration of a multimodal large language model (MLLM) and dedicated vision algorithms, designed for automated compliance review in the &quot;piece-weight-dimension&quot; stage of e-commerce logistics. The product performs structured review across multiple dimensions including <b>bounding box validity, bounding box fit accuracy, and foreign object interference</b> for parcels on scanning platforms. It adapts to different hardware capture scenarios such as white and green background boards, and outputs Boolean review conclusions with Chinese reason descriptions that can directly interface with business systems. It is suitable for large-scale, high-concurrency inbound quality inspection pipelines.</para>
        /// <h2>Scenarios</h2>
        /// <ol>
        /// <item><description><b>Parcel bounding box review</b>: Automatically determines whether the operator\&quot;s manual bounding box constitutes the &quot;minimum effective border rectangle&quot; for the parcel, identifying typical issues such as oversized or undersized bounding boxes.</description></item>
        /// <item><description><b>Foreign object interference detection</b>: Automatically identifies whether non-target objects such as fingers, keyboards, or supporting tools are present in the scanning area.</description></item>
        /// <item><description><b>Multi-capture environment adaptation</b>: A single API handles both white background board (blue frame) and green background board (blue frame + red frame) capture patterns without requiring the caller to distinguish between scenarios.</description></item>
        /// <item><description><b>Inbound quality inspection pipeline</b>: Used for automated compliance review in the piece-weight-dimension stage of the logistics warehouse new product inbound SOP, as a replacement for or supplement to manual outsourced review.
        /// The product is also applicable to general image &quot;frame-subject&quot; relationship review scenarios, such as product photography material review and document scanning quality verification.</description></item>
        /// </ol>
        /// <h2>Features</h2>
        /// <ol>
        /// <item><description><b>Multi-scenario intelligent routing</b>: The product has built-in scenario classification capabilities that automatically identify the background type (white/green) and bounding box type (none/single frame/double frame) in images, and route requests to the corresponding review sub-process. Callers only need to pass in the image URL without manually specifying the scenario.</description></item>
        /// <item><description><b>MLLM + dedicated CV model collaboration</b>: Uses a multimodal large language model for semantic-level scene understanding and foreign object recognition, and uses dedicated parcel segmentation and IoU evaluation models for pixel-level bounding box fit quantification, ensuring accuracy while controlling inference latency and cost.</description></item>
        /// <item><description><b>Structured review conclusions</b>: Output is unified as <c>result</c> (Boolean) + <c>info</c> (Chinese reason) structure. Supported reason types include &quot;Review passed&quot;, &quot;Review failed: bounding box too large&quot;, &quot;Review failed: bounding box too small&quot;, &quot;Review failed: foreign object detected&quot;, and others, enabling direct integration with downstream business systems.</description></item>
        /// <item><description><b>Supported input formats</b>: Currently supports publicly accessible image URLs.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// PackageWeightSizeCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// PackageWeightSizeCheckResponse
        /// </returns>
        public async Task<PackageWeightSizeCheckResponse> PackageWeightSizeCheckAsync(PackageWeightSizeCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PackageWeightSizeCheckWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs, continuously optimized for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports translation between more than 100 language pairs (including bridged translations), especially Chinese-English, Chinese-multilingual, and English-multilingual translations. It supports language detection for 24 language directions. If you do not specify the source language, automatic detection is performed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion\+ high-quality bilingual sentence pairs, continuously optimized for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports translation between more than 100 language pairs (including bridged translations), especially Chinese-English, Chinese-multilingual, and English-multilingual translations. It supports language detection for 24 language directions. If you do not specify the source language, automatic detection is performed.</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description>Product titles: Marco MT large model translation accurately translates phrases, keywords, and trending words in product titles into the target language, improving product visibility on e-commerce platforms.</description></item>
        /// <item><description>Product descriptions: Product descriptions are typically long with diverse and complex formatting. Marco large model translation supports long text translation and HTML format, delivering excellent translation quality and format preservation.</description></item>
        /// <item><description>Product attributes: Product attribute terms are short and may contain e-commerce-specific terms such as model numbers and parameters.</description></item>
        /// <item><description>Customer service conversations: In customer service scenarios, the model optimizes issues such as missing context and typos, and supports polite expressions for certain language directions.
        /// Marco MT large model translation can also be used for general-purpose translation scenarios such as office work, meetings, and daily conversations.</description></item>
        /// </list>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>Supported language directions</b> Marco MT large model translation supports translation between more than 100 languages and language detection for 23 languages. For specific language directions, refer to the language mapping table in Section 5.6.</description></item>
        /// <item><description><b>Ultra-low hallucination rate and high-speed inference</b> Marco MT large model translation is a large language model with preference alignment for translation scenarios. Compared with general-purpose large language models, it offers faster translation inference speed and an extremely low hallucination rate, making it especially suitable for large-scale invocation scenarios.</description></item>
        /// <item><description><b>Supported text format types</b> Currently supports text and html text types.</description></item>
        /// <item><description><b>Translation intervention support</b> Supports custom translation results, including do-not-translate (ABC-ABC), specified translation (ABC-DEF), and no translation (ABC-empty value). This is commonly used for brand name protection scenarios. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</description></item>
        /// </list>
        /// <h2>Translation quality comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Source text</b></th>
        /// <th><b>Aidge translation</b></th>
        /// <th><b>Other translation product 1</b></th>
        /// <th><b>Other translation product 2</b></th>
        /// <th><b>Aidge translation advantage</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>75mm 4Pin 0.38A GA81S2U 12V GTX 960 Cooling Fan for Zotac GTX960 Graphics Card Cooling Fan</td>
        /// <td>75mm 4Pin 0.38A GA81S2U 12V GTX 960, ventilador de enfriamiento para tarjeta gráfica Zotac GTX960.</td>
        /// <td>Ventilador de refrigeración de 75mm 4Pin 0.38A GA81S2U 12V para la tarjeta gráfica Zotac GTX960 Ventilador de enfriamiento GTX 960.</td>
        /// <td>Ventilador de refrigeración para tarjeta gráfica Zotac GTX960, 75mm, 4 pines, 0,38A, GA81S2U, 12V, GTX 960</td>
        /// <td>Clearer product subject</td>
        /// </tr>
        /// <tr>
        /// <td>New Arrival Classic Style Luxury Brand 6 Hands Swiss Automatic Mechanical Men\&quot;s Business Steel Watch</td>
        /// <td>Nueva llegada, reloj mecánico automático de lujo con 6 manecillas, estilo clásico, de acero para hombres de negocios</td>
        /// <td>Nueva Llegada Reloj De Acero de Negocios para Hombre con Mecanismo Automático Suizo y 6 Agujas de Estilo Clásico de Marca de Lujo.</td>
        /// <td>Reloj de acero de negocios para hombre, mecánico automático suizo, marca de lujo, estilo clásico, 6 manos, nueva llegada</td>
        /// <td>More complete sentence structure, clearer expression, and more reasonable segmentation</td>
        /// </tr>
        /// <tr>
        /// <td>Men Key Bag Genuine Cow Leather Buckets Key Cases Pouch Zipper Keychain Auto Car Key Case Women Home Key Holder Wallet</td>
        /// <td>Sac à clés pour hommes en cuir de vache véritable, étuis à clés, pochette à fermeture éclair, porte-clés, étui à clé de voiture, porte-clés pour femmes, organisateur de portefeuille</td>
        /// <td>Porte-clés sac en cuir de vache véritable, étuis à clés en forme de seau, pochette à fermeture éclair, porte-clés auto pour voiture, étui à clés pour femmes, organisateur de clés de maison, portefeuille.</td>
        /// <td>Hommes porte-clés en cuir de vache véritable sac/pochette fermature éclair porte-clés Auto voiture porte-clés femmes maison porte-clés organisateur portefeuille</td>
        /// <td>Clearer and more precise product subject expression. The translation correctly identifies &quot;key bag&quot; rather than &quot;keychain&quot;, avoiding ambiguity about the product type</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// PrepaidTextTranslateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PrepaidTextTranslateResponse
        /// </returns>
        public PrepaidTextTranslateResponse PrepaidTextTranslateWithOptions(PrepaidTextTranslateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PrepaidTextTranslateShrinkRequest request = new PrepaidTextTranslateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceTextList))
            {
                request.SourceTextListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceTextList, "SourceTextList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatType))
            {
                body["FormatType"] = request.FormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Glossary))
            {
                body["Glossary"] = request.Glossary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                body["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTextListShrink))
            {
                body["SourceTextList"] = request.SourceTextListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                body["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslateScene))
            {
                body["TranslateScene"] = request.TranslateScene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PrepaidTextTranslate",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PrepaidTextTranslateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs, continuously optimized for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports translation between more than 100 language pairs (including bridged translations), especially Chinese-English, Chinese-multilingual, and English-multilingual translations. It supports language detection for 24 language directions. If you do not specify the source language, automatic detection is performed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion\+ high-quality bilingual sentence pairs, continuously optimized for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports translation between more than 100 language pairs (including bridged translations), especially Chinese-English, Chinese-multilingual, and English-multilingual translations. It supports language detection for 24 language directions. If you do not specify the source language, automatic detection is performed.</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description>Product titles: Marco MT large model translation accurately translates phrases, keywords, and trending words in product titles into the target language, improving product visibility on e-commerce platforms.</description></item>
        /// <item><description>Product descriptions: Product descriptions are typically long with diverse and complex formatting. Marco large model translation supports long text translation and HTML format, delivering excellent translation quality and format preservation.</description></item>
        /// <item><description>Product attributes: Product attribute terms are short and may contain e-commerce-specific terms such as model numbers and parameters.</description></item>
        /// <item><description>Customer service conversations: In customer service scenarios, the model optimizes issues such as missing context and typos, and supports polite expressions for certain language directions.
        /// Marco MT large model translation can also be used for general-purpose translation scenarios such as office work, meetings, and daily conversations.</description></item>
        /// </list>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>Supported language directions</b> Marco MT large model translation supports translation between more than 100 languages and language detection for 23 languages. For specific language directions, refer to the language mapping table in Section 5.6.</description></item>
        /// <item><description><b>Ultra-low hallucination rate and high-speed inference</b> Marco MT large model translation is a large language model with preference alignment for translation scenarios. Compared with general-purpose large language models, it offers faster translation inference speed and an extremely low hallucination rate, making it especially suitable for large-scale invocation scenarios.</description></item>
        /// <item><description><b>Supported text format types</b> Currently supports text and html text types.</description></item>
        /// <item><description><b>Translation intervention support</b> Supports custom translation results, including do-not-translate (ABC-ABC), specified translation (ABC-DEF), and no translation (ABC-empty value). This is commonly used for brand name protection scenarios. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</description></item>
        /// </list>
        /// <h2>Translation quality comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Source text</b></th>
        /// <th><b>Aidge translation</b></th>
        /// <th><b>Other translation product 1</b></th>
        /// <th><b>Other translation product 2</b></th>
        /// <th><b>Aidge translation advantage</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>75mm 4Pin 0.38A GA81S2U 12V GTX 960 Cooling Fan for Zotac GTX960 Graphics Card Cooling Fan</td>
        /// <td>75mm 4Pin 0.38A GA81S2U 12V GTX 960, ventilador de enfriamiento para tarjeta gráfica Zotac GTX960.</td>
        /// <td>Ventilador de refrigeración de 75mm 4Pin 0.38A GA81S2U 12V para la tarjeta gráfica Zotac GTX960 Ventilador de enfriamiento GTX 960.</td>
        /// <td>Ventilador de refrigeración para tarjeta gráfica Zotac GTX960, 75mm, 4 pines, 0,38A, GA81S2U, 12V, GTX 960</td>
        /// <td>Clearer product subject</td>
        /// </tr>
        /// <tr>
        /// <td>New Arrival Classic Style Luxury Brand 6 Hands Swiss Automatic Mechanical Men\&quot;s Business Steel Watch</td>
        /// <td>Nueva llegada, reloj mecánico automático de lujo con 6 manecillas, estilo clásico, de acero para hombres de negocios</td>
        /// <td>Nueva Llegada Reloj De Acero de Negocios para Hombre con Mecanismo Automático Suizo y 6 Agujas de Estilo Clásico de Marca de Lujo.</td>
        /// <td>Reloj de acero de negocios para hombre, mecánico automático suizo, marca de lujo, estilo clásico, 6 manos, nueva llegada</td>
        /// <td>More complete sentence structure, clearer expression, and more reasonable segmentation</td>
        /// </tr>
        /// <tr>
        /// <td>Men Key Bag Genuine Cow Leather Buckets Key Cases Pouch Zipper Keychain Auto Car Key Case Women Home Key Holder Wallet</td>
        /// <td>Sac à clés pour hommes en cuir de vache véritable, étuis à clés, pochette à fermeture éclair, porte-clés, étui à clé de voiture, porte-clés pour femmes, organisateur de portefeuille</td>
        /// <td>Porte-clés sac en cuir de vache véritable, étuis à clés en forme de seau, pochette à fermeture éclair, porte-clés auto pour voiture, étui à clés pour femmes, organisateur de clés de maison, portefeuille.</td>
        /// <td>Hommes porte-clés en cuir de vache véritable sac/pochette fermature éclair porte-clés Auto voiture porte-clés femmes maison porte-clés organisateur portefeuille</td>
        /// <td>Clearer and more precise product subject expression. The translation correctly identifies &quot;key bag&quot; rather than &quot;keychain&quot;, avoiding ambiguity about the product type</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// PrepaidTextTranslateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PrepaidTextTranslateResponse
        /// </returns>
        public async Task<PrepaidTextTranslateResponse> PrepaidTextTranslateWithOptionsAsync(PrepaidTextTranslateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PrepaidTextTranslateShrinkRequest request = new PrepaidTextTranslateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceTextList))
            {
                request.SourceTextListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceTextList, "SourceTextList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatType))
            {
                body["FormatType"] = request.FormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Glossary))
            {
                body["Glossary"] = request.Glossary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                body["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTextListShrink))
            {
                body["SourceTextList"] = request.SourceTextListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                body["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslateScene))
            {
                body["TranslateScene"] = request.TranslateScene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PrepaidTextTranslate",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PrepaidTextTranslateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs, continuously optimized for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports translation between more than 100 language pairs (including bridged translations), especially Chinese-English, Chinese-multilingual, and English-multilingual translations. It supports language detection for 24 language directions. If you do not specify the source language, automatic detection is performed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion\+ high-quality bilingual sentence pairs, continuously optimized for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports translation between more than 100 language pairs (including bridged translations), especially Chinese-English, Chinese-multilingual, and English-multilingual translations. It supports language detection for 24 language directions. If you do not specify the source language, automatic detection is performed.</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description>Product titles: Marco MT large model translation accurately translates phrases, keywords, and trending words in product titles into the target language, improving product visibility on e-commerce platforms.</description></item>
        /// <item><description>Product descriptions: Product descriptions are typically long with diverse and complex formatting. Marco large model translation supports long text translation and HTML format, delivering excellent translation quality and format preservation.</description></item>
        /// <item><description>Product attributes: Product attribute terms are short and may contain e-commerce-specific terms such as model numbers and parameters.</description></item>
        /// <item><description>Customer service conversations: In customer service scenarios, the model optimizes issues such as missing context and typos, and supports polite expressions for certain language directions.
        /// Marco MT large model translation can also be used for general-purpose translation scenarios such as office work, meetings, and daily conversations.</description></item>
        /// </list>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>Supported language directions</b> Marco MT large model translation supports translation between more than 100 languages and language detection for 23 languages. For specific language directions, refer to the language mapping table in Section 5.6.</description></item>
        /// <item><description><b>Ultra-low hallucination rate and high-speed inference</b> Marco MT large model translation is a large language model with preference alignment for translation scenarios. Compared with general-purpose large language models, it offers faster translation inference speed and an extremely low hallucination rate, making it especially suitable for large-scale invocation scenarios.</description></item>
        /// <item><description><b>Supported text format types</b> Currently supports text and html text types.</description></item>
        /// <item><description><b>Translation intervention support</b> Supports custom translation results, including do-not-translate (ABC-ABC), specified translation (ABC-DEF), and no translation (ABC-empty value). This is commonly used for brand name protection scenarios. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</description></item>
        /// </list>
        /// <h2>Translation quality comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Source text</b></th>
        /// <th><b>Aidge translation</b></th>
        /// <th><b>Other translation product 1</b></th>
        /// <th><b>Other translation product 2</b></th>
        /// <th><b>Aidge translation advantage</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>75mm 4Pin 0.38A GA81S2U 12V GTX 960 Cooling Fan for Zotac GTX960 Graphics Card Cooling Fan</td>
        /// <td>75mm 4Pin 0.38A GA81S2U 12V GTX 960, ventilador de enfriamiento para tarjeta gráfica Zotac GTX960.</td>
        /// <td>Ventilador de refrigeración de 75mm 4Pin 0.38A GA81S2U 12V para la tarjeta gráfica Zotac GTX960 Ventilador de enfriamiento GTX 960.</td>
        /// <td>Ventilador de refrigeración para tarjeta gráfica Zotac GTX960, 75mm, 4 pines, 0,38A, GA81S2U, 12V, GTX 960</td>
        /// <td>Clearer product subject</td>
        /// </tr>
        /// <tr>
        /// <td>New Arrival Classic Style Luxury Brand 6 Hands Swiss Automatic Mechanical Men\&quot;s Business Steel Watch</td>
        /// <td>Nueva llegada, reloj mecánico automático de lujo con 6 manecillas, estilo clásico, de acero para hombres de negocios</td>
        /// <td>Nueva Llegada Reloj De Acero de Negocios para Hombre con Mecanismo Automático Suizo y 6 Agujas de Estilo Clásico de Marca de Lujo.</td>
        /// <td>Reloj de acero de negocios para hombre, mecánico automático suizo, marca de lujo, estilo clásico, 6 manos, nueva llegada</td>
        /// <td>More complete sentence structure, clearer expression, and more reasonable segmentation</td>
        /// </tr>
        /// <tr>
        /// <td>Men Key Bag Genuine Cow Leather Buckets Key Cases Pouch Zipper Keychain Auto Car Key Case Women Home Key Holder Wallet</td>
        /// <td>Sac à clés pour hommes en cuir de vache véritable, étuis à clés, pochette à fermeture éclair, porte-clés, étui à clé de voiture, porte-clés pour femmes, organisateur de portefeuille</td>
        /// <td>Porte-clés sac en cuir de vache véritable, étuis à clés en forme de seau, pochette à fermeture éclair, porte-clés auto pour voiture, étui à clés pour femmes, organisateur de clés de maison, portefeuille.</td>
        /// <td>Hommes porte-clés en cuir de vache véritable sac/pochette fermature éclair porte-clés Auto voiture porte-clés femmes maison porte-clés organisateur portefeuille</td>
        /// <td>Clearer and more precise product subject expression. The translation correctly identifies &quot;key bag&quot; rather than &quot;keychain&quot;, avoiding ambiguity about the product type</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// PrepaidTextTranslateRequest
        /// </param>
        /// 
        /// <returns>
        /// PrepaidTextTranslateResponse
        /// </returns>
        public PrepaidTextTranslateResponse PrepaidTextTranslate(PrepaidTextTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PrepaidTextTranslateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs, continuously optimized for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports translation between more than 100 language pairs (including bridged translations), especially Chinese-English, Chinese-multilingual, and English-multilingual translations. It supports language detection for 24 language directions. If you do not specify the source language, automatic detection is performed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion\+ high-quality bilingual sentence pairs, continuously optimized for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports translation between more than 100 language pairs (including bridged translations), especially Chinese-English, Chinese-multilingual, and English-multilingual translations. It supports language detection for 24 language directions. If you do not specify the source language, automatic detection is performed.</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description>Product titles: Marco MT large model translation accurately translates phrases, keywords, and trending words in product titles into the target language, improving product visibility on e-commerce platforms.</description></item>
        /// <item><description>Product descriptions: Product descriptions are typically long with diverse and complex formatting. Marco large model translation supports long text translation and HTML format, delivering excellent translation quality and format preservation.</description></item>
        /// <item><description>Product attributes: Product attribute terms are short and may contain e-commerce-specific terms such as model numbers and parameters.</description></item>
        /// <item><description>Customer service conversations: In customer service scenarios, the model optimizes issues such as missing context and typos, and supports polite expressions for certain language directions.
        /// Marco MT large model translation can also be used for general-purpose translation scenarios such as office work, meetings, and daily conversations.</description></item>
        /// </list>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>Supported language directions</b> Marco MT large model translation supports translation between more than 100 languages and language detection for 23 languages. For specific language directions, refer to the language mapping table in Section 5.6.</description></item>
        /// <item><description><b>Ultra-low hallucination rate and high-speed inference</b> Marco MT large model translation is a large language model with preference alignment for translation scenarios. Compared with general-purpose large language models, it offers faster translation inference speed and an extremely low hallucination rate, making it especially suitable for large-scale invocation scenarios.</description></item>
        /// <item><description><b>Supported text format types</b> Currently supports text and html text types.</description></item>
        /// <item><description><b>Translation intervention support</b> Supports custom translation results, including do-not-translate (ABC-ABC), specified translation (ABC-DEF), and no translation (ABC-empty value). This is commonly used for brand name protection scenarios. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</description></item>
        /// </list>
        /// <h2>Translation quality comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Source text</b></th>
        /// <th><b>Aidge translation</b></th>
        /// <th><b>Other translation product 1</b></th>
        /// <th><b>Other translation product 2</b></th>
        /// <th><b>Aidge translation advantage</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>75mm 4Pin 0.38A GA81S2U 12V GTX 960 Cooling Fan for Zotac GTX960 Graphics Card Cooling Fan</td>
        /// <td>75mm 4Pin 0.38A GA81S2U 12V GTX 960, ventilador de enfriamiento para tarjeta gráfica Zotac GTX960.</td>
        /// <td>Ventilador de refrigeración de 75mm 4Pin 0.38A GA81S2U 12V para la tarjeta gráfica Zotac GTX960 Ventilador de enfriamiento GTX 960.</td>
        /// <td>Ventilador de refrigeración para tarjeta gráfica Zotac GTX960, 75mm, 4 pines, 0,38A, GA81S2U, 12V, GTX 960</td>
        /// <td>Clearer product subject</td>
        /// </tr>
        /// <tr>
        /// <td>New Arrival Classic Style Luxury Brand 6 Hands Swiss Automatic Mechanical Men\&quot;s Business Steel Watch</td>
        /// <td>Nueva llegada, reloj mecánico automático de lujo con 6 manecillas, estilo clásico, de acero para hombres de negocios</td>
        /// <td>Nueva Llegada Reloj De Acero de Negocios para Hombre con Mecanismo Automático Suizo y 6 Agujas de Estilo Clásico de Marca de Lujo.</td>
        /// <td>Reloj de acero de negocios para hombre, mecánico automático suizo, marca de lujo, estilo clásico, 6 manos, nueva llegada</td>
        /// <td>More complete sentence structure, clearer expression, and more reasonable segmentation</td>
        /// </tr>
        /// <tr>
        /// <td>Men Key Bag Genuine Cow Leather Buckets Key Cases Pouch Zipper Keychain Auto Car Key Case Women Home Key Holder Wallet</td>
        /// <td>Sac à clés pour hommes en cuir de vache véritable, étuis à clés, pochette à fermeture éclair, porte-clés, étui à clé de voiture, porte-clés pour femmes, organisateur de portefeuille</td>
        /// <td>Porte-clés sac en cuir de vache véritable, étuis à clés en forme de seau, pochette à fermeture éclair, porte-clés auto pour voiture, étui à clés pour femmes, organisateur de clés de maison, portefeuille.</td>
        /// <td>Hommes porte-clés en cuir de vache véritable sac/pochette fermature éclair porte-clés Auto voiture porte-clés femmes maison porte-clés organisateur portefeuille</td>
        /// <td>Clearer and more precise product subject expression. The translation correctly identifies &quot;key bag&quot; rather than &quot;keychain&quot;, avoiding ambiguity about the product type</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// PrepaidTextTranslateRequest
        /// </param>
        /// 
        /// <returns>
        /// PrepaidTextTranslateResponse
        /// </returns>
        public async Task<PrepaidTextTranslateResponse> PrepaidTextTranslateAsync(PrepaidTextTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PrepaidTextTranslateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Automatically identifies and locates specified products in an image based on a multimodal foundation model.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para><b>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.aliyun.com/price/product#/ecs/detail">pricing</a> of the product hotzone recognition service.</b>
        /// This API automatically identifies and locates specified products in a target scene image based on the provided target scene image and product reference images, and outputs the product name and normalized bounding box. Each request takes one target scene image and a set of product reference images. If the same case has multiple target images, call the operation separately for each target image.</para>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>Image URLs must use HTTPS and be accessible by the server.</description></item>
        /// <item><description>Common image formats such as JPEG, PNG, and WebP are supported.</description></item>
        /// <item><description>Each image should not exceed 2 MB.</description></item>
        /// <item><description>When using signed URLs, set the validity period to at least 30 minutes.</description></item>
        /// <item><description>If the same case has multiple target scene images, call the operation separately for each target image. The reference image list can be reused.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ProductHotspotDetectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProductHotspotDetectionResponse
        /// </returns>
        public ProductHotspotDetectionResponse ProductHotspotDetectionWithOptions(ProductHotspotDetectionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ProductHotspotDetectionShrinkRequest request = new ProductHotspotDetectionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceImageUrls))
            {
                request.ReferenceImageUrlsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceImageUrls, "ReferenceImageUrls", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceImageUrlsShrink))
            {
                query["ReferenceImageUrls"] = request.ReferenceImageUrlsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetImageUrl))
            {
                query["TargetImageUrl"] = request.TargetImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProductHotspotDetection",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProductHotspotDetectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Automatically identifies and locates specified products in an image based on a multimodal foundation model.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para><b>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.aliyun.com/price/product#/ecs/detail">pricing</a> of the product hotzone recognition service.</b>
        /// This API automatically identifies and locates specified products in a target scene image based on the provided target scene image and product reference images, and outputs the product name and normalized bounding box. Each request takes one target scene image and a set of product reference images. If the same case has multiple target images, call the operation separately for each target image.</para>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>Image URLs must use HTTPS and be accessible by the server.</description></item>
        /// <item><description>Common image formats such as JPEG, PNG, and WebP are supported.</description></item>
        /// <item><description>Each image should not exceed 2 MB.</description></item>
        /// <item><description>When using signed URLs, set the validity period to at least 30 minutes.</description></item>
        /// <item><description>If the same case has multiple target scene images, call the operation separately for each target image. The reference image list can be reused.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ProductHotspotDetectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProductHotspotDetectionResponse
        /// </returns>
        public async Task<ProductHotspotDetectionResponse> ProductHotspotDetectionWithOptionsAsync(ProductHotspotDetectionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ProductHotspotDetectionShrinkRequest request = new ProductHotspotDetectionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ReferenceImageUrls))
            {
                request.ReferenceImageUrlsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ReferenceImageUrls, "ReferenceImageUrls", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReferenceImageUrlsShrink))
            {
                query["ReferenceImageUrls"] = request.ReferenceImageUrlsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetImageUrl))
            {
                query["TargetImageUrl"] = request.TargetImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProductHotspotDetection",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProductHotspotDetectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Automatically identifies and locates specified products in an image based on a multimodal foundation model.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para><b>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.aliyun.com/price/product#/ecs/detail">pricing</a> of the product hotzone recognition service.</b>
        /// This API automatically identifies and locates specified products in a target scene image based on the provided target scene image and product reference images, and outputs the product name and normalized bounding box. Each request takes one target scene image and a set of product reference images. If the same case has multiple target images, call the operation separately for each target image.</para>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>Image URLs must use HTTPS and be accessible by the server.</description></item>
        /// <item><description>Common image formats such as JPEG, PNG, and WebP are supported.</description></item>
        /// <item><description>Each image should not exceed 2 MB.</description></item>
        /// <item><description>When using signed URLs, set the validity period to at least 30 minutes.</description></item>
        /// <item><description>If the same case has multiple target scene images, call the operation separately for each target image. The reference image list can be reused.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ProductHotspotDetectionRequest
        /// </param>
        /// 
        /// <returns>
        /// ProductHotspotDetectionResponse
        /// </returns>
        public ProductHotspotDetectionResponse ProductHotspotDetection(ProductHotspotDetectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ProductHotspotDetectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Automatically identifies and locates specified products in an image based on a multimodal foundation model.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para><b>Before using this operation, make sure that you fully understand the billing method and <a href="https://www.aliyun.com/price/product#/ecs/detail">pricing</a> of the product hotzone recognition service.</b>
        /// This API automatically identifies and locates specified products in a target scene image based on the provided target scene image and product reference images, and outputs the product name and normalized bounding box. Each request takes one target scene image and a set of product reference images. If the same case has multiple target images, call the operation separately for each target image.</para>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>Image URLs must use HTTPS and be accessible by the server.</description></item>
        /// <item><description>Common image formats such as JPEG, PNG, and WebP are supported.</description></item>
        /// <item><description>Each image should not exceed 2 MB.</description></item>
        /// <item><description>When using signed URLs, set the validity period to at least 30 minutes.</description></item>
        /// <item><description>If the same case has multiple target scene images, call the operation separately for each target image. The reference image list can be reused.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ProductHotspotDetectionRequest
        /// </param>
        /// 
        /// <returns>
        /// ProductHotspotDetectionResponse
        /// </returns>
        public async Task<ProductHotspotDetectionResponse> ProductHotspotDetectionAsync(ProductHotspotDetectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ProductHotspotDetectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of an asynchronous task. The API name on the POP gateway is QueryAsyncTaskResult.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API name on the POP gateway is QueryAsyncTaskResult.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryAsyncTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAsyncTaskResultResponse
        /// </returns>
        public QueryAsyncTaskResultResponse QueryAsyncTaskResultWithOptions(QueryAsyncTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryAsyncTaskResult",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAsyncTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of an asynchronous task. The API name on the POP gateway is QueryAsyncTaskResult.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API name on the POP gateway is QueryAsyncTaskResult.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryAsyncTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAsyncTaskResultResponse
        /// </returns>
        public async Task<QueryAsyncTaskResultResponse> QueryAsyncTaskResultWithOptionsAsync(QueryAsyncTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryAsyncTaskResult",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAsyncTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of an asynchronous task. The API name on the POP gateway is QueryAsyncTaskResult.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API name on the POP gateway is QueryAsyncTaskResult.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryAsyncTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAsyncTaskResultResponse
        /// </returns>
        public QueryAsyncTaskResultResponse QueryAsyncTaskResult(QueryAsyncTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAsyncTaskResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of an asynchronous task. The API name on the POP gateway is QueryAsyncTaskResult.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The API name on the POP gateway is QueryAsyncTaskResult.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryAsyncTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAsyncTaskResultResponse
        /// </returns>
        public async Task<QueryAsyncTaskResultResponse> QueryAsyncTaskResultAsync(QueryAsyncTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAsyncTaskResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detects whether an image contains a size chart. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>Detects whether an image contains a size chart. (Synchronous)</para>
        /// <h1>2. Common scenarios</h1>
        /// <para><b>Batch processing scenario:</b> Detect images containing size charts from a batch of images for further image translation or extraction. The size chart detection service helps reduce costs.</para>
        /// <h1>3. Features</h1>
        /// <para>The size chart detection service uses image recognition technology to automatically determine whether an input image contains size chart content. You provide an image URL, and the system returns a detection result (True/False) indicating whether the image is a size chart.
        /// You can customize the confidence threshold (default: 0.4) and flexibly adjust the detection sensitivity based on your business accuracy requirements. A lower threshold results in more lenient detection, while a higher threshold results in stricter detection. The API processes a single image per request and is suitable for integration into automated batch workflows for sequential invocation.</para>
        /// <h1>4. Effect comparison</h1>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Input image</b></th>
        /// <th><b>Confidence</b></th>
        /// <th><b>Output result</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4jKqm0bAebrKLnw1/img/0a914347-2acb-4b94-bf07-86aab2b31279.png" alt="image.png"></td>
        /// <td>0.4</td>
        /// <td>true</td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4jKqm0bAebrKLnw1/img/ab29b032-139a-4b22-9371-b387581559b7.webp" alt="O1CN01ZjViRX1rdaL6QDFNo_!!6000000005654-0-tps-2048-2048.webp"></td>
        /// <td>0.4</td>
        /// <td>false</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// SizeChartDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SizeChartDetectResponse
        /// </returns>
        public SizeChartDetectResponse SizeChartDetectWithOptions(SizeChartDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SizeChartDetect",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SizeChartDetectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detects whether an image contains a size chart. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>Detects whether an image contains a size chart. (Synchronous)</para>
        /// <h1>2. Common scenarios</h1>
        /// <para><b>Batch processing scenario:</b> Detect images containing size charts from a batch of images for further image translation or extraction. The size chart detection service helps reduce costs.</para>
        /// <h1>3. Features</h1>
        /// <para>The size chart detection service uses image recognition technology to automatically determine whether an input image contains size chart content. You provide an image URL, and the system returns a detection result (True/False) indicating whether the image is a size chart.
        /// You can customize the confidence threshold (default: 0.4) and flexibly adjust the detection sensitivity based on your business accuracy requirements. A lower threshold results in more lenient detection, while a higher threshold results in stricter detection. The API processes a single image per request and is suitable for integration into automated batch workflows for sequential invocation.</para>
        /// <h1>4. Effect comparison</h1>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Input image</b></th>
        /// <th><b>Confidence</b></th>
        /// <th><b>Output result</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4jKqm0bAebrKLnw1/img/0a914347-2acb-4b94-bf07-86aab2b31279.png" alt="image.png"></td>
        /// <td>0.4</td>
        /// <td>true</td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4jKqm0bAebrKLnw1/img/ab29b032-139a-4b22-9371-b387581559b7.webp" alt="O1CN01ZjViRX1rdaL6QDFNo_!!6000000005654-0-tps-2048-2048.webp"></td>
        /// <td>0.4</td>
        /// <td>false</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// SizeChartDetectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SizeChartDetectResponse
        /// </returns>
        public async Task<SizeChartDetectResponse> SizeChartDetectWithOptionsAsync(SizeChartDetectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SizeChartDetect",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SizeChartDetectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detects whether an image contains a size chart. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>Detects whether an image contains a size chart. (Synchronous)</para>
        /// <h1>2. Common scenarios</h1>
        /// <para><b>Batch processing scenario:</b> Detect images containing size charts from a batch of images for further image translation or extraction. The size chart detection service helps reduce costs.</para>
        /// <h1>3. Features</h1>
        /// <para>The size chart detection service uses image recognition technology to automatically determine whether an input image contains size chart content. You provide an image URL, and the system returns a detection result (True/False) indicating whether the image is a size chart.
        /// You can customize the confidence threshold (default: 0.4) and flexibly adjust the detection sensitivity based on your business accuracy requirements. A lower threshold results in more lenient detection, while a higher threshold results in stricter detection. The API processes a single image per request and is suitable for integration into automated batch workflows for sequential invocation.</para>
        /// <h1>4. Effect comparison</h1>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Input image</b></th>
        /// <th><b>Confidence</b></th>
        /// <th><b>Output result</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4jKqm0bAebrKLnw1/img/0a914347-2acb-4b94-bf07-86aab2b31279.png" alt="image.png"></td>
        /// <td>0.4</td>
        /// <td>true</td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4jKqm0bAebrKLnw1/img/ab29b032-139a-4b22-9371-b387581559b7.webp" alt="O1CN01ZjViRX1rdaL6QDFNo_!!6000000005654-0-tps-2048-2048.webp"></td>
        /// <td>0.4</td>
        /// <td>false</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// SizeChartDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// SizeChartDetectResponse
        /// </returns>
        public SizeChartDetectResponse SizeChartDetect(SizeChartDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SizeChartDetectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Detects whether an image contains a size chart. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>Detects whether an image contains a size chart. (Synchronous)</para>
        /// <h1>2. Common scenarios</h1>
        /// <para><b>Batch processing scenario:</b> Detect images containing size charts from a batch of images for further image translation or extraction. The size chart detection service helps reduce costs.</para>
        /// <h1>3. Features</h1>
        /// <para>The size chart detection service uses image recognition technology to automatically determine whether an input image contains size chart content. You provide an image URL, and the system returns a detection result (True/False) indicating whether the image is a size chart.
        /// You can customize the confidence threshold (default: 0.4) and flexibly adjust the detection sensitivity based on your business accuracy requirements. A lower threshold results in more lenient detection, while a higher threshold results in stricter detection. The API processes a single image per request and is suitable for integration into automated batch workflows for sequential invocation.</para>
        /// <h1>4. Effect comparison</h1>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Input image</b></th>
        /// <th><b>Confidence</b></th>
        /// <th><b>Output result</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4jKqm0bAebrKLnw1/img/0a914347-2acb-4b94-bf07-86aab2b31279.png" alt="image.png"></td>
        /// <td>0.4</td>
        /// <td>true</td>
        /// </tr>
        /// <tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4jKqm0bAebrKLnw1/img/ab29b032-139a-4b22-9371-b387581559b7.webp" alt="O1CN01ZjViRX1rdaL6QDFNo_!!6000000005654-0-tps-2048-2048.webp"></td>
        /// <td>0.4</td>
        /// <td>false</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// SizeChartDetectRequest
        /// </param>
        /// 
        /// <returns>
        /// SizeChartDetectResponse
        /// </returns>
        public async Task<SizeChartDetectResponse> SizeChartDetectAsync(SizeChartDetectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SizeChartDetectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Intelligently extracts structured information such as size charts and package weight/dimensions from images using a multimodal foundation model. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Intelligently extracts structured information such as size charts and package weight/dimensions from images using a multimodal foundation model. (Asynchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para>Size chart: Extracts size charts from apparel category images into text.</para>
        /// </description></item>
        /// <item><description><para>Package weight/dimensions: Extracts package weight and dimension information from images.</para>
        /// </description></item>
        /// </list>
        /// <h2>Functions and features</h2>
        /// <para>The size chart extraction service is based on a multimodal foundation model that automatically identifies size tables or package weight/dimension information in images and converts them into structured text output. You provide an image URL, and the system processes it as an asynchronous task, returning the extracted structured data. You can specify column names to recognize (such as Size, Bust, Length) through ColumnNameList for precise targeted extraction. You can also control the output language through the LanguageModel parameter, with options for Chinese (cn) or English (en). If not specified, the original language is preserved. This service is suitable for scenarios such as converting apparel size tables to text and batch structuring of product package weight/dimension information.
        /// Core capabilities: Input an image URL and optional column name configuration, and output structured data of size charts or package weight/dimensions from the image. The API uses an asynchronous task mode (background: true). After submission, a task ID is returned, and you need to poll for the final result. This is suitable for processing complex images or high-volume call scenarios.</para>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Input image</b></th>
        /// <th><b>Output result</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4jKqm0bAebrKLnw1/img/0a914347-2acb-4b94-bf07-86aab2b31279.png" alt="image.png"></td>
        /// <td>{</td>
        /// </tr>
        /// </tbody></table>
        /// <pre><c>      &quot;SizeChart&quot;: [
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;S&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 58
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 81
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 40,
        ///             &quot;upper_value&quot;: 47.5
        ///           }
        ///         },
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;M&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 59
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 82
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 45,
        ///             &quot;upper_value&quot;: 52.5
        ///           }
        ///         },
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;L&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 60
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 83
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 50,
        ///             &quot;upper_value&quot;: 57.5
        ///           }
        ///         },
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;XL&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 61
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 84
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 55,
        ///             &quot;upper_value&quot;: 62.5
        ///           }
        ///         },
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;2XL&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 62
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 85
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 60,
        ///             &quot;upper_value&quot;: 67.5
        ///           }
        ///         }
        ///       \\],
        ///       &quot;SizeChartAttributes&quot;: [
        ///         &quot;尺码&quot;,
        ///         &quot;裙长&quot;,
        ///         &quot;腰围&quot;,
        ///         &quot;体重建议&quot;
        ///       \\],
        ///       &quot;IntersectionAttributes&quot;: [
        ///         &quot;尺码&quot;,
        ///         &quot;裙长&quot;,
        ///         &quot;腰围(拉伸)&quot;,
        ///         &quot;体重建议&quot;
        ///       \\]
        /// </c></pre>
        /// <para>} |</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// SizeChartExtractRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SizeChartExtractResponse
        /// </returns>
        public SizeChartExtractResponse SizeChartExtractWithOptions(SizeChartExtractRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SizeChartExtractShrinkRequest request = new SizeChartExtractShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ColumnNameList))
            {
                request.ColumnNameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ColumnNameList, "ColumnNameList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnNameListShrink))
            {
                query["ColumnNameList"] = request.ColumnNameListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageModel))
            {
                query["LanguageModel"] = request.LanguageModel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SizeChartExtract",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SizeChartExtractResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Intelligently extracts structured information such as size charts and package weight/dimensions from images using a multimodal foundation model. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Intelligently extracts structured information such as size charts and package weight/dimensions from images using a multimodal foundation model. (Asynchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para>Size chart: Extracts size charts from apparel category images into text.</para>
        /// </description></item>
        /// <item><description><para>Package weight/dimensions: Extracts package weight and dimension information from images.</para>
        /// </description></item>
        /// </list>
        /// <h2>Functions and features</h2>
        /// <para>The size chart extraction service is based on a multimodal foundation model that automatically identifies size tables or package weight/dimension information in images and converts them into structured text output. You provide an image URL, and the system processes it as an asynchronous task, returning the extracted structured data. You can specify column names to recognize (such as Size, Bust, Length) through ColumnNameList for precise targeted extraction. You can also control the output language through the LanguageModel parameter, with options for Chinese (cn) or English (en). If not specified, the original language is preserved. This service is suitable for scenarios such as converting apparel size tables to text and batch structuring of product package weight/dimension information.
        /// Core capabilities: Input an image URL and optional column name configuration, and output structured data of size charts or package weight/dimensions from the image. The API uses an asynchronous task mode (background: true). After submission, a task ID is returned, and you need to poll for the final result. This is suitable for processing complex images or high-volume call scenarios.</para>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Input image</b></th>
        /// <th><b>Output result</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4jKqm0bAebrKLnw1/img/0a914347-2acb-4b94-bf07-86aab2b31279.png" alt="image.png"></td>
        /// <td>{</td>
        /// </tr>
        /// </tbody></table>
        /// <pre><c>      &quot;SizeChart&quot;: [
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;S&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 58
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 81
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 40,
        ///             &quot;upper_value&quot;: 47.5
        ///           }
        ///         },
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;M&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 59
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 82
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 45,
        ///             &quot;upper_value&quot;: 52.5
        ///           }
        ///         },
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;L&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 60
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 83
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 50,
        ///             &quot;upper_value&quot;: 57.5
        ///           }
        ///         },
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;XL&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 61
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 84
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 55,
        ///             &quot;upper_value&quot;: 62.5
        ///           }
        ///         },
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;2XL&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 62
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 85
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 60,
        ///             &quot;upper_value&quot;: 67.5
        ///           }
        ///         }
        ///       \\],
        ///       &quot;SizeChartAttributes&quot;: [
        ///         &quot;尺码&quot;,
        ///         &quot;裙长&quot;,
        ///         &quot;腰围&quot;,
        ///         &quot;体重建议&quot;
        ///       \\],
        ///       &quot;IntersectionAttributes&quot;: [
        ///         &quot;尺码&quot;,
        ///         &quot;裙长&quot;,
        ///         &quot;腰围(拉伸)&quot;,
        ///         &quot;体重建议&quot;
        ///       \\]
        /// </c></pre>
        /// <para>} |</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// SizeChartExtractRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SizeChartExtractResponse
        /// </returns>
        public async Task<SizeChartExtractResponse> SizeChartExtractWithOptionsAsync(SizeChartExtractRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SizeChartExtractShrinkRequest request = new SizeChartExtractShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ColumnNameList))
            {
                request.ColumnNameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ColumnNameList, "ColumnNameList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnNameListShrink))
            {
                query["ColumnNameList"] = request.ColumnNameListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageModel))
            {
                query["LanguageModel"] = request.LanguageModel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SizeChartExtract",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SizeChartExtractResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Intelligently extracts structured information such as size charts and package weight/dimensions from images using a multimodal foundation model. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Intelligently extracts structured information such as size charts and package weight/dimensions from images using a multimodal foundation model. (Asynchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para>Size chart: Extracts size charts from apparel category images into text.</para>
        /// </description></item>
        /// <item><description><para>Package weight/dimensions: Extracts package weight and dimension information from images.</para>
        /// </description></item>
        /// </list>
        /// <h2>Functions and features</h2>
        /// <para>The size chart extraction service is based on a multimodal foundation model that automatically identifies size tables or package weight/dimension information in images and converts them into structured text output. You provide an image URL, and the system processes it as an asynchronous task, returning the extracted structured data. You can specify column names to recognize (such as Size, Bust, Length) through ColumnNameList for precise targeted extraction. You can also control the output language through the LanguageModel parameter, with options for Chinese (cn) or English (en). If not specified, the original language is preserved. This service is suitable for scenarios such as converting apparel size tables to text and batch structuring of product package weight/dimension information.
        /// Core capabilities: Input an image URL and optional column name configuration, and output structured data of size charts or package weight/dimensions from the image. The API uses an asynchronous task mode (background: true). After submission, a task ID is returned, and you need to poll for the final result. This is suitable for processing complex images or high-volume call scenarios.</para>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Input image</b></th>
        /// <th><b>Output result</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4jKqm0bAebrKLnw1/img/0a914347-2acb-4b94-bf07-86aab2b31279.png" alt="image.png"></td>
        /// <td>{</td>
        /// </tr>
        /// </tbody></table>
        /// <pre><c>      &quot;SizeChart&quot;: [
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;S&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 58
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 81
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 40,
        ///             &quot;upper_value&quot;: 47.5
        ///           }
        ///         },
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;M&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 59
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 82
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 45,
        ///             &quot;upper_value&quot;: 52.5
        ///           }
        ///         },
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;L&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 60
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 83
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 50,
        ///             &quot;upper_value&quot;: 57.5
        ///           }
        ///         },
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;XL&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 61
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 84
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 55,
        ///             &quot;upper_value&quot;: 62.5
        ///           }
        ///         },
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;2XL&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 62
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 85
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 60,
        ///             &quot;upper_value&quot;: 67.5
        ///           }
        ///         }
        ///       \\],
        ///       &quot;SizeChartAttributes&quot;: [
        ///         &quot;尺码&quot;,
        ///         &quot;裙长&quot;,
        ///         &quot;腰围&quot;,
        ///         &quot;体重建议&quot;
        ///       \\],
        ///       &quot;IntersectionAttributes&quot;: [
        ///         &quot;尺码&quot;,
        ///         &quot;裙长&quot;,
        ///         &quot;腰围(拉伸)&quot;,
        ///         &quot;体重建议&quot;
        ///       \\]
        /// </c></pre>
        /// <para>} |</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SizeChartExtractRequest
        /// </param>
        /// 
        /// <returns>
        /// SizeChartExtractResponse
        /// </returns>
        public SizeChartExtractResponse SizeChartExtract(SizeChartExtractRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SizeChartExtractWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Intelligently extracts structured information such as size charts and package weight/dimensions from images using a multimodal foundation model. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Intelligently extracts structured information such as size charts and package weight/dimensions from images using a multimodal foundation model. (Asynchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para>Size chart: Extracts size charts from apparel category images into text.</para>
        /// </description></item>
        /// <item><description><para>Package weight/dimensions: Extracts package weight and dimension information from images.</para>
        /// </description></item>
        /// </list>
        /// <h2>Functions and features</h2>
        /// <para>The size chart extraction service is based on a multimodal foundation model that automatically identifies size tables or package weight/dimension information in images and converts them into structured text output. You provide an image URL, and the system processes it as an asynchronous task, returning the extracted structured data. You can specify column names to recognize (such as Size, Bust, Length) through ColumnNameList for precise targeted extraction. You can also control the output language through the LanguageModel parameter, with options for Chinese (cn) or English (en). If not specified, the original language is preserved. This service is suitable for scenarios such as converting apparel size tables to text and batch structuring of product package weight/dimension information.
        /// Core capabilities: Input an image URL and optional column name configuration, and output structured data of size charts or package weight/dimensions from the image. The API uses an asynchronous task mode (background: true). After submission, a task ID is returned, and you need to poll for the final result. This is suitable for processing complex images or high-volume call scenarios.</para>
        /// <h2>Effect comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Input image</b></th>
        /// <th><b>Output result</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4jKqm0bAebrKLnw1/img/0a914347-2acb-4b94-bf07-86aab2b31279.png" alt="image.png"></td>
        /// <td>{</td>
        /// </tr>
        /// </tbody></table>
        /// <pre><c>      &quot;SizeChart&quot;: [
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;S&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 58
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 81
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 40,
        ///             &quot;upper_value&quot;: 47.5
        ///           }
        ///         },
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;M&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 59
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 82
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 45,
        ///             &quot;upper_value&quot;: 52.5
        ///           }
        ///         },
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;L&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 60
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 83
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 50,
        ///             &quot;upper_value&quot;: 57.5
        ///           }
        ///         },
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;XL&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 61
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 84
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 55,
        ///             &quot;upper_value&quot;: 62.5
        ///           }
        ///         },
        ///         {
        ///           &quot;尺码&quot;: {
        ///             &quot;value&quot;: &quot;2XL&quot;
        ///           },
        ///           &quot;腰围&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 62
        ///           },
        ///           &quot;裙长&quot;: {
        ///             &quot;unit&quot;: &quot;CM&quot;,
        ///             &quot;value&quot;: 85
        ///           },
        ///           &quot;体重建议&quot;: {
        ///             &quot;unit&quot;: &quot;kg&quot;,
        ///             &quot;lower_value&quot;: 60,
        ///             &quot;upper_value&quot;: 67.5
        ///           }
        ///         }
        ///       \\],
        ///       &quot;SizeChartAttributes&quot;: [
        ///         &quot;尺码&quot;,
        ///         &quot;裙长&quot;,
        ///         &quot;腰围&quot;,
        ///         &quot;体重建议&quot;
        ///       \\],
        ///       &quot;IntersectionAttributes&quot;: [
        ///         &quot;尺码&quot;,
        ///         &quot;裙长&quot;,
        ///         &quot;腰围(拉伸)&quot;,
        ///         &quot;体重建议&quot;
        ///       \\]
        /// </c></pre>
        /// <para>} |</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SizeChartExtractRequest
        /// </param>
        /// 
        /// <returns>
        /// SizeChartExtractResponse
        /// </returns>
        public async Task<SizeChartExtractResponse> SizeChartExtractAsync(SizeChartExtractRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SizeChartExtractWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Corrects errors in search terms and titles.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Corrects errors in search terms and titles. The following 14 languages are currently supported:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>No.</th>
        /// <th>Language name (English)</th>
        /// <th>Language code</th>
        /// <th>Language name (Chinese)</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>1</td>
        /// <td>Arabic</td>
        /// <td>ar</td>
        /// <td>阿拉伯语</td>
        /// </tr>
        /// <tr>
        /// <td>2</td>
        /// <td>German</td>
        /// <td>de</td>
        /// <td>德语</td>
        /// </tr>
        /// <tr>
        /// <td>3</td>
        /// <td>English</td>
        /// <td>en</td>
        /// <td>英语</td>
        /// </tr>
        /// <tr>
        /// <td>4</td>
        /// <td>Spanish</td>
        /// <td>es</td>
        /// <td>西班牙语</td>
        /// </tr>
        /// <tr>
        /// <td>5</td>
        /// <td>French</td>
        /// <td>fr</td>
        /// <td>法语</td>
        /// </tr>
        /// <tr>
        /// <td>6</td>
        /// <td>Hebrew</td>
        /// <td>he</td>
        /// <td>希伯来语</td>
        /// </tr>
        /// <tr>
        /// <td>7</td>
        /// <td>Italian</td>
        /// <td>it</td>
        /// <td>意大利语</td>
        /// </tr>
        /// <tr>
        /// <td>8</td>
        /// <td>Japanese</td>
        /// <td>ja</td>
        /// <td>日语</td>
        /// </tr>
        /// <tr>
        /// <td>9</td>
        /// <td>Korean</td>
        /// <td>ko</td>
        /// <td>韩语</td>
        /// </tr>
        /// <tr>
        /// <td>10</td>
        /// <td>Dutch</td>
        /// <td>nl</td>
        /// <td>荷兰语</td>
        /// </tr>
        /// <tr>
        /// <td>11</td>
        /// <td>Polish</td>
        /// <td>pl</td>
        /// <td>波兰语</td>
        /// </tr>
        /// <tr>
        /// <td>12</td>
        /// <td>Portuguese</td>
        /// <td>pt</td>
        /// <td>葡萄牙语-巴西</td>
        /// </tr>
        /// <tr>
        /// <td>13</td>
        /// <td>Russian</td>
        /// <td>ru</td>
        /// <td>俄语</td>
        /// </tr>
        /// <tr>
        /// <td>14</td>
        /// <td>Ukrainian</td>
        /// <td>uk</td>
        /// <td>乌克兰语</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// TextCorrectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TextCorrectResponse
        /// </returns>
        public TextCorrectResponse TextCorrectWithOptions(TextCorrectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                query["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceText))
            {
                query["SourceText"] = request.SourceText;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TextCorrect",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TextCorrectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Corrects errors in search terms and titles.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Corrects errors in search terms and titles. The following 14 languages are currently supported:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>No.</th>
        /// <th>Language name (English)</th>
        /// <th>Language code</th>
        /// <th>Language name (Chinese)</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>1</td>
        /// <td>Arabic</td>
        /// <td>ar</td>
        /// <td>阿拉伯语</td>
        /// </tr>
        /// <tr>
        /// <td>2</td>
        /// <td>German</td>
        /// <td>de</td>
        /// <td>德语</td>
        /// </tr>
        /// <tr>
        /// <td>3</td>
        /// <td>English</td>
        /// <td>en</td>
        /// <td>英语</td>
        /// </tr>
        /// <tr>
        /// <td>4</td>
        /// <td>Spanish</td>
        /// <td>es</td>
        /// <td>西班牙语</td>
        /// </tr>
        /// <tr>
        /// <td>5</td>
        /// <td>French</td>
        /// <td>fr</td>
        /// <td>法语</td>
        /// </tr>
        /// <tr>
        /// <td>6</td>
        /// <td>Hebrew</td>
        /// <td>he</td>
        /// <td>希伯来语</td>
        /// </tr>
        /// <tr>
        /// <td>7</td>
        /// <td>Italian</td>
        /// <td>it</td>
        /// <td>意大利语</td>
        /// </tr>
        /// <tr>
        /// <td>8</td>
        /// <td>Japanese</td>
        /// <td>ja</td>
        /// <td>日语</td>
        /// </tr>
        /// <tr>
        /// <td>9</td>
        /// <td>Korean</td>
        /// <td>ko</td>
        /// <td>韩语</td>
        /// </tr>
        /// <tr>
        /// <td>10</td>
        /// <td>Dutch</td>
        /// <td>nl</td>
        /// <td>荷兰语</td>
        /// </tr>
        /// <tr>
        /// <td>11</td>
        /// <td>Polish</td>
        /// <td>pl</td>
        /// <td>波兰语</td>
        /// </tr>
        /// <tr>
        /// <td>12</td>
        /// <td>Portuguese</td>
        /// <td>pt</td>
        /// <td>葡萄牙语-巴西</td>
        /// </tr>
        /// <tr>
        /// <td>13</td>
        /// <td>Russian</td>
        /// <td>ru</td>
        /// <td>俄语</td>
        /// </tr>
        /// <tr>
        /// <td>14</td>
        /// <td>Ukrainian</td>
        /// <td>uk</td>
        /// <td>乌克兰语</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// TextCorrectRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TextCorrectResponse
        /// </returns>
        public async Task<TextCorrectResponse> TextCorrectWithOptionsAsync(TextCorrectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                query["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceText))
            {
                query["SourceText"] = request.SourceText;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TextCorrect",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TextCorrectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Corrects errors in search terms and titles.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Corrects errors in search terms and titles. The following 14 languages are currently supported:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>No.</th>
        /// <th>Language name (English)</th>
        /// <th>Language code</th>
        /// <th>Language name (Chinese)</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>1</td>
        /// <td>Arabic</td>
        /// <td>ar</td>
        /// <td>阿拉伯语</td>
        /// </tr>
        /// <tr>
        /// <td>2</td>
        /// <td>German</td>
        /// <td>de</td>
        /// <td>德语</td>
        /// </tr>
        /// <tr>
        /// <td>3</td>
        /// <td>English</td>
        /// <td>en</td>
        /// <td>英语</td>
        /// </tr>
        /// <tr>
        /// <td>4</td>
        /// <td>Spanish</td>
        /// <td>es</td>
        /// <td>西班牙语</td>
        /// </tr>
        /// <tr>
        /// <td>5</td>
        /// <td>French</td>
        /// <td>fr</td>
        /// <td>法语</td>
        /// </tr>
        /// <tr>
        /// <td>6</td>
        /// <td>Hebrew</td>
        /// <td>he</td>
        /// <td>希伯来语</td>
        /// </tr>
        /// <tr>
        /// <td>7</td>
        /// <td>Italian</td>
        /// <td>it</td>
        /// <td>意大利语</td>
        /// </tr>
        /// <tr>
        /// <td>8</td>
        /// <td>Japanese</td>
        /// <td>ja</td>
        /// <td>日语</td>
        /// </tr>
        /// <tr>
        /// <td>9</td>
        /// <td>Korean</td>
        /// <td>ko</td>
        /// <td>韩语</td>
        /// </tr>
        /// <tr>
        /// <td>10</td>
        /// <td>Dutch</td>
        /// <td>nl</td>
        /// <td>荷兰语</td>
        /// </tr>
        /// <tr>
        /// <td>11</td>
        /// <td>Polish</td>
        /// <td>pl</td>
        /// <td>波兰语</td>
        /// </tr>
        /// <tr>
        /// <td>12</td>
        /// <td>Portuguese</td>
        /// <td>pt</td>
        /// <td>葡萄牙语-巴西</td>
        /// </tr>
        /// <tr>
        /// <td>13</td>
        /// <td>Russian</td>
        /// <td>ru</td>
        /// <td>俄语</td>
        /// </tr>
        /// <tr>
        /// <td>14</td>
        /// <td>Ukrainian</td>
        /// <td>uk</td>
        /// <td>乌克兰语</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// TextCorrectRequest
        /// </param>
        /// 
        /// <returns>
        /// TextCorrectResponse
        /// </returns>
        public TextCorrectResponse TextCorrect(TextCorrectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TextCorrectWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Corrects errors in search terms and titles.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Corrects errors in search terms and titles. The following 14 languages are currently supported:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>No.</th>
        /// <th>Language name (English)</th>
        /// <th>Language code</th>
        /// <th>Language name (Chinese)</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>1</td>
        /// <td>Arabic</td>
        /// <td>ar</td>
        /// <td>阿拉伯语</td>
        /// </tr>
        /// <tr>
        /// <td>2</td>
        /// <td>German</td>
        /// <td>de</td>
        /// <td>德语</td>
        /// </tr>
        /// <tr>
        /// <td>3</td>
        /// <td>English</td>
        /// <td>en</td>
        /// <td>英语</td>
        /// </tr>
        /// <tr>
        /// <td>4</td>
        /// <td>Spanish</td>
        /// <td>es</td>
        /// <td>西班牙语</td>
        /// </tr>
        /// <tr>
        /// <td>5</td>
        /// <td>French</td>
        /// <td>fr</td>
        /// <td>法语</td>
        /// </tr>
        /// <tr>
        /// <td>6</td>
        /// <td>Hebrew</td>
        /// <td>he</td>
        /// <td>希伯来语</td>
        /// </tr>
        /// <tr>
        /// <td>7</td>
        /// <td>Italian</td>
        /// <td>it</td>
        /// <td>意大利语</td>
        /// </tr>
        /// <tr>
        /// <td>8</td>
        /// <td>Japanese</td>
        /// <td>ja</td>
        /// <td>日语</td>
        /// </tr>
        /// <tr>
        /// <td>9</td>
        /// <td>Korean</td>
        /// <td>ko</td>
        /// <td>韩语</td>
        /// </tr>
        /// <tr>
        /// <td>10</td>
        /// <td>Dutch</td>
        /// <td>nl</td>
        /// <td>荷兰语</td>
        /// </tr>
        /// <tr>
        /// <td>11</td>
        /// <td>Polish</td>
        /// <td>pl</td>
        /// <td>波兰语</td>
        /// </tr>
        /// <tr>
        /// <td>12</td>
        /// <td>Portuguese</td>
        /// <td>pt</td>
        /// <td>葡萄牙语-巴西</td>
        /// </tr>
        /// <tr>
        /// <td>13</td>
        /// <td>Russian</td>
        /// <td>ru</td>
        /// <td>俄语</td>
        /// </tr>
        /// <tr>
        /// <td>14</td>
        /// <td>Ukrainian</td>
        /// <td>uk</td>
        /// <td>乌克兰语</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// TextCorrectRequest
        /// </param>
        /// 
        /// <returns>
        /// TextCorrectResponse
        /// </returns>
        public async Task<TextCorrectResponse> TextCorrectAsync(TextCorrectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TextCorrectWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs, with continuous optimization for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports mutual translation among more than 100 language pairs (including bridged pairs), especially Chinese-English, Chinese-multilingual, and English-multilingual translation. It supports language detection for 24 languages. If you do not specify a source language, automatic detection is performed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs, with continuous optimization for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports mutual translation among more than 100 language pairs (including bridged pairs), especially Chinese-English, Chinese-multilingual, and English-multilingual translation. It supports language detection for 24 languages. If you do not specify a source language, automatic detection is performed.</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description>Product titles: Marco MT can accurately translate phrases, keywords, and trending terms in product titles into the target language, improving product visibility on e-commerce platforms.</description></item>
        /// <item><description>Product descriptions: Product descriptions are typically long with diverse and complex formatting. Marco MT supports long text translation and HTML format, delivering excellent translation quality and format preservation.</description></item>
        /// <item><description>Product attributes: Product attribute terms are typically short and may contain e-commerce-specific terms such as model numbers and parameters.</description></item>
        /// <item><description>Customer service conversations: In customer service scenarios, Marco MT can handle issues such as missing context and typos, and supports polite expressions for certain language pairs.
        /// Marco MT can also be used for general translation scenarios, such as office work, meetings, and daily conversations.</description></item>
        /// </list>
        /// <h2>Functions and features</h2>
        /// <list type="bullet">
        /// <item><description><b>Supported language pairs</b><br>Marco MT supports mutual translation among more than 100 languages and language detection for 24 languages. For supported language pairs, see <a href="https://www.alibabacloud.com/help/en/document_detail/3041883.html">Language pair mapping table</a>.</description></item>
        /// <item><description><b>Ultra-low hallucination rate and high-speed inference</b><br>Marco MT is a large language model with preference alignment for translation scenarios. Compared with general-purpose large language models, it provides faster translation inference and an extremely low hallucination rate, making it especially suitable for large-scale invocation scenarios.</description></item>
        /// <item><description><b>Supported text format types</b><br>Currently, text and html text types are supported.</description></item>
        /// <item><description><b>Translation intervention support</b><br>Custom translation results are supported, including do-not-translate (ABC→ABC), specified translation (ABC→DEF), and skip translation (ABC→empty value). This is commonly used for scenarios such as brand name protection. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</description></item>
        /// </list>
        /// <h2>Translation quality comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Source text</b></th>
        /// <th><b>Aidge translation</b></th>
        /// <th><b>Other translation product 1</b></th>
        /// <th><b>Other translation product 2</b></th>
        /// <th><b>Aidge translation advantage</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>75mm 4Pin 0.38A GA81S2U 12V GTX 960 Cooling Fan for Zotac GTX960 Graphics Card Cooling Fan</td>
        /// <td>75mm 4Pin 0.38A GA81S2U 12V GTX 960, ventilador de enfriamiento para tarjeta gráfica Zotac GTX960.</td>
        /// <td>Ventilador de refrigeración de 75mm 4Pin 0.38A GA81S2U 12V para la tarjeta gráfica Zotac GTX960 Ventilador de enfriamiento GTX 960.</td>
        /// <td>Ventilador de refrigeración para tarjeta gráfica Zotac GTX960, 75mm, 4 pines, 0,38A, GA81S2U, 12V, GTX 960</td>
        /// <td>Clearer product subject</td>
        /// </tr>
        /// <tr>
        /// <td>New Arrival Classic Style Luxury Brand 6 Hands Swiss Automatic Mechanical Men\&quot;s Business Steel Watch</td>
        /// <td>Nueva llegada, reloj mecánico automático de lujo con 6 manecillas, estilo clásico, de acero para hombres de negocios</td>
        /// <td>Nueva Llegada Reloj De Acero de Negocios para Hombre con Mecanismo Automático Suizo y 6 Agujas de Estilo Clásico de Marca de Lujo.</td>
        /// <td>Reloj de acero de negocios para hombre, mecánico automático suizo, marca de lujo, estilo clásico, 6 manos, nueva llegada</td>
        /// <td>More complete sentence structure, clearer expression, and more reasonable segmentation</td>
        /// </tr>
        /// <tr>
        /// <td>Men Key Bag Genuine Cow Leather Buckets Key Cases Pouch Zipper Keychain Auto Car Key Case Women Home Key Holder Wallet</td>
        /// <td>Sac à clés pour hommes en cuir de vache véritable, étuis à clés, pochette à fermeture éclair, porte-clés, étui à clé de voiture, porte-clés pour femmes, organisateur de portefeuille</td>
        /// <td>Porte-clés sac en cuir de vache véritable, étuis à clés en forme de seau, pochette à fermeture éclair, porte-clés auto pour voiture, étui à clés pour femmes, organisateur de clés de maison, portefeuille.</td>
        /// <td>Hommes porte-clés en cuir de vache véritable sac/pochette fermature éclair porte-clés Auto voiture porte-clés femmes maison porte-clés organisateur portefeuille</td>
        /// <td>Clearer and more accurate product subject expression. The translation correctly identifies &quot;key bag&quot; rather than &quot;keychain&quot;, avoiding ambiguity about the product type in other translations</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// TextTranslateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TextTranslateResponse
        /// </returns>
        public TextTranslateResponse TextTranslateWithOptions(TextTranslateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TextTranslateShrinkRequest request = new TextTranslateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceTextList))
            {
                request.SourceTextListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceTextList, "SourceTextList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatType))
            {
                body["FormatType"] = request.FormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Glossary))
            {
                body["Glossary"] = request.Glossary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                body["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTextListShrink))
            {
                body["SourceTextList"] = request.SourceTextListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                body["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslateScene))
            {
                body["TranslateScene"] = request.TranslateScene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TextTranslate",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TextTranslateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs, with continuous optimization for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports mutual translation among more than 100 language pairs (including bridged pairs), especially Chinese-English, Chinese-multilingual, and English-multilingual translation. It supports language detection for 24 languages. If you do not specify a source language, automatic detection is performed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs, with continuous optimization for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports mutual translation among more than 100 language pairs (including bridged pairs), especially Chinese-English, Chinese-multilingual, and English-multilingual translation. It supports language detection for 24 languages. If you do not specify a source language, automatic detection is performed.</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description>Product titles: Marco MT can accurately translate phrases, keywords, and trending terms in product titles into the target language, improving product visibility on e-commerce platforms.</description></item>
        /// <item><description>Product descriptions: Product descriptions are typically long with diverse and complex formatting. Marco MT supports long text translation and HTML format, delivering excellent translation quality and format preservation.</description></item>
        /// <item><description>Product attributes: Product attribute terms are typically short and may contain e-commerce-specific terms such as model numbers and parameters.</description></item>
        /// <item><description>Customer service conversations: In customer service scenarios, Marco MT can handle issues such as missing context and typos, and supports polite expressions for certain language pairs.
        /// Marco MT can also be used for general translation scenarios, such as office work, meetings, and daily conversations.</description></item>
        /// </list>
        /// <h2>Functions and features</h2>
        /// <list type="bullet">
        /// <item><description><b>Supported language pairs</b><br>Marco MT supports mutual translation among more than 100 languages and language detection for 24 languages. For supported language pairs, see <a href="https://www.alibabacloud.com/help/en/document_detail/3041883.html">Language pair mapping table</a>.</description></item>
        /// <item><description><b>Ultra-low hallucination rate and high-speed inference</b><br>Marco MT is a large language model with preference alignment for translation scenarios. Compared with general-purpose large language models, it provides faster translation inference and an extremely low hallucination rate, making it especially suitable for large-scale invocation scenarios.</description></item>
        /// <item><description><b>Supported text format types</b><br>Currently, text and html text types are supported.</description></item>
        /// <item><description><b>Translation intervention support</b><br>Custom translation results are supported, including do-not-translate (ABC→ABC), specified translation (ABC→DEF), and skip translation (ABC→empty value). This is commonly used for scenarios such as brand name protection. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</description></item>
        /// </list>
        /// <h2>Translation quality comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Source text</b></th>
        /// <th><b>Aidge translation</b></th>
        /// <th><b>Other translation product 1</b></th>
        /// <th><b>Other translation product 2</b></th>
        /// <th><b>Aidge translation advantage</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>75mm 4Pin 0.38A GA81S2U 12V GTX 960 Cooling Fan for Zotac GTX960 Graphics Card Cooling Fan</td>
        /// <td>75mm 4Pin 0.38A GA81S2U 12V GTX 960, ventilador de enfriamiento para tarjeta gráfica Zotac GTX960.</td>
        /// <td>Ventilador de refrigeración de 75mm 4Pin 0.38A GA81S2U 12V para la tarjeta gráfica Zotac GTX960 Ventilador de enfriamiento GTX 960.</td>
        /// <td>Ventilador de refrigeración para tarjeta gráfica Zotac GTX960, 75mm, 4 pines, 0,38A, GA81S2U, 12V, GTX 960</td>
        /// <td>Clearer product subject</td>
        /// </tr>
        /// <tr>
        /// <td>New Arrival Classic Style Luxury Brand 6 Hands Swiss Automatic Mechanical Men\&quot;s Business Steel Watch</td>
        /// <td>Nueva llegada, reloj mecánico automático de lujo con 6 manecillas, estilo clásico, de acero para hombres de negocios</td>
        /// <td>Nueva Llegada Reloj De Acero de Negocios para Hombre con Mecanismo Automático Suizo y 6 Agujas de Estilo Clásico de Marca de Lujo.</td>
        /// <td>Reloj de acero de negocios para hombre, mecánico automático suizo, marca de lujo, estilo clásico, 6 manos, nueva llegada</td>
        /// <td>More complete sentence structure, clearer expression, and more reasonable segmentation</td>
        /// </tr>
        /// <tr>
        /// <td>Men Key Bag Genuine Cow Leather Buckets Key Cases Pouch Zipper Keychain Auto Car Key Case Women Home Key Holder Wallet</td>
        /// <td>Sac à clés pour hommes en cuir de vache véritable, étuis à clés, pochette à fermeture éclair, porte-clés, étui à clé de voiture, porte-clés pour femmes, organisateur de portefeuille</td>
        /// <td>Porte-clés sac en cuir de vache véritable, étuis à clés en forme de seau, pochette à fermeture éclair, porte-clés auto pour voiture, étui à clés pour femmes, organisateur de clés de maison, portefeuille.</td>
        /// <td>Hommes porte-clés en cuir de vache véritable sac/pochette fermature éclair porte-clés Auto voiture porte-clés femmes maison porte-clés organisateur portefeuille</td>
        /// <td>Clearer and more accurate product subject expression. The translation correctly identifies &quot;key bag&quot; rather than &quot;keychain&quot;, avoiding ambiguity about the product type in other translations</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// TextTranslateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TextTranslateResponse
        /// </returns>
        public async Task<TextTranslateResponse> TextTranslateWithOptionsAsync(TextTranslateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TextTranslateShrinkRequest request = new TextTranslateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceTextList))
            {
                request.SourceTextListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceTextList, "SourceTextList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizName))
            {
                body["BizName"] = request.BizName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatType))
            {
                body["FormatType"] = request.FormatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Glossary))
            {
                body["Glossary"] = request.Glossary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                body["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceTextListShrink))
            {
                body["SourceTextList"] = request.SourceTextListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                body["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslateScene))
            {
                body["TranslateScene"] = request.TranslateScene;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TextTranslate",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TextTranslateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs, with continuous optimization for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports mutual translation among more than 100 language pairs (including bridged pairs), especially Chinese-English, Chinese-multilingual, and English-multilingual translation. It supports language detection for 24 languages. If you do not specify a source language, automatic detection is performed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs, with continuous optimization for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports mutual translation among more than 100 language pairs (including bridged pairs), especially Chinese-English, Chinese-multilingual, and English-multilingual translation. It supports language detection for 24 languages. If you do not specify a source language, automatic detection is performed.</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description>Product titles: Marco MT can accurately translate phrases, keywords, and trending terms in product titles into the target language, improving product visibility on e-commerce platforms.</description></item>
        /// <item><description>Product descriptions: Product descriptions are typically long with diverse and complex formatting. Marco MT supports long text translation and HTML format, delivering excellent translation quality and format preservation.</description></item>
        /// <item><description>Product attributes: Product attribute terms are typically short and may contain e-commerce-specific terms such as model numbers and parameters.</description></item>
        /// <item><description>Customer service conversations: In customer service scenarios, Marco MT can handle issues such as missing context and typos, and supports polite expressions for certain language pairs.
        /// Marco MT can also be used for general translation scenarios, such as office work, meetings, and daily conversations.</description></item>
        /// </list>
        /// <h2>Functions and features</h2>
        /// <list type="bullet">
        /// <item><description><b>Supported language pairs</b><br>Marco MT supports mutual translation among more than 100 languages and language detection for 24 languages. For supported language pairs, see <a href="https://www.alibabacloud.com/help/en/document_detail/3041883.html">Language pair mapping table</a>.</description></item>
        /// <item><description><b>Ultra-low hallucination rate and high-speed inference</b><br>Marco MT is a large language model with preference alignment for translation scenarios. Compared with general-purpose large language models, it provides faster translation inference and an extremely low hallucination rate, making it especially suitable for large-scale invocation scenarios.</description></item>
        /// <item><description><b>Supported text format types</b><br>Currently, text and html text types are supported.</description></item>
        /// <item><description><b>Translation intervention support</b><br>Custom translation results are supported, including do-not-translate (ABC→ABC), specified translation (ABC→DEF), and skip translation (ABC→empty value). This is commonly used for scenarios such as brand name protection. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</description></item>
        /// </list>
        /// <h2>Translation quality comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Source text</b></th>
        /// <th><b>Aidge translation</b></th>
        /// <th><b>Other translation product 1</b></th>
        /// <th><b>Other translation product 2</b></th>
        /// <th><b>Aidge translation advantage</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>75mm 4Pin 0.38A GA81S2U 12V GTX 960 Cooling Fan for Zotac GTX960 Graphics Card Cooling Fan</td>
        /// <td>75mm 4Pin 0.38A GA81S2U 12V GTX 960, ventilador de enfriamiento para tarjeta gráfica Zotac GTX960.</td>
        /// <td>Ventilador de refrigeración de 75mm 4Pin 0.38A GA81S2U 12V para la tarjeta gráfica Zotac GTX960 Ventilador de enfriamiento GTX 960.</td>
        /// <td>Ventilador de refrigeración para tarjeta gráfica Zotac GTX960, 75mm, 4 pines, 0,38A, GA81S2U, 12V, GTX 960</td>
        /// <td>Clearer product subject</td>
        /// </tr>
        /// <tr>
        /// <td>New Arrival Classic Style Luxury Brand 6 Hands Swiss Automatic Mechanical Men\&quot;s Business Steel Watch</td>
        /// <td>Nueva llegada, reloj mecánico automático de lujo con 6 manecillas, estilo clásico, de acero para hombres de negocios</td>
        /// <td>Nueva Llegada Reloj De Acero de Negocios para Hombre con Mecanismo Automático Suizo y 6 Agujas de Estilo Clásico de Marca de Lujo.</td>
        /// <td>Reloj de acero de negocios para hombre, mecánico automático suizo, marca de lujo, estilo clásico, 6 manos, nueva llegada</td>
        /// <td>More complete sentence structure, clearer expression, and more reasonable segmentation</td>
        /// </tr>
        /// <tr>
        /// <td>Men Key Bag Genuine Cow Leather Buckets Key Cases Pouch Zipper Keychain Auto Car Key Case Women Home Key Holder Wallet</td>
        /// <td>Sac à clés pour hommes en cuir de vache véritable, étuis à clés, pochette à fermeture éclair, porte-clés, étui à clé de voiture, porte-clés pour femmes, organisateur de portefeuille</td>
        /// <td>Porte-clés sac en cuir de vache véritable, étuis à clés en forme de seau, pochette à fermeture éclair, porte-clés auto pour voiture, étui à clés pour femmes, organisateur de clés de maison, portefeuille.</td>
        /// <td>Hommes porte-clés en cuir de vache véritable sac/pochette fermature éclair porte-clés Auto voiture porte-clés femmes maison porte-clés organisateur portefeuille</td>
        /// <td>Clearer and more accurate product subject expression. The translation correctly identifies &quot;key bag&quot; rather than &quot;keychain&quot;, avoiding ambiguity about the product type in other translations</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// TextTranslateRequest
        /// </param>
        /// 
        /// <returns>
        /// TextTranslateResponse
        /// </returns>
        public TextTranslateResponse TextTranslate(TextTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TextTranslateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs, with continuous optimization for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports mutual translation among more than 100 language pairs (including bridged pairs), especially Chinese-English, Chinese-multilingual, and English-multilingual translation. It supports language detection for 24 languages. If you do not specify a source language, automatic detection is performed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs, with continuous optimization for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports mutual translation among more than 100 language pairs (including bridged pairs), especially Chinese-English, Chinese-multilingual, and English-multilingual translation. It supports language detection for 24 languages. If you do not specify a source language, automatic detection is performed.</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description>Product titles: Marco MT can accurately translate phrases, keywords, and trending terms in product titles into the target language, improving product visibility on e-commerce platforms.</description></item>
        /// <item><description>Product descriptions: Product descriptions are typically long with diverse and complex formatting. Marco MT supports long text translation and HTML format, delivering excellent translation quality and format preservation.</description></item>
        /// <item><description>Product attributes: Product attribute terms are typically short and may contain e-commerce-specific terms such as model numbers and parameters.</description></item>
        /// <item><description>Customer service conversations: In customer service scenarios, Marco MT can handle issues such as missing context and typos, and supports polite expressions for certain language pairs.
        /// Marco MT can also be used for general translation scenarios, such as office work, meetings, and daily conversations.</description></item>
        /// </list>
        /// <h2>Functions and features</h2>
        /// <list type="bullet">
        /// <item><description><b>Supported language pairs</b><br>Marco MT supports mutual translation among more than 100 languages and language detection for 24 languages. For supported language pairs, see <a href="https://www.alibabacloud.com/help/en/document_detail/3041883.html">Language pair mapping table</a>.</description></item>
        /// <item><description><b>Ultra-low hallucination rate and high-speed inference</b><br>Marco MT is a large language model with preference alignment for translation scenarios. Compared with general-purpose large language models, it provides faster translation inference and an extremely low hallucination rate, making it especially suitable for large-scale invocation scenarios.</description></item>
        /// <item><description><b>Supported text format types</b><br>Currently, text and html text types are supported.</description></item>
        /// <item><description><b>Translation intervention support</b><br>Custom translation results are supported, including do-not-translate (ABC→ABC), specified translation (ABC→DEF), and skip translation (ABC→empty value). This is commonly used for scenarios such as brand name protection. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</description></item>
        /// </list>
        /// <h2>Translation quality comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Source text</b></th>
        /// <th><b>Aidge translation</b></th>
        /// <th><b>Other translation product 1</b></th>
        /// <th><b>Other translation product 2</b></th>
        /// <th><b>Aidge translation advantage</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>75mm 4Pin 0.38A GA81S2U 12V GTX 960 Cooling Fan for Zotac GTX960 Graphics Card Cooling Fan</td>
        /// <td>75mm 4Pin 0.38A GA81S2U 12V GTX 960, ventilador de enfriamiento para tarjeta gráfica Zotac GTX960.</td>
        /// <td>Ventilador de refrigeración de 75mm 4Pin 0.38A GA81S2U 12V para la tarjeta gráfica Zotac GTX960 Ventilador de enfriamiento GTX 960.</td>
        /// <td>Ventilador de refrigeración para tarjeta gráfica Zotac GTX960, 75mm, 4 pines, 0,38A, GA81S2U, 12V, GTX 960</td>
        /// <td>Clearer product subject</td>
        /// </tr>
        /// <tr>
        /// <td>New Arrival Classic Style Luxury Brand 6 Hands Swiss Automatic Mechanical Men\&quot;s Business Steel Watch</td>
        /// <td>Nueva llegada, reloj mecánico automático de lujo con 6 manecillas, estilo clásico, de acero para hombres de negocios</td>
        /// <td>Nueva Llegada Reloj De Acero de Negocios para Hombre con Mecanismo Automático Suizo y 6 Agujas de Estilo Clásico de Marca de Lujo.</td>
        /// <td>Reloj de acero de negocios para hombre, mecánico automático suizo, marca de lujo, estilo clásico, 6 manos, nueva llegada</td>
        /// <td>More complete sentence structure, clearer expression, and more reasonable segmentation</td>
        /// </tr>
        /// <tr>
        /// <td>Men Key Bag Genuine Cow Leather Buckets Key Cases Pouch Zipper Keychain Auto Car Key Case Women Home Key Holder Wallet</td>
        /// <td>Sac à clés pour hommes en cuir de vache véritable, étuis à clés, pochette à fermeture éclair, porte-clés, étui à clé de voiture, porte-clés pour femmes, organisateur de portefeuille</td>
        /// <td>Porte-clés sac en cuir de vache véritable, étuis à clés en forme de seau, pochette à fermeture éclair, porte-clés auto pour voiture, étui à clés pour femmes, organisateur de clés de maison, portefeuille.</td>
        /// <td>Hommes porte-clés en cuir de vache véritable sac/pochette fermature éclair porte-clés Auto voiture porte-clés femmes maison porte-clés organisateur portefeuille</td>
        /// <td>Clearer and more accurate product subject expression. The translation correctly identifies &quot;key bag&quot; rather than &quot;keychain&quot;, avoiding ambiguity about the product type in other translations</td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// TextTranslateRequest
        /// </param>
        /// 
        /// <returns>
        /// TextTranslateResponse
        /// </returns>
        public async Task<TextTranslateResponse> TextTranslateAsync(TextTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TextTranslateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The E-commerce AI Video Generation Agent is designed for e-commerce merchants and platforms. Based on product main images, titles, selling points, and other information, it automatically generates 5–30 second product showcase short videos, helping customers efficiently produce and distribute e-commerce content. The product supports multiple resolution outputs such as 720P and 1080P, supports both quick single-product calls and multi-product batch generation, and accommodates both daily operations and large-scale product content production needs. Currently, it covers all apparel categories (tops, pants, skirts, suits, underwear, swimwear, etc.) and is gradually expanding to skincare, cosmetics, food and beverages, home appliances, and other core e-commerce categories.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Scenarios</h1>
        /// <list type="bullet">
        /// <item><description>Sellers/platforms batch-generate product short videos: Supports multiple video aspect ratios and sizes (3:4, 9:16), suitable for product detail page video slots, product homepage displays, information feed placements, short video content marketing, campaign material, and other scenarios.</description></item>
        /// <item><description>New product launches with rapid initial video material generation: When merchants have a large number of new products to list, they only need to upload product images, product titles, and other basic information to quickly generate product showcase videos, model try-on videos, voiceover explanation videos, and other content, helping merchants rapidly complete material preparation during the launch phase.</description></item>
        /// <item><description>High-fidelity apparel display: Generates model showcase videos based on product main images that closely resemble real commercial photography, with key optimizations for silhouette accuracy, fabric texture preservation, color fidelity, and consistent detail stability. Supports common e-commerce display methods such as garment try-on, turning, walking, close-up shots, and multi-angle switching.</description></item>
        /// <item><description>High-quality commercial photography models: Includes 20+ built-in target audience model libraries covering plus-size women, plus-size men, swimwear, youthful style, smart casual commuter, young casual, business menswear, sports and fitness, and other body types, skin tones, and ethnicities. Supports multiple commercial photography presentation methods such as standing poses, side views, walking displays, and detail close-ups.</description></item>
        /// <item><description>Standard product explanation and other high-frequency e-commerce scenarios: Suitable for standardized product categories such as skincare, cosmetics, personal care small appliances, food and beverages, household cleaning products, and 3C digital products. Quickly generates product explanation videos based on product main images, titles, selling point information, and explanation scripts.</description></item>
        /// <item><description>Multi-product and multi-selling-point testing to improve placement efficiency: For information feed advertising, short video placement, and content marketing scenarios, quickly generates multiple versions of video materials, enabling businesses to cost-effectively validate the conversion performance of different selling points and presentation formats, improving placement ROI.</description></item>
        /// </list>
        /// <h1>Features</h1>
        /// <list type="bullet">
        /// <item><description>Fully automated end-to-end batch generation with zero prompt threshold: Callers only need to provide product image URLs and titles. The system automatically completes the entire process from product understanding, storyboard planning, to video generation, without manual prompt writing, template selection, or repeated parameter tuning. Built-in multi-agent capabilities for product understanding, visual quality inspection, script planning, and directing/camera movement significantly lower the barrier to use.</description></item>
        /// <item><description>Highly stable generation with low waste rate: Uses a deterministic generation process and multi-layer quality control mechanism to output usable materials with fewer retries, reducing invalid generation and resource waste, making overall production costs more controllable.</description></item>
        /// <item><description>E-commerce-specific product fidelity: Built-in multi-round quality inspection agents lock product state throughout video generation (for example, zippers will not be unzipped, sleeves will not be lowered, prints will not disappear). Multi-layer defense through &quot;script rewriting + explicit constraint injection + failure-aware retry&quot; ensures product consistency.</description></item>
        /// <item><description>Reference image priority + 6-axis consistency verification: Uses a Reference-Image-First generation paradigm with the original product image as the sole visual source of truth. Automatically performs 6-dimensional VL diagnostics (color drift, pattern loss, contour deviation, structural addition/removal, model matching, stain detection), fundamentally preventing generated images from deviating from the product.</description></item>
        /// <item><description>Flexible storyboard arrangement and duration control: Supports adjustable video duration from 5–30 seconds. The agent autonomously plans independent storyboards to showcase the product in different scenarios. Also supports fixed-scene mode for in-depth product presentation under a unified visual style.</description></item>
        /// <item><description>Cinematic camera movement capabilities: Built-in advanced camera movement modes including bullet time, Grammy-style slow motion, 360° orbital rotation, and full-body model rotation display, achieving deterministic output through segment-level precise control.</description></item>
        /// <item><description>Model library and customization services: Built-in multi-type model resource library. Supports merchants in specifying fixed models, customizing exclusive model personas, and long-term brand visual identity binding to ensure brand visual consistency.</description></item>
        /// <item><description>Adapted for high-frequency e-commerce content scenarios: Supports multiple resolutions such as 720P and 1080P and multiple aspect ratios such as 3:4 and 9:16, suitable for product detail page video slots, product homepage video displays, waterfall/information feed placements, campaign materials, and new product launch and promotional video generation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// VideoGenerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VideoGenerationResponse
        /// </returns>
        public VideoGenerationResponse VideoGenerationWithOptions(VideoGenerationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            VideoGenerationShrinkRequest request = new VideoGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Intent))
            {
                request.IntentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Intent, "Intent", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Output))
            {
                request.OutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Output, "Output", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentShrink))
            {
                query["Intent"] = request.IntentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputShrink))
            {
                query["Output"] = request.OutputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoGeneration",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoGenerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The E-commerce AI Video Generation Agent is designed for e-commerce merchants and platforms. Based on product main images, titles, selling points, and other information, it automatically generates 5–30 second product showcase short videos, helping customers efficiently produce and distribute e-commerce content. The product supports multiple resolution outputs such as 720P and 1080P, supports both quick single-product calls and multi-product batch generation, and accommodates both daily operations and large-scale product content production needs. Currently, it covers all apparel categories (tops, pants, skirts, suits, underwear, swimwear, etc.) and is gradually expanding to skincare, cosmetics, food and beverages, home appliances, and other core e-commerce categories.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Scenarios</h1>
        /// <list type="bullet">
        /// <item><description>Sellers/platforms batch-generate product short videos: Supports multiple video aspect ratios and sizes (3:4, 9:16), suitable for product detail page video slots, product homepage displays, information feed placements, short video content marketing, campaign material, and other scenarios.</description></item>
        /// <item><description>New product launches with rapid initial video material generation: When merchants have a large number of new products to list, they only need to upload product images, product titles, and other basic information to quickly generate product showcase videos, model try-on videos, voiceover explanation videos, and other content, helping merchants rapidly complete material preparation during the launch phase.</description></item>
        /// <item><description>High-fidelity apparel display: Generates model showcase videos based on product main images that closely resemble real commercial photography, with key optimizations for silhouette accuracy, fabric texture preservation, color fidelity, and consistent detail stability. Supports common e-commerce display methods such as garment try-on, turning, walking, close-up shots, and multi-angle switching.</description></item>
        /// <item><description>High-quality commercial photography models: Includes 20+ built-in target audience model libraries covering plus-size women, plus-size men, swimwear, youthful style, smart casual commuter, young casual, business menswear, sports and fitness, and other body types, skin tones, and ethnicities. Supports multiple commercial photography presentation methods such as standing poses, side views, walking displays, and detail close-ups.</description></item>
        /// <item><description>Standard product explanation and other high-frequency e-commerce scenarios: Suitable for standardized product categories such as skincare, cosmetics, personal care small appliances, food and beverages, household cleaning products, and 3C digital products. Quickly generates product explanation videos based on product main images, titles, selling point information, and explanation scripts.</description></item>
        /// <item><description>Multi-product and multi-selling-point testing to improve placement efficiency: For information feed advertising, short video placement, and content marketing scenarios, quickly generates multiple versions of video materials, enabling businesses to cost-effectively validate the conversion performance of different selling points and presentation formats, improving placement ROI.</description></item>
        /// </list>
        /// <h1>Features</h1>
        /// <list type="bullet">
        /// <item><description>Fully automated end-to-end batch generation with zero prompt threshold: Callers only need to provide product image URLs and titles. The system automatically completes the entire process from product understanding, storyboard planning, to video generation, without manual prompt writing, template selection, or repeated parameter tuning. Built-in multi-agent capabilities for product understanding, visual quality inspection, script planning, and directing/camera movement significantly lower the barrier to use.</description></item>
        /// <item><description>Highly stable generation with low waste rate: Uses a deterministic generation process and multi-layer quality control mechanism to output usable materials with fewer retries, reducing invalid generation and resource waste, making overall production costs more controllable.</description></item>
        /// <item><description>E-commerce-specific product fidelity: Built-in multi-round quality inspection agents lock product state throughout video generation (for example, zippers will not be unzipped, sleeves will not be lowered, prints will not disappear). Multi-layer defense through &quot;script rewriting + explicit constraint injection + failure-aware retry&quot; ensures product consistency.</description></item>
        /// <item><description>Reference image priority + 6-axis consistency verification: Uses a Reference-Image-First generation paradigm with the original product image as the sole visual source of truth. Automatically performs 6-dimensional VL diagnostics (color drift, pattern loss, contour deviation, structural addition/removal, model matching, stain detection), fundamentally preventing generated images from deviating from the product.</description></item>
        /// <item><description>Flexible storyboard arrangement and duration control: Supports adjustable video duration from 5–30 seconds. The agent autonomously plans independent storyboards to showcase the product in different scenarios. Also supports fixed-scene mode for in-depth product presentation under a unified visual style.</description></item>
        /// <item><description>Cinematic camera movement capabilities: Built-in advanced camera movement modes including bullet time, Grammy-style slow motion, 360° orbital rotation, and full-body model rotation display, achieving deterministic output through segment-level precise control.</description></item>
        /// <item><description>Model library and customization services: Built-in multi-type model resource library. Supports merchants in specifying fixed models, customizing exclusive model personas, and long-term brand visual identity binding to ensure brand visual consistency.</description></item>
        /// <item><description>Adapted for high-frequency e-commerce content scenarios: Supports multiple resolutions such as 720P and 1080P and multiple aspect ratios such as 3:4 and 9:16, suitable for product detail page video slots, product homepage video displays, waterfall/information feed placements, campaign materials, and new product launch and promotional video generation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// VideoGenerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VideoGenerationResponse
        /// </returns>
        public async Task<VideoGenerationResponse> VideoGenerationWithOptionsAsync(VideoGenerationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            VideoGenerationShrinkRequest request = new VideoGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Input))
            {
                request.InputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Input, "Input", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Intent))
            {
                request.IntentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Intent, "Intent", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Output))
            {
                request.OutputShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Output, "Output", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputShrink))
            {
                query["Input"] = request.InputShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentShrink))
            {
                query["Intent"] = request.IntentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputShrink))
            {
                query["Output"] = request.OutputShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoGeneration",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The E-commerce AI Video Generation Agent is designed for e-commerce merchants and platforms. Based on product main images, titles, selling points, and other information, it automatically generates 5–30 second product showcase short videos, helping customers efficiently produce and distribute e-commerce content. The product supports multiple resolution outputs such as 720P and 1080P, supports both quick single-product calls and multi-product batch generation, and accommodates both daily operations and large-scale product content production needs. Currently, it covers all apparel categories (tops, pants, skirts, suits, underwear, swimwear, etc.) and is gradually expanding to skincare, cosmetics, food and beverages, home appliances, and other core e-commerce categories.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Scenarios</h1>
        /// <list type="bullet">
        /// <item><description>Sellers/platforms batch-generate product short videos: Supports multiple video aspect ratios and sizes (3:4, 9:16), suitable for product detail page video slots, product homepage displays, information feed placements, short video content marketing, campaign material, and other scenarios.</description></item>
        /// <item><description>New product launches with rapid initial video material generation: When merchants have a large number of new products to list, they only need to upload product images, product titles, and other basic information to quickly generate product showcase videos, model try-on videos, voiceover explanation videos, and other content, helping merchants rapidly complete material preparation during the launch phase.</description></item>
        /// <item><description>High-fidelity apparel display: Generates model showcase videos based on product main images that closely resemble real commercial photography, with key optimizations for silhouette accuracy, fabric texture preservation, color fidelity, and consistent detail stability. Supports common e-commerce display methods such as garment try-on, turning, walking, close-up shots, and multi-angle switching.</description></item>
        /// <item><description>High-quality commercial photography models: Includes 20+ built-in target audience model libraries covering plus-size women, plus-size men, swimwear, youthful style, smart casual commuter, young casual, business menswear, sports and fitness, and other body types, skin tones, and ethnicities. Supports multiple commercial photography presentation methods such as standing poses, side views, walking displays, and detail close-ups.</description></item>
        /// <item><description>Standard product explanation and other high-frequency e-commerce scenarios: Suitable for standardized product categories such as skincare, cosmetics, personal care small appliances, food and beverages, household cleaning products, and 3C digital products. Quickly generates product explanation videos based on product main images, titles, selling point information, and explanation scripts.</description></item>
        /// <item><description>Multi-product and multi-selling-point testing to improve placement efficiency: For information feed advertising, short video placement, and content marketing scenarios, quickly generates multiple versions of video materials, enabling businesses to cost-effectively validate the conversion performance of different selling points and presentation formats, improving placement ROI.</description></item>
        /// </list>
        /// <h1>Features</h1>
        /// <list type="bullet">
        /// <item><description>Fully automated end-to-end batch generation with zero prompt threshold: Callers only need to provide product image URLs and titles. The system automatically completes the entire process from product understanding, storyboard planning, to video generation, without manual prompt writing, template selection, or repeated parameter tuning. Built-in multi-agent capabilities for product understanding, visual quality inspection, script planning, and directing/camera movement significantly lower the barrier to use.</description></item>
        /// <item><description>Highly stable generation with low waste rate: Uses a deterministic generation process and multi-layer quality control mechanism to output usable materials with fewer retries, reducing invalid generation and resource waste, making overall production costs more controllable.</description></item>
        /// <item><description>E-commerce-specific product fidelity: Built-in multi-round quality inspection agents lock product state throughout video generation (for example, zippers will not be unzipped, sleeves will not be lowered, prints will not disappear). Multi-layer defense through &quot;script rewriting + explicit constraint injection + failure-aware retry&quot; ensures product consistency.</description></item>
        /// <item><description>Reference image priority + 6-axis consistency verification: Uses a Reference-Image-First generation paradigm with the original product image as the sole visual source of truth. Automatically performs 6-dimensional VL diagnostics (color drift, pattern loss, contour deviation, structural addition/removal, model matching, stain detection), fundamentally preventing generated images from deviating from the product.</description></item>
        /// <item><description>Flexible storyboard arrangement and duration control: Supports adjustable video duration from 5–30 seconds. The agent autonomously plans independent storyboards to showcase the product in different scenarios. Also supports fixed-scene mode for in-depth product presentation under a unified visual style.</description></item>
        /// <item><description>Cinematic camera movement capabilities: Built-in advanced camera movement modes including bullet time, Grammy-style slow motion, 360° orbital rotation, and full-body model rotation display, achieving deterministic output through segment-level precise control.</description></item>
        /// <item><description>Model library and customization services: Built-in multi-type model resource library. Supports merchants in specifying fixed models, customizing exclusive model personas, and long-term brand visual identity binding to ensure brand visual consistency.</description></item>
        /// <item><description>Adapted for high-frequency e-commerce content scenarios: Supports multiple resolutions such as 720P and 1080P and multiple aspect ratios such as 3:4 and 9:16, suitable for product detail page video slots, product homepage video displays, waterfall/information feed placements, campaign materials, and new product launch and promotional video generation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// VideoGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// VideoGenerationResponse
        /// </returns>
        public VideoGenerationResponse VideoGeneration(VideoGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VideoGenerationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The E-commerce AI Video Generation Agent is designed for e-commerce merchants and platforms. Based on product main images, titles, selling points, and other information, it automatically generates 5–30 second product showcase short videos, helping customers efficiently produce and distribute e-commerce content. The product supports multiple resolution outputs such as 720P and 1080P, supports both quick single-product calls and multi-product batch generation, and accommodates both daily operations and large-scale product content production needs. Currently, it covers all apparel categories (tops, pants, skirts, suits, underwear, swimwear, etc.) and is gradually expanding to skincare, cosmetics, food and beverages, home appliances, and other core e-commerce categories.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Scenarios</h1>
        /// <list type="bullet">
        /// <item><description>Sellers/platforms batch-generate product short videos: Supports multiple video aspect ratios and sizes (3:4, 9:16), suitable for product detail page video slots, product homepage displays, information feed placements, short video content marketing, campaign material, and other scenarios.</description></item>
        /// <item><description>New product launches with rapid initial video material generation: When merchants have a large number of new products to list, they only need to upload product images, product titles, and other basic information to quickly generate product showcase videos, model try-on videos, voiceover explanation videos, and other content, helping merchants rapidly complete material preparation during the launch phase.</description></item>
        /// <item><description>High-fidelity apparel display: Generates model showcase videos based on product main images that closely resemble real commercial photography, with key optimizations for silhouette accuracy, fabric texture preservation, color fidelity, and consistent detail stability. Supports common e-commerce display methods such as garment try-on, turning, walking, close-up shots, and multi-angle switching.</description></item>
        /// <item><description>High-quality commercial photography models: Includes 20+ built-in target audience model libraries covering plus-size women, plus-size men, swimwear, youthful style, smart casual commuter, young casual, business menswear, sports and fitness, and other body types, skin tones, and ethnicities. Supports multiple commercial photography presentation methods such as standing poses, side views, walking displays, and detail close-ups.</description></item>
        /// <item><description>Standard product explanation and other high-frequency e-commerce scenarios: Suitable for standardized product categories such as skincare, cosmetics, personal care small appliances, food and beverages, household cleaning products, and 3C digital products. Quickly generates product explanation videos based on product main images, titles, selling point information, and explanation scripts.</description></item>
        /// <item><description>Multi-product and multi-selling-point testing to improve placement efficiency: For information feed advertising, short video placement, and content marketing scenarios, quickly generates multiple versions of video materials, enabling businesses to cost-effectively validate the conversion performance of different selling points and presentation formats, improving placement ROI.</description></item>
        /// </list>
        /// <h1>Features</h1>
        /// <list type="bullet">
        /// <item><description>Fully automated end-to-end batch generation with zero prompt threshold: Callers only need to provide product image URLs and titles. The system automatically completes the entire process from product understanding, storyboard planning, to video generation, without manual prompt writing, template selection, or repeated parameter tuning. Built-in multi-agent capabilities for product understanding, visual quality inspection, script planning, and directing/camera movement significantly lower the barrier to use.</description></item>
        /// <item><description>Highly stable generation with low waste rate: Uses a deterministic generation process and multi-layer quality control mechanism to output usable materials with fewer retries, reducing invalid generation and resource waste, making overall production costs more controllable.</description></item>
        /// <item><description>E-commerce-specific product fidelity: Built-in multi-round quality inspection agents lock product state throughout video generation (for example, zippers will not be unzipped, sleeves will not be lowered, prints will not disappear). Multi-layer defense through &quot;script rewriting + explicit constraint injection + failure-aware retry&quot; ensures product consistency.</description></item>
        /// <item><description>Reference image priority + 6-axis consistency verification: Uses a Reference-Image-First generation paradigm with the original product image as the sole visual source of truth. Automatically performs 6-dimensional VL diagnostics (color drift, pattern loss, contour deviation, structural addition/removal, model matching, stain detection), fundamentally preventing generated images from deviating from the product.</description></item>
        /// <item><description>Flexible storyboard arrangement and duration control: Supports adjustable video duration from 5–30 seconds. The agent autonomously plans independent storyboards to showcase the product in different scenarios. Also supports fixed-scene mode for in-depth product presentation under a unified visual style.</description></item>
        /// <item><description>Cinematic camera movement capabilities: Built-in advanced camera movement modes including bullet time, Grammy-style slow motion, 360° orbital rotation, and full-body model rotation display, achieving deterministic output through segment-level precise control.</description></item>
        /// <item><description>Model library and customization services: Built-in multi-type model resource library. Supports merchants in specifying fixed models, customizing exclusive model personas, and long-term brand visual identity binding to ensure brand visual consistency.</description></item>
        /// <item><description>Adapted for high-frequency e-commerce content scenarios: Supports multiple resolutions such as 720P and 1080P and multiple aspect ratios such as 3:4 and 9:16, suitable for product detail page video slots, product homepage video displays, waterfall/information feed placements, campaign materials, and new product launch and promotional video generation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// VideoGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// VideoGenerationResponse
        /// </returns>
        public async Task<VideoGenerationResponse> VideoGenerationAsync(VideoGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VideoGenerationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Translates embedded text (subtitles, promotional text, etc.) in video frames into a target language and erases the original text.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>1. Product Introduction</h2>
        /// <para>The Video Translation API translates embedded text (subtitles, promotional text, etc.) in video frames into a target language and erases the original text. This API is applicable to scenarios such as multilingual distribution of e-commerce videos, international social media marketing, and global brand advertising.
        /// The API uses an asynchronous call mode: after submitting a translation task, you receive a <c>task_id</c>, then poll the query endpoint for the task status until the task is completed and results are available.</para>
        /// <h2>2. Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Cross-border e-commerce video localization</b>: Translates promotional text in product introduction videos into the target market language to facilitate overseas platform promotion.</para>
        /// </description></item>
        /// <item><description><para><b>International social media marketing</b>: Localizes text content in video frames with one click for platforms such as TikTok, Instagram, and YouTube, improving comprehension and conversion rates among overseas users.</para>
        /// </description></item>
        /// <item><description><para><b>Global brand advertising</b>: Automatically generates video versions in the language of the target region, reducing manual production costs.</para>
        /// </description></item>
        /// <item><description><para><b>Training and product documentation</b>: Translates on-screen text in training courses or product demonstration videos into multiple languages for use by global teams.</para>
        /// </description></item>
        /// </list>
        /// <h2>3. Features</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Capability</th>
        /// <th>Identifier</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Visual translation</td>
        /// <td><c>visual</c></td>
        /// <td>Translates embedded text (subtitles, promotional text, etc.) in video frames into the target language and erases the original text</td>
        /// </tr>
        /// </tbody></table>
        /// <h2>4. Developer guide.</h2>
        /// <h3>4.1 Submit a translation task.</h3>
        /// <h4>Request</h4>
        /// <para><c>POST /api/v1/video/translation</c></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// VideoTranslationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VideoTranslationResponse
        /// </returns>
        public VideoTranslationResponse VideoTranslationWithOptions(VideoTranslationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            VideoTranslationShrinkRequest request = new VideoTranslationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Capabilities))
            {
                request.CapabilitiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Capabilities, "Capabilities", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CapabilitiesShrink))
            {
                body["Capabilities"] = request.CapabilitiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                body["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                body["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUrl))
            {
                body["VideoUrl"] = request.VideoUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoTranslation",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoTranslationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Translates embedded text (subtitles, promotional text, etc.) in video frames into a target language and erases the original text.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>1. Product Introduction</h2>
        /// <para>The Video Translation API translates embedded text (subtitles, promotional text, etc.) in video frames into a target language and erases the original text. This API is applicable to scenarios such as multilingual distribution of e-commerce videos, international social media marketing, and global brand advertising.
        /// The API uses an asynchronous call mode: after submitting a translation task, you receive a <c>task_id</c>, then poll the query endpoint for the task status until the task is completed and results are available.</para>
        /// <h2>2. Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Cross-border e-commerce video localization</b>: Translates promotional text in product introduction videos into the target market language to facilitate overseas platform promotion.</para>
        /// </description></item>
        /// <item><description><para><b>International social media marketing</b>: Localizes text content in video frames with one click for platforms such as TikTok, Instagram, and YouTube, improving comprehension and conversion rates among overseas users.</para>
        /// </description></item>
        /// <item><description><para><b>Global brand advertising</b>: Automatically generates video versions in the language of the target region, reducing manual production costs.</para>
        /// </description></item>
        /// <item><description><para><b>Training and product documentation</b>: Translates on-screen text in training courses or product demonstration videos into multiple languages for use by global teams.</para>
        /// </description></item>
        /// </list>
        /// <h2>3. Features</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Capability</th>
        /// <th>Identifier</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Visual translation</td>
        /// <td><c>visual</c></td>
        /// <td>Translates embedded text (subtitles, promotional text, etc.) in video frames into the target language and erases the original text</td>
        /// </tr>
        /// </tbody></table>
        /// <h2>4. Developer guide.</h2>
        /// <h3>4.1 Submit a translation task.</h3>
        /// <h4>Request</h4>
        /// <para><c>POST /api/v1/video/translation</c></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// VideoTranslationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VideoTranslationResponse
        /// </returns>
        public async Task<VideoTranslationResponse> VideoTranslationWithOptionsAsync(VideoTranslationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            VideoTranslationShrinkRequest request = new VideoTranslationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Capabilities))
            {
                request.CapabilitiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Capabilities, "Capabilities", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CapabilitiesShrink))
            {
                body["Capabilities"] = request.CapabilitiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                body["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                body["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUrl))
            {
                body["VideoUrl"] = request.VideoUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoTranslation",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoTranslationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Translates embedded text (subtitles, promotional text, etc.) in video frames into a target language and erases the original text.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>1. Product Introduction</h2>
        /// <para>The Video Translation API translates embedded text (subtitles, promotional text, etc.) in video frames into a target language and erases the original text. This API is applicable to scenarios such as multilingual distribution of e-commerce videos, international social media marketing, and global brand advertising.
        /// The API uses an asynchronous call mode: after submitting a translation task, you receive a <c>task_id</c>, then poll the query endpoint for the task status until the task is completed and results are available.</para>
        /// <h2>2. Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Cross-border e-commerce video localization</b>: Translates promotional text in product introduction videos into the target market language to facilitate overseas platform promotion.</para>
        /// </description></item>
        /// <item><description><para><b>International social media marketing</b>: Localizes text content in video frames with one click for platforms such as TikTok, Instagram, and YouTube, improving comprehension and conversion rates among overseas users.</para>
        /// </description></item>
        /// <item><description><para><b>Global brand advertising</b>: Automatically generates video versions in the language of the target region, reducing manual production costs.</para>
        /// </description></item>
        /// <item><description><para><b>Training and product documentation</b>: Translates on-screen text in training courses or product demonstration videos into multiple languages for use by global teams.</para>
        /// </description></item>
        /// </list>
        /// <h2>3. Features</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Capability</th>
        /// <th>Identifier</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Visual translation</td>
        /// <td><c>visual</c></td>
        /// <td>Translates embedded text (subtitles, promotional text, etc.) in video frames into the target language and erases the original text</td>
        /// </tr>
        /// </tbody></table>
        /// <h2>4. Developer guide.</h2>
        /// <h3>4.1 Submit a translation task.</h3>
        /// <h4>Request</h4>
        /// <para><c>POST /api/v1/video/translation</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// VideoTranslationRequest
        /// </param>
        /// 
        /// <returns>
        /// VideoTranslationResponse
        /// </returns>
        public VideoTranslationResponse VideoTranslation(VideoTranslationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VideoTranslationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Translates embedded text (subtitles, promotional text, etc.) in video frames into a target language and erases the original text.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>1. Product Introduction</h2>
        /// <para>The Video Translation API translates embedded text (subtitles, promotional text, etc.) in video frames into a target language and erases the original text. This API is applicable to scenarios such as multilingual distribution of e-commerce videos, international social media marketing, and global brand advertising.
        /// The API uses an asynchronous call mode: after submitting a translation task, you receive a <c>task_id</c>, then poll the query endpoint for the task status until the task is completed and results are available.</para>
        /// <h2>2. Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Cross-border e-commerce video localization</b>: Translates promotional text in product introduction videos into the target market language to facilitate overseas platform promotion.</para>
        /// </description></item>
        /// <item><description><para><b>International social media marketing</b>: Localizes text content in video frames with one click for platforms such as TikTok, Instagram, and YouTube, improving comprehension and conversion rates among overseas users.</para>
        /// </description></item>
        /// <item><description><para><b>Global brand advertising</b>: Automatically generates video versions in the language of the target region, reducing manual production costs.</para>
        /// </description></item>
        /// <item><description><para><b>Training and product documentation</b>: Translates on-screen text in training courses or product demonstration videos into multiple languages for use by global teams.</para>
        /// </description></item>
        /// </list>
        /// <h2>3. Features</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Capability</th>
        /// <th>Identifier</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Visual translation</td>
        /// <td><c>visual</c></td>
        /// <td>Translates embedded text (subtitles, promotional text, etc.) in video frames into the target language and erases the original text</td>
        /// </tr>
        /// </tbody></table>
        /// <h2>4. Developer guide.</h2>
        /// <h3>4.1 Submit a translation task.</h3>
        /// <h4>Request</h4>
        /// <para><c>POST /api/v1/video/translation</c></para>
        /// </description>
        /// 
        /// <param name="request">
        /// VideoTranslationRequest
        /// </param>
        /// 
        /// <returns>
        /// VideoTranslationResponse
        /// </returns>
        public async Task<VideoTranslationResponse> VideoTranslationAsync(VideoTranslationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VideoTranslationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates virtual try-on images based on AI algorithms. This API service replaces the clothing on a model with the specified garment based on the input garment image and model image, while preserving the model\&quot;s appearance details, pose, facial features, and scene details to achieve a realistic and well-fitted try-on result. You only need to provide the URL of the original product image to obtain a processed clean image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Scenarios</h2>
        /// <list type="bullet">
        /// <item><description><b>Virtual try-on for clothing products:</b>
        /// Supports multiple clothing categories such as tops, bottoms, jumpsuits, and skirts. After uploading a model image and a product image, the system generates a natural and realistic try-on effect that intuitively showcases how the clothing looks when worn.</description></item>
        /// <item><description><b>Virtual try-on for shoes and hats:</b>
        /// Supports virtual try-on for shoes, hats, and similar products. The system intelligently matches the product position and proportion based on the model\&quot;s pose and body parts, producing a coordinated and realistic wearing effect.</description></item>
        /// <item><description><b>E-commerce product display and marketing:</b>
        /// Helps merchants quickly generate model try-on images for different products, reducing the costs of traditional photography, outfit changes, and post-production, and improving the production efficiency of product images.  </description></item>
        /// <item><description><b>Online shopping experience optimization:</b>
        /// Consumers can preview how products look when worn through virtual try-on, gaining a more intuitive understanding of the style, coordination, and overall effect of products, which assists purchase decisions and enhances the shopping experience.</description></item>
        /// </list>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>First, the user needs to provide a model image and a product image. The system uses the model image as the try-on subject and applies the garment from the product image onto the model:</b><list type="bullet">
        /// <item><description>a. Model image: the image of the person for the virtual try-on.</description></item>
        /// <item><description>b. Product image: the image of the clothing, shoes, or hat to be applied onto the model.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Second, the user can select the corresponding product type based on the actual product. Supported types include tops, bottoms, jumpsuits, skirts, shoes, and hats:</b><list type="bullet">
        /// <item><description>a. Specified product type: the user can directly specify the product type, and the system processes accordingly.</description></item>
        /// <item><description>b. Automatic type recognition: if the user does not specify a product type, the system automatically identifies the product category from the product image and performs the virtual try-on based on the recognition result.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Finally, the system combines the model image, product image, and product type to generate a virtual try-on image that shows how the product looks on the model:</b><list type="bullet">
        /// <item><description>a. Preserves model details: the generation process does not alter the model\&quot;s appearance, hairstyle, pose, body shape, or other details from the original model image.</description></item>
        /// <item><description>b. Maintains scene consistency: the background, composition, lighting, and overall visual effect of the original model image remain unchanged. Only the wearing area corresponding to the product is processed.</description></item>
        /// <item><description>c. Generates try-on effect: the product is naturally applied onto the model, fitting the model\&quot;s pose and body structure to produce a coordinated and realistic virtual try-on image.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h2>Sample results</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Type</b></th>
        /// <th><b>Model image</b></th>
        /// <th><b>Garment image</b></th>
        /// <th><b>Try-on result</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Tops</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/e4273b03-0d3b-4e98-b8f3-8713fccee303.png" alt="lQLPJv-OKUNDSxvNBojNA62wAMWEBuiTUuMKXnNidWFWAA_941_1672.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/d9ab77f7-8791-4fa5-8d76-4fda3e2e1310.png" alt="男模特衬衫正面-aidge.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/42982786-73ee-4d23-a8d0-551f7a18be22.png" alt="7c1c0c04-9828-940f-b86d-c08f7ec8fb97_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Bottoms</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/64147be2-0c95-431a-8c04-f756fac96db2.jpeg" alt="lQDPJwcNMfxtoRvNBQDNAtCwhseujKzDt_QKXnNSTPaeAA_720_1280.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/f79a31cb-08bd-4b59-be9d-9b9aa3f60230.png" alt="微喇牛仔裤-aidge.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/297f29eb-7bc9-49a5-b4f7-114375a0f312.png" alt="adbb8e02-9738-991a-9699-f46bc5c089a9_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Shoes</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/64147be2-0c95-431a-8c04-f756fac96db2.jpeg" alt="lQDPJwcNMfxtoRvNBQDNAtCwhseujKzDt_QKXnNSTPaeAA_720_1280.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/bb9804b5-0ab9-485b-829b-d54708377fd2.png" alt="男模特鞋子正面-aidge.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/8e54fdc3-7a86-4e3b-aa1d-f3741ce7658c.png" alt="91d7b8c4-fc31-9a7f-8b6e-3bec5e62efb3_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Jumpsuits</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/eddffa7c-a494-4f5b-9d66-da758fb0265f.jpeg" alt="lQDPJwcNMfxtoRvNBQDNAtCwhseujKzDt_QKXnNSTPaeAA_720_1280.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/7f5cec40-a884-4640-8339-6109305dfa1d.png" alt="image.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/635096eb-f2b2-4fd8-91d8-4c7e2e7d7ad1.png" alt="20c8b46a-213e-985c-aab2-d56f8752f3a4_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Skirts</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/eddffa7c-a494-4f5b-9d66-da758fb0265f.jpeg" alt="lQDPJwcNMfxtoRvNBQDNAtCwhseujKzDt_QKXnNSTPaeAA_720_1280.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/3d4a6de0-95d2-40cf-9105-48b5e899e0d3.png" alt="image.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/a3cbb609-db71-47d6-8ac6-884f18c6596f.png" alt="45b630e6-4e9d-9bf0-bb4e-224b30a91f77_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Hats</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/ac26f38e-acc7-49d1-a4ec-a51b54e4bd66.png" alt="adbb8e02-9738-991a-9699-f46bc5c089a9_qwen_image3_serving_output_0.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/34176b57-3aa8-4b6e-8d0f-808ae953654a.png" alt="帽子-aidge.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/949b4c28-8821-4aa5-a2b4-e4acc1e57b9b.png" alt="881f02f3-12f5-95dd-b651-98fab6e30fa0_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// VirtualTryOnRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VirtualTryOnResponse
        /// </returns>
        public VirtualTryOnResponse VirtualTryOnWithOptions(VirtualTryOnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClothImageUrl))
            {
                query["ClothImageUrl"] = request.ClothImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClothType))
            {
                query["ClothType"] = request.ClothType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelImageUrl))
            {
                query["ModelImageUrl"] = request.ModelImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                query["Resolution"] = request.Resolution;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VirtualTryOn",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VirtualTryOnResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates virtual try-on images based on AI algorithms. This API service replaces the clothing on a model with the specified garment based on the input garment image and model image, while preserving the model\&quot;s appearance details, pose, facial features, and scene details to achieve a realistic and well-fitted try-on result. You only need to provide the URL of the original product image to obtain a processed clean image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Scenarios</h2>
        /// <list type="bullet">
        /// <item><description><b>Virtual try-on for clothing products:</b>
        /// Supports multiple clothing categories such as tops, bottoms, jumpsuits, and skirts. After uploading a model image and a product image, the system generates a natural and realistic try-on effect that intuitively showcases how the clothing looks when worn.</description></item>
        /// <item><description><b>Virtual try-on for shoes and hats:</b>
        /// Supports virtual try-on for shoes, hats, and similar products. The system intelligently matches the product position and proportion based on the model\&quot;s pose and body parts, producing a coordinated and realistic wearing effect.</description></item>
        /// <item><description><b>E-commerce product display and marketing:</b>
        /// Helps merchants quickly generate model try-on images for different products, reducing the costs of traditional photography, outfit changes, and post-production, and improving the production efficiency of product images.  </description></item>
        /// <item><description><b>Online shopping experience optimization:</b>
        /// Consumers can preview how products look when worn through virtual try-on, gaining a more intuitive understanding of the style, coordination, and overall effect of products, which assists purchase decisions and enhances the shopping experience.</description></item>
        /// </list>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>First, the user needs to provide a model image and a product image. The system uses the model image as the try-on subject and applies the garment from the product image onto the model:</b><list type="bullet">
        /// <item><description>a. Model image: the image of the person for the virtual try-on.</description></item>
        /// <item><description>b. Product image: the image of the clothing, shoes, or hat to be applied onto the model.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Second, the user can select the corresponding product type based on the actual product. Supported types include tops, bottoms, jumpsuits, skirts, shoes, and hats:</b><list type="bullet">
        /// <item><description>a. Specified product type: the user can directly specify the product type, and the system processes accordingly.</description></item>
        /// <item><description>b. Automatic type recognition: if the user does not specify a product type, the system automatically identifies the product category from the product image and performs the virtual try-on based on the recognition result.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Finally, the system combines the model image, product image, and product type to generate a virtual try-on image that shows how the product looks on the model:</b><list type="bullet">
        /// <item><description>a. Preserves model details: the generation process does not alter the model\&quot;s appearance, hairstyle, pose, body shape, or other details from the original model image.</description></item>
        /// <item><description>b. Maintains scene consistency: the background, composition, lighting, and overall visual effect of the original model image remain unchanged. Only the wearing area corresponding to the product is processed.</description></item>
        /// <item><description>c. Generates try-on effect: the product is naturally applied onto the model, fitting the model\&quot;s pose and body structure to produce a coordinated and realistic virtual try-on image.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h2>Sample results</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Type</b></th>
        /// <th><b>Model image</b></th>
        /// <th><b>Garment image</b></th>
        /// <th><b>Try-on result</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Tops</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/e4273b03-0d3b-4e98-b8f3-8713fccee303.png" alt="lQLPJv-OKUNDSxvNBojNA62wAMWEBuiTUuMKXnNidWFWAA_941_1672.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/d9ab77f7-8791-4fa5-8d76-4fda3e2e1310.png" alt="男模特衬衫正面-aidge.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/42982786-73ee-4d23-a8d0-551f7a18be22.png" alt="7c1c0c04-9828-940f-b86d-c08f7ec8fb97_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Bottoms</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/64147be2-0c95-431a-8c04-f756fac96db2.jpeg" alt="lQDPJwcNMfxtoRvNBQDNAtCwhseujKzDt_QKXnNSTPaeAA_720_1280.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/f79a31cb-08bd-4b59-be9d-9b9aa3f60230.png" alt="微喇牛仔裤-aidge.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/297f29eb-7bc9-49a5-b4f7-114375a0f312.png" alt="adbb8e02-9738-991a-9699-f46bc5c089a9_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Shoes</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/64147be2-0c95-431a-8c04-f756fac96db2.jpeg" alt="lQDPJwcNMfxtoRvNBQDNAtCwhseujKzDt_QKXnNSTPaeAA_720_1280.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/bb9804b5-0ab9-485b-829b-d54708377fd2.png" alt="男模特鞋子正面-aidge.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/8e54fdc3-7a86-4e3b-aa1d-f3741ce7658c.png" alt="91d7b8c4-fc31-9a7f-8b6e-3bec5e62efb3_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Jumpsuits</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/eddffa7c-a494-4f5b-9d66-da758fb0265f.jpeg" alt="lQDPJwcNMfxtoRvNBQDNAtCwhseujKzDt_QKXnNSTPaeAA_720_1280.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/7f5cec40-a884-4640-8339-6109305dfa1d.png" alt="image.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/635096eb-f2b2-4fd8-91d8-4c7e2e7d7ad1.png" alt="20c8b46a-213e-985c-aab2-d56f8752f3a4_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Skirts</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/eddffa7c-a494-4f5b-9d66-da758fb0265f.jpeg" alt="lQDPJwcNMfxtoRvNBQDNAtCwhseujKzDt_QKXnNSTPaeAA_720_1280.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/3d4a6de0-95d2-40cf-9105-48b5e899e0d3.png" alt="image.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/a3cbb609-db71-47d6-8ac6-884f18c6596f.png" alt="45b630e6-4e9d-9bf0-bb4e-224b30a91f77_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Hats</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/ac26f38e-acc7-49d1-a4ec-a51b54e4bd66.png" alt="adbb8e02-9738-991a-9699-f46bc5c089a9_qwen_image3_serving_output_0.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/34176b57-3aa8-4b6e-8d0f-808ae953654a.png" alt="帽子-aidge.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/949b4c28-8821-4aa5-a2b4-e4acc1e57b9b.png" alt="881f02f3-12f5-95dd-b651-98fab6e30fa0_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// VirtualTryOnRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VirtualTryOnResponse
        /// </returns>
        public async Task<VirtualTryOnResponse> VirtualTryOnWithOptionsAsync(VirtualTryOnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClothImageUrl))
            {
                query["ClothImageUrl"] = request.ClothImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClothType))
            {
                query["ClothType"] = request.ClothType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelImageUrl))
            {
                query["ModelImageUrl"] = request.ModelImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resolution))
            {
                query["Resolution"] = request.Resolution;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VirtualTryOn",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VirtualTryOnResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates virtual try-on images based on AI algorithms. This API service replaces the clothing on a model with the specified garment based on the input garment image and model image, while preserving the model\&quot;s appearance details, pose, facial features, and scene details to achieve a realistic and well-fitted try-on result. You only need to provide the URL of the original product image to obtain a processed clean image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Scenarios</h2>
        /// <list type="bullet">
        /// <item><description><b>Virtual try-on for clothing products:</b>
        /// Supports multiple clothing categories such as tops, bottoms, jumpsuits, and skirts. After uploading a model image and a product image, the system generates a natural and realistic try-on effect that intuitively showcases how the clothing looks when worn.</description></item>
        /// <item><description><b>Virtual try-on for shoes and hats:</b>
        /// Supports virtual try-on for shoes, hats, and similar products. The system intelligently matches the product position and proportion based on the model\&quot;s pose and body parts, producing a coordinated and realistic wearing effect.</description></item>
        /// <item><description><b>E-commerce product display and marketing:</b>
        /// Helps merchants quickly generate model try-on images for different products, reducing the costs of traditional photography, outfit changes, and post-production, and improving the production efficiency of product images.  </description></item>
        /// <item><description><b>Online shopping experience optimization:</b>
        /// Consumers can preview how products look when worn through virtual try-on, gaining a more intuitive understanding of the style, coordination, and overall effect of products, which assists purchase decisions and enhances the shopping experience.</description></item>
        /// </list>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>First, the user needs to provide a model image and a product image. The system uses the model image as the try-on subject and applies the garment from the product image onto the model:</b><list type="bullet">
        /// <item><description>a. Model image: the image of the person for the virtual try-on.</description></item>
        /// <item><description>b. Product image: the image of the clothing, shoes, or hat to be applied onto the model.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Second, the user can select the corresponding product type based on the actual product. Supported types include tops, bottoms, jumpsuits, skirts, shoes, and hats:</b><list type="bullet">
        /// <item><description>a. Specified product type: the user can directly specify the product type, and the system processes accordingly.</description></item>
        /// <item><description>b. Automatic type recognition: if the user does not specify a product type, the system automatically identifies the product category from the product image and performs the virtual try-on based on the recognition result.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Finally, the system combines the model image, product image, and product type to generate a virtual try-on image that shows how the product looks on the model:</b><list type="bullet">
        /// <item><description>a. Preserves model details: the generation process does not alter the model\&quot;s appearance, hairstyle, pose, body shape, or other details from the original model image.</description></item>
        /// <item><description>b. Maintains scene consistency: the background, composition, lighting, and overall visual effect of the original model image remain unchanged. Only the wearing area corresponding to the product is processed.</description></item>
        /// <item><description>c. Generates try-on effect: the product is naturally applied onto the model, fitting the model\&quot;s pose and body structure to produce a coordinated and realistic virtual try-on image.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h2>Sample results</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Type</b></th>
        /// <th><b>Model image</b></th>
        /// <th><b>Garment image</b></th>
        /// <th><b>Try-on result</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Tops</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/e4273b03-0d3b-4e98-b8f3-8713fccee303.png" alt="lQLPJv-OKUNDSxvNBojNA62wAMWEBuiTUuMKXnNidWFWAA_941_1672.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/d9ab77f7-8791-4fa5-8d76-4fda3e2e1310.png" alt="男模特衬衫正面-aidge.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/42982786-73ee-4d23-a8d0-551f7a18be22.png" alt="7c1c0c04-9828-940f-b86d-c08f7ec8fb97_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Bottoms</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/64147be2-0c95-431a-8c04-f756fac96db2.jpeg" alt="lQDPJwcNMfxtoRvNBQDNAtCwhseujKzDt_QKXnNSTPaeAA_720_1280.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/f79a31cb-08bd-4b59-be9d-9b9aa3f60230.png" alt="微喇牛仔裤-aidge.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/297f29eb-7bc9-49a5-b4f7-114375a0f312.png" alt="adbb8e02-9738-991a-9699-f46bc5c089a9_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Shoes</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/64147be2-0c95-431a-8c04-f756fac96db2.jpeg" alt="lQDPJwcNMfxtoRvNBQDNAtCwhseujKzDt_QKXnNSTPaeAA_720_1280.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/bb9804b5-0ab9-485b-829b-d54708377fd2.png" alt="男模特鞋子正面-aidge.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/8e54fdc3-7a86-4e3b-aa1d-f3741ce7658c.png" alt="91d7b8c4-fc31-9a7f-8b6e-3bec5e62efb3_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Jumpsuits</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/eddffa7c-a494-4f5b-9d66-da758fb0265f.jpeg" alt="lQDPJwcNMfxtoRvNBQDNAtCwhseujKzDt_QKXnNSTPaeAA_720_1280.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/7f5cec40-a884-4640-8339-6109305dfa1d.png" alt="image.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/635096eb-f2b2-4fd8-91d8-4c7e2e7d7ad1.png" alt="20c8b46a-213e-985c-aab2-d56f8752f3a4_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Skirts</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/eddffa7c-a494-4f5b-9d66-da758fb0265f.jpeg" alt="lQDPJwcNMfxtoRvNBQDNAtCwhseujKzDt_QKXnNSTPaeAA_720_1280.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/3d4a6de0-95d2-40cf-9105-48b5e899e0d3.png" alt="image.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/a3cbb609-db71-47d6-8ac6-884f18c6596f.png" alt="45b630e6-4e9d-9bf0-bb4e-224b30a91f77_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Hats</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/ac26f38e-acc7-49d1-a4ec-a51b54e4bd66.png" alt="adbb8e02-9738-991a-9699-f46bc5c089a9_qwen_image3_serving_output_0.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/34176b57-3aa8-4b6e-8d0f-808ae953654a.png" alt="帽子-aidge.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/949b4c28-8821-4aa5-a2b4-e4acc1e57b9b.png" alt="881f02f3-12f5-95dd-b651-98fab6e30fa0_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// VirtualTryOnRequest
        /// </param>
        /// 
        /// <returns>
        /// VirtualTryOnResponse
        /// </returns>
        public VirtualTryOnResponse VirtualTryOn(VirtualTryOnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VirtualTryOnWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates virtual try-on images based on AI algorithms. This API service replaces the clothing on a model with the specified garment based on the input garment image and model image, while preserving the model\&quot;s appearance details, pose, facial features, and scene details to achieve a realistic and well-fitted try-on result. You only need to provide the URL of the original product image to obtain a processed clean image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Scenarios</h2>
        /// <list type="bullet">
        /// <item><description><b>Virtual try-on for clothing products:</b>
        /// Supports multiple clothing categories such as tops, bottoms, jumpsuits, and skirts. After uploading a model image and a product image, the system generates a natural and realistic try-on effect that intuitively showcases how the clothing looks when worn.</description></item>
        /// <item><description><b>Virtual try-on for shoes and hats:</b>
        /// Supports virtual try-on for shoes, hats, and similar products. The system intelligently matches the product position and proportion based on the model\&quot;s pose and body parts, producing a coordinated and realistic wearing effect.</description></item>
        /// <item><description><b>E-commerce product display and marketing:</b>
        /// Helps merchants quickly generate model try-on images for different products, reducing the costs of traditional photography, outfit changes, and post-production, and improving the production efficiency of product images.  </description></item>
        /// <item><description><b>Online shopping experience optimization:</b>
        /// Consumers can preview how products look when worn through virtual try-on, gaining a more intuitive understanding of the style, coordination, and overall effect of products, which assists purchase decisions and enhances the shopping experience.</description></item>
        /// </list>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>First, the user needs to provide a model image and a product image. The system uses the model image as the try-on subject and applies the garment from the product image onto the model:</b><list type="bullet">
        /// <item><description>a. Model image: the image of the person for the virtual try-on.</description></item>
        /// <item><description>b. Product image: the image of the clothing, shoes, or hat to be applied onto the model.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Second, the user can select the corresponding product type based on the actual product. Supported types include tops, bottoms, jumpsuits, skirts, shoes, and hats:</b><list type="bullet">
        /// <item><description>a. Specified product type: the user can directly specify the product type, and the system processes accordingly.</description></item>
        /// <item><description>b. Automatic type recognition: if the user does not specify a product type, the system automatically identifies the product category from the product image and performs the virtual try-on based on the recognition result.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Finally, the system combines the model image, product image, and product type to generate a virtual try-on image that shows how the product looks on the model:</b><list type="bullet">
        /// <item><description>a. Preserves model details: the generation process does not alter the model\&quot;s appearance, hairstyle, pose, body shape, or other details from the original model image.</description></item>
        /// <item><description>b. Maintains scene consistency: the background, composition, lighting, and overall visual effect of the original model image remain unchanged. Only the wearing area corresponding to the product is processed.</description></item>
        /// <item><description>c. Generates try-on effect: the product is naturally applied onto the model, fitting the model\&quot;s pose and body structure to produce a coordinated and realistic virtual try-on image.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h2>Sample results</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Type</b></th>
        /// <th><b>Model image</b></th>
        /// <th><b>Garment image</b></th>
        /// <th><b>Try-on result</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Tops</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/e4273b03-0d3b-4e98-b8f3-8713fccee303.png" alt="lQLPJv-OKUNDSxvNBojNA62wAMWEBuiTUuMKXnNidWFWAA_941_1672.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/d9ab77f7-8791-4fa5-8d76-4fda3e2e1310.png" alt="男模特衬衫正面-aidge.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/42982786-73ee-4d23-a8d0-551f7a18be22.png" alt="7c1c0c04-9828-940f-b86d-c08f7ec8fb97_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Bottoms</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/64147be2-0c95-431a-8c04-f756fac96db2.jpeg" alt="lQDPJwcNMfxtoRvNBQDNAtCwhseujKzDt_QKXnNSTPaeAA_720_1280.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/f79a31cb-08bd-4b59-be9d-9b9aa3f60230.png" alt="微喇牛仔裤-aidge.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/297f29eb-7bc9-49a5-b4f7-114375a0f312.png" alt="adbb8e02-9738-991a-9699-f46bc5c089a9_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Shoes</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/64147be2-0c95-431a-8c04-f756fac96db2.jpeg" alt="lQDPJwcNMfxtoRvNBQDNAtCwhseujKzDt_QKXnNSTPaeAA_720_1280.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/bb9804b5-0ab9-485b-829b-d54708377fd2.png" alt="男模特鞋子正面-aidge.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/8e54fdc3-7a86-4e3b-aa1d-f3741ce7658c.png" alt="91d7b8c4-fc31-9a7f-8b6e-3bec5e62efb3_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Jumpsuits</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/eddffa7c-a494-4f5b-9d66-da758fb0265f.jpeg" alt="lQDPJwcNMfxtoRvNBQDNAtCwhseujKzDt_QKXnNSTPaeAA_720_1280.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/7f5cec40-a884-4640-8339-6109305dfa1d.png" alt="image.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/635096eb-f2b2-4fd8-91d8-4c7e2e7d7ad1.png" alt="20c8b46a-213e-985c-aab2-d56f8752f3a4_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Skirts</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/eddffa7c-a494-4f5b-9d66-da758fb0265f.jpeg" alt="lQDPJwcNMfxtoRvNBQDNAtCwhseujKzDt_QKXnNSTPaeAA_720_1280.jpeg"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/3d4a6de0-95d2-40cf-9105-48b5e899e0d3.png" alt="image.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/a3cbb609-db71-47d6-8ac6-884f18c6596f.png" alt="45b630e6-4e9d-9bf0-bb4e-224b30a91f77_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// <tr>
        /// <td>Hats</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/ac26f38e-acc7-49d1-a4ec-a51b54e4bd66.png" alt="adbb8e02-9738-991a-9699-f46bc5c089a9_qwen_image3_serving_output_0.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/34176b57-3aa8-4b6e-8d0f-808ae953654a.png" alt="帽子-aidge.png"></td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/4j6OJ5PZM1WeKq3p/img/949b4c28-8821-4aa5-a2b4-e4acc1e57b9b.png" alt="881f02f3-12f5-95dd-b651-98fab6e30fa0_qwen_image3_serving_output_0.png"></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// VirtualTryOnRequest
        /// </param>
        /// 
        /// <returns>
        /// VirtualTryOnResponse
        /// </returns>
        public async Task<VirtualTryOnResponse> VirtualTryOnAsync(VirtualTryOnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VirtualTryOnWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a one-stop AI-powered image processing service for e-commerce sellers. Orchestrates seven atomic capabilities — element detection, intelligent matting, intelligent removal, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling — into an image processing workflow. Users upload an image once, select the desired capabilities, and complete multiple image optimizations sequentially in a single call to produce product images that meet listing platform requirements. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>A one-stop AI-powered image processing service for e-commerce sellers. Orchestrates seven atomic capabilities — element detection, intelligent matting, intelligent removal, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling — into an image processing workflow. Users upload an image once, select the desired capabilities, and complete multiple image optimizations sequentially in a single call to produce product images that meet listing platform requirements. (Asynchronous)</para>
        /// <h1>2. Applicable scenarios</h1>
        /// <para>Applicable to batch optimization of product images in cross-platform listing scenarios. Adapts source product images into main images, SKU images, and detail images required by listing platforms. Supported capabilities include:</para>
        /// <list type="bullet">
        /// <item><description><para>Detecting low-quality images that contain text, watermarks, logos, or ad patches, allowing users to filter images that need processing</para>
        /// </description></item>
        /// <item><description><para>Removing non-compliant elements such as watermarks, logos, ad patches, and Chinese text from original images</para>
        /// </description></item>
        /// <item><description><para>Removing the background around the product subject edges</para>
        /// </description></item>
        /// <item><description><para>Translating text within images into other languages</para>
        /// </description></item>
        /// <item><description><para>Expanding images to other dimensions (by ratio, size, etc.) with automatic background fill</para>
        /// </description></item>
        /// <item><description><para>Cropping images to specified dimensions</para>
        /// </description></item>
        /// <item><description><para>Upscaling image pixels by a specified factor</para>
        /// </description></item>
        /// </list>
        /// <h1>3. Feature overview</h1>
        /// <para>Users provide a product image URL and select the desired AI capability combination through the Ability parameter (1=Intelligent Element Detection, 2=Intelligent Matting, 3=Intelligent Removal, 4=Image Translation Pro, 5=Image Expansion, 6=Intelligent Cropping, 7=HD Upscaling). The system executes the selected capabilities sequentially in a preset order. Because Intelligent Element Detection helps users determine whether an image contains certain specified elements, and the presence of elements affects subsequent AI capability selection, an additional input is provided that allows users to choose whether to filter images out of or retain images in the subsequent AI processing pipeline.
        /// <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/bddb522a-0795-4b5c-b25d-10e933426367.svg" alt="ai-pipeline-flowchart.svg">
        /// Each AI capability is described as follows:</para>
        /// <ol>
        /// <item><description><para><b>Intelligent Element Detection:</b> An element detection capability designed specifically for e-commerce images. Detects text, logos, watermarks, and text-bearing color blocks in both the image subject and background, and returns Boolean detection results. Supports filtering images based on detection results (for example, processing only images with watermarks). Works in conjunction with subsequent capabilities — first identifies the types of elements that need optimization, then precisely executes removal and other operations.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent Matting:</b> Automatically identifies the product subject in an image and precisely separates it from the background. Based on deep learning models, supports accurate segmentation of complex edges such as hair strands and transparent objects. Outputs images with transparent or white backgrounds, supports custom background colors and target size cropping, and directly generates product display images that comply with e-commerce platform specifications.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent Removal:</b> Automatically identifies and removes non-compliant elements from e-commerce images, including text, specific names (brand/store names), transparent text blocks, and ad patches. Supports specifying removal of elements in the subject area or non-subject area separately, and also supports precise removal area specification through the Mask parameter for efficient batch compliance cleanup.</para>
        /// </description></item>
        /// <item><description><para><b>Image Translation Pro:</b> Leverages multimodal large model technology to translate text in images into the target language and render it directly at the corresponding position in the original image. Supports over 100 language pairs. Provides product subject text protection, brand name protection, and translation intervention glossaries to prevent mistranslation of embedded product information. After translation, returns layout information such as text position, font, and color to support secondary editing.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent Image Expansion:</b> Expands the image canvas using AI generation technology to broaden the image field of view without cropping the subject. Supports multiple expansion methods: by aspect ratio (1:1, 3:4, 4:3, 9:16, 16:9), by horizontal/vertical scaling ratio (1.0–3.0×), and by pixel offset in up/down/left/right directions. AI automatically fills in naturally transitioning background content.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent Cropping:</b> Intelligently crops images to specified dimensions, automatically identifies the image subject area, and precisely preserves core content. Supports custom output width and height (100–5000 pixels) to meet the image dimension requirements of different e-commerce platforms and ad placements, ensuring the subject remains prominent and the composition stays balanced after cropping.</para>
        /// </description></item>
        /// <item><description><para><b>HD Upscaling:</b> Enhances details and reduces noise while upscaling images, supporting 2–4× magnification. Suitable for improving the clarity of low-resolution product images and optimizing visual presentation. Supports output in PNG, JPG, BMP, and other formats.</para>
        /// </description></item>
        /// </ol>
        /// <h1>4. Before and after comparison</h1>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image</b></th>
        /// <th><b>Capabilities used</b></th>
        /// <th><b>Output image</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/3c1af966-8a5a-491d-9bfa-aefc321c9bed.png" alt="image.png"></td>
        /// <td>*   Intelligent detection</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><para>Image Translation Pro</para>
        /// </description></item>
        /// <item><description><para>Intelligent cropping | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/c2579e3e-389e-4717-84e3-834e60fea6b0.png" alt="R1.png"> |
        /// | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/a92d14a9-ecf4-4e77-ad96-a2fcdd95dd1d.png" alt="image.png"> | *   Intelligent matting</para>
        /// </description></item>
        /// <item><description><para>Intelligent removal</para>
        /// </description></item>
        /// <item><description><para>Intelligent cropping | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/f631f578-3496-4aa1-b5ef-cd1ea603e049.png" alt="R1.png"> |
        /// | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/12965cf8-cfdf-4a85-95fe-fdfcefcaa4ae.png" alt="C2.png"> | *   Intelligent detection</para>
        /// </description></item>
        /// <item><description><para>Intelligent removal</para>
        /// </description></item>
        /// <item><description><para>HD upscaling | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/95d29e79-8622-45fb-b284-cd580fe40ea0.jpeg" alt="R2.jpeg"> |</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// VisionFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VisionFlowResponse
        /// </returns>
        public VisionFlowResponse VisionFlowWithOptions(VisionFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            VisionFlowShrinkRequest request = new VisionFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Ability))
            {
                request.AbilityShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Ability, "Ability", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NonobjectDetectElements))
            {
                request.NonobjectDetectElementsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NonobjectDetectElements, "NonobjectDetectElements", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NonobjectRemoveElements))
            {
                request.NonobjectRemoveElementsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NonobjectRemoveElements, "NonobjectRemoveElements", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ObjectDetectElements))
            {
                request.ObjectDetectElementsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ObjectDetectElements, "ObjectDetectElements", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ObjectRemoveElements))
            {
                request.ObjectRemoveElementsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ObjectRemoveElements, "ObjectRemoveElements", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AbilityShrink))
            {
                query["Ability"] = request.AbilityShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackGroundType))
            {
                query["BackGroundType"] = request.BackGroundType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Glossary))
            {
                query["Glossary"] = request.Glossary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludingProductArea))
            {
                query["IncludingProductArea"] = request.IncludingProductArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsFilter))
            {
                query["IsFilter"] = request.IsFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonobjectDetectElementsShrink))
            {
                query["NonobjectDetectElements"] = request.NonobjectDetectElementsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonobjectRemoveElementsShrink))
            {
                query["NonobjectRemoveElements"] = request.NonobjectRemoveElementsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectDetectElementsShrink))
            {
                query["ObjectDetectElements"] = request.ObjectDetectElementsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectRemoveElementsShrink))
            {
                query["ObjectRemoveElements"] = request.ObjectRemoveElementsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                query["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetHeight))
            {
                query["TargetHeight"] = request.TargetHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                query["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetWidth))
            {
                query["TargetWidth"] = request.TargetWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslatingBrandInTheProduct))
            {
                query["TranslatingBrandInTheProduct"] = request.TranslatingBrandInTheProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpscaleFactor))
            {
                query["UpscaleFactor"] = request.UpscaleFactor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VisionFlow",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VisionFlowResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a one-stop AI-powered image processing service for e-commerce sellers. Orchestrates seven atomic capabilities — element detection, intelligent matting, intelligent removal, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling — into an image processing workflow. Users upload an image once, select the desired capabilities, and complete multiple image optimizations sequentially in a single call to produce product images that meet listing platform requirements. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>A one-stop AI-powered image processing service for e-commerce sellers. Orchestrates seven atomic capabilities — element detection, intelligent matting, intelligent removal, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling — into an image processing workflow. Users upload an image once, select the desired capabilities, and complete multiple image optimizations sequentially in a single call to produce product images that meet listing platform requirements. (Asynchronous)</para>
        /// <h1>2. Applicable scenarios</h1>
        /// <para>Applicable to batch optimization of product images in cross-platform listing scenarios. Adapts source product images into main images, SKU images, and detail images required by listing platforms. Supported capabilities include:</para>
        /// <list type="bullet">
        /// <item><description><para>Detecting low-quality images that contain text, watermarks, logos, or ad patches, allowing users to filter images that need processing</para>
        /// </description></item>
        /// <item><description><para>Removing non-compliant elements such as watermarks, logos, ad patches, and Chinese text from original images</para>
        /// </description></item>
        /// <item><description><para>Removing the background around the product subject edges</para>
        /// </description></item>
        /// <item><description><para>Translating text within images into other languages</para>
        /// </description></item>
        /// <item><description><para>Expanding images to other dimensions (by ratio, size, etc.) with automatic background fill</para>
        /// </description></item>
        /// <item><description><para>Cropping images to specified dimensions</para>
        /// </description></item>
        /// <item><description><para>Upscaling image pixels by a specified factor</para>
        /// </description></item>
        /// </list>
        /// <h1>3. Feature overview</h1>
        /// <para>Users provide a product image URL and select the desired AI capability combination through the Ability parameter (1=Intelligent Element Detection, 2=Intelligent Matting, 3=Intelligent Removal, 4=Image Translation Pro, 5=Image Expansion, 6=Intelligent Cropping, 7=HD Upscaling). The system executes the selected capabilities sequentially in a preset order. Because Intelligent Element Detection helps users determine whether an image contains certain specified elements, and the presence of elements affects subsequent AI capability selection, an additional input is provided that allows users to choose whether to filter images out of or retain images in the subsequent AI processing pipeline.
        /// <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/bddb522a-0795-4b5c-b25d-10e933426367.svg" alt="ai-pipeline-flowchart.svg">
        /// Each AI capability is described as follows:</para>
        /// <ol>
        /// <item><description><para><b>Intelligent Element Detection:</b> An element detection capability designed specifically for e-commerce images. Detects text, logos, watermarks, and text-bearing color blocks in both the image subject and background, and returns Boolean detection results. Supports filtering images based on detection results (for example, processing only images with watermarks). Works in conjunction with subsequent capabilities — first identifies the types of elements that need optimization, then precisely executes removal and other operations.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent Matting:</b> Automatically identifies the product subject in an image and precisely separates it from the background. Based on deep learning models, supports accurate segmentation of complex edges such as hair strands and transparent objects. Outputs images with transparent or white backgrounds, supports custom background colors and target size cropping, and directly generates product display images that comply with e-commerce platform specifications.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent Removal:</b> Automatically identifies and removes non-compliant elements from e-commerce images, including text, specific names (brand/store names), transparent text blocks, and ad patches. Supports specifying removal of elements in the subject area or non-subject area separately, and also supports precise removal area specification through the Mask parameter for efficient batch compliance cleanup.</para>
        /// </description></item>
        /// <item><description><para><b>Image Translation Pro:</b> Leverages multimodal large model technology to translate text in images into the target language and render it directly at the corresponding position in the original image. Supports over 100 language pairs. Provides product subject text protection, brand name protection, and translation intervention glossaries to prevent mistranslation of embedded product information. After translation, returns layout information such as text position, font, and color to support secondary editing.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent Image Expansion:</b> Expands the image canvas using AI generation technology to broaden the image field of view without cropping the subject. Supports multiple expansion methods: by aspect ratio (1:1, 3:4, 4:3, 9:16, 16:9), by horizontal/vertical scaling ratio (1.0–3.0×), and by pixel offset in up/down/left/right directions. AI automatically fills in naturally transitioning background content.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent Cropping:</b> Intelligently crops images to specified dimensions, automatically identifies the image subject area, and precisely preserves core content. Supports custom output width and height (100–5000 pixels) to meet the image dimension requirements of different e-commerce platforms and ad placements, ensuring the subject remains prominent and the composition stays balanced after cropping.</para>
        /// </description></item>
        /// <item><description><para><b>HD Upscaling:</b> Enhances details and reduces noise while upscaling images, supporting 2–4× magnification. Suitable for improving the clarity of low-resolution product images and optimizing visual presentation. Supports output in PNG, JPG, BMP, and other formats.</para>
        /// </description></item>
        /// </ol>
        /// <h1>4. Before and after comparison</h1>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image</b></th>
        /// <th><b>Capabilities used</b></th>
        /// <th><b>Output image</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/3c1af966-8a5a-491d-9bfa-aefc321c9bed.png" alt="image.png"></td>
        /// <td>*   Intelligent detection</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><para>Image Translation Pro</para>
        /// </description></item>
        /// <item><description><para>Intelligent cropping | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/c2579e3e-389e-4717-84e3-834e60fea6b0.png" alt="R1.png"> |
        /// | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/a92d14a9-ecf4-4e77-ad96-a2fcdd95dd1d.png" alt="image.png"> | *   Intelligent matting</para>
        /// </description></item>
        /// <item><description><para>Intelligent removal</para>
        /// </description></item>
        /// <item><description><para>Intelligent cropping | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/f631f578-3496-4aa1-b5ef-cd1ea603e049.png" alt="R1.png"> |
        /// | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/12965cf8-cfdf-4a85-95fe-fdfcefcaa4ae.png" alt="C2.png"> | *   Intelligent detection</para>
        /// </description></item>
        /// <item><description><para>Intelligent removal</para>
        /// </description></item>
        /// <item><description><para>HD upscaling | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/95d29e79-8622-45fb-b284-cd580fe40ea0.jpeg" alt="R2.jpeg"> |</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// VisionFlowRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VisionFlowResponse
        /// </returns>
        public async Task<VisionFlowResponse> VisionFlowWithOptionsAsync(VisionFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            VisionFlowShrinkRequest request = new VisionFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Ability))
            {
                request.AbilityShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Ability, "Ability", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NonobjectDetectElements))
            {
                request.NonobjectDetectElementsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NonobjectDetectElements, "NonobjectDetectElements", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NonobjectRemoveElements))
            {
                request.NonobjectRemoveElementsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NonobjectRemoveElements, "NonobjectRemoveElements", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ObjectDetectElements))
            {
                request.ObjectDetectElementsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ObjectDetectElements, "ObjectDetectElements", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ObjectRemoveElements))
            {
                request.ObjectRemoveElementsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ObjectRemoveElements, "ObjectRemoveElements", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AbilityShrink))
            {
                query["Ability"] = request.AbilityShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackGroundType))
            {
                query["BackGroundType"] = request.BackGroundType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Glossary))
            {
                query["Glossary"] = request.Glossary;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludingProductArea))
            {
                query["IncludingProductArea"] = request.IncludingProductArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsFilter))
            {
                query["IsFilter"] = request.IsFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mask))
            {
                query["Mask"] = request.Mask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonobjectDetectElementsShrink))
            {
                query["NonobjectDetectElements"] = request.NonobjectDetectElementsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonobjectRemoveElementsShrink))
            {
                query["NonobjectRemoveElements"] = request.NonobjectRemoveElementsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectDetectElementsShrink))
            {
                query["ObjectDetectElements"] = request.ObjectDetectElementsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectRemoveElementsShrink))
            {
                query["ObjectRemoveElements"] = request.ObjectRemoveElementsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceLanguage))
            {
                query["SourceLanguage"] = request.SourceLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetHeight))
            {
                query["TargetHeight"] = request.TargetHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetLanguage))
            {
                query["TargetLanguage"] = request.TargetLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetWidth))
            {
                query["TargetWidth"] = request.TargetWidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TranslatingBrandInTheProduct))
            {
                query["TranslatingBrandInTheProduct"] = request.TranslatingBrandInTheProduct;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpscaleFactor))
            {
                query["UpscaleFactor"] = request.UpscaleFactor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VisionFlow",
                Version = "2026-04-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VisionFlowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a one-stop AI-powered image processing service for e-commerce sellers. Orchestrates seven atomic capabilities — element detection, intelligent matting, intelligent removal, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling — into an image processing workflow. Users upload an image once, select the desired capabilities, and complete multiple image optimizations sequentially in a single call to produce product images that meet listing platform requirements. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>A one-stop AI-powered image processing service for e-commerce sellers. Orchestrates seven atomic capabilities — element detection, intelligent matting, intelligent removal, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling — into an image processing workflow. Users upload an image once, select the desired capabilities, and complete multiple image optimizations sequentially in a single call to produce product images that meet listing platform requirements. (Asynchronous)</para>
        /// <h1>2. Applicable scenarios</h1>
        /// <para>Applicable to batch optimization of product images in cross-platform listing scenarios. Adapts source product images into main images, SKU images, and detail images required by listing platforms. Supported capabilities include:</para>
        /// <list type="bullet">
        /// <item><description><para>Detecting low-quality images that contain text, watermarks, logos, or ad patches, allowing users to filter images that need processing</para>
        /// </description></item>
        /// <item><description><para>Removing non-compliant elements such as watermarks, logos, ad patches, and Chinese text from original images</para>
        /// </description></item>
        /// <item><description><para>Removing the background around the product subject edges</para>
        /// </description></item>
        /// <item><description><para>Translating text within images into other languages</para>
        /// </description></item>
        /// <item><description><para>Expanding images to other dimensions (by ratio, size, etc.) with automatic background fill</para>
        /// </description></item>
        /// <item><description><para>Cropping images to specified dimensions</para>
        /// </description></item>
        /// <item><description><para>Upscaling image pixels by a specified factor</para>
        /// </description></item>
        /// </list>
        /// <h1>3. Feature overview</h1>
        /// <para>Users provide a product image URL and select the desired AI capability combination through the Ability parameter (1=Intelligent Element Detection, 2=Intelligent Matting, 3=Intelligent Removal, 4=Image Translation Pro, 5=Image Expansion, 6=Intelligent Cropping, 7=HD Upscaling). The system executes the selected capabilities sequentially in a preset order. Because Intelligent Element Detection helps users determine whether an image contains certain specified elements, and the presence of elements affects subsequent AI capability selection, an additional input is provided that allows users to choose whether to filter images out of or retain images in the subsequent AI processing pipeline.
        /// <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/bddb522a-0795-4b5c-b25d-10e933426367.svg" alt="ai-pipeline-flowchart.svg">
        /// Each AI capability is described as follows:</para>
        /// <ol>
        /// <item><description><para><b>Intelligent Element Detection:</b> An element detection capability designed specifically for e-commerce images. Detects text, logos, watermarks, and text-bearing color blocks in both the image subject and background, and returns Boolean detection results. Supports filtering images based on detection results (for example, processing only images with watermarks). Works in conjunction with subsequent capabilities — first identifies the types of elements that need optimization, then precisely executes removal and other operations.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent Matting:</b> Automatically identifies the product subject in an image and precisely separates it from the background. Based on deep learning models, supports accurate segmentation of complex edges such as hair strands and transparent objects. Outputs images with transparent or white backgrounds, supports custom background colors and target size cropping, and directly generates product display images that comply with e-commerce platform specifications.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent Removal:</b> Automatically identifies and removes non-compliant elements from e-commerce images, including text, specific names (brand/store names), transparent text blocks, and ad patches. Supports specifying removal of elements in the subject area or non-subject area separately, and also supports precise removal area specification through the Mask parameter for efficient batch compliance cleanup.</para>
        /// </description></item>
        /// <item><description><para><b>Image Translation Pro:</b> Leverages multimodal large model technology to translate text in images into the target language and render it directly at the corresponding position in the original image. Supports over 100 language pairs. Provides product subject text protection, brand name protection, and translation intervention glossaries to prevent mistranslation of embedded product information. After translation, returns layout information such as text position, font, and color to support secondary editing.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent Image Expansion:</b> Expands the image canvas using AI generation technology to broaden the image field of view without cropping the subject. Supports multiple expansion methods: by aspect ratio (1:1, 3:4, 4:3, 9:16, 16:9), by horizontal/vertical scaling ratio (1.0–3.0×), and by pixel offset in up/down/left/right directions. AI automatically fills in naturally transitioning background content.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent Cropping:</b> Intelligently crops images to specified dimensions, automatically identifies the image subject area, and precisely preserves core content. Supports custom output width and height (100–5000 pixels) to meet the image dimension requirements of different e-commerce platforms and ad placements, ensuring the subject remains prominent and the composition stays balanced after cropping.</para>
        /// </description></item>
        /// <item><description><para><b>HD Upscaling:</b> Enhances details and reduces noise while upscaling images, supporting 2–4× magnification. Suitable for improving the clarity of low-resolution product images and optimizing visual presentation. Supports output in PNG, JPG, BMP, and other formats.</para>
        /// </description></item>
        /// </ol>
        /// <h1>4. Before and after comparison</h1>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image</b></th>
        /// <th><b>Capabilities used</b></th>
        /// <th><b>Output image</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/3c1af966-8a5a-491d-9bfa-aefc321c9bed.png" alt="image.png"></td>
        /// <td>*   Intelligent detection</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><para>Image Translation Pro</para>
        /// </description></item>
        /// <item><description><para>Intelligent cropping | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/c2579e3e-389e-4717-84e3-834e60fea6b0.png" alt="R1.png"> |
        /// | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/a92d14a9-ecf4-4e77-ad96-a2fcdd95dd1d.png" alt="image.png"> | *   Intelligent matting</para>
        /// </description></item>
        /// <item><description><para>Intelligent removal</para>
        /// </description></item>
        /// <item><description><para>Intelligent cropping | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/f631f578-3496-4aa1-b5ef-cd1ea603e049.png" alt="R1.png"> |
        /// | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/12965cf8-cfdf-4a85-95fe-fdfcefcaa4ae.png" alt="C2.png"> | *   Intelligent detection</para>
        /// </description></item>
        /// <item><description><para>Intelligent removal</para>
        /// </description></item>
        /// <item><description><para>HD upscaling | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/95d29e79-8622-45fb-b284-cd580fe40ea0.jpeg" alt="R2.jpeg"> |</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// VisionFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// VisionFlowResponse
        /// </returns>
        public VisionFlowResponse VisionFlow(VisionFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VisionFlowWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a one-stop AI-powered image processing service for e-commerce sellers. Orchestrates seven atomic capabilities — element detection, intelligent matting, intelligent removal, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling — into an image processing workflow. Users upload an image once, select the desired capabilities, and complete multiple image optimizations sequentially in a single call to produce product images that meet listing platform requirements. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>A one-stop AI-powered image processing service for e-commerce sellers. Orchestrates seven atomic capabilities — element detection, intelligent matting, intelligent removal, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling — into an image processing workflow. Users upload an image once, select the desired capabilities, and complete multiple image optimizations sequentially in a single call to produce product images that meet listing platform requirements. (Asynchronous)</para>
        /// <h1>2. Applicable scenarios</h1>
        /// <para>Applicable to batch optimization of product images in cross-platform listing scenarios. Adapts source product images into main images, SKU images, and detail images required by listing platforms. Supported capabilities include:</para>
        /// <list type="bullet">
        /// <item><description><para>Detecting low-quality images that contain text, watermarks, logos, or ad patches, allowing users to filter images that need processing</para>
        /// </description></item>
        /// <item><description><para>Removing non-compliant elements such as watermarks, logos, ad patches, and Chinese text from original images</para>
        /// </description></item>
        /// <item><description><para>Removing the background around the product subject edges</para>
        /// </description></item>
        /// <item><description><para>Translating text within images into other languages</para>
        /// </description></item>
        /// <item><description><para>Expanding images to other dimensions (by ratio, size, etc.) with automatic background fill</para>
        /// </description></item>
        /// <item><description><para>Cropping images to specified dimensions</para>
        /// </description></item>
        /// <item><description><para>Upscaling image pixels by a specified factor</para>
        /// </description></item>
        /// </list>
        /// <h1>3. Feature overview</h1>
        /// <para>Users provide a product image URL and select the desired AI capability combination through the Ability parameter (1=Intelligent Element Detection, 2=Intelligent Matting, 3=Intelligent Removal, 4=Image Translation Pro, 5=Image Expansion, 6=Intelligent Cropping, 7=HD Upscaling). The system executes the selected capabilities sequentially in a preset order. Because Intelligent Element Detection helps users determine whether an image contains certain specified elements, and the presence of elements affects subsequent AI capability selection, an additional input is provided that allows users to choose whether to filter images out of or retain images in the subsequent AI processing pipeline.
        /// <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/bddb522a-0795-4b5c-b25d-10e933426367.svg" alt="ai-pipeline-flowchart.svg">
        /// Each AI capability is described as follows:</para>
        /// <ol>
        /// <item><description><para><b>Intelligent Element Detection:</b> An element detection capability designed specifically for e-commerce images. Detects text, logos, watermarks, and text-bearing color blocks in both the image subject and background, and returns Boolean detection results. Supports filtering images based on detection results (for example, processing only images with watermarks). Works in conjunction with subsequent capabilities — first identifies the types of elements that need optimization, then precisely executes removal and other operations.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent Matting:</b> Automatically identifies the product subject in an image and precisely separates it from the background. Based on deep learning models, supports accurate segmentation of complex edges such as hair strands and transparent objects. Outputs images with transparent or white backgrounds, supports custom background colors and target size cropping, and directly generates product display images that comply with e-commerce platform specifications.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent Removal:</b> Automatically identifies and removes non-compliant elements from e-commerce images, including text, specific names (brand/store names), transparent text blocks, and ad patches. Supports specifying removal of elements in the subject area or non-subject area separately, and also supports precise removal area specification through the Mask parameter for efficient batch compliance cleanup.</para>
        /// </description></item>
        /// <item><description><para><b>Image Translation Pro:</b> Leverages multimodal large model technology to translate text in images into the target language and render it directly at the corresponding position in the original image. Supports over 100 language pairs. Provides product subject text protection, brand name protection, and translation intervention glossaries to prevent mistranslation of embedded product information. After translation, returns layout information such as text position, font, and color to support secondary editing.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent Image Expansion:</b> Expands the image canvas using AI generation technology to broaden the image field of view without cropping the subject. Supports multiple expansion methods: by aspect ratio (1:1, 3:4, 4:3, 9:16, 16:9), by horizontal/vertical scaling ratio (1.0–3.0×), and by pixel offset in up/down/left/right directions. AI automatically fills in naturally transitioning background content.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent Cropping:</b> Intelligently crops images to specified dimensions, automatically identifies the image subject area, and precisely preserves core content. Supports custom output width and height (100–5000 pixels) to meet the image dimension requirements of different e-commerce platforms and ad placements, ensuring the subject remains prominent and the composition stays balanced after cropping.</para>
        /// </description></item>
        /// <item><description><para><b>HD Upscaling:</b> Enhances details and reduces noise while upscaling images, supporting 2–4× magnification. Suitable for improving the clarity of low-resolution product images and optimizing visual presentation. Supports output in PNG, JPG, BMP, and other formats.</para>
        /// </description></item>
        /// </ol>
        /// <h1>4. Before and after comparison</h1>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original image</b></th>
        /// <th><b>Capabilities used</b></th>
        /// <th><b>Output image</b></th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/3c1af966-8a5a-491d-9bfa-aefc321c9bed.png" alt="image.png"></td>
        /// <td>*   Intelligent detection</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// <list type="bullet">
        /// <item><description><para>Image Translation Pro</para>
        /// </description></item>
        /// <item><description><para>Intelligent cropping | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/c2579e3e-389e-4717-84e3-834e60fea6b0.png" alt="R1.png"> |
        /// | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/a92d14a9-ecf4-4e77-ad96-a2fcdd95dd1d.png" alt="image.png"> | *   Intelligent matting</para>
        /// </description></item>
        /// <item><description><para>Intelligent removal</para>
        /// </description></item>
        /// <item><description><para>Intelligent cropping | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/f631f578-3496-4aa1-b5ef-cd1ea603e049.png" alt="R1.png"> |
        /// | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/12965cf8-cfdf-4a85-95fe-fdfcefcaa4ae.png" alt="C2.png"> | *   Intelligent detection</para>
        /// </description></item>
        /// <item><description><para>Intelligent removal</para>
        /// </description></item>
        /// <item><description><para>HD upscaling | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/95d29e79-8622-45fb-b284-cd580fe40ea0.jpeg" alt="R2.jpeg"> |</para>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// VisionFlowRequest
        /// </param>
        /// 
        /// <returns>
        /// VisionFlowResponse
        /// </returns>
        public async Task<VisionFlowResponse> VisionFlowAsync(VisionFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VisionFlowWithOptionsAsync(request, runtime);
        }

    }
}
