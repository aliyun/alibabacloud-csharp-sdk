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
            this._endpointRule = "";
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
        /// <para>A one-click cross-platform product material optimization service for cross-border e-commerce sellers (minimum cost version). Input product links from source platforms to generate optimized materials including titles, attributes, main images, SKU images, detail images, and descriptions that comply with the target platform\&quot;s requirements. Uses officially pre-built minimum-cost workflows, primarily based on filtering and lightweight processing without invoking high-cost image translation capabilities, maximizing cost control while ensuring listing compliance. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A one-click cross-platform product material optimization service for cross-border e-commerce sellers (minimum cost version). Input product links from source platforms to generate optimized materials including titles, attributes, main images, SKU images, detail images, and descriptions that comply with the target platform\&quot;s requirements. Uses officially pre-built minimum-cost workflows, primarily based on filtering and lightweight processing without invoking high-cost image translation capabilities, maximizing cost control while ensuring listing compliance. (Asynchronous)</para>
        /// <h2>Applicable Scenarios</h2>
        /// <para>Suitable for cost-sensitive cross-platform product listing scenarios where speed, volume, and affordability are top priorities: for example, bulk listing from 1688 to TEMU, high-SKU inventory batch uploads, entry-level AI processing capabilities provided by top sellers and ERP/SaaS platforms, and merchants with high daily processing volumes but low requirements for marketing performance.
        /// By filtering images containing watermarks or non-compliant elements and prioritizing clean original images, it helps merchants complete cross-platform listings at minimal cost.</para>
        /// <h2>Feature Overview</h2>
        /// <para>This service uses an officially pre-built &quot;Minimum Cost&quot; product optimization workflow, covering the full pipeline from material acquisition, compliance filtering, text optimization, to image processing:</para>
        /// <ol>
        /// <item><description>Automatically parses 1688 product links to extract multiple material types including titles, SKUs, main images, detail images, and attributes;</description></item>
        /// <item><description>Performs text filtering and SEO optimization based on TEMU platform blacklisted terms and compliance rules;</description></item>
        /// <item><description>Intelligently identifies watermarks, logos, and Chinese text in images, prioritizing filtering and selecting clean original images. SKU images and a small number of main images are processed using image translation capabilities to comply with platform standards (high-conversion images with marketing text may be filtered out);</description></item>
        /// <item><description>Completes category matching, attribute filling, and localization rewriting according to target platform requirements.</description></item>
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
        /// <para>A one-click cross-platform product material optimization service for cross-border e-commerce sellers (minimum cost version). Input product links from source platforms to generate optimized materials including titles, attributes, main images, SKU images, detail images, and descriptions that comply with the target platform\&quot;s requirements. Uses officially pre-built minimum-cost workflows, primarily based on filtering and lightweight processing without invoking high-cost image translation capabilities, maximizing cost control while ensuring listing compliance. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A one-click cross-platform product material optimization service for cross-border e-commerce sellers (minimum cost version). Input product links from source platforms to generate optimized materials including titles, attributes, main images, SKU images, detail images, and descriptions that comply with the target platform\&quot;s requirements. Uses officially pre-built minimum-cost workflows, primarily based on filtering and lightweight processing without invoking high-cost image translation capabilities, maximizing cost control while ensuring listing compliance. (Asynchronous)</para>
        /// <h2>Applicable Scenarios</h2>
        /// <para>Suitable for cost-sensitive cross-platform product listing scenarios where speed, volume, and affordability are top priorities: for example, bulk listing from 1688 to TEMU, high-SKU inventory batch uploads, entry-level AI processing capabilities provided by top sellers and ERP/SaaS platforms, and merchants with high daily processing volumes but low requirements for marketing performance.
        /// By filtering images containing watermarks or non-compliant elements and prioritizing clean original images, it helps merchants complete cross-platform listings at minimal cost.</para>
        /// <h2>Feature Overview</h2>
        /// <para>This service uses an officially pre-built &quot;Minimum Cost&quot; product optimization workflow, covering the full pipeline from material acquisition, compliance filtering, text optimization, to image processing:</para>
        /// <ol>
        /// <item><description>Automatically parses 1688 product links to extract multiple material types including titles, SKUs, main images, detail images, and attributes;</description></item>
        /// <item><description>Performs text filtering and SEO optimization based on TEMU platform blacklisted terms and compliance rules;</description></item>
        /// <item><description>Intelligently identifies watermarks, logos, and Chinese text in images, prioritizing filtering and selecting clean original images. SKU images and a small number of main images are processed using image translation capabilities to comply with platform standards (high-conversion images with marketing text may be filtered out);</description></item>
        /// <item><description>Completes category matching, attribute filling, and localization rewriting according to target platform requirements.</description></item>
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
        /// <para>A one-click cross-platform product material optimization service for cross-border e-commerce sellers (minimum cost version). Input product links from source platforms to generate optimized materials including titles, attributes, main images, SKU images, detail images, and descriptions that comply with the target platform\&quot;s requirements. Uses officially pre-built minimum-cost workflows, primarily based on filtering and lightweight processing without invoking high-cost image translation capabilities, maximizing cost control while ensuring listing compliance. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A one-click cross-platform product material optimization service for cross-border e-commerce sellers (minimum cost version). Input product links from source platforms to generate optimized materials including titles, attributes, main images, SKU images, detail images, and descriptions that comply with the target platform\&quot;s requirements. Uses officially pre-built minimum-cost workflows, primarily based on filtering and lightweight processing without invoking high-cost image translation capabilities, maximizing cost control while ensuring listing compliance. (Asynchronous)</para>
        /// <h2>Applicable Scenarios</h2>
        /// <para>Suitable for cost-sensitive cross-platform product listing scenarios where speed, volume, and affordability are top priorities: for example, bulk listing from 1688 to TEMU, high-SKU inventory batch uploads, entry-level AI processing capabilities provided by top sellers and ERP/SaaS platforms, and merchants with high daily processing volumes but low requirements for marketing performance.
        /// By filtering images containing watermarks or non-compliant elements and prioritizing clean original images, it helps merchants complete cross-platform listings at minimal cost.</para>
        /// <h2>Feature Overview</h2>
        /// <para>This service uses an officially pre-built &quot;Minimum Cost&quot; product optimization workflow, covering the full pipeline from material acquisition, compliance filtering, text optimization, to image processing:</para>
        /// <ol>
        /// <item><description>Automatically parses 1688 product links to extract multiple material types including titles, SKUs, main images, detail images, and attributes;</description></item>
        /// <item><description>Performs text filtering and SEO optimization based on TEMU platform blacklisted terms and compliance rules;</description></item>
        /// <item><description>Intelligently identifies watermarks, logos, and Chinese text in images, prioritizing filtering and selecting clean original images. SKU images and a small number of main images are processed using image translation capabilities to comply with platform standards (high-conversion images with marketing text may be filtered out);</description></item>
        /// <item><description>Completes category matching, attribute filling, and localization rewriting according to target platform requirements.</description></item>
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
        /// <para>A one-click cross-platform product material optimization service for cross-border e-commerce sellers (minimum cost version). Input product links from source platforms to generate optimized materials including titles, attributes, main images, SKU images, detail images, and descriptions that comply with the target platform\&quot;s requirements. Uses officially pre-built minimum-cost workflows, primarily based on filtering and lightweight processing without invoking high-cost image translation capabilities, maximizing cost control while ensuring listing compliance. (Asynchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A one-click cross-platform product material optimization service for cross-border e-commerce sellers (minimum cost version). Input product links from source platforms to generate optimized materials including titles, attributes, main images, SKU images, detail images, and descriptions that comply with the target platform\&quot;s requirements. Uses officially pre-built minimum-cost workflows, primarily based on filtering and lightweight processing without invoking high-cost image translation capabilities, maximizing cost control while ensuring listing compliance. (Asynchronous)</para>
        /// <h2>Applicable Scenarios</h2>
        /// <para>Suitable for cost-sensitive cross-platform product listing scenarios where speed, volume, and affordability are top priorities: for example, bulk listing from 1688 to TEMU, high-SKU inventory batch uploads, entry-level AI processing capabilities provided by top sellers and ERP/SaaS platforms, and merchants with high daily processing volumes but low requirements for marketing performance.
        /// By filtering images containing watermarks or non-compliant elements and prioritizing clean original images, it helps merchants complete cross-platform listings at minimal cost.</para>
        /// <h2>Feature Overview</h2>
        /// <para>This service uses an officially pre-built &quot;Minimum Cost&quot; product optimization workflow, covering the full pipeline from material acquisition, compliance filtering, text optimization, to image processing:</para>
        /// <ol>
        /// <item><description>Automatically parses 1688 product links to extract multiple material types including titles, SKUs, main images, detail images, and attributes;</description></item>
        /// <item><description>Performs text filtering and SEO optimization based on TEMU platform blacklisted terms and compliance rules;</description></item>
        /// <item><description>Intelligently identifies watermarks, logos, and Chinese text in images, prioritizing filtering and selecting clean original images. SKU images and a small number of main images are processed using image translation capabilities to comply with platform standards (high-conversion images with marketing text may be filtered out);</description></item>
        /// <item><description>Completes category matching, attribute filling, and localization rewriting according to target platform requirements.</description></item>
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
        /// <para>Provides a one-click cross-platform product listing optimization service (best effect edition) for cross-border e-commerce sellers. Takes a 1688 product link as input and outputs a complete set of assets adapted to TEMU platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting. Uses the official pre-built best-effect workflow to maximize AI capabilities, retains and localizes brand marketing assets, and outputs category-specific assets such as size charts for apparel categories. (Asynchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A one-click cross-platform product listing optimization service (best effect edition) for cross-border e-commerce sellers. Takes a 1688 product link as input and outputs a complete set of assets adapted to TEMU platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting.</para>
        /// <h2>Common scenarios</h2>
        /// <para>Suitable for scenarios that demand high-quality cross-platform product listing assets and strong conversion performance. Examples include categories with high dependency on marketing assets such as apparel, accessories, beauty, and home goods. Also suitable for brand merchants and high-value products that need to retain marketing images with embedded copywriting. Ideal for top sellers and ERP/SaaS platforms conducting localized operations across multiple languages and markets, as well as scenarios that require category-specific assets (such as size charts and package weight/dimensions) to improve listing quality and conversion rates.</para>
        /// <h2>Features</h2>
        /// <para>This service uses the official pre-built &quot;Best Effect&quot; product optimization workflow, covering the entire pipeline from asset retrieval, diagnosis, filtering, and optimization to output:</para>
        /// <ol>
        /// <item><description>Automatically parses 1688 product links to extract all assets including titles, SKUs, main images, detail images, and attributes. Intelligently diagnoses missing assets and optimization opportunities.</description></item>
        /// <item><description>Uses LLM-based text compliance filtering, SEO keyword optimization, five-point description generation, and multilingual localization rewriting.</description></item>
        /// <item><description>Invokes multiple image processing capabilities including intelligent recognition, intelligent background removal, intelligent erasure, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling.</description></item>
        /// <item><description>Outputs category-specific assets, such as size charts and package weight/dimensions for apparel categories.</description></item>
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
        /// <para>Provides a one-click cross-platform product listing optimization service (best effect edition) for cross-border e-commerce sellers. Takes a 1688 product link as input and outputs a complete set of assets adapted to TEMU platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting. Uses the official pre-built best-effect workflow to maximize AI capabilities, retains and localizes brand marketing assets, and outputs category-specific assets such as size charts for apparel categories. (Asynchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A one-click cross-platform product listing optimization service (best effect edition) for cross-border e-commerce sellers. Takes a 1688 product link as input and outputs a complete set of assets adapted to TEMU platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting.</para>
        /// <h2>Common scenarios</h2>
        /// <para>Suitable for scenarios that demand high-quality cross-platform product listing assets and strong conversion performance. Examples include categories with high dependency on marketing assets such as apparel, accessories, beauty, and home goods. Also suitable for brand merchants and high-value products that need to retain marketing images with embedded copywriting. Ideal for top sellers and ERP/SaaS platforms conducting localized operations across multiple languages and markets, as well as scenarios that require category-specific assets (such as size charts and package weight/dimensions) to improve listing quality and conversion rates.</para>
        /// <h2>Features</h2>
        /// <para>This service uses the official pre-built &quot;Best Effect&quot; product optimization workflow, covering the entire pipeline from asset retrieval, diagnosis, filtering, and optimization to output:</para>
        /// <ol>
        /// <item><description>Automatically parses 1688 product links to extract all assets including titles, SKUs, main images, detail images, and attributes. Intelligently diagnoses missing assets and optimization opportunities.</description></item>
        /// <item><description>Uses LLM-based text compliance filtering, SEO keyword optimization, five-point description generation, and multilingual localization rewriting.</description></item>
        /// <item><description>Invokes multiple image processing capabilities including intelligent recognition, intelligent background removal, intelligent erasure, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling.</description></item>
        /// <item><description>Outputs category-specific assets, such as size charts and package weight/dimensions for apparel categories.</description></item>
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
        /// <para>Provides a one-click cross-platform product listing optimization service (best effect edition) for cross-border e-commerce sellers. Takes a 1688 product link as input and outputs a complete set of assets adapted to TEMU platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting. Uses the official pre-built best-effect workflow to maximize AI capabilities, retains and localizes brand marketing assets, and outputs category-specific assets such as size charts for apparel categories. (Asynchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A one-click cross-platform product listing optimization service (best effect edition) for cross-border e-commerce sellers. Takes a 1688 product link as input and outputs a complete set of assets adapted to TEMU platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting.</para>
        /// <h2>Common scenarios</h2>
        /// <para>Suitable for scenarios that demand high-quality cross-platform product listing assets and strong conversion performance. Examples include categories with high dependency on marketing assets such as apparel, accessories, beauty, and home goods. Also suitable for brand merchants and high-value products that need to retain marketing images with embedded copywriting. Ideal for top sellers and ERP/SaaS platforms conducting localized operations across multiple languages and markets, as well as scenarios that require category-specific assets (such as size charts and package weight/dimensions) to improve listing quality and conversion rates.</para>
        /// <h2>Features</h2>
        /// <para>This service uses the official pre-built &quot;Best Effect&quot; product optimization workflow, covering the entire pipeline from asset retrieval, diagnosis, filtering, and optimization to output:</para>
        /// <ol>
        /// <item><description>Automatically parses 1688 product links to extract all assets including titles, SKUs, main images, detail images, and attributes. Intelligently diagnoses missing assets and optimization opportunities.</description></item>
        /// <item><description>Uses LLM-based text compliance filtering, SEO keyword optimization, five-point description generation, and multilingual localization rewriting.</description></item>
        /// <item><description>Invokes multiple image processing capabilities including intelligent recognition, intelligent background removal, intelligent erasure, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling.</description></item>
        /// <item><description>Outputs category-specific assets, such as size charts and package weight/dimensions for apparel categories.</description></item>
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
        /// <para>Provides a one-click cross-platform product listing optimization service (best effect edition) for cross-border e-commerce sellers. Takes a 1688 product link as input and outputs a complete set of assets adapted to TEMU platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting. Uses the official pre-built best-effect workflow to maximize AI capabilities, retains and localizes brand marketing assets, and outputs category-specific assets such as size charts for apparel categories. (Asynchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>A one-click cross-platform product listing optimization service (best effect edition) for cross-border e-commerce sellers. Takes a 1688 product link as input and outputs a complete set of assets adapted to TEMU platform requirements, including titles, attributes, main images, SKU images, detail images, and copywriting.</para>
        /// <h2>Common scenarios</h2>
        /// <para>Suitable for scenarios that demand high-quality cross-platform product listing assets and strong conversion performance. Examples include categories with high dependency on marketing assets such as apparel, accessories, beauty, and home goods. Also suitable for brand merchants and high-value products that need to retain marketing images with embedded copywriting. Ideal for top sellers and ERP/SaaS platforms conducting localized operations across multiple languages and markets, as well as scenarios that require category-specific assets (such as size charts and package weight/dimensions) to improve listing quality and conversion rates.</para>
        /// <h2>Features</h2>
        /// <para>This service uses the official pre-built &quot;Best Effect&quot; product optimization workflow, covering the entire pipeline from asset retrieval, diagnosis, filtering, and optimization to output:</para>
        /// <ol>
        /// <item><description>Automatically parses 1688 product links to extract all assets including titles, SKUs, main images, detail images, and attributes. Intelligently diagnoses missing assets and optimization opportunities.</description></item>
        /// <item><description>Uses LLM-based text compliance filtering, SEO keyword optimization, five-point description generation, and multilingual localization rewriting.</description></item>
        /// <item><description>Invokes multiple image processing capabilities including intelligent recognition, intelligent background removal, intelligent erasure, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling.</description></item>
        /// <item><description>Outputs category-specific assets, such as size charts and package weight/dimensions for apparel categories.</description></item>
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
        /// <para>Provides a cross-platform product category and attribute intelligent filling service based on multimodal large models. Takes product information from a source platform, automatically matches the category on the target listing platform, and intelligently fills in all required attribute fields under that category, offering a one-stop solution for category selection and attribute filling during product listing. (Synchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Scenarios</h1>
        /// <para>Cross-platform product listing attribute filling: When merchants list products across platforms, different platforms such as the source platform and the TEMU platform require different attribute fields for different categories, with complex hierarchical associations (such as material → wood type → density). Manual filling is time-consuming and error-prone. This service automatically understands product information and intelligently fills in attributes. It is applicable to scenarios such as automated bulk listing for top sellers, ERP/SaaS platform integration, and quick product listing for SMB merchants.</para>
        /// <h1>Features</h1>
        /// <para>Users input the product title, source category, product details, SKU, product attributes, and product images (up to 10). The system uses multimodal AI to understand product semantics and visual features, and completes two core tasks: ① Matches the precise category path for the product on the TEMU platform. ② Automatically fills in the required attributes under that category (such as material, battery properties, size, and connectivity), and returns the confidence score and reasoning for each attribute. The API uses synchronous mode and returns results immediately upon invocation.</para>
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
        /// <td>品牌</td>
        /// <td>其他</td>
        /// <td>供电方式</td>
        /// <td>USB充电（内置电池）</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>续航时长</td>
        /// <td>3-6h(含)</td>
        /// <td>可充电电池</td>
        /// <td>锂系电池</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>附加功能</td>
        /// <td>数显</td>
        /// <td>电池容量（mAh）</td>
        /// <td>4000</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>内置蓄电池容量</td>
        /// <td>2000mAh-4000mAh（含）</td>
        /// <td>风扇功能</td>
        /// <td>高速特征</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>货号</td>
        /// <td>X699</td>
        /// <td>控制方式</td>
        /// <td>按键</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>主要下游平台</td>
        /// <td>ebay,亚马逊,wish,速卖通,独立站,LAZADA,其他</td>
        /// <td>完成类型</td>
        /// <td>涂漆</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>有可授权的自有品牌</td>
        /// <td>否</td>
        /// <td>推荐使用</td>
        /// <td>冷却</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>尺寸</td>
        /// <td>65\*60\*171</td>
        /// <td>电风扇设计</td>
        /// <td>可穿戴风扇</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>适用送礼场合</td>
        /// <td>个人礼品</td>
        /// <td>包含的组件</td>
        /// <td>无</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>外壳工艺</td>
        /// <td>喷涂（UV漆，橡胶漆，金属漆，钢琴烤漆，珠光粉）</td>
        /// <td>材料</td>
        /// <td>塑料</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>包装体积</td>
        /// <td>65\*60\*171</td>
        /// <td>特殊功能</td>
        /// <td>便携式</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>外观尺寸</td>
        /// <td>51\*36\*34</td>
        /// <td>室内外使用</td>
        /// <td>室内室外均可</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>风速档位</td>
        /// <td>3档</td>
        /// <td>品牌名</td>
        /// <td>无</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>操作方式</td>
        /// <td>普通按钮</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>扇叶材质</td>
        /// <td>ABS</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>电源方式</td>
        /// <td>USB</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>是否内置电池</td>
        /// <td>内置电池</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>是否专利货源</td>
        /// <td>否</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>颜色</td>
        /// <td>X699风扇-黄色,X699风扇-浅紫色,X699风扇-天蓝色,X699风扇-橙色,X699风扇-浅绿色,普通小风扇</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>主要销售地区</td>
        /// <td>日韩,非洲,韩国,日本,欧洲,南美,东南亚,北美,东北亚,中东,拉丁美洲,欧美,其他</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>是否跨境出口专供货源</td>
        /// <td>是</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>风格</td>
        /// <td>清新</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>电机类型</td>
        /// <td>无刷电机</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>噪音</td>
        /// <td>36dB(A)-45dB(A)(含)</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>产品净重</td>
        /// <td>125g</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>扇叶数量</td>
        /// <td>6片及以上</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>风扇分类</td>
        /// <td>手持风扇</td>
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
        /// <para>Provides a cross-platform product category and attribute intelligent filling service based on multimodal large models. Takes product information from a source platform, automatically matches the category on the target listing platform, and intelligently fills in all required attribute fields under that category, offering a one-stop solution for category selection and attribute filling during product listing. (Synchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Scenarios</h1>
        /// <para>Cross-platform product listing attribute filling: When merchants list products across platforms, different platforms such as the source platform and the TEMU platform require different attribute fields for different categories, with complex hierarchical associations (such as material → wood type → density). Manual filling is time-consuming and error-prone. This service automatically understands product information and intelligently fills in attributes. It is applicable to scenarios such as automated bulk listing for top sellers, ERP/SaaS platform integration, and quick product listing for SMB merchants.</para>
        /// <h1>Features</h1>
        /// <para>Users input the product title, source category, product details, SKU, product attributes, and product images (up to 10). The system uses multimodal AI to understand product semantics and visual features, and completes two core tasks: ① Matches the precise category path for the product on the TEMU platform. ② Automatically fills in the required attributes under that category (such as material, battery properties, size, and connectivity), and returns the confidence score and reasoning for each attribute. The API uses synchronous mode and returns results immediately upon invocation.</para>
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
        /// <td>品牌</td>
        /// <td>其他</td>
        /// <td>供电方式</td>
        /// <td>USB充电（内置电池）</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>续航时长</td>
        /// <td>3-6h(含)</td>
        /// <td>可充电电池</td>
        /// <td>锂系电池</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>附加功能</td>
        /// <td>数显</td>
        /// <td>电池容量（mAh）</td>
        /// <td>4000</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>内置蓄电池容量</td>
        /// <td>2000mAh-4000mAh（含）</td>
        /// <td>风扇功能</td>
        /// <td>高速特征</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>货号</td>
        /// <td>X699</td>
        /// <td>控制方式</td>
        /// <td>按键</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>主要下游平台</td>
        /// <td>ebay,亚马逊,wish,速卖通,独立站,LAZADA,其他</td>
        /// <td>完成类型</td>
        /// <td>涂漆</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>有可授权的自有品牌</td>
        /// <td>否</td>
        /// <td>推荐使用</td>
        /// <td>冷却</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>尺寸</td>
        /// <td>65\*60\*171</td>
        /// <td>电风扇设计</td>
        /// <td>可穿戴风扇</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>适用送礼场合</td>
        /// <td>个人礼品</td>
        /// <td>包含的组件</td>
        /// <td>无</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>外壳工艺</td>
        /// <td>喷涂（UV漆，橡胶漆，金属漆，钢琴烤漆，珠光粉）</td>
        /// <td>材料</td>
        /// <td>塑料</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>包装体积</td>
        /// <td>65\*60\*171</td>
        /// <td>特殊功能</td>
        /// <td>便携式</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>外观尺寸</td>
        /// <td>51\*36\*34</td>
        /// <td>室内外使用</td>
        /// <td>室内室外均可</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>风速档位</td>
        /// <td>3档</td>
        /// <td>品牌名</td>
        /// <td>无</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>操作方式</td>
        /// <td>普通按钮</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>扇叶材质</td>
        /// <td>ABS</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>电源方式</td>
        /// <td>USB</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>是否内置电池</td>
        /// <td>内置电池</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>是否专利货源</td>
        /// <td>否</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>颜色</td>
        /// <td>X699风扇-黄色,X699风扇-浅紫色,X699风扇-天蓝色,X699风扇-橙色,X699风扇-浅绿色,普通小风扇</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>主要销售地区</td>
        /// <td>日韩,非洲,韩国,日本,欧洲,南美,东南亚,北美,东北亚,中东,拉丁美洲,欧美,其他</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>是否跨境出口专供货源</td>
        /// <td>是</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>风格</td>
        /// <td>清新</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>电机类型</td>
        /// <td>无刷电机</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>噪音</td>
        /// <td>36dB(A)-45dB(A)(含)</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>产品净重</td>
        /// <td>125g</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>扇叶数量</td>
        /// <td>6片及以上</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>风扇分类</td>
        /// <td>手持风扇</td>
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
        /// <para>Provides a cross-platform product category and attribute intelligent filling service based on multimodal large models. Takes product information from a source platform, automatically matches the category on the target listing platform, and intelligently fills in all required attribute fields under that category, offering a one-stop solution for category selection and attribute filling during product listing. (Synchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Scenarios</h1>
        /// <para>Cross-platform product listing attribute filling: When merchants list products across platforms, different platforms such as the source platform and the TEMU platform require different attribute fields for different categories, with complex hierarchical associations (such as material → wood type → density). Manual filling is time-consuming and error-prone. This service automatically understands product information and intelligently fills in attributes. It is applicable to scenarios such as automated bulk listing for top sellers, ERP/SaaS platform integration, and quick product listing for SMB merchants.</para>
        /// <h1>Features</h1>
        /// <para>Users input the product title, source category, product details, SKU, product attributes, and product images (up to 10). The system uses multimodal AI to understand product semantics and visual features, and completes two core tasks: ① Matches the precise category path for the product on the TEMU platform. ② Automatically fills in the required attributes under that category (such as material, battery properties, size, and connectivity), and returns the confidence score and reasoning for each attribute. The API uses synchronous mode and returns results immediately upon invocation.</para>
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
        /// <td>品牌</td>
        /// <td>其他</td>
        /// <td>供电方式</td>
        /// <td>USB充电（内置电池）</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>续航时长</td>
        /// <td>3-6h(含)</td>
        /// <td>可充电电池</td>
        /// <td>锂系电池</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>附加功能</td>
        /// <td>数显</td>
        /// <td>电池容量（mAh）</td>
        /// <td>4000</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>内置蓄电池容量</td>
        /// <td>2000mAh-4000mAh（含）</td>
        /// <td>风扇功能</td>
        /// <td>高速特征</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>货号</td>
        /// <td>X699</td>
        /// <td>控制方式</td>
        /// <td>按键</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>主要下游平台</td>
        /// <td>ebay,亚马逊,wish,速卖通,独立站,LAZADA,其他</td>
        /// <td>完成类型</td>
        /// <td>涂漆</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>有可授权的自有品牌</td>
        /// <td>否</td>
        /// <td>推荐使用</td>
        /// <td>冷却</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>尺寸</td>
        /// <td>65\*60\*171</td>
        /// <td>电风扇设计</td>
        /// <td>可穿戴风扇</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>适用送礼场合</td>
        /// <td>个人礼品</td>
        /// <td>包含的组件</td>
        /// <td>无</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>外壳工艺</td>
        /// <td>喷涂（UV漆，橡胶漆，金属漆，钢琴烤漆，珠光粉）</td>
        /// <td>材料</td>
        /// <td>塑料</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>包装体积</td>
        /// <td>65\*60\*171</td>
        /// <td>特殊功能</td>
        /// <td>便携式</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>外观尺寸</td>
        /// <td>51\*36\*34</td>
        /// <td>室内外使用</td>
        /// <td>室内室外均可</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>风速档位</td>
        /// <td>3档</td>
        /// <td>品牌名</td>
        /// <td>无</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>操作方式</td>
        /// <td>普通按钮</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>扇叶材质</td>
        /// <td>ABS</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>电源方式</td>
        /// <td>USB</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>是否内置电池</td>
        /// <td>内置电池</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>是否专利货源</td>
        /// <td>否</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>颜色</td>
        /// <td>X699风扇-黄色,X699风扇-浅紫色,X699风扇-天蓝色,X699风扇-橙色,X699风扇-浅绿色,普通小风扇</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>主要销售地区</td>
        /// <td>日韩,非洲,韩国,日本,欧洲,南美,东南亚,北美,东北亚,中东,拉丁美洲,欧美,其他</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>是否跨境出口专供货源</td>
        /// <td>是</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>风格</td>
        /// <td>清新</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>电机类型</td>
        /// <td>无刷电机</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>噪音</td>
        /// <td>36dB(A)-45dB(A)(含)</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>产品净重</td>
        /// <td>125g</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>扇叶数量</td>
        /// <td>6片及以上</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>风扇分类</td>
        /// <td>手持风扇</td>
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
        /// <para>Provides a cross-platform product category and attribute intelligent filling service based on multimodal large models. Takes product information from a source platform, automatically matches the category on the target listing platform, and intelligently fills in all required attribute fields under that category, offering a one-stop solution for category selection and attribute filling during product listing. (Synchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>Scenarios</h1>
        /// <para>Cross-platform product listing attribute filling: When merchants list products across platforms, different platforms such as the source platform and the TEMU platform require different attribute fields for different categories, with complex hierarchical associations (such as material → wood type → density). Manual filling is time-consuming and error-prone. This service automatically understands product information and intelligently fills in attributes. It is applicable to scenarios such as automated bulk listing for top sellers, ERP/SaaS platform integration, and quick product listing for SMB merchants.</para>
        /// <h1>Features</h1>
        /// <para>Users input the product title, source category, product details, SKU, product attributes, and product images (up to 10). The system uses multimodal AI to understand product semantics and visual features, and completes two core tasks: ① Matches the precise category path for the product on the TEMU platform. ② Automatically fills in the required attributes under that category (such as material, battery properties, size, and connectivity), and returns the confidence score and reasoning for each attribute. The API uses synchronous mode and returns results immediately upon invocation.</para>
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
        /// <td>品牌</td>
        /// <td>其他</td>
        /// <td>供电方式</td>
        /// <td>USB充电（内置电池）</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>续航时长</td>
        /// <td>3-6h(含)</td>
        /// <td>可充电电池</td>
        /// <td>锂系电池</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>附加功能</td>
        /// <td>数显</td>
        /// <td>电池容量（mAh）</td>
        /// <td>4000</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>内置蓄电池容量</td>
        /// <td>2000mAh-4000mAh（含）</td>
        /// <td>风扇功能</td>
        /// <td>高速特征</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>货号</td>
        /// <td>X699</td>
        /// <td>控制方式</td>
        /// <td>按键</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>主要下游平台</td>
        /// <td>ebay,亚马逊,wish,速卖通,独立站,LAZADA,其他</td>
        /// <td>完成类型</td>
        /// <td>涂漆</td>
        /// <td>Yes</td>
        /// </tr>
        /// <tr>
        /// <td>有可授权的自有品牌</td>
        /// <td>否</td>
        /// <td>推荐使用</td>
        /// <td>冷却</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>尺寸</td>
        /// <td>65\*60\*171</td>
        /// <td>电风扇设计</td>
        /// <td>可穿戴风扇</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>适用送礼场合</td>
        /// <td>个人礼品</td>
        /// <td>包含的组件</td>
        /// <td>无</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>外壳工艺</td>
        /// <td>喷涂（UV漆，橡胶漆，金属漆，钢琴烤漆，珠光粉）</td>
        /// <td>材料</td>
        /// <td>塑料</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>包装体积</td>
        /// <td>65\*60\*171</td>
        /// <td>特殊功能</td>
        /// <td>便携式</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>外观尺寸</td>
        /// <td>51\*36\*34</td>
        /// <td>室内外使用</td>
        /// <td>室内室外均可</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>风速档位</td>
        /// <td>3档</td>
        /// <td>品牌名</td>
        /// <td>无</td>
        /// <td>No</td>
        /// </tr>
        /// <tr>
        /// <td>操作方式</td>
        /// <td>普通按钮</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>扇叶材质</td>
        /// <td>ABS</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>电源方式</td>
        /// <td>USB</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>是否内置电池</td>
        /// <td>内置电池</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>是否专利货源</td>
        /// <td>否</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>颜色</td>
        /// <td>X699风扇-黄色,X699风扇-浅紫色,X699风扇-天蓝色,X699风扇-橙色,X699风扇-浅绿色,普通小风扇</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>主要销售地区</td>
        /// <td>日韩,非洲,韩国,日本,欧洲,南美,东南亚,北美,东北亚,中东,拉丁美洲,欧美,其他</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>是否跨境出口专供货源</td>
        /// <td>是</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>风格</td>
        /// <td>清新</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>电机类型</td>
        /// <td>无刷电机</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>噪音</td>
        /// <td>36dB(A)-45dB(A)(含)</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>产品净重</td>
        /// <td>125g</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>扇叶数量</td>
        /// <td>6片及以上</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>风扇分类</td>
        /// <td>手持风扇</td>
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
        /// <para>Provides a large language model-based cross-platform product category intelligent matching service. Accepts product information from a source platform, automatically matches the best category on the target listing platform, and returns a confidence level score with matching reasons to help sellers quickly select categories for cross-platform product listing. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Provides a large language model-based cross-platform product category intelligent matching service. Accepts product information from a source platform, automatically matches the best category on the target listing platform, and returns a confidence level score with matching reasons to help sellers quickly select categories for cross-platform product listing. (Synchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <para>Cross-platform product listing: After sourcing products, sellers need to map them to the correct categories in the target platform\&quot;s category tree. Manually selecting categories requires familiarity with the target platform\&quot;s entire category structure, which is time-consuming, labor-intensive, and error-prone. Incorrect category mapping can cause products to be delisted.
        /// This service automates category mapping and is suitable for bulk API calls from large sellers\&quot; proprietary systems, integration into ERP/SaaS platforms for automated listing workflows, and quick single-product listing for SMB sellers.
        /// The current version supports only TEMU as the target listing platform. Automatic retrieval of product information from source platforms is not yet supported and requires manual parameter input. This capability and support for additional source and target platforms will be added in future releases.</para>
        /// <h2>Functions and features</h2>
        /// <para>You can input fields such as product title, source category, product description, SKU information, and product attributes. The system uses an AI model to understand product semantics and matches the most appropriate category path from the full TEMU platform category tree. The response includes the complete category path (CategoryPath), category name (CategoryName), confidence score (0–100), and matching reason. The API uses synchronous mode and returns results immediately, making it suitable for embedding in real-time business workflows.</para>
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
        /// <td>USB风扇、迷你风扇</td>
        /// <td>TEMU</td>
        /// <td>家电</td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;加热、冷却和空气质量电器</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;电风扇</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;USB 风扇</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>1688</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/jP2lRYjv7234mO8g/img/8a546f7d-826e-43d6-b5f3-12d1edef8897.png" alt="image.png"></td>
        /// <td>手链</td>
        /// <td>TEMU</td>
        /// <td>服装、鞋靴和珠宝饰品</td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士饰品</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚手链、手镯</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚吊饰和吊饰手链</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚吊饰手链</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚链式吊饰手链</td>
        /// <td>.</td>
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
        /// <para>Provides a large language model-based cross-platform product category intelligent matching service. Accepts product information from a source platform, automatically matches the best category on the target listing platform, and returns a confidence level score with matching reasons to help sellers quickly select categories for cross-platform product listing. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Provides a large language model-based cross-platform product category intelligent matching service. Accepts product information from a source platform, automatically matches the best category on the target listing platform, and returns a confidence level score with matching reasons to help sellers quickly select categories for cross-platform product listing. (Synchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <para>Cross-platform product listing: After sourcing products, sellers need to map them to the correct categories in the target platform\&quot;s category tree. Manually selecting categories requires familiarity with the target platform\&quot;s entire category structure, which is time-consuming, labor-intensive, and error-prone. Incorrect category mapping can cause products to be delisted.
        /// This service automates category mapping and is suitable for bulk API calls from large sellers\&quot; proprietary systems, integration into ERP/SaaS platforms for automated listing workflows, and quick single-product listing for SMB sellers.
        /// The current version supports only TEMU as the target listing platform. Automatic retrieval of product information from source platforms is not yet supported and requires manual parameter input. This capability and support for additional source and target platforms will be added in future releases.</para>
        /// <h2>Functions and features</h2>
        /// <para>You can input fields such as product title, source category, product description, SKU information, and product attributes. The system uses an AI model to understand product semantics and matches the most appropriate category path from the full TEMU platform category tree. The response includes the complete category path (CategoryPath), category name (CategoryName), confidence score (0–100), and matching reason. The API uses synchronous mode and returns results immediately, making it suitable for embedding in real-time business workflows.</para>
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
        /// <td>USB风扇、迷你风扇</td>
        /// <td>TEMU</td>
        /// <td>家电</td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;加热、冷却和空气质量电器</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;电风扇</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;USB 风扇</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>1688</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/jP2lRYjv7234mO8g/img/8a546f7d-826e-43d6-b5f3-12d1edef8897.png" alt="image.png"></td>
        /// <td>手链</td>
        /// <td>TEMU</td>
        /// <td>服装、鞋靴和珠宝饰品</td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士饰品</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚手链、手镯</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚吊饰和吊饰手链</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚吊饰手链</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚链式吊饰手链</td>
        /// <td>.</td>
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
        /// <para>Provides a large language model-based cross-platform product category intelligent matching service. Accepts product information from a source platform, automatically matches the best category on the target listing platform, and returns a confidence level score with matching reasons to help sellers quickly select categories for cross-platform product listing. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Provides a large language model-based cross-platform product category intelligent matching service. Accepts product information from a source platform, automatically matches the best category on the target listing platform, and returns a confidence level score with matching reasons to help sellers quickly select categories for cross-platform product listing. (Synchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <para>Cross-platform product listing: After sourcing products, sellers need to map them to the correct categories in the target platform\&quot;s category tree. Manually selecting categories requires familiarity with the target platform\&quot;s entire category structure, which is time-consuming, labor-intensive, and error-prone. Incorrect category mapping can cause products to be delisted.
        /// This service automates category mapping and is suitable for bulk API calls from large sellers\&quot; proprietary systems, integration into ERP/SaaS platforms for automated listing workflows, and quick single-product listing for SMB sellers.
        /// The current version supports only TEMU as the target listing platform. Automatic retrieval of product information from source platforms is not yet supported and requires manual parameter input. This capability and support for additional source and target platforms will be added in future releases.</para>
        /// <h2>Functions and features</h2>
        /// <para>You can input fields such as product title, source category, product description, SKU information, and product attributes. The system uses an AI model to understand product semantics and matches the most appropriate category path from the full TEMU platform category tree. The response includes the complete category path (CategoryPath), category name (CategoryName), confidence score (0–100), and matching reason. The API uses synchronous mode and returns results immediately, making it suitable for embedding in real-time business workflows.</para>
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
        /// <td>USB风扇、迷你风扇</td>
        /// <td>TEMU</td>
        /// <td>家电</td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;加热、冷却和空气质量电器</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;电风扇</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;USB 风扇</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>1688</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/jP2lRYjv7234mO8g/img/8a546f7d-826e-43d6-b5f3-12d1edef8897.png" alt="image.png"></td>
        /// <td>手链</td>
        /// <td>TEMU</td>
        /// <td>服装、鞋靴和珠宝饰品</td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士饰品</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚手链、手镯</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚吊饰和吊饰手链</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚吊饰手链</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚链式吊饰手链</td>
        /// <td>.</td>
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
        /// <para>Provides a large language model-based cross-platform product category intelligent matching service. Accepts product information from a source platform, automatically matches the best category on the target listing platform, and returns a confidence level score with matching reasons to help sellers quickly select categories for cross-platform product listing. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Provides a large language model-based cross-platform product category intelligent matching service. Accepts product information from a source platform, automatically matches the best category on the target listing platform, and returns a confidence level score with matching reasons to help sellers quickly select categories for cross-platform product listing. (Synchronous)</para>
        /// <h2>Common scenarios</h2>
        /// <para>Cross-platform product listing: After sourcing products, sellers need to map them to the correct categories in the target platform\&quot;s category tree. Manually selecting categories requires familiarity with the target platform\&quot;s entire category structure, which is time-consuming, labor-intensive, and error-prone. Incorrect category mapping can cause products to be delisted.
        /// This service automates category mapping and is suitable for bulk API calls from large sellers\&quot; proprietary systems, integration into ERP/SaaS platforms for automated listing workflows, and quick single-product listing for SMB sellers.
        /// The current version supports only TEMU as the target listing platform. Automatic retrieval of product information from source platforms is not yet supported and requires manual parameter input. This capability and support for additional source and target platforms will be added in future releases.</para>
        /// <h2>Functions and features</h2>
        /// <para>You can input fields such as product title, source category, product description, SKU information, and product attributes. The system uses an AI model to understand product semantics and matches the most appropriate category path from the full TEMU platform category tree. The response includes the complete category path (CategoryPath), category name (CategoryName), confidence score (0–100), and matching reason. The API uses synchronous mode and returns results immediately, making it suitable for embedding in real-time business workflows.</para>
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
        /// <td>USB风扇、迷你风扇</td>
        /// <td>TEMU</td>
        /// <td>家电</td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;加热、冷却和空气质量电器</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;电风扇</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;USB 风扇</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>1688</td>
        /// <td><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/jP2lRYjv7234mO8g/img/8a546f7d-826e-43d6-b5f3-12d1edef8897.png" alt="image.png"></td>
        /// <td>手链</td>
        /// <td>TEMU</td>
        /// <td>服装、鞋靴和珠宝饰品</td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士饰品</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚手链、手镯</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚吊饰和吊饰手链</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚吊饰手链</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>\&gt;女士时尚链式吊饰手链</td>
        /// <td>.</td>
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
        /// <para>Designed specifically for document translation, this service supports translation between more than 100 language pairs (including bridged pairs), handling multi-scenario, multi-page, and highly complex document translation. Scanned documents are not currently supported.
        /// The service excels in the following areas:</para>
        /// <list type="bullet">
        /// <item><description>Content accuracy: translation accuracy, parameter and unit accuracy.</description></item>
        /// <item><description>Structural integrity: overall layout continuity, page margin and layout preservation.</description></item>
        /// </list>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Designed specifically for document translation, this service supports translation between more than 100 language pairs (including bridged pairs), handling multi-scenario, multi-page, and highly complex document translation. Scanned documents are not currently supported.
        /// The service excels in the following areas:</para>
        /// <list type="bullet">
        /// <item><description>Content accuracy: translation accuracy, parameter and unit accuracy.</description></item>
        /// <item><description>Structural integrity: overall layout continuity, page margin and layout preservation.</description></item>
        /// </list>
        /// <h2>Common scenarios</h2>
        /// <para>Cross-border e-commerce product manuals, contracts, agreements, business proposals, qualification documents, textbooks, courseware, and other scenarios.
        /// 3. Features</para>
        /// <list type="bullet">
        /// <item><description>Supports PDF and Word formats. Supports source documents that contain multiple languages. For a detailed list of supported languages, see section 4.5.</description></item>
        /// <item><description>Supports translation of text within images in documents, as well as complex translation scenarios such as charts and special symbols.</description></item>
        /// <item><description>Supports high-fidelity layout preservation after translation.</description></item>
        /// <item><description>A single PDF supports up to 100 pages, and a single Word document supports up to 100 pages.</description></item>
        /// <item><description>Supports custom translation results, including do-not-translate (ABC-ABC), specified translation (ABC-DEF), and skip translation (ABC-empty value). This is commonly used for brand name protection. Pass the corresponding glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 glossary entries. If you need more, contact the platform for assistance.</description></item>
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
        /// <para>Designed specifically for document translation, this service supports translation between more than 100 language pairs (including bridged pairs), handling multi-scenario, multi-page, and highly complex document translation. Scanned documents are not currently supported.
        /// The service excels in the following areas:</para>
        /// <list type="bullet">
        /// <item><description>Content accuracy: translation accuracy, parameter and unit accuracy.</description></item>
        /// <item><description>Structural integrity: overall layout continuity, page margin and layout preservation.</description></item>
        /// </list>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Designed specifically for document translation, this service supports translation between more than 100 language pairs (including bridged pairs), handling multi-scenario, multi-page, and highly complex document translation. Scanned documents are not currently supported.
        /// The service excels in the following areas:</para>
        /// <list type="bullet">
        /// <item><description>Content accuracy: translation accuracy, parameter and unit accuracy.</description></item>
        /// <item><description>Structural integrity: overall layout continuity, page margin and layout preservation.</description></item>
        /// </list>
        /// <h2>Common scenarios</h2>
        /// <para>Cross-border e-commerce product manuals, contracts, agreements, business proposals, qualification documents, textbooks, courseware, and other scenarios.
        /// 3. Features</para>
        /// <list type="bullet">
        /// <item><description>Supports PDF and Word formats. Supports source documents that contain multiple languages. For a detailed list of supported languages, see section 4.5.</description></item>
        /// <item><description>Supports translation of text within images in documents, as well as complex translation scenarios such as charts and special symbols.</description></item>
        /// <item><description>Supports high-fidelity layout preservation after translation.</description></item>
        /// <item><description>A single PDF supports up to 100 pages, and a single Word document supports up to 100 pages.</description></item>
        /// <item><description>Supports custom translation results, including do-not-translate (ABC-ABC), specified translation (ABC-DEF), and skip translation (ABC-empty value). This is commonly used for brand name protection. Pass the corresponding glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 glossary entries. If you need more, contact the platform for assistance.</description></item>
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
        /// <para>Designed specifically for document translation, this service supports translation between more than 100 language pairs (including bridged pairs), handling multi-scenario, multi-page, and highly complex document translation. Scanned documents are not currently supported.
        /// The service excels in the following areas:</para>
        /// <list type="bullet">
        /// <item><description>Content accuracy: translation accuracy, parameter and unit accuracy.</description></item>
        /// <item><description>Structural integrity: overall layout continuity, page margin and layout preservation.</description></item>
        /// </list>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Designed specifically for document translation, this service supports translation between more than 100 language pairs (including bridged pairs), handling multi-scenario, multi-page, and highly complex document translation. Scanned documents are not currently supported.
        /// The service excels in the following areas:</para>
        /// <list type="bullet">
        /// <item><description>Content accuracy: translation accuracy, parameter and unit accuracy.</description></item>
        /// <item><description>Structural integrity: overall layout continuity, page margin and layout preservation.</description></item>
        /// </list>
        /// <h2>Common scenarios</h2>
        /// <para>Cross-border e-commerce product manuals, contracts, agreements, business proposals, qualification documents, textbooks, courseware, and other scenarios.
        /// 3. Features</para>
        /// <list type="bullet">
        /// <item><description>Supports PDF and Word formats. Supports source documents that contain multiple languages. For a detailed list of supported languages, see section 4.5.</description></item>
        /// <item><description>Supports translation of text within images in documents, as well as complex translation scenarios such as charts and special symbols.</description></item>
        /// <item><description>Supports high-fidelity layout preservation after translation.</description></item>
        /// <item><description>A single PDF supports up to 100 pages, and a single Word document supports up to 100 pages.</description></item>
        /// <item><description>Supports custom translation results, including do-not-translate (ABC-ABC), specified translation (ABC-DEF), and skip translation (ABC-empty value). This is commonly used for brand name protection. Pass the corresponding glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 glossary entries. If you need more, contact the platform for assistance.</description></item>
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
        /// <para>Designed specifically for document translation, this service supports translation between more than 100 language pairs (including bridged pairs), handling multi-scenario, multi-page, and highly complex document translation. Scanned documents are not currently supported.
        /// The service excels in the following areas:</para>
        /// <list type="bullet">
        /// <item><description>Content accuracy: translation accuracy, parameter and unit accuracy.</description></item>
        /// <item><description>Structural integrity: overall layout continuity, page margin and layout preservation.</description></item>
        /// </list>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Designed specifically for document translation, this service supports translation between more than 100 language pairs (including bridged pairs), handling multi-scenario, multi-page, and highly complex document translation. Scanned documents are not currently supported.
        /// The service excels in the following areas:</para>
        /// <list type="bullet">
        /// <item><description>Content accuracy: translation accuracy, parameter and unit accuracy.</description></item>
        /// <item><description>Structural integrity: overall layout continuity, page margin and layout preservation.</description></item>
        /// </list>
        /// <h2>Common scenarios</h2>
        /// <para>Cross-border e-commerce product manuals, contracts, agreements, business proposals, qualification documents, textbooks, courseware, and other scenarios.
        /// 3. Features</para>
        /// <list type="bullet">
        /// <item><description>Supports PDF and Word formats. Supports source documents that contain multiple languages. For a detailed list of supported languages, see section 4.5.</description></item>
        /// <item><description>Supports translation of text within images in documents, as well as complex translation scenarios such as charts and special symbols.</description></item>
        /// <item><description>Supports high-fidelity layout preservation after translation.</description></item>
        /// <item><description>A single PDF supports up to 100 pages, and a single Word document supports up to 100 pages.</description></item>
        /// <item><description>Supports custom translation results, including do-not-translate (ABC-ABC), specified translation (ABC-DEF), and skip translation (ABC-empty value). This is commonly used for brand name protection. Pass the corresponding glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 glossary entries. If you need more, contact the platform for assistance.</description></item>
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
        /// <para>Intelligently crop images to specified dimensions, automatically identify the main subject area of the image, and precisely crop to various sizes to meet design requirements for different scenarios. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Overview</h2>
        /// <para>The image cropping product can resize input images to specified dimensions. It supports automatic identification of the main subject area in images and precisely crops to various sizes to meet design requirements for different scenarios. (Synchronous)</para>
        /// <h2>Use Cases</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Multi-platform Content Distribution</b>: Automatically generate content in multiple sizes to meet the different image size requirements of various platforms and scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>Content Placement</b>: Automatically adjust sizes for different ad slots on different platforms, highlighting the main content, reducing blank space, and showcasing product features.</para>
        /// </description></item>
        /// </list>
        /// <h2>Feature Description</h2>
        /// <list type="bullet">
        /// <item><description><para>Automatically identify the main subject area of an image and crop precisely.</para>
        /// </description></item>
        /// <item><description><para>Support custom crop size output to adapt to different platforms and devices.</para>
        /// </description></item>
        /// </list>
        /// <h2>Effect Comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original Image</b></th>
        /// <th>*<em>Cropped to 1000\<em>1000</em></em></th>
        /// <th>*<em>Cropped to 3000\<em>2000</em></em></th>
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
        /// <para>Intelligently crop images to specified dimensions, automatically identify the main subject area of the image, and precisely crop to various sizes to meet design requirements for different scenarios. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Overview</h2>
        /// <para>The image cropping product can resize input images to specified dimensions. It supports automatic identification of the main subject area in images and precisely crops to various sizes to meet design requirements for different scenarios. (Synchronous)</para>
        /// <h2>Use Cases</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Multi-platform Content Distribution</b>: Automatically generate content in multiple sizes to meet the different image size requirements of various platforms and scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>Content Placement</b>: Automatically adjust sizes for different ad slots on different platforms, highlighting the main content, reducing blank space, and showcasing product features.</para>
        /// </description></item>
        /// </list>
        /// <h2>Feature Description</h2>
        /// <list type="bullet">
        /// <item><description><para>Automatically identify the main subject area of an image and crop precisely.</para>
        /// </description></item>
        /// <item><description><para>Support custom crop size output to adapt to different platforms and devices.</para>
        /// </description></item>
        /// </list>
        /// <h2>Effect Comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original Image</b></th>
        /// <th>*<em>Cropped to 1000\<em>1000</em></em></th>
        /// <th>*<em>Cropped to 3000\<em>2000</em></em></th>
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
        /// <para>Intelligently crop images to specified dimensions, automatically identify the main subject area of the image, and precisely crop to various sizes to meet design requirements for different scenarios. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Overview</h2>
        /// <para>The image cropping product can resize input images to specified dimensions. It supports automatic identification of the main subject area in images and precisely crops to various sizes to meet design requirements for different scenarios. (Synchronous)</para>
        /// <h2>Use Cases</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Multi-platform Content Distribution</b>: Automatically generate content in multiple sizes to meet the different image size requirements of various platforms and scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>Content Placement</b>: Automatically adjust sizes for different ad slots on different platforms, highlighting the main content, reducing blank space, and showcasing product features.</para>
        /// </description></item>
        /// </list>
        /// <h2>Feature Description</h2>
        /// <list type="bullet">
        /// <item><description><para>Automatically identify the main subject area of an image and crop precisely.</para>
        /// </description></item>
        /// <item><description><para>Support custom crop size output to adapt to different platforms and devices.</para>
        /// </description></item>
        /// </list>
        /// <h2>Effect Comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original Image</b></th>
        /// <th>*<em>Cropped to 1000\<em>1000</em></em></th>
        /// <th>*<em>Cropped to 3000\<em>2000</em></em></th>
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
        /// <para>Intelligently crop images to specified dimensions, automatically identify the main subject area of the image, and precisely crop to various sizes to meet design requirements for different scenarios. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Overview</h2>
        /// <para>The image cropping product can resize input images to specified dimensions. It supports automatic identification of the main subject area in images and precisely crops to various sizes to meet design requirements for different scenarios. (Synchronous)</para>
        /// <h2>Use Cases</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Multi-platform Content Distribution</b>: Automatically generate content in multiple sizes to meet the different image size requirements of various platforms and scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>Content Placement</b>: Automatically adjust sizes for different ad slots on different platforms, highlighting the main content, reducing blank space, and showcasing product features.</para>
        /// </description></item>
        /// </list>
        /// <h2>Feature Description</h2>
        /// <list type="bullet">
        /// <item><description><para>Automatically identify the main subject area of an image and crop precisely.</para>
        /// </description></item>
        /// <item><description><para>Support custom crop size output to adapt to different platforms and devices.</para>
        /// </description></item>
        /// </list>
        /// <h2>Effect Comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Original Image</b></th>
        /// <th>*<em>Cropped to 1000\<em>1000</em></em></th>
        /// <th>*<em>Cropped to 3000\<em>2000</em></em></th>
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
        /// <para>Intelligent image matting automatically identifies salient subjects in images, separates subjects from backgrounds, and returns subject images with backgrounds removed. The product also provides multiple background options and custom size selections to optimize product display. (Synchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Intelligent image matting automatically identifies salient subjects in images, separates subjects from backgrounds, and returns subject images with backgrounds removed. The product also provides multiple background options and custom size selections to optimize product display. (Synchronous).</para>
        /// <h2>Scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Secondary editing of materials</b>: After separating the image subject from the background, you can further edit the image.</para>
        /// </description></item>
        /// <item><description><para><b>Improved material processing efficiency</b>: Quickly extract subjects from various material images for easy background replacement, improving the production efficiency of advertising visuals and marketing posters.</para>
        /// </description></item>
        /// </list>
        /// <h2>Features.</h2>
        /// <h4>1. One-click precise subject recognition</h4>
        /// <list type="bullet">
        /// <item><description><para><b>AI automatic recognition</b>: Based on deep learning models, the feature intelligently distinguishes foreground subjects (portraits, products, objects, etc.) from backgrounds without manual tracing.</para>
        /// </description></item>
        /// <item><description><para><b>Multi-scenario adaptation</b>: Supports precise segmentation in complex scenarios (such as hair strands, transparent objects, and fur edges) with an accuracy rate exceeding 95%.</para>
        /// </description></item>
        /// </list>
        /// <h4>2. Intelligent edge optimization</h4>
        /// <list type="bullet">
        /// <item><description><b>Detail-level processing</b>: Performs automatic optimization of edge aliasing and semi-transparent areas (such as smoke and glass) while preserving natural transition effects.</description></item>
        /// </list>
        /// <h4>3. Multi-format output and background operations</h4>
        /// <list type="bullet">
        /// <item><description><para><b>Transparent background export</b>: Directly generates PNG images with transparent backgrounds and white backgrounds, suitable for e-commerce, design, and other scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>Custom background color support</b>.</para>
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
        /// <para>Intelligent image matting automatically identifies salient subjects in images, separates subjects from backgrounds, and returns subject images with backgrounds removed. The product also provides multiple background options and custom size selections to optimize product display. (Synchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Intelligent image matting automatically identifies salient subjects in images, separates subjects from backgrounds, and returns subject images with backgrounds removed. The product also provides multiple background options and custom size selections to optimize product display. (Synchronous).</para>
        /// <h2>Scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Secondary editing of materials</b>: After separating the image subject from the background, you can further edit the image.</para>
        /// </description></item>
        /// <item><description><para><b>Improved material processing efficiency</b>: Quickly extract subjects from various material images for easy background replacement, improving the production efficiency of advertising visuals and marketing posters.</para>
        /// </description></item>
        /// </list>
        /// <h2>Features.</h2>
        /// <h4>1. One-click precise subject recognition</h4>
        /// <list type="bullet">
        /// <item><description><para><b>AI automatic recognition</b>: Based on deep learning models, the feature intelligently distinguishes foreground subjects (portraits, products, objects, etc.) from backgrounds without manual tracing.</para>
        /// </description></item>
        /// <item><description><para><b>Multi-scenario adaptation</b>: Supports precise segmentation in complex scenarios (such as hair strands, transparent objects, and fur edges) with an accuracy rate exceeding 95%.</para>
        /// </description></item>
        /// </list>
        /// <h4>2. Intelligent edge optimization</h4>
        /// <list type="bullet">
        /// <item><description><b>Detail-level processing</b>: Performs automatic optimization of edge aliasing and semi-transparent areas (such as smoke and glass) while preserving natural transition effects.</description></item>
        /// </list>
        /// <h4>3. Multi-format output and background operations</h4>
        /// <list type="bullet">
        /// <item><description><para><b>Transparent background export</b>: Directly generates PNG images with transparent backgrounds and white backgrounds, suitable for e-commerce, design, and other scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>Custom background color support</b>.</para>
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
        /// <para>Intelligent image matting automatically identifies salient subjects in images, separates subjects from backgrounds, and returns subject images with backgrounds removed. The product also provides multiple background options and custom size selections to optimize product display. (Synchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Intelligent image matting automatically identifies salient subjects in images, separates subjects from backgrounds, and returns subject images with backgrounds removed. The product also provides multiple background options and custom size selections to optimize product display. (Synchronous).</para>
        /// <h2>Scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Secondary editing of materials</b>: After separating the image subject from the background, you can further edit the image.</para>
        /// </description></item>
        /// <item><description><para><b>Improved material processing efficiency</b>: Quickly extract subjects from various material images for easy background replacement, improving the production efficiency of advertising visuals and marketing posters.</para>
        /// </description></item>
        /// </list>
        /// <h2>Features.</h2>
        /// <h4>1. One-click precise subject recognition</h4>
        /// <list type="bullet">
        /// <item><description><para><b>AI automatic recognition</b>: Based on deep learning models, the feature intelligently distinguishes foreground subjects (portraits, products, objects, etc.) from backgrounds without manual tracing.</para>
        /// </description></item>
        /// <item><description><para><b>Multi-scenario adaptation</b>: Supports precise segmentation in complex scenarios (such as hair strands, transparent objects, and fur edges) with an accuracy rate exceeding 95%.</para>
        /// </description></item>
        /// </list>
        /// <h4>2. Intelligent edge optimization</h4>
        /// <list type="bullet">
        /// <item><description><b>Detail-level processing</b>: Performs automatic optimization of edge aliasing and semi-transparent areas (such as smoke and glass) while preserving natural transition effects.</description></item>
        /// </list>
        /// <h4>3. Multi-format output and background operations</h4>
        /// <list type="bullet">
        /// <item><description><para><b>Transparent background export</b>: Directly generates PNG images with transparent backgrounds and white backgrounds, suitable for e-commerce, design, and other scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>Custom background color support</b>.</para>
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
        /// <para>Intelligent image matting automatically identifies salient subjects in images, separates subjects from backgrounds, and returns subject images with backgrounds removed. The product also provides multiple background options and custom size selections to optimize product display. (Synchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Intelligent image matting automatically identifies salient subjects in images, separates subjects from backgrounds, and returns subject images with backgrounds removed. The product also provides multiple background options and custom size selections to optimize product display. (Synchronous).</para>
        /// <h2>Scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para><b>Secondary editing of materials</b>: After separating the image subject from the background, you can further edit the image.</para>
        /// </description></item>
        /// <item><description><para><b>Improved material processing efficiency</b>: Quickly extract subjects from various material images for easy background replacement, improving the production efficiency of advertising visuals and marketing posters.</para>
        /// </description></item>
        /// </list>
        /// <h2>Features.</h2>
        /// <h4>1. One-click precise subject recognition</h4>
        /// <list type="bullet">
        /// <item><description><para><b>AI automatic recognition</b>: Based on deep learning models, the feature intelligently distinguishes foreground subjects (portraits, products, objects, etc.) from backgrounds without manual tracing.</para>
        /// </description></item>
        /// <item><description><para><b>Multi-scenario adaptation</b>: Supports precise segmentation in complex scenarios (such as hair strands, transparent objects, and fur edges) with an accuracy rate exceeding 95%.</para>
        /// </description></item>
        /// </list>
        /// <h4>2. Intelligent edge optimization</h4>
        /// <list type="bullet">
        /// <item><description><b>Detail-level processing</b>: Performs automatic optimization of edge aliasing and semi-transparent areas (such as smoke and glass) while preserving natural transition effects.</description></item>
        /// </list>
        /// <h4>3. Multi-format output and background operations</h4>
        /// <list type="bullet">
        /// <item><description><para><b>Transparent background export</b>: Directly generates PNG images with transparent backgrounds and white backgrounds, suitable for e-commerce, design, and other scenarios.</para>
        /// </description></item>
        /// <item><description><para><b>Custom background color support</b>.</para>
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
        /// <para>Intelligent element recognition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>The Intelligent Element Recognition API is designed specifically for identifying specific elements in e-commerce images. It analyzes image details in depth, helping you quickly identify elements such as text, logos, watermarks, and text-containing color blocks in both the subject and background of images. This greatly improves the efficiency and accuracy of image screening. (Synchronous).</para>
        /// <h2>Scenarios</h2>
        /// <para><b>1. Intelligent image screening and optimization:</b>
        /// Merchants and platforms can use the Intelligent Element Recognition API for image screening to automatically identify images that contain specific elements such as watermarks and logos. After screening, you can call the Intelligent Removal API to optimize these images, improve image quality, and shorten the product release cycle.
        /// <b>2. Automated image processing and efficiency improvement:</b>
        /// With the Intelligent Element Recognition API, merchants and platforms can automate the image processing workflow by automatically identifying and marking image elements that require optimization. This process reduces manual intervention and improves image processing efficiency.</para>
        /// <h2>Features</h2>
        /// <para><b>1. Definitions of image subject, image background, text, logo, watermark, and text-containing color block: For details, refer to the related examples in the removal documentation (reserved text link)</b></para>
        /// <list type="bullet">
        /// <item><description><para>Image subject: The core product area in the image</para>
        /// </description></item>
        /// <item><description><para>Image background: The remaining part of the image other than the product subject</para>
        /// </description></item>
        /// <item><description><para>Text: Horizontal, vertical, or diagonal English or Chinese text</para>
        /// </description></item>
        /// <item><description><para>Logo: An emblem or trademark</para>
        /// </description></item>
        /// <item><description><para>Watermark: Monochrome transparent text, emblems, images, URLs, or store names</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: A color block outside the subject that contains text</para>
        /// </description></item>
        /// </list>
        /// <para><b>2. The main features of the Intelligent Element Recognition API include:</b></para>
        /// <list type="bullet">
        /// <item><description><para>Element recognition: Identifies whether elements such as text, logos, watermarks, and text-containing color blocks exist in the image subject and background.</para>
        /// </description></item>
        /// <item><description><para>Workflow coordination: Works in conjunction with the Intelligent Removal API. First, the Intelligent Element Recognition API identifies elements that need to be removed, and then the Intelligent Removal API effectively removes them, ensuring accuracy and efficiency in image processing.</para>
        /// </description></item>
        /// </list>
        /// <h2>Technical advantages</h2>
        /// <list type="bullet">
        /// <item><description><para>Synchronous batch processing: As a synchronous API, the Intelligent Element Recognition API can process large volumes of images while maintaining fast response times, adapting to business needs of different scales.</para>
        /// </description></item>
        /// <item><description><para>Flexibility: You can select the element types to recognize based on your needs, including elements in both the subject and non-subject areas such as watermarks, logos, and text, to meet personalized recognition requirements.</para>
        /// </description></item>
        /// </list>
        /// <h2>Comparison</h2>
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
        /// <item><description><para>Text-containing color block: true |.</para>
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
        /// <para>Intelligent element recognition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>The Intelligent Element Recognition API is designed specifically for identifying specific elements in e-commerce images. It analyzes image details in depth, helping you quickly identify elements such as text, logos, watermarks, and text-containing color blocks in both the subject and background of images. This greatly improves the efficiency and accuracy of image screening. (Synchronous).</para>
        /// <h2>Scenarios</h2>
        /// <para><b>1. Intelligent image screening and optimization:</b>
        /// Merchants and platforms can use the Intelligent Element Recognition API for image screening to automatically identify images that contain specific elements such as watermarks and logos. After screening, you can call the Intelligent Removal API to optimize these images, improve image quality, and shorten the product release cycle.
        /// <b>2. Automated image processing and efficiency improvement:</b>
        /// With the Intelligent Element Recognition API, merchants and platforms can automate the image processing workflow by automatically identifying and marking image elements that require optimization. This process reduces manual intervention and improves image processing efficiency.</para>
        /// <h2>Features</h2>
        /// <para><b>1. Definitions of image subject, image background, text, logo, watermark, and text-containing color block: For details, refer to the related examples in the removal documentation (reserved text link)</b></para>
        /// <list type="bullet">
        /// <item><description><para>Image subject: The core product area in the image</para>
        /// </description></item>
        /// <item><description><para>Image background: The remaining part of the image other than the product subject</para>
        /// </description></item>
        /// <item><description><para>Text: Horizontal, vertical, or diagonal English or Chinese text</para>
        /// </description></item>
        /// <item><description><para>Logo: An emblem or trademark</para>
        /// </description></item>
        /// <item><description><para>Watermark: Monochrome transparent text, emblems, images, URLs, or store names</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: A color block outside the subject that contains text</para>
        /// </description></item>
        /// </list>
        /// <para><b>2. The main features of the Intelligent Element Recognition API include:</b></para>
        /// <list type="bullet">
        /// <item><description><para>Element recognition: Identifies whether elements such as text, logos, watermarks, and text-containing color blocks exist in the image subject and background.</para>
        /// </description></item>
        /// <item><description><para>Workflow coordination: Works in conjunction with the Intelligent Removal API. First, the Intelligent Element Recognition API identifies elements that need to be removed, and then the Intelligent Removal API effectively removes them, ensuring accuracy and efficiency in image processing.</para>
        /// </description></item>
        /// </list>
        /// <h2>Technical advantages</h2>
        /// <list type="bullet">
        /// <item><description><para>Synchronous batch processing: As a synchronous API, the Intelligent Element Recognition API can process large volumes of images while maintaining fast response times, adapting to business needs of different scales.</para>
        /// </description></item>
        /// <item><description><para>Flexibility: You can select the element types to recognize based on your needs, including elements in both the subject and non-subject areas such as watermarks, logos, and text, to meet personalized recognition requirements.</para>
        /// </description></item>
        /// </list>
        /// <h2>Comparison</h2>
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
        /// <item><description><para>Text-containing color block: true |.</para>
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
        /// <para>Intelligent element recognition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>The Intelligent Element Recognition API is designed specifically for identifying specific elements in e-commerce images. It analyzes image details in depth, helping you quickly identify elements such as text, logos, watermarks, and text-containing color blocks in both the subject and background of images. This greatly improves the efficiency and accuracy of image screening. (Synchronous).</para>
        /// <h2>Scenarios</h2>
        /// <para><b>1. Intelligent image screening and optimization:</b>
        /// Merchants and platforms can use the Intelligent Element Recognition API for image screening to automatically identify images that contain specific elements such as watermarks and logos. After screening, you can call the Intelligent Removal API to optimize these images, improve image quality, and shorten the product release cycle.
        /// <b>2. Automated image processing and efficiency improvement:</b>
        /// With the Intelligent Element Recognition API, merchants and platforms can automate the image processing workflow by automatically identifying and marking image elements that require optimization. This process reduces manual intervention and improves image processing efficiency.</para>
        /// <h2>Features</h2>
        /// <para><b>1. Definitions of image subject, image background, text, logo, watermark, and text-containing color block: For details, refer to the related examples in the removal documentation (reserved text link)</b></para>
        /// <list type="bullet">
        /// <item><description><para>Image subject: The core product area in the image</para>
        /// </description></item>
        /// <item><description><para>Image background: The remaining part of the image other than the product subject</para>
        /// </description></item>
        /// <item><description><para>Text: Horizontal, vertical, or diagonal English or Chinese text</para>
        /// </description></item>
        /// <item><description><para>Logo: An emblem or trademark</para>
        /// </description></item>
        /// <item><description><para>Watermark: Monochrome transparent text, emblems, images, URLs, or store names</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: A color block outside the subject that contains text</para>
        /// </description></item>
        /// </list>
        /// <para><b>2. The main features of the Intelligent Element Recognition API include:</b></para>
        /// <list type="bullet">
        /// <item><description><para>Element recognition: Identifies whether elements such as text, logos, watermarks, and text-containing color blocks exist in the image subject and background.</para>
        /// </description></item>
        /// <item><description><para>Workflow coordination: Works in conjunction with the Intelligent Removal API. First, the Intelligent Element Recognition API identifies elements that need to be removed, and then the Intelligent Removal API effectively removes them, ensuring accuracy and efficiency in image processing.</para>
        /// </description></item>
        /// </list>
        /// <h2>Technical advantages</h2>
        /// <list type="bullet">
        /// <item><description><para>Synchronous batch processing: As a synchronous API, the Intelligent Element Recognition API can process large volumes of images while maintaining fast response times, adapting to business needs of different scales.</para>
        /// </description></item>
        /// <item><description><para>Flexibility: You can select the element types to recognize based on your needs, including elements in both the subject and non-subject areas such as watermarks, logos, and text, to meet personalized recognition requirements.</para>
        /// </description></item>
        /// </list>
        /// <h2>Comparison</h2>
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
        /// <item><description><para>Text-containing color block: true |.</para>
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
        /// <para>Intelligent element recognition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>The Intelligent Element Recognition API is designed specifically for identifying specific elements in e-commerce images. It analyzes image details in depth, helping you quickly identify elements such as text, logos, watermarks, and text-containing color blocks in both the subject and background of images. This greatly improves the efficiency and accuracy of image screening. (Synchronous).</para>
        /// <h2>Scenarios</h2>
        /// <para><b>1. Intelligent image screening and optimization:</b>
        /// Merchants and platforms can use the Intelligent Element Recognition API for image screening to automatically identify images that contain specific elements such as watermarks and logos. After screening, you can call the Intelligent Removal API to optimize these images, improve image quality, and shorten the product release cycle.
        /// <b>2. Automated image processing and efficiency improvement:</b>
        /// With the Intelligent Element Recognition API, merchants and platforms can automate the image processing workflow by automatically identifying and marking image elements that require optimization. This process reduces manual intervention and improves image processing efficiency.</para>
        /// <h2>Features</h2>
        /// <para><b>1. Definitions of image subject, image background, text, logo, watermark, and text-containing color block: For details, refer to the related examples in the removal documentation (reserved text link)</b></para>
        /// <list type="bullet">
        /// <item><description><para>Image subject: The core product area in the image</para>
        /// </description></item>
        /// <item><description><para>Image background: The remaining part of the image other than the product subject</para>
        /// </description></item>
        /// <item><description><para>Text: Horizontal, vertical, or diagonal English or Chinese text</para>
        /// </description></item>
        /// <item><description><para>Logo: An emblem or trademark</para>
        /// </description></item>
        /// <item><description><para>Watermark: Monochrome transparent text, emblems, images, URLs, or store names</para>
        /// </description></item>
        /// <item><description><para>Text-containing color block: A color block outside the subject that contains text</para>
        /// </description></item>
        /// </list>
        /// <para><b>2. The main features of the Intelligent Element Recognition API include:</b></para>
        /// <list type="bullet">
        /// <item><description><para>Element recognition: Identifies whether elements such as text, logos, watermarks, and text-containing color blocks exist in the image subject and background.</para>
        /// </description></item>
        /// <item><description><para>Workflow coordination: Works in conjunction with the Intelligent Removal API. First, the Intelligent Element Recognition API identifies elements that need to be removed, and then the Intelligent Removal API effectively removes them, ensuring accuracy and efficiency in image processing.</para>
        /// </description></item>
        /// </list>
        /// <h2>Technical advantages</h2>
        /// <list type="bullet">
        /// <item><description><para>Synchronous batch processing: As a synchronous API, the Intelligent Element Recognition API can process large volumes of images while maintaining fast response times, adapting to business needs of different scales.</para>
        /// </description></item>
        /// <item><description><para>Flexibility: You can select the element types to recognize based on your needs, including elements in both the subject and non-subject areas such as watermarks, logos, and text, to meet personalized recognition requirements.</para>
        /// </description></item>
        /// </list>
        /// <h2>Comparison</h2>
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
        /// <item><description><para>Text-containing color block: true |.</para>
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
        /// <para>The Intelligent Image Removal product is specially designed for e-commerce images. It automatically identifies and removes text, specific names, transparent text blocks, and blemishes from e-commerce images. You can specify objects to remove from images as needed, enabling efficient and accurate batch processing of large volumes of images and simplifying the image editing workflow. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Overview</h2>
        /// <para>The Intelligent Image Removal product is specially designed for e-commerce images. It automatically identifies and removes text, specific names, transparent text blocks, and blemishes from e-commerce images. You can specify objects to remove from images as needed, enabling efficient and accurate batch processing of large volumes of images and simplifying the image editing workflow. (Synchronous)</para>
        /// <h2>Use Cases</h2>
        /// <list type="bullet">
        /// <item><description><b>Efficient E-commerce Image Processing:</b></description></item>
        /// </list>
        /// <para>Remove irrelevant visual elements to provide a cleaner, more focused product display and enhance the customer shopping experience.</para>
        /// <list type="bullet">
        /// <item><description><b>Multi-platform Product Information Synchronization:</b></description></item>
        /// </list>
        /// <para>When merchants simultaneously list products across different e-commerce platforms, they can quickly remove specific text and blemishes to comply with different platform image specifications.</para>
        /// <list type="bullet">
        /// <item><description><b>Marketing Material Preparation:</b></description></item>
        /// </list>
        /// <para>Merchants can easily remove existing promotional information and quickly update it with the latest campaign details.</para>
        /// <remarks>
        /// <para>Note: Merchants or platforms can batch remove impurities from images to optimize image quality. We recommend using this in combination with the &quot;Intelligent Recognition API&quot; (coming soon). First, filter out images containing text, specific names, transparent text blocks, and blemishes, then use the &quot;Intelligent Removal API&quot; to batch remove them. The Intelligent Recognition API focuses on &quot;recognition,&quot; while the Intelligent Removal API focuses on &quot;removal.&quot; By calling them in sequence, you can maximize removal effectiveness and reduce &quot;false removals&quot; and &quot;false recognitions.&quot;</para>
        /// </remarks>
        /// <h2>Feature Introduction</h2>
        /// <ol>
        /// <item><description><para>First, clarify the definitions of image subject and image background. In actual use, when specifying removal targets, you can choose whether the removal scope is the image subject or the image background area. Both API and editor integration methods are supported to meet different types of requirements.</para>
        /// <ol>
        /// <item><description><para>Image subject: The core product area in the image</para>
        /// </description></item>
        /// <item><description><para>Image background: The remaining portion of the image apart from the product subject</para>
        /// </description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><para>Second, the removal targets support the following four types: text, specific names, transparent text blocks, and blemishes. You can use the following examples to clarify your usage requirements and perform targeted operations:</para>
        /// </description></item>
        /// </ol>
        /// <h2>Effect Comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Removable Objects in Images</b></th>
        /// <th><b>Original Image</b></th>
        /// <th><b>Image After Removal</b></th>
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
        /// | Specific Names | *   Involving the image subject area</para>
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
        /// | Transparent Text Blocks | *   Involving the image subject area</para>
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
        /// | Blemishes | *   Involving the image subject area</para>
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
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/caa6994b-2f97-484d-a807-671a0dc75947.jpeg" alt="dee0c7cf-8b0d-4d6d-9677-d5f2e6099834.jpeg"> |</para>
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
        /// <para>The Intelligent Image Removal product is specially designed for e-commerce images. It automatically identifies and removes text, specific names, transparent text blocks, and blemishes from e-commerce images. You can specify objects to remove from images as needed, enabling efficient and accurate batch processing of large volumes of images and simplifying the image editing workflow. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Overview</h2>
        /// <para>The Intelligent Image Removal product is specially designed for e-commerce images. It automatically identifies and removes text, specific names, transparent text blocks, and blemishes from e-commerce images. You can specify objects to remove from images as needed, enabling efficient and accurate batch processing of large volumes of images and simplifying the image editing workflow. (Synchronous)</para>
        /// <h2>Use Cases</h2>
        /// <list type="bullet">
        /// <item><description><b>Efficient E-commerce Image Processing:</b></description></item>
        /// </list>
        /// <para>Remove irrelevant visual elements to provide a cleaner, more focused product display and enhance the customer shopping experience.</para>
        /// <list type="bullet">
        /// <item><description><b>Multi-platform Product Information Synchronization:</b></description></item>
        /// </list>
        /// <para>When merchants simultaneously list products across different e-commerce platforms, they can quickly remove specific text and blemishes to comply with different platform image specifications.</para>
        /// <list type="bullet">
        /// <item><description><b>Marketing Material Preparation:</b></description></item>
        /// </list>
        /// <para>Merchants can easily remove existing promotional information and quickly update it with the latest campaign details.</para>
        /// <remarks>
        /// <para>Note: Merchants or platforms can batch remove impurities from images to optimize image quality. We recommend using this in combination with the &quot;Intelligent Recognition API&quot; (coming soon). First, filter out images containing text, specific names, transparent text blocks, and blemishes, then use the &quot;Intelligent Removal API&quot; to batch remove them. The Intelligent Recognition API focuses on &quot;recognition,&quot; while the Intelligent Removal API focuses on &quot;removal.&quot; By calling them in sequence, you can maximize removal effectiveness and reduce &quot;false removals&quot; and &quot;false recognitions.&quot;</para>
        /// </remarks>
        /// <h2>Feature Introduction</h2>
        /// <ol>
        /// <item><description><para>First, clarify the definitions of image subject and image background. In actual use, when specifying removal targets, you can choose whether the removal scope is the image subject or the image background area. Both API and editor integration methods are supported to meet different types of requirements.</para>
        /// <ol>
        /// <item><description><para>Image subject: The core product area in the image</para>
        /// </description></item>
        /// <item><description><para>Image background: The remaining portion of the image apart from the product subject</para>
        /// </description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><para>Second, the removal targets support the following four types: text, specific names, transparent text blocks, and blemishes. You can use the following examples to clarify your usage requirements and perform targeted operations:</para>
        /// </description></item>
        /// </ol>
        /// <h2>Effect Comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Removable Objects in Images</b></th>
        /// <th><b>Original Image</b></th>
        /// <th><b>Image After Removal</b></th>
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
        /// | Specific Names | *   Involving the image subject area</para>
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
        /// | Transparent Text Blocks | *   Involving the image subject area</para>
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
        /// | Blemishes | *   Involving the image subject area</para>
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
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/caa6994b-2f97-484d-a807-671a0dc75947.jpeg" alt="dee0c7cf-8b0d-4d6d-9677-d5f2e6099834.jpeg"> |</para>
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
        /// <para>The Intelligent Image Removal product is specially designed for e-commerce images. It automatically identifies and removes text, specific names, transparent text blocks, and blemishes from e-commerce images. You can specify objects to remove from images as needed, enabling efficient and accurate batch processing of large volumes of images and simplifying the image editing workflow. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Overview</h2>
        /// <para>The Intelligent Image Removal product is specially designed for e-commerce images. It automatically identifies and removes text, specific names, transparent text blocks, and blemishes from e-commerce images. You can specify objects to remove from images as needed, enabling efficient and accurate batch processing of large volumes of images and simplifying the image editing workflow. (Synchronous)</para>
        /// <h2>Use Cases</h2>
        /// <list type="bullet">
        /// <item><description><b>Efficient E-commerce Image Processing:</b></description></item>
        /// </list>
        /// <para>Remove irrelevant visual elements to provide a cleaner, more focused product display and enhance the customer shopping experience.</para>
        /// <list type="bullet">
        /// <item><description><b>Multi-platform Product Information Synchronization:</b></description></item>
        /// </list>
        /// <para>When merchants simultaneously list products across different e-commerce platforms, they can quickly remove specific text and blemishes to comply with different platform image specifications.</para>
        /// <list type="bullet">
        /// <item><description><b>Marketing Material Preparation:</b></description></item>
        /// </list>
        /// <para>Merchants can easily remove existing promotional information and quickly update it with the latest campaign details.</para>
        /// <remarks>
        /// <para>Note: Merchants or platforms can batch remove impurities from images to optimize image quality. We recommend using this in combination with the &quot;Intelligent Recognition API&quot; (coming soon). First, filter out images containing text, specific names, transparent text blocks, and blemishes, then use the &quot;Intelligent Removal API&quot; to batch remove them. The Intelligent Recognition API focuses on &quot;recognition,&quot; while the Intelligent Removal API focuses on &quot;removal.&quot; By calling them in sequence, you can maximize removal effectiveness and reduce &quot;false removals&quot; and &quot;false recognitions.&quot;</para>
        /// </remarks>
        /// <h2>Feature Introduction</h2>
        /// <ol>
        /// <item><description><para>First, clarify the definitions of image subject and image background. In actual use, when specifying removal targets, you can choose whether the removal scope is the image subject or the image background area. Both API and editor integration methods are supported to meet different types of requirements.</para>
        /// <ol>
        /// <item><description><para>Image subject: The core product area in the image</para>
        /// </description></item>
        /// <item><description><para>Image background: The remaining portion of the image apart from the product subject</para>
        /// </description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><para>Second, the removal targets support the following four types: text, specific names, transparent text blocks, and blemishes. You can use the following examples to clarify your usage requirements and perform targeted operations:</para>
        /// </description></item>
        /// </ol>
        /// <h2>Effect Comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Removable Objects in Images</b></th>
        /// <th><b>Original Image</b></th>
        /// <th><b>Image After Removal</b></th>
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
        /// | Specific Names | *   Involving the image subject area</para>
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
        /// | Transparent Text Blocks | *   Involving the image subject area</para>
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
        /// | Blemishes | *   Involving the image subject area</para>
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
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/caa6994b-2f97-484d-a807-671a0dc75947.jpeg" alt="dee0c7cf-8b0d-4d6d-9677-d5f2e6099834.jpeg"> |</para>
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
        /// <para>The Intelligent Image Removal product is specially designed for e-commerce images. It automatically identifies and removes text, specific names, transparent text blocks, and blemishes from e-commerce images. You can specify objects to remove from images as needed, enabling efficient and accurate batch processing of large volumes of images and simplifying the image editing workflow. (Synchronous)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Overview</h2>
        /// <para>The Intelligent Image Removal product is specially designed for e-commerce images. It automatically identifies and removes text, specific names, transparent text blocks, and blemishes from e-commerce images. You can specify objects to remove from images as needed, enabling efficient and accurate batch processing of large volumes of images and simplifying the image editing workflow. (Synchronous)</para>
        /// <h2>Use Cases</h2>
        /// <list type="bullet">
        /// <item><description><b>Efficient E-commerce Image Processing:</b></description></item>
        /// </list>
        /// <para>Remove irrelevant visual elements to provide a cleaner, more focused product display and enhance the customer shopping experience.</para>
        /// <list type="bullet">
        /// <item><description><b>Multi-platform Product Information Synchronization:</b></description></item>
        /// </list>
        /// <para>When merchants simultaneously list products across different e-commerce platforms, they can quickly remove specific text and blemishes to comply with different platform image specifications.</para>
        /// <list type="bullet">
        /// <item><description><b>Marketing Material Preparation:</b></description></item>
        /// </list>
        /// <para>Merchants can easily remove existing promotional information and quickly update it with the latest campaign details.</para>
        /// <remarks>
        /// <para>Note: Merchants or platforms can batch remove impurities from images to optimize image quality. We recommend using this in combination with the &quot;Intelligent Recognition API&quot; (coming soon). First, filter out images containing text, specific names, transparent text blocks, and blemishes, then use the &quot;Intelligent Removal API&quot; to batch remove them. The Intelligent Recognition API focuses on &quot;recognition,&quot; while the Intelligent Removal API focuses on &quot;removal.&quot; By calling them in sequence, you can maximize removal effectiveness and reduce &quot;false removals&quot; and &quot;false recognitions.&quot;</para>
        /// </remarks>
        /// <h2>Feature Introduction</h2>
        /// <ol>
        /// <item><description><para>First, clarify the definitions of image subject and image background. In actual use, when specifying removal targets, you can choose whether the removal scope is the image subject or the image background area. Both API and editor integration methods are supported to meet different types of requirements.</para>
        /// <ol>
        /// <item><description><para>Image subject: The core product area in the image</para>
        /// </description></item>
        /// <item><description><para>Image background: The remaining portion of the image apart from the product subject</para>
        /// </description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><para>Second, the removal targets support the following four types: text, specific names, transparent text blocks, and blemishes. You can use the following examples to clarify your usage requirements and perform targeted operations:</para>
        /// </description></item>
        /// </ol>
        /// <h2>Effect Comparison</h2>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th><b>Removable Objects in Images</b></th>
        /// <th><b>Original Image</b></th>
        /// <th><b>Image After Removal</b></th>
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
        /// | Specific Names | *   Involving the image subject area</para>
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
        /// | Transparent Text Blocks | *   Involving the image subject area</para>
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
        /// | Blemishes | *   Involving the image subject area</para>
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
        /// <para><img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/Mp7ld7bZAb2VAOBQ/img/caa6994b-2f97-484d-a807-671a0dc75947.jpeg" alt="dee0c7cf-8b0d-4d6d-9677-d5f2e6099834.jpeg"> |</para>
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
        /// <para>Image Translation Pro is designed specifically for e-commerce images. It integrates multimodal foundation model technology to achieve more accurate image understanding, significantly improve translation quality, and continuously expand and optimize multilingual translation capabilities. More than 100 language directions are supported, including bridged translations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Image Translation Pro is designed specifically for e-commerce images. It integrates multimodal foundation model technology to achieve more accurate image understanding, significantly improve translation quality, and continuously expand and optimize multilingual translation capabilities. More than 100 language directions are supported, including bridged translations.</para>
        /// <h2>Scenarios</h2>
        /// <para>E-commerce product images, marketing images, and images for various other scenarios.</para>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>Product subject information protection</b>: Specify whether to translate text on the product subject. This helps protect subject information such as embedded product names from being translated.</description></item>
        /// <item><description><b>Post-translation editing</b>: Specify whether to return layout information such as text position, font, and color. This can be used for secondary editing when integrated with an image editor. The editor SDK is not yet available. Follow platform notifications for updates.</description></item>
        /// <item><description><b>Brand name protection</b>: Specify whether to translate brand names on images. This helps protect brand name information from being translated.</description></item>
        /// <item><description><b>Translation intervention</b>: Customize translation results, including do-not-translate (ABC→ABC), specified translation (ABC→DEF), and remove text (ABC→empty value). This is commonly used for brand name protection. Pass the corresponding intervention glossary ID when calling the API to meet translation needs across different scenarios. You can upload up to 100,000 intervention terms. Contact the platform if you need more.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallType))
            {
                body["callType"] = request.CallType;
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
        /// <para>Image Translation Pro is designed specifically for e-commerce images. It integrates multimodal foundation model technology to achieve more accurate image understanding, significantly improve translation quality, and continuously expand and optimize multilingual translation capabilities. More than 100 language directions are supported, including bridged translations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Image Translation Pro is designed specifically for e-commerce images. It integrates multimodal foundation model technology to achieve more accurate image understanding, significantly improve translation quality, and continuously expand and optimize multilingual translation capabilities. More than 100 language directions are supported, including bridged translations.</para>
        /// <h2>Scenarios</h2>
        /// <para>E-commerce product images, marketing images, and images for various other scenarios.</para>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>Product subject information protection</b>: Specify whether to translate text on the product subject. This helps protect subject information such as embedded product names from being translated.</description></item>
        /// <item><description><b>Post-translation editing</b>: Specify whether to return layout information such as text position, font, and color. This can be used for secondary editing when integrated with an image editor. The editor SDK is not yet available. Follow platform notifications for updates.</description></item>
        /// <item><description><b>Brand name protection</b>: Specify whether to translate brand names on images. This helps protect brand name information from being translated.</description></item>
        /// <item><description><b>Translation intervention</b>: Customize translation results, including do-not-translate (ABC→ABC), specified translation (ABC→DEF), and remove text (ABC→empty value). This is commonly used for brand name protection. Pass the corresponding intervention glossary ID when calling the API to meet translation needs across different scenarios. You can upload up to 100,000 intervention terms. Contact the platform if you need more.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallType))
            {
                body["callType"] = request.CallType;
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
        /// <para>Image Translation Pro is designed specifically for e-commerce images. It integrates multimodal foundation model technology to achieve more accurate image understanding, significantly improve translation quality, and continuously expand and optimize multilingual translation capabilities. More than 100 language directions are supported, including bridged translations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Image Translation Pro is designed specifically for e-commerce images. It integrates multimodal foundation model technology to achieve more accurate image understanding, significantly improve translation quality, and continuously expand and optimize multilingual translation capabilities. More than 100 language directions are supported, including bridged translations.</para>
        /// <h2>Scenarios</h2>
        /// <para>E-commerce product images, marketing images, and images for various other scenarios.</para>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>Product subject information protection</b>: Specify whether to translate text on the product subject. This helps protect subject information such as embedded product names from being translated.</description></item>
        /// <item><description><b>Post-translation editing</b>: Specify whether to return layout information such as text position, font, and color. This can be used for secondary editing when integrated with an image editor. The editor SDK is not yet available. Follow platform notifications for updates.</description></item>
        /// <item><description><b>Brand name protection</b>: Specify whether to translate brand names on images. This helps protect brand name information from being translated.</description></item>
        /// <item><description><b>Translation intervention</b>: Customize translation results, including do-not-translate (ABC→ABC), specified translation (ABC→DEF), and remove text (ABC→empty value). This is commonly used for brand name protection. Pass the corresponding intervention glossary ID when calling the API to meet translation needs across different scenarios. You can upload up to 100,000 intervention terms. Contact the platform if you need more.</description></item>
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
        /// <para>Image Translation Pro is designed specifically for e-commerce images. It integrates multimodal foundation model technology to achieve more accurate image understanding, significantly improve translation quality, and continuously expand and optimize multilingual translation capabilities. More than 100 language directions are supported, including bridged translations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Image Translation Pro is designed specifically for e-commerce images. It integrates multimodal foundation model technology to achieve more accurate image understanding, significantly improve translation quality, and continuously expand and optimize multilingual translation capabilities. More than 100 language directions are supported, including bridged translations.</para>
        /// <h2>Scenarios</h2>
        /// <para>E-commerce product images, marketing images, and images for various other scenarios.</para>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>Product subject information protection</b>: Specify whether to translate text on the product subject. This helps protect subject information such as embedded product names from being translated.</description></item>
        /// <item><description><b>Post-translation editing</b>: Specify whether to return layout information such as text position, font, and color. This can be used for secondary editing when integrated with an image editor. The editor SDK is not yet available. Follow platform notifications for updates.</description></item>
        /// <item><description><b>Brand name protection</b>: Specify whether to translate brand names on images. This helps protect brand name information from being translated.</description></item>
        /// <item><description><b>Translation intervention</b>: Customize translation results, including do-not-translate (ABC→ABC), specified translation (ABC→DEF), and remove text (ABC→empty value). This is commonly used for brand name protection. Pass the corresponding intervention glossary ID when calling the API to meet translation needs across different scenarios. You can upload up to 100,000 intervention terms. Contact the platform if you need more.</description></item>
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
        /// <para>Image Translation is designed specifically for e-commerce images. It supports more than 100 language directions, accurately processes complex text layouts within images, and ensures that translated content matches the image content. This helps e-commerce platforms and developers easily achieve multilingual conversion and rendering of image content.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Image Translation is designed specifically for e-commerce images. It supports more than 100 language directions, accurately processes complex text layouts within images, and ensures that translated content matches the image content. This helps e-commerce platforms and developers easily achieve multilingual conversion and rendering of image content.</para>
        /// <h2>Common scenarios</h2>
        /// <para>E-commerce product images, marketing images, and images for various other scenarios.</para>
        /// <h2>Functions and features</h2>
        /// <list type="bullet">
        /// <item><description><b>Product subject information protection</b>: You can choose whether to translate text on the product subject. This helps protect subject information from being translated, such as embedded information like product names.</description></item>
        /// <item><description><b>Brand name protection</b>: You can choose whether to translate brand names on images. This helps protect brand name information from being translated.</description></item>
        /// <item><description><b>Translation intervention support</b>: You can customize translation results, including keeping text untranslated (ABC-ABC), specifying translations (ABC-DEF), or removing text (ABC-empty value). This is commonly used for brand name protection and similar scenarios. Pass the corresponding intervention glossary ID when calling the API to meet your translation needs in different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</description></item>
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
        /// <para>Image Translation is designed specifically for e-commerce images. It supports more than 100 language directions, accurately processes complex text layouts within images, and ensures that translated content matches the image content. This helps e-commerce platforms and developers easily achieve multilingual conversion and rendering of image content.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Image Translation is designed specifically for e-commerce images. It supports more than 100 language directions, accurately processes complex text layouts within images, and ensures that translated content matches the image content. This helps e-commerce platforms and developers easily achieve multilingual conversion and rendering of image content.</para>
        /// <h2>Common scenarios</h2>
        /// <para>E-commerce product images, marketing images, and images for various other scenarios.</para>
        /// <h2>Functions and features</h2>
        /// <list type="bullet">
        /// <item><description><b>Product subject information protection</b>: You can choose whether to translate text on the product subject. This helps protect subject information from being translated, such as embedded information like product names.</description></item>
        /// <item><description><b>Brand name protection</b>: You can choose whether to translate brand names on images. This helps protect brand name information from being translated.</description></item>
        /// <item><description><b>Translation intervention support</b>: You can customize translation results, including keeping text untranslated (ABC-ABC), specifying translations (ABC-DEF), or removing text (ABC-empty value). This is commonly used for brand name protection and similar scenarios. Pass the corresponding intervention glossary ID when calling the API to meet your translation needs in different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</description></item>
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
        /// <para>Image Translation is designed specifically for e-commerce images. It supports more than 100 language directions, accurately processes complex text layouts within images, and ensures that translated content matches the image content. This helps e-commerce platforms and developers easily achieve multilingual conversion and rendering of image content.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Image Translation is designed specifically for e-commerce images. It supports more than 100 language directions, accurately processes complex text layouts within images, and ensures that translated content matches the image content. This helps e-commerce platforms and developers easily achieve multilingual conversion and rendering of image content.</para>
        /// <h2>Common scenarios</h2>
        /// <para>E-commerce product images, marketing images, and images for various other scenarios.</para>
        /// <h2>Functions and features</h2>
        /// <list type="bullet">
        /// <item><description><b>Product subject information protection</b>: You can choose whether to translate text on the product subject. This helps protect subject information from being translated, such as embedded information like product names.</description></item>
        /// <item><description><b>Brand name protection</b>: You can choose whether to translate brand names on images. This helps protect brand name information from being translated.</description></item>
        /// <item><description><b>Translation intervention support</b>: You can customize translation results, including keeping text untranslated (ABC-ABC), specifying translations (ABC-DEF), or removing text (ABC-empty value). This is commonly used for brand name protection and similar scenarios. Pass the corresponding intervention glossary ID when calling the API to meet your translation needs in different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</description></item>
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
        /// <para>Image Translation is designed specifically for e-commerce images. It supports more than 100 language directions, accurately processes complex text layouts within images, and ensures that translated content matches the image content. This helps e-commerce platforms and developers easily achieve multilingual conversion and rendering of image content.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Image Translation is designed specifically for e-commerce images. It supports more than 100 language directions, accurately processes complex text layouts within images, and ensures that translated content matches the image content. This helps e-commerce platforms and developers easily achieve multilingual conversion and rendering of image content.</para>
        /// <h2>Common scenarios</h2>
        /// <para>E-commerce product images, marketing images, and images for various other scenarios.</para>
        /// <h2>Functions and features</h2>
        /// <list type="bullet">
        /// <item><description><b>Product subject information protection</b>: You can choose whether to translate text on the product subject. This helps protect subject information from being translated, such as embedded information like product names.</description></item>
        /// <item><description><b>Brand name protection</b>: You can choose whether to translate brand names on images. This helps protect brand name information from being translated.</description></item>
        /// <item><description><b>Translation intervention support</b>: You can customize translation results, including keeping text untranslated (ABC-ABC), specifying translations (ABC-DEF), or removing text (ABC-empty value). This is commonly used for brand name protection and similar scenarios. Pass the corresponding intervention glossary ID when calling the API to meet your translation needs in different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</description></item>
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
        /// <para>Supports automatic language detection for 24 languages. Applicable to short text such as search queries, titles, and conversations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Supports automatic language detection for 24 languages. Applicable to short text such as search queries, titles, and conversations.</para>
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
        /// <para>Supports automatic language detection for 24 languages. Applicable to short text such as search queries, titles, and conversations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Supports automatic language detection for 24 languages. Applicable to short text such as search queries, titles, and conversations.</para>
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
        /// <para>Supports automatic language detection for 24 languages. Applicable to short text such as search queries, titles, and conversations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Supports automatic language detection for 24 languages. Applicable to short text such as search queries, titles, and conversations.</para>
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
        /// <para>Supports automatic language detection for 24 languages. Applicable to short text such as search queries, titles, and conversations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Supports automatic language detection for 24 languages. Applicable to short text such as search queries, titles, and conversations.</para>
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
        /// <para>An intelligent logistics parcel auditing product built on the synergy of Multimodal Large Language Models (MLLM) and specialized vision algorithms, designed for automated compliance review in the &quot;piece-weight-dimension&quot; stage of e-commerce logistics. The product performs structured auditing across multiple dimensions including bounding box validity, bounding box fit accuracy, and foreign object interference on parcels placed on scanning platforms. It supports different hardware acquisition scenarios such as white background boards and green background boards, and outputs Boolean audit conclusions with Chinese reason descriptions that can be directly integrated into business systems. It is suitable for large-scale, high-concurrency inbound quality inspection pipelines.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>An intelligent logistics parcel auditing product built on the synergy of Multimodal Large Language Models (MLLM) and specialized vision algorithms, designed for automated compliance review in the &quot;piece-weight-dimension&quot; stage of e-commerce logistics. The product performs structured auditing across multiple dimensions including <b>bounding box validity, bounding box fit accuracy, and foreign object interference</b> on parcels placed on scanning platforms. It supports different hardware acquisition scenarios such as white background boards and green background boards, and outputs Boolean audit conclusions with Chinese reason descriptions that can be directly integrated into business systems. It is suitable for large-scale, high-concurrency inbound quality inspection pipelines.</para>
        /// <h2>Applicable Scenarios</h2>
        /// <ol>
        /// <item><description><b>Parcel Bounding Box Audit</b>: Automatically determines whether the operator\&quot;s manual bounding box constitutes the &quot;minimum valid bounding rectangle&quot; for the parcel, identifying typical issues such as oversized or undersized bounding boxes.</description></item>
        /// <item><description><b>Foreign Object Interference Detection</b>: Automatically identifies whether non-target objects such as fingers, keyboards, or auxiliary tools have entered the scanning area.</description></item>
        /// <item><description><b>Multi-Acquisition Environment Adaptation</b>: A single API can handle two common acquisition modes — white background board (blue box) and green background board (blue box + red box) — without requiring the caller to distinguish between scenarios.</description></item>
        /// <item><description><b>Inbound Quality Inspection Pipeline</b>: Used for automated review in the piece-weight-dimension stage of the logistics warehouse new product inbound SOP, replacing or assisting manual outsourced auditing.
        /// Additionally, the product can also be used for general image &quot;box-subject&quot; relationship audit scenarios, such as product photography material review and document scanning quality verification.</description></item>
        /// </ol>
        /// <h2>Feature Introduction</h2>
        /// <ol>
        /// <item><description><b>Multi-Scenario Intelligent Routing</b>: The product has a built-in scenario classification capability that can automatically identify the background type (white/green) and bounding box type (none/single box/double box) in the image, and route the request to the corresponding audit sub-process. The caller only needs to provide the image URL without manually specifying the scenario.</description></item>
        /// <item><description><b>MLLM + Specialized CV Model Synergy</b>: Multimodal large language models are used for semantic-level scene understanding and foreign object recognition, while specialized parcel segmentation and IoU evaluation models are used for pixel-level bounding box fit quantification, ensuring accuracy while controlling inference latency and cost.</description></item>
        /// <item><description><b>Structured Audit Conclusions</b>: The output is uniformly structured as <c>result</c> (Boolean) + <c>info</c> (Chinese reason). Supported reason types include &quot;Audit passed&quot;, &quot;Audit not passed: bounding box too large&quot;, &quot;Audit not passed: bounding box too small&quot;, &quot;Audit not passed: foreign object present&quot;, etc., facilitating direct integration with downstream business systems.</description></item>
        /// <item><description><b>Supported Input Formats</b>: Currently supports publicly accessible image URLs.</description></item>
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
        /// <para>An intelligent logistics parcel auditing product built on the synergy of Multimodal Large Language Models (MLLM) and specialized vision algorithms, designed for automated compliance review in the &quot;piece-weight-dimension&quot; stage of e-commerce logistics. The product performs structured auditing across multiple dimensions including bounding box validity, bounding box fit accuracy, and foreign object interference on parcels placed on scanning platforms. It supports different hardware acquisition scenarios such as white background boards and green background boards, and outputs Boolean audit conclusions with Chinese reason descriptions that can be directly integrated into business systems. It is suitable for large-scale, high-concurrency inbound quality inspection pipelines.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>An intelligent logistics parcel auditing product built on the synergy of Multimodal Large Language Models (MLLM) and specialized vision algorithms, designed for automated compliance review in the &quot;piece-weight-dimension&quot; stage of e-commerce logistics. The product performs structured auditing across multiple dimensions including <b>bounding box validity, bounding box fit accuracy, and foreign object interference</b> on parcels placed on scanning platforms. It supports different hardware acquisition scenarios such as white background boards and green background boards, and outputs Boolean audit conclusions with Chinese reason descriptions that can be directly integrated into business systems. It is suitable for large-scale, high-concurrency inbound quality inspection pipelines.</para>
        /// <h2>Applicable Scenarios</h2>
        /// <ol>
        /// <item><description><b>Parcel Bounding Box Audit</b>: Automatically determines whether the operator\&quot;s manual bounding box constitutes the &quot;minimum valid bounding rectangle&quot; for the parcel, identifying typical issues such as oversized or undersized bounding boxes.</description></item>
        /// <item><description><b>Foreign Object Interference Detection</b>: Automatically identifies whether non-target objects such as fingers, keyboards, or auxiliary tools have entered the scanning area.</description></item>
        /// <item><description><b>Multi-Acquisition Environment Adaptation</b>: A single API can handle two common acquisition modes — white background board (blue box) and green background board (blue box + red box) — without requiring the caller to distinguish between scenarios.</description></item>
        /// <item><description><b>Inbound Quality Inspection Pipeline</b>: Used for automated review in the piece-weight-dimension stage of the logistics warehouse new product inbound SOP, replacing or assisting manual outsourced auditing.
        /// Additionally, the product can also be used for general image &quot;box-subject&quot; relationship audit scenarios, such as product photography material review and document scanning quality verification.</description></item>
        /// </ol>
        /// <h2>Feature Introduction</h2>
        /// <ol>
        /// <item><description><b>Multi-Scenario Intelligent Routing</b>: The product has a built-in scenario classification capability that can automatically identify the background type (white/green) and bounding box type (none/single box/double box) in the image, and route the request to the corresponding audit sub-process. The caller only needs to provide the image URL without manually specifying the scenario.</description></item>
        /// <item><description><b>MLLM + Specialized CV Model Synergy</b>: Multimodal large language models are used for semantic-level scene understanding and foreign object recognition, while specialized parcel segmentation and IoU evaluation models are used for pixel-level bounding box fit quantification, ensuring accuracy while controlling inference latency and cost.</description></item>
        /// <item><description><b>Structured Audit Conclusions</b>: The output is uniformly structured as <c>result</c> (Boolean) + <c>info</c> (Chinese reason). Supported reason types include &quot;Audit passed&quot;, &quot;Audit not passed: bounding box too large&quot;, &quot;Audit not passed: bounding box too small&quot;, &quot;Audit not passed: foreign object present&quot;, etc., facilitating direct integration with downstream business systems.</description></item>
        /// <item><description><b>Supported Input Formats</b>: Currently supports publicly accessible image URLs.</description></item>
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
        /// <para>An intelligent logistics parcel auditing product built on the synergy of Multimodal Large Language Models (MLLM) and specialized vision algorithms, designed for automated compliance review in the &quot;piece-weight-dimension&quot; stage of e-commerce logistics. The product performs structured auditing across multiple dimensions including bounding box validity, bounding box fit accuracy, and foreign object interference on parcels placed on scanning platforms. It supports different hardware acquisition scenarios such as white background boards and green background boards, and outputs Boolean audit conclusions with Chinese reason descriptions that can be directly integrated into business systems. It is suitable for large-scale, high-concurrency inbound quality inspection pipelines.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>An intelligent logistics parcel auditing product built on the synergy of Multimodal Large Language Models (MLLM) and specialized vision algorithms, designed for automated compliance review in the &quot;piece-weight-dimension&quot; stage of e-commerce logistics. The product performs structured auditing across multiple dimensions including <b>bounding box validity, bounding box fit accuracy, and foreign object interference</b> on parcels placed on scanning platforms. It supports different hardware acquisition scenarios such as white background boards and green background boards, and outputs Boolean audit conclusions with Chinese reason descriptions that can be directly integrated into business systems. It is suitable for large-scale, high-concurrency inbound quality inspection pipelines.</para>
        /// <h2>Applicable Scenarios</h2>
        /// <ol>
        /// <item><description><b>Parcel Bounding Box Audit</b>: Automatically determines whether the operator\&quot;s manual bounding box constitutes the &quot;minimum valid bounding rectangle&quot; for the parcel, identifying typical issues such as oversized or undersized bounding boxes.</description></item>
        /// <item><description><b>Foreign Object Interference Detection</b>: Automatically identifies whether non-target objects such as fingers, keyboards, or auxiliary tools have entered the scanning area.</description></item>
        /// <item><description><b>Multi-Acquisition Environment Adaptation</b>: A single API can handle two common acquisition modes — white background board (blue box) and green background board (blue box + red box) — without requiring the caller to distinguish between scenarios.</description></item>
        /// <item><description><b>Inbound Quality Inspection Pipeline</b>: Used for automated review in the piece-weight-dimension stage of the logistics warehouse new product inbound SOP, replacing or assisting manual outsourced auditing.
        /// Additionally, the product can also be used for general image &quot;box-subject&quot; relationship audit scenarios, such as product photography material review and document scanning quality verification.</description></item>
        /// </ol>
        /// <h2>Feature Introduction</h2>
        /// <ol>
        /// <item><description><b>Multi-Scenario Intelligent Routing</b>: The product has a built-in scenario classification capability that can automatically identify the background type (white/green) and bounding box type (none/single box/double box) in the image, and route the request to the corresponding audit sub-process. The caller only needs to provide the image URL without manually specifying the scenario.</description></item>
        /// <item><description><b>MLLM + Specialized CV Model Synergy</b>: Multimodal large language models are used for semantic-level scene understanding and foreign object recognition, while specialized parcel segmentation and IoU evaluation models are used for pixel-level bounding box fit quantification, ensuring accuracy while controlling inference latency and cost.</description></item>
        /// <item><description><b>Structured Audit Conclusions</b>: The output is uniformly structured as <c>result</c> (Boolean) + <c>info</c> (Chinese reason). Supported reason types include &quot;Audit passed&quot;, &quot;Audit not passed: bounding box too large&quot;, &quot;Audit not passed: bounding box too small&quot;, &quot;Audit not passed: foreign object present&quot;, etc., facilitating direct integration with downstream business systems.</description></item>
        /// <item><description><b>Supported Input Formats</b>: Currently supports publicly accessible image URLs.</description></item>
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
        /// <para>An intelligent logistics parcel auditing product built on the synergy of Multimodal Large Language Models (MLLM) and specialized vision algorithms, designed for automated compliance review in the &quot;piece-weight-dimension&quot; stage of e-commerce logistics. The product performs structured auditing across multiple dimensions including bounding box validity, bounding box fit accuracy, and foreign object interference on parcels placed on scanning platforms. It supports different hardware acquisition scenarios such as white background boards and green background boards, and outputs Boolean audit conclusions with Chinese reason descriptions that can be directly integrated into business systems. It is suitable for large-scale, high-concurrency inbound quality inspection pipelines.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>An intelligent logistics parcel auditing product built on the synergy of Multimodal Large Language Models (MLLM) and specialized vision algorithms, designed for automated compliance review in the &quot;piece-weight-dimension&quot; stage of e-commerce logistics. The product performs structured auditing across multiple dimensions including <b>bounding box validity, bounding box fit accuracy, and foreign object interference</b> on parcels placed on scanning platforms. It supports different hardware acquisition scenarios such as white background boards and green background boards, and outputs Boolean audit conclusions with Chinese reason descriptions that can be directly integrated into business systems. It is suitable for large-scale, high-concurrency inbound quality inspection pipelines.</para>
        /// <h2>Applicable Scenarios</h2>
        /// <ol>
        /// <item><description><b>Parcel Bounding Box Audit</b>: Automatically determines whether the operator\&quot;s manual bounding box constitutes the &quot;minimum valid bounding rectangle&quot; for the parcel, identifying typical issues such as oversized or undersized bounding boxes.</description></item>
        /// <item><description><b>Foreign Object Interference Detection</b>: Automatically identifies whether non-target objects such as fingers, keyboards, or auxiliary tools have entered the scanning area.</description></item>
        /// <item><description><b>Multi-Acquisition Environment Adaptation</b>: A single API can handle two common acquisition modes — white background board (blue box) and green background board (blue box + red box) — without requiring the caller to distinguish between scenarios.</description></item>
        /// <item><description><b>Inbound Quality Inspection Pipeline</b>: Used for automated review in the piece-weight-dimension stage of the logistics warehouse new product inbound SOP, replacing or assisting manual outsourced auditing.
        /// Additionally, the product can also be used for general image &quot;box-subject&quot; relationship audit scenarios, such as product photography material review and document scanning quality verification.</description></item>
        /// </ol>
        /// <h2>Feature Introduction</h2>
        /// <ol>
        /// <item><description><b>Multi-Scenario Intelligent Routing</b>: The product has a built-in scenario classification capability that can automatically identify the background type (white/green) and bounding box type (none/single box/double box) in the image, and route the request to the corresponding audit sub-process. The caller only needs to provide the image URL without manually specifying the scenario.</description></item>
        /// <item><description><b>MLLM + Specialized CV Model Synergy</b>: Multimodal large language models are used for semantic-level scene understanding and foreign object recognition, while specialized parcel segmentation and IoU evaluation models are used for pixel-level bounding box fit quantification, ensuring accuracy while controlling inference latency and cost.</description></item>
        /// <item><description><b>Structured Audit Conclusions</b>: The output is uniformly structured as <c>result</c> (Boolean) + <c>info</c> (Chinese reason). Supported reason types include &quot;Audit passed&quot;, &quot;Audit not passed: bounding box too large&quot;, &quot;Audit not passed: bounding box too small&quot;, &quot;Audit not passed: foreign object present&quot;, etc., facilitating direct integration with downstream business systems.</description></item>
        /// <item><description><b>Supported Input Formats</b>: Currently supports publicly accessible image URLs.</description></item>
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
        /// <para>API name on the POP gateway: QueryAsyncTaskResult.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>API name on the POP gateway: QueryAsyncTaskResult.</para>
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
        /// <para>API name on the POP gateway: QueryAsyncTaskResult.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>API name on the POP gateway: QueryAsyncTaskResult.</para>
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
        /// <para>API name on the POP gateway: QueryAsyncTaskResult.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>API name on the POP gateway: QueryAsyncTaskResult.</para>
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
        /// <para>API name on the POP gateway: QueryAsyncTaskResult.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>API name on the POP gateway: QueryAsyncTaskResult.</para>
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
        /// <para>Detects whether an image contains a size chart. (Synchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>Detects whether an image contains a size chart. (Synchronous).</para>
        /// <h1>2. Common scenarios</h1>
        /// <para><b>Batch processing scenarios:</b> Detect images that contain size charts from a batch of images for further translation or extraction. The size chart detection service helps reduce costs.</para>
        /// <h1>3. Functions and features</h1>
        /// <para>The size chart detection service uses image recognition technology to automatically determine whether an input image contains a size chart. You provide an image URL, and the system returns a detection result (True/False) indicating whether the image is a size chart.
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
        /// <para>Detects whether an image contains a size chart. (Synchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>Detects whether an image contains a size chart. (Synchronous).</para>
        /// <h1>2. Common scenarios</h1>
        /// <para><b>Batch processing scenarios:</b> Detect images that contain size charts from a batch of images for further translation or extraction. The size chart detection service helps reduce costs.</para>
        /// <h1>3. Functions and features</h1>
        /// <para>The size chart detection service uses image recognition technology to automatically determine whether an input image contains a size chart. You provide an image URL, and the system returns a detection result (True/False) indicating whether the image is a size chart.
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
        /// <para>Detects whether an image contains a size chart. (Synchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>Detects whether an image contains a size chart. (Synchronous).</para>
        /// <h1>2. Common scenarios</h1>
        /// <para><b>Batch processing scenarios:</b> Detect images that contain size charts from a batch of images for further translation or extraction. The size chart detection service helps reduce costs.</para>
        /// <h1>3. Functions and features</h1>
        /// <para>The size chart detection service uses image recognition technology to automatically determine whether an input image contains a size chart. You provide an image URL, and the system returns a detection result (True/False) indicating whether the image is a size chart.
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
        /// <para>Detects whether an image contains a size chart. (Synchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>Detects whether an image contains a size chart. (Synchronous).</para>
        /// <h1>2. Common scenarios</h1>
        /// <para><b>Batch processing scenarios:</b> Detect images that contain size charts from a batch of images for further translation or extraction. The size chart detection service helps reduce costs.</para>
        /// <h1>3. Functions and features</h1>
        /// <para>The size chart detection service uses image recognition technology to automatically determine whether an input image contains a size chart. You provide an image URL, and the system returns a detection result (True/False) indicating whether the image is a size chart.
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
        /// <para>Intelligently extracts structured information such as size charts and package weight/dimension data from images by using a multimodal large language model. (Asynchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Intelligently extracts structured information such as size charts and package weight/dimension data from images by using a multimodal large language model. (Asynchronous).</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para>Size charts: Extracts size charts from apparel categories into text.</para>
        /// </description></item>
        /// <item><description><para>Package weight/dimensions: Extracts package weight and dimension information from images.</para>
        /// </description></item>
        /// </list>
        /// <h2>Functions and features</h2>
        /// <para>The size chart extraction service is based on a multimodal large language model. It automatically recognizes size chart or package weight/dimension information in images and converts it into structured text output. You provide an image URL, and the system processes the request as an asynchronous task and returns the extracted structured data. You can use the ColumnNameList parameter to specify the column names to recognize (such as Size, Bust, and Length) for precise targeted extraction. You can also use the LanguageModel parameter to control the output language. Valid values: cn (Chinese) and en (English). If you leave this parameter empty, the original language is retained. This service is applicable to scenarios such as converting apparel size charts to text and batch structuring of product weight/dimension information.
        /// Core capabilities: Provide an image URL and optional column name configurations as input, and receive structured data of size charts or package weight/dimensions from the image as output. The API uses an asynchronous task mode (background: true). After submission, a task ID is returned. Poll for the final result. This mode is suitable for processing complex images or high-volume calls.</para>
        /// <h2>Comparison</h2>
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
        /// <para>} |.</para>
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
        /// <para>Intelligently extracts structured information such as size charts and package weight/dimension data from images by using a multimodal large language model. (Asynchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Intelligently extracts structured information such as size charts and package weight/dimension data from images by using a multimodal large language model. (Asynchronous).</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para>Size charts: Extracts size charts from apparel categories into text.</para>
        /// </description></item>
        /// <item><description><para>Package weight/dimensions: Extracts package weight and dimension information from images.</para>
        /// </description></item>
        /// </list>
        /// <h2>Functions and features</h2>
        /// <para>The size chart extraction service is based on a multimodal large language model. It automatically recognizes size chart or package weight/dimension information in images and converts it into structured text output. You provide an image URL, and the system processes the request as an asynchronous task and returns the extracted structured data. You can use the ColumnNameList parameter to specify the column names to recognize (such as Size, Bust, and Length) for precise targeted extraction. You can also use the LanguageModel parameter to control the output language. Valid values: cn (Chinese) and en (English). If you leave this parameter empty, the original language is retained. This service is applicable to scenarios such as converting apparel size charts to text and batch structuring of product weight/dimension information.
        /// Core capabilities: Provide an image URL and optional column name configurations as input, and receive structured data of size charts or package weight/dimensions from the image as output. The API uses an asynchronous task mode (background: true). After submission, a task ID is returned. Poll for the final result. This mode is suitable for processing complex images or high-volume calls.</para>
        /// <h2>Comparison</h2>
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
        /// <para>} |.</para>
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
        /// <para>Intelligently extracts structured information such as size charts and package weight/dimension data from images by using a multimodal large language model. (Asynchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Intelligently extracts structured information such as size charts and package weight/dimension data from images by using a multimodal large language model. (Asynchronous).</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para>Size charts: Extracts size charts from apparel categories into text.</para>
        /// </description></item>
        /// <item><description><para>Package weight/dimensions: Extracts package weight and dimension information from images.</para>
        /// </description></item>
        /// </list>
        /// <h2>Functions and features</h2>
        /// <para>The size chart extraction service is based on a multimodal large language model. It automatically recognizes size chart or package weight/dimension information in images and converts it into structured text output. You provide an image URL, and the system processes the request as an asynchronous task and returns the extracted structured data. You can use the ColumnNameList parameter to specify the column names to recognize (such as Size, Bust, and Length) for precise targeted extraction. You can also use the LanguageModel parameter to control the output language. Valid values: cn (Chinese) and en (English). If you leave this parameter empty, the original language is retained. This service is applicable to scenarios such as converting apparel size charts to text and batch structuring of product weight/dimension information.
        /// Core capabilities: Provide an image URL and optional column name configurations as input, and receive structured data of size charts or package weight/dimensions from the image as output. The API uses an asynchronous task mode (background: true). After submission, a task ID is returned. Poll for the final result. This mode is suitable for processing complex images or high-volume calls.</para>
        /// <h2>Comparison</h2>
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
        /// <para>} |.</para>
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
        /// <para>Intelligently extracts structured information such as size charts and package weight/dimension data from images by using a multimodal large language model. (Asynchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Intelligently extracts structured information such as size charts and package weight/dimension data from images by using a multimodal large language model. (Asynchronous).</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description><para>Size charts: Extracts size charts from apparel categories into text.</para>
        /// </description></item>
        /// <item><description><para>Package weight/dimensions: Extracts package weight and dimension information from images.</para>
        /// </description></item>
        /// </list>
        /// <h2>Functions and features</h2>
        /// <para>The size chart extraction service is based on a multimodal large language model. It automatically recognizes size chart or package weight/dimension information in images and converts it into structured text output. You provide an image URL, and the system processes the request as an asynchronous task and returns the extracted structured data. You can use the ColumnNameList parameter to specify the column names to recognize (such as Size, Bust, and Length) for precise targeted extraction. You can also use the LanguageModel parameter to control the output language. Valid values: cn (Chinese) and en (English). If you leave this parameter empty, the original language is retained. This service is applicable to scenarios such as converting apparel size charts to text and batch structuring of product weight/dimension information.
        /// Core capabilities: Provide an image URL and optional column name configurations as input, and receive structured data of size charts or package weight/dimensions from the image as output. The API uses an asynchronous task mode (background: true). After submission, a task ID is returned. Poll for the final result. This mode is suitable for processing complex images or high-volume calls.</para>
        /// <h2>Comparison</h2>
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
        /// <para>} |.</para>
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
        /// <para>Correct errors in search terms and titles</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Corrects errors in search terms and titles. Currently supports the following 14 languages:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>No.</th>
        /// <th>Language Name (English)</th>
        /// <th>Language Code</th>
        /// <th>Language Name (Chinese)</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>1</td>
        /// <td>Arabic</td>
        /// <td>ar</td>
        /// <td>Arabic</td>
        /// </tr>
        /// <tr>
        /// <td>2</td>
        /// <td>German</td>
        /// <td>de</td>
        /// <td>German</td>
        /// </tr>
        /// <tr>
        /// <td>3</td>
        /// <td>English</td>
        /// <td>en</td>
        /// <td>English</td>
        /// </tr>
        /// <tr>
        /// <td>4</td>
        /// <td>Spanish</td>
        /// <td>es</td>
        /// <td>Spanish</td>
        /// </tr>
        /// <tr>
        /// <td>5</td>
        /// <td>French</td>
        /// <td>fr</td>
        /// <td>French</td>
        /// </tr>
        /// <tr>
        /// <td>6</td>
        /// <td>Hebrew</td>
        /// <td>he</td>
        /// <td>Hebrew</td>
        /// </tr>
        /// <tr>
        /// <td>7</td>
        /// <td>Italian</td>
        /// <td>it</td>
        /// <td>Italian</td>
        /// </tr>
        /// <tr>
        /// <td>8</td>
        /// <td>Japanese</td>
        /// <td>ja</td>
        /// <td>Japanese</td>
        /// </tr>
        /// <tr>
        /// <td>9</td>
        /// <td>Korean</td>
        /// <td>ko</td>
        /// <td>Korean</td>
        /// </tr>
        /// <tr>
        /// <td>10</td>
        /// <td>Dutch</td>
        /// <td>nl</td>
        /// <td>Dutch</td>
        /// </tr>
        /// <tr>
        /// <td>11</td>
        /// <td>Polish</td>
        /// <td>pl</td>
        /// <td>Polish</td>
        /// </tr>
        /// <tr>
        /// <td>12</td>
        /// <td>Portuguese</td>
        /// <td>pt</td>
        /// <td>Portuguese (Brazil)</td>
        /// </tr>
        /// <tr>
        /// <td>13</td>
        /// <td>Russian</td>
        /// <td>ru</td>
        /// <td>Russian</td>
        /// </tr>
        /// <tr>
        /// <td>14</td>
        /// <td>Ukrainian</td>
        /// <td>uk</td>
        /// <td>Ukrainian</td>
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
        /// <para>Correct errors in search terms and titles</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Corrects errors in search terms and titles. Currently supports the following 14 languages:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>No.</th>
        /// <th>Language Name (English)</th>
        /// <th>Language Code</th>
        /// <th>Language Name (Chinese)</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>1</td>
        /// <td>Arabic</td>
        /// <td>ar</td>
        /// <td>Arabic</td>
        /// </tr>
        /// <tr>
        /// <td>2</td>
        /// <td>German</td>
        /// <td>de</td>
        /// <td>German</td>
        /// </tr>
        /// <tr>
        /// <td>3</td>
        /// <td>English</td>
        /// <td>en</td>
        /// <td>English</td>
        /// </tr>
        /// <tr>
        /// <td>4</td>
        /// <td>Spanish</td>
        /// <td>es</td>
        /// <td>Spanish</td>
        /// </tr>
        /// <tr>
        /// <td>5</td>
        /// <td>French</td>
        /// <td>fr</td>
        /// <td>French</td>
        /// </tr>
        /// <tr>
        /// <td>6</td>
        /// <td>Hebrew</td>
        /// <td>he</td>
        /// <td>Hebrew</td>
        /// </tr>
        /// <tr>
        /// <td>7</td>
        /// <td>Italian</td>
        /// <td>it</td>
        /// <td>Italian</td>
        /// </tr>
        /// <tr>
        /// <td>8</td>
        /// <td>Japanese</td>
        /// <td>ja</td>
        /// <td>Japanese</td>
        /// </tr>
        /// <tr>
        /// <td>9</td>
        /// <td>Korean</td>
        /// <td>ko</td>
        /// <td>Korean</td>
        /// </tr>
        /// <tr>
        /// <td>10</td>
        /// <td>Dutch</td>
        /// <td>nl</td>
        /// <td>Dutch</td>
        /// </tr>
        /// <tr>
        /// <td>11</td>
        /// <td>Polish</td>
        /// <td>pl</td>
        /// <td>Polish</td>
        /// </tr>
        /// <tr>
        /// <td>12</td>
        /// <td>Portuguese</td>
        /// <td>pt</td>
        /// <td>Portuguese (Brazil)</td>
        /// </tr>
        /// <tr>
        /// <td>13</td>
        /// <td>Russian</td>
        /// <td>ru</td>
        /// <td>Russian</td>
        /// </tr>
        /// <tr>
        /// <td>14</td>
        /// <td>Ukrainian</td>
        /// <td>uk</td>
        /// <td>Ukrainian</td>
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
        /// <para>Correct errors in search terms and titles</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Corrects errors in search terms and titles. Currently supports the following 14 languages:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>No.</th>
        /// <th>Language Name (English)</th>
        /// <th>Language Code</th>
        /// <th>Language Name (Chinese)</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>1</td>
        /// <td>Arabic</td>
        /// <td>ar</td>
        /// <td>Arabic</td>
        /// </tr>
        /// <tr>
        /// <td>2</td>
        /// <td>German</td>
        /// <td>de</td>
        /// <td>German</td>
        /// </tr>
        /// <tr>
        /// <td>3</td>
        /// <td>English</td>
        /// <td>en</td>
        /// <td>English</td>
        /// </tr>
        /// <tr>
        /// <td>4</td>
        /// <td>Spanish</td>
        /// <td>es</td>
        /// <td>Spanish</td>
        /// </tr>
        /// <tr>
        /// <td>5</td>
        /// <td>French</td>
        /// <td>fr</td>
        /// <td>French</td>
        /// </tr>
        /// <tr>
        /// <td>6</td>
        /// <td>Hebrew</td>
        /// <td>he</td>
        /// <td>Hebrew</td>
        /// </tr>
        /// <tr>
        /// <td>7</td>
        /// <td>Italian</td>
        /// <td>it</td>
        /// <td>Italian</td>
        /// </tr>
        /// <tr>
        /// <td>8</td>
        /// <td>Japanese</td>
        /// <td>ja</td>
        /// <td>Japanese</td>
        /// </tr>
        /// <tr>
        /// <td>9</td>
        /// <td>Korean</td>
        /// <td>ko</td>
        /// <td>Korean</td>
        /// </tr>
        /// <tr>
        /// <td>10</td>
        /// <td>Dutch</td>
        /// <td>nl</td>
        /// <td>Dutch</td>
        /// </tr>
        /// <tr>
        /// <td>11</td>
        /// <td>Polish</td>
        /// <td>pl</td>
        /// <td>Polish</td>
        /// </tr>
        /// <tr>
        /// <td>12</td>
        /// <td>Portuguese</td>
        /// <td>pt</td>
        /// <td>Portuguese (Brazil)</td>
        /// </tr>
        /// <tr>
        /// <td>13</td>
        /// <td>Russian</td>
        /// <td>ru</td>
        /// <td>Russian</td>
        /// </tr>
        /// <tr>
        /// <td>14</td>
        /// <td>Ukrainian</td>
        /// <td>uk</td>
        /// <td>Ukrainian</td>
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
        /// <para>Correct errors in search terms and titles</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Corrects errors in search terms and titles. Currently supports the following 14 languages:</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>No.</th>
        /// <th>Language Name (English)</th>
        /// <th>Language Code</th>
        /// <th>Language Name (Chinese)</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>1</td>
        /// <td>Arabic</td>
        /// <td>ar</td>
        /// <td>Arabic</td>
        /// </tr>
        /// <tr>
        /// <td>2</td>
        /// <td>German</td>
        /// <td>de</td>
        /// <td>German</td>
        /// </tr>
        /// <tr>
        /// <td>3</td>
        /// <td>English</td>
        /// <td>en</td>
        /// <td>English</td>
        /// </tr>
        /// <tr>
        /// <td>4</td>
        /// <td>Spanish</td>
        /// <td>es</td>
        /// <td>Spanish</td>
        /// </tr>
        /// <tr>
        /// <td>5</td>
        /// <td>French</td>
        /// <td>fr</td>
        /// <td>French</td>
        /// </tr>
        /// <tr>
        /// <td>6</td>
        /// <td>Hebrew</td>
        /// <td>he</td>
        /// <td>Hebrew</td>
        /// </tr>
        /// <tr>
        /// <td>7</td>
        /// <td>Italian</td>
        /// <td>it</td>
        /// <td>Italian</td>
        /// </tr>
        /// <tr>
        /// <td>8</td>
        /// <td>Japanese</td>
        /// <td>ja</td>
        /// <td>Japanese</td>
        /// </tr>
        /// <tr>
        /// <td>9</td>
        /// <td>Korean</td>
        /// <td>ko</td>
        /// <td>Korean</td>
        /// </tr>
        /// <tr>
        /// <td>10</td>
        /// <td>Dutch</td>
        /// <td>nl</td>
        /// <td>Dutch</td>
        /// </tr>
        /// <tr>
        /// <td>11</td>
        /// <td>Polish</td>
        /// <td>pl</td>
        /// <td>Polish</td>
        /// </tr>
        /// <tr>
        /// <td>12</td>
        /// <td>Portuguese</td>
        /// <td>pt</td>
        /// <td>Portuguese (Brazil)</td>
        /// </tr>
        /// <tr>
        /// <td>13</td>
        /// <td>Russian</td>
        /// <td>ru</td>
        /// <td>Russian</td>
        /// </tr>
        /// <tr>
        /// <td>14</td>
        /// <td>Ukrainian</td>
        /// <td>uk</td>
        /// <td>Ukrainian</td>
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
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs. The model is continuously optimized for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports translation between more than 100 language pairs (including bridged translations), especially Chinese-English, Chinese-multilingual, and English-multilingual translations. It supports language detection for 24 language directions. If you do not specify a source language, automatic detection is performed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs. The model is continuously optimized for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports translation between more than 100 language pairs (including bridged translations), especially Chinese-English, Chinese-multilingual, and English-multilingual translations. It supports language detection for 24 language directions. If you do not specify a source language, automatic detection is performed.</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description>Product titles: Marco MT can accurately translate phrases, keywords, and trending terms in product titles into the target language, improving product visibility on e-commerce platforms.</description></item>
        /// <item><description>Product descriptions: Product descriptions are typically long with diverse and complex formatting. Marco MT supports long text translation and HTML format, delivering excellent translation quality and format preservation.</description></item>
        /// <item><description>Product attributes: Product attribute terms are typically short and may contain e-commerce-specific terms such as model numbers and specifications.</description></item>
        /// <item><description>Customer service conversations: In customer service scenarios, Marco MT can handle issues such as missing context and typos, and supports polite expressions for certain language directions.
        /// Marco MT can also be used for general-purpose translation scenarios such as office work, meetings, and daily conversations.</description></item>
        /// </list>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>Supported language directions</b> Marco MT supports translation between more than 100 languages and language detection for 23 languages. For specific language directions, refer to the language mapping table in Section 5.6.</description></item>
        /// <item><description><b>Ultra-low hallucination rate and high-speed inference</b> Marco MT is a large language model with preference alignment for translation scenarios. Compared with general-purpose large language models, it delivers faster translation inference and an extremely low hallucination rate, making it especially suitable for large-scale invocation scenarios.</description></item>
        /// <item><description><b>Supported text format types</b> Currently supports text and html text types.</description></item>
        /// <item><description><b>Translation intervention</b> Supports custom translation results, including do-not-translate (ABC→ABC), specified translation (ABC→DEF), and skip translation (ABC→empty value). This is commonly used for brand name protection. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</description></item>
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
        /// <td>Clearer and more accurate product subject description. The product is a &quot;key bag&quot; rather than a &quot;keychain.&quot; Other translations may cause ambiguity about the product subject</td>
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
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs. The model is continuously optimized for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports translation between more than 100 language pairs (including bridged translations), especially Chinese-English, Chinese-multilingual, and English-multilingual translations. It supports language detection for 24 language directions. If you do not specify a source language, automatic detection is performed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs. The model is continuously optimized for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports translation between more than 100 language pairs (including bridged translations), especially Chinese-English, Chinese-multilingual, and English-multilingual translations. It supports language detection for 24 language directions. If you do not specify a source language, automatic detection is performed.</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description>Product titles: Marco MT can accurately translate phrases, keywords, and trending terms in product titles into the target language, improving product visibility on e-commerce platforms.</description></item>
        /// <item><description>Product descriptions: Product descriptions are typically long with diverse and complex formatting. Marco MT supports long text translation and HTML format, delivering excellent translation quality and format preservation.</description></item>
        /// <item><description>Product attributes: Product attribute terms are typically short and may contain e-commerce-specific terms such as model numbers and specifications.</description></item>
        /// <item><description>Customer service conversations: In customer service scenarios, Marco MT can handle issues such as missing context and typos, and supports polite expressions for certain language directions.
        /// Marco MT can also be used for general-purpose translation scenarios such as office work, meetings, and daily conversations.</description></item>
        /// </list>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>Supported language directions</b> Marco MT supports translation between more than 100 languages and language detection for 23 languages. For specific language directions, refer to the language mapping table in Section 5.6.</description></item>
        /// <item><description><b>Ultra-low hallucination rate and high-speed inference</b> Marco MT is a large language model with preference alignment for translation scenarios. Compared with general-purpose large language models, it delivers faster translation inference and an extremely low hallucination rate, making it especially suitable for large-scale invocation scenarios.</description></item>
        /// <item><description><b>Supported text format types</b> Currently supports text and html text types.</description></item>
        /// <item><description><b>Translation intervention</b> Supports custom translation results, including do-not-translate (ABC→ABC), specified translation (ABC→DEF), and skip translation (ABC→empty value). This is commonly used for brand name protection. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</description></item>
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
        /// <td>Clearer and more accurate product subject description. The product is a &quot;key bag&quot; rather than a &quot;keychain.&quot; Other translations may cause ambiguity about the product subject</td>
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
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs. The model is continuously optimized for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports translation between more than 100 language pairs (including bridged translations), especially Chinese-English, Chinese-multilingual, and English-multilingual translations. It supports language detection for 24 language directions. If you do not specify a source language, automatic detection is performed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs. The model is continuously optimized for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports translation between more than 100 language pairs (including bridged translations), especially Chinese-English, Chinese-multilingual, and English-multilingual translations. It supports language detection for 24 language directions. If you do not specify a source language, automatic detection is performed.</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description>Product titles: Marco MT can accurately translate phrases, keywords, and trending terms in product titles into the target language, improving product visibility on e-commerce platforms.</description></item>
        /// <item><description>Product descriptions: Product descriptions are typically long with diverse and complex formatting. Marco MT supports long text translation and HTML format, delivering excellent translation quality and format preservation.</description></item>
        /// <item><description>Product attributes: Product attribute terms are typically short and may contain e-commerce-specific terms such as model numbers and specifications.</description></item>
        /// <item><description>Customer service conversations: In customer service scenarios, Marco MT can handle issues such as missing context and typos, and supports polite expressions for certain language directions.
        /// Marco MT can also be used for general-purpose translation scenarios such as office work, meetings, and daily conversations.</description></item>
        /// </list>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>Supported language directions</b> Marco MT supports translation between more than 100 languages and language detection for 23 languages. For specific language directions, refer to the language mapping table in Section 5.6.</description></item>
        /// <item><description><b>Ultra-low hallucination rate and high-speed inference</b> Marco MT is a large language model with preference alignment for translation scenarios. Compared with general-purpose large language models, it delivers faster translation inference and an extremely low hallucination rate, making it especially suitable for large-scale invocation scenarios.</description></item>
        /// <item><description><b>Supported text format types</b> Currently supports text and html text types.</description></item>
        /// <item><description><b>Translation intervention</b> Supports custom translation results, including do-not-translate (ABC→ABC), specified translation (ABC→DEF), and skip translation (ABC→empty value). This is commonly used for brand name protection. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</description></item>
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
        /// <td>Clearer and more accurate product subject description. The product is a &quot;key bag&quot; rather than a &quot;keychain.&quot; Other translations may cause ambiguity about the product subject</td>
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
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs. The model is continuously optimized for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports translation between more than 100 language pairs (including bridged translations), especially Chinese-English, Chinese-multilingual, and English-multilingual translations. It supports language detection for 24 language directions. If you do not specify a source language, automatic detection is performed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Product Introduction</h2>
        /// <para>Marco MT is an e-commerce translation model trained on over 1 billion high-quality bilingual sentence pairs. The model is continuously optimized for e-commerce-specific terminology such as brands, models, materials, and attributes. It supports translation between more than 100 language pairs (including bridged translations), especially Chinese-English, Chinese-multilingual, and English-multilingual translations. It supports language detection for 24 language directions. If you do not specify a source language, automatic detection is performed.</para>
        /// <h2>Common scenarios</h2>
        /// <list type="bullet">
        /// <item><description>Product titles: Marco MT can accurately translate phrases, keywords, and trending terms in product titles into the target language, improving product visibility on e-commerce platforms.</description></item>
        /// <item><description>Product descriptions: Product descriptions are typically long with diverse and complex formatting. Marco MT supports long text translation and HTML format, delivering excellent translation quality and format preservation.</description></item>
        /// <item><description>Product attributes: Product attribute terms are typically short and may contain e-commerce-specific terms such as model numbers and specifications.</description></item>
        /// <item><description>Customer service conversations: In customer service scenarios, Marco MT can handle issues such as missing context and typos, and supports polite expressions for certain language directions.
        /// Marco MT can also be used for general-purpose translation scenarios such as office work, meetings, and daily conversations.</description></item>
        /// </list>
        /// <h2>Features</h2>
        /// <list type="bullet">
        /// <item><description><b>Supported language directions</b> Marco MT supports translation between more than 100 languages and language detection for 23 languages. For specific language directions, refer to the language mapping table in Section 5.6.</description></item>
        /// <item><description><b>Ultra-low hallucination rate and high-speed inference</b> Marco MT is a large language model with preference alignment for translation scenarios. Compared with general-purpose large language models, it delivers faster translation inference and an extremely low hallucination rate, making it especially suitable for large-scale invocation scenarios.</description></item>
        /// <item><description><b>Supported text format types</b> Currently supports text and html text types.</description></item>
        /// <item><description><b>Translation intervention</b> Supports custom translation results, including do-not-translate (ABC→ABC), specified translation (ABC→DEF), and skip translation (ABC→empty value). This is commonly used for brand name protection. Simply pass the corresponding intervention glossary ID when calling the API to meet your translation needs across different scenarios. You can upload up to 100,000 intervention terms. If you need more, contact the platform for assistance.</description></item>
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
        /// <td>Clearer and more accurate product subject description. The product is a &quot;key bag&quot; rather than a &quot;keychain.&quot; Other translations may cause ambiguity about the product subject</td>
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
        /// <para>Provides a one-stop AI-powered image processing service for e-commerce sellers. Orchestrates seven atomic capabilities — element detection, intelligent matting, intelligent removal, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling — into an image processing workflow. Upload an image once, select the desired capabilities, and complete multiple image optimizations sequentially in a single call to produce product images that meet listing platform requirements. (Asynchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>A one-stop AI-powered image processing service for e-commerce sellers. Orchestrates seven atomic capabilities — element detection, intelligent matting, intelligent removal, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling — into an image processing workflow. Upload an image once, select the desired capabilities, and complete multiple image optimizations sequentially in a single call to produce product images that meet listing platform requirements. (Asynchronous).</para>
        /// <h1>2. Common scenarios</h1>
        /// <para>Applicable to batch optimization of product images for cross-platform listing scenarios. Adapts source product images into main images, SKU images, and detail images required by listing platforms. Supported capabilities include:</para>
        /// <list type="bullet">
        /// <item><description><para>Detecting low-quality images that contain text, watermarks, logos, or overlay patches, and allowing users to filter images that require processing</para>
        /// </description></item>
        /// <item><description><para>Removing non-compliant elements such as watermarks, logos, overlay patches, and Chinese text from original images</para>
        /// </description></item>
        /// <item><description><para>Removing the background around the product subject edges</para>
        /// </description></item>
        /// <item><description><para>Translating text within images into other languages</para>
        /// </description></item>
        /// <item><description><para>Expanding images to other dimensions (by ratio, size, or other methods) with automatic background completion</para>
        /// </description></item>
        /// <item><description><para>Cropping images to specified dimensions</para>
        /// </description></item>
        /// <item><description><para>Upscaling image resolution by a specified factor.</para>
        /// </description></item>
        /// </list>
        /// <h1>3. Features</h1>
        /// <para>Provide a product image URL and use the Ability parameter to select the AI capability combination to invoke (1 = intelligent element detection, 2 = intelligent matting, 3 = intelligent removal, 4 = Image Translation Pro, 5 = image expansion, 6 = intelligent cropping, 7 = HD upscaling). The system executes the selected capabilities sequentially in a preset order. Because intelligent element detection helps users determine whether an image contains certain specified elements, and the presence of elements affects subsequent AI capability selection, an additional input is provided that allows users to either filter images out of or retain images in the subsequent AI processing pipeline.
        /// <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/bddb522a-0795-4b5c-b25d-10e933426367.svg" alt="ai-pipeline-flowchart.svg">
        /// Each AI capability is described as follows:</para>
        /// <ol>
        /// <item><description><para><b>Intelligent element detection:</b> An element detection capability designed for e-commerce images. Detects text, logos, watermarks, and text-bearing color blocks in both the subject and background of an image, and returns Boolean detection results. Allows users to filter images based on detection results (for example, process only images that contain watermarks). Works in conjunction with subsequent capabilities — first identifies the types of elements that need optimization, then precisely executes removal and other operations.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent matting:</b> Automatically identifies the product subject in an image and precisely separates the subject from the background. Based on deep learning models, supports accurate segmentation of complex edges such as hair strands and transparent objects. Outputs images with a transparent or white background, supports custom background colors and target dimension cropping, and directly generates product display images that comply with e-commerce platform specifications.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent removal:</b> Automatically detects and removes non-compliant elements from e-commerce images, including text, specific names (brand/store names), transparent text blocks, and overlay patches. Supports specifying removal of elements in the subject area or non-subject area separately, and also supports precise removal area specification through the Mask parameter for efficient compliance cleanup of large batches of images.</para>
        /// </description></item>
        /// <item><description><para><b>Image Translation Pro:</b> Leverages multimodal foundation model technology to translate text in images into a target language and render it directly at the corresponding position in the original image. Supports more than 100 language pairs. Provides product subject text protection, brand name protection, and translation intervention glossaries to prevent mistranslation of embedded product information. After translation, returns layout information such as text position, font, and color for secondary editing.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent image expansion:</b> Expands the image canvas using AI generation technology to broaden the image view without cropping the subject. Supports multiple expansion methods: by aspect ratio (1:1, 3:4, 4:3, 9:16, 16:9), by horizontal/vertical scaling ratio (1.0× to 3.0×), or by pixel offset in the up, down, left, and right directions. AI automatically generates naturally transitioning background content.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent cropping:</b> Intelligently crops images to specified dimensions, automatically identifies the subject area, and precisely preserves core content. Supports custom output width and height (100 to 5000 pixels) to meet the image dimension requirements of different e-commerce platforms and ad placements, ensuring the subject remains prominent and the composition stays balanced after cropping.</para>
        /// </description></item>
        /// <item><description><para><b>HD upscaling:</b> Enhances details and reduces noise while upscaling images. Supports 2× to 4× upscaling. Suitable for improving the clarity of low-resolution product images and optimizing visual presentation. Supports output in PNG, JPG, BMP, and other formats.</para>
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
        /// <item><description><para>HD upscaling | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/95d29e79-8622-45fb-b284-cd580fe40ea0.jpeg" alt="R2.jpeg"> |.</para>
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
        /// <para>Provides a one-stop AI-powered image processing service for e-commerce sellers. Orchestrates seven atomic capabilities — element detection, intelligent matting, intelligent removal, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling — into an image processing workflow. Upload an image once, select the desired capabilities, and complete multiple image optimizations sequentially in a single call to produce product images that meet listing platform requirements. (Asynchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>A one-stop AI-powered image processing service for e-commerce sellers. Orchestrates seven atomic capabilities — element detection, intelligent matting, intelligent removal, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling — into an image processing workflow. Upload an image once, select the desired capabilities, and complete multiple image optimizations sequentially in a single call to produce product images that meet listing platform requirements. (Asynchronous).</para>
        /// <h1>2. Common scenarios</h1>
        /// <para>Applicable to batch optimization of product images for cross-platform listing scenarios. Adapts source product images into main images, SKU images, and detail images required by listing platforms. Supported capabilities include:</para>
        /// <list type="bullet">
        /// <item><description><para>Detecting low-quality images that contain text, watermarks, logos, or overlay patches, and allowing users to filter images that require processing</para>
        /// </description></item>
        /// <item><description><para>Removing non-compliant elements such as watermarks, logos, overlay patches, and Chinese text from original images</para>
        /// </description></item>
        /// <item><description><para>Removing the background around the product subject edges</para>
        /// </description></item>
        /// <item><description><para>Translating text within images into other languages</para>
        /// </description></item>
        /// <item><description><para>Expanding images to other dimensions (by ratio, size, or other methods) with automatic background completion</para>
        /// </description></item>
        /// <item><description><para>Cropping images to specified dimensions</para>
        /// </description></item>
        /// <item><description><para>Upscaling image resolution by a specified factor.</para>
        /// </description></item>
        /// </list>
        /// <h1>3. Features</h1>
        /// <para>Provide a product image URL and use the Ability parameter to select the AI capability combination to invoke (1 = intelligent element detection, 2 = intelligent matting, 3 = intelligent removal, 4 = Image Translation Pro, 5 = image expansion, 6 = intelligent cropping, 7 = HD upscaling). The system executes the selected capabilities sequentially in a preset order. Because intelligent element detection helps users determine whether an image contains certain specified elements, and the presence of elements affects subsequent AI capability selection, an additional input is provided that allows users to either filter images out of or retain images in the subsequent AI processing pipeline.
        /// <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/bddb522a-0795-4b5c-b25d-10e933426367.svg" alt="ai-pipeline-flowchart.svg">
        /// Each AI capability is described as follows:</para>
        /// <ol>
        /// <item><description><para><b>Intelligent element detection:</b> An element detection capability designed for e-commerce images. Detects text, logos, watermarks, and text-bearing color blocks in both the subject and background of an image, and returns Boolean detection results. Allows users to filter images based on detection results (for example, process only images that contain watermarks). Works in conjunction with subsequent capabilities — first identifies the types of elements that need optimization, then precisely executes removal and other operations.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent matting:</b> Automatically identifies the product subject in an image and precisely separates the subject from the background. Based on deep learning models, supports accurate segmentation of complex edges such as hair strands and transparent objects. Outputs images with a transparent or white background, supports custom background colors and target dimension cropping, and directly generates product display images that comply with e-commerce platform specifications.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent removal:</b> Automatically detects and removes non-compliant elements from e-commerce images, including text, specific names (brand/store names), transparent text blocks, and overlay patches. Supports specifying removal of elements in the subject area or non-subject area separately, and also supports precise removal area specification through the Mask parameter for efficient compliance cleanup of large batches of images.</para>
        /// </description></item>
        /// <item><description><para><b>Image Translation Pro:</b> Leverages multimodal foundation model technology to translate text in images into a target language and render it directly at the corresponding position in the original image. Supports more than 100 language pairs. Provides product subject text protection, brand name protection, and translation intervention glossaries to prevent mistranslation of embedded product information. After translation, returns layout information such as text position, font, and color for secondary editing.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent image expansion:</b> Expands the image canvas using AI generation technology to broaden the image view without cropping the subject. Supports multiple expansion methods: by aspect ratio (1:1, 3:4, 4:3, 9:16, 16:9), by horizontal/vertical scaling ratio (1.0× to 3.0×), or by pixel offset in the up, down, left, and right directions. AI automatically generates naturally transitioning background content.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent cropping:</b> Intelligently crops images to specified dimensions, automatically identifies the subject area, and precisely preserves core content. Supports custom output width and height (100 to 5000 pixels) to meet the image dimension requirements of different e-commerce platforms and ad placements, ensuring the subject remains prominent and the composition stays balanced after cropping.</para>
        /// </description></item>
        /// <item><description><para><b>HD upscaling:</b> Enhances details and reduces noise while upscaling images. Supports 2× to 4× upscaling. Suitable for improving the clarity of low-resolution product images and optimizing visual presentation. Supports output in PNG, JPG, BMP, and other formats.</para>
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
        /// <item><description><para>HD upscaling | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/95d29e79-8622-45fb-b284-cd580fe40ea0.jpeg" alt="R2.jpeg"> |.</para>
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
        /// <para>Provides a one-stop AI-powered image processing service for e-commerce sellers. Orchestrates seven atomic capabilities — element detection, intelligent matting, intelligent removal, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling — into an image processing workflow. Upload an image once, select the desired capabilities, and complete multiple image optimizations sequentially in a single call to produce product images that meet listing platform requirements. (Asynchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>A one-stop AI-powered image processing service for e-commerce sellers. Orchestrates seven atomic capabilities — element detection, intelligent matting, intelligent removal, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling — into an image processing workflow. Upload an image once, select the desired capabilities, and complete multiple image optimizations sequentially in a single call to produce product images that meet listing platform requirements. (Asynchronous).</para>
        /// <h1>2. Common scenarios</h1>
        /// <para>Applicable to batch optimization of product images for cross-platform listing scenarios. Adapts source product images into main images, SKU images, and detail images required by listing platforms. Supported capabilities include:</para>
        /// <list type="bullet">
        /// <item><description><para>Detecting low-quality images that contain text, watermarks, logos, or overlay patches, and allowing users to filter images that require processing</para>
        /// </description></item>
        /// <item><description><para>Removing non-compliant elements such as watermarks, logos, overlay patches, and Chinese text from original images</para>
        /// </description></item>
        /// <item><description><para>Removing the background around the product subject edges</para>
        /// </description></item>
        /// <item><description><para>Translating text within images into other languages</para>
        /// </description></item>
        /// <item><description><para>Expanding images to other dimensions (by ratio, size, or other methods) with automatic background completion</para>
        /// </description></item>
        /// <item><description><para>Cropping images to specified dimensions</para>
        /// </description></item>
        /// <item><description><para>Upscaling image resolution by a specified factor.</para>
        /// </description></item>
        /// </list>
        /// <h1>3. Features</h1>
        /// <para>Provide a product image URL and use the Ability parameter to select the AI capability combination to invoke (1 = intelligent element detection, 2 = intelligent matting, 3 = intelligent removal, 4 = Image Translation Pro, 5 = image expansion, 6 = intelligent cropping, 7 = HD upscaling). The system executes the selected capabilities sequentially in a preset order. Because intelligent element detection helps users determine whether an image contains certain specified elements, and the presence of elements affects subsequent AI capability selection, an additional input is provided that allows users to either filter images out of or retain images in the subsequent AI processing pipeline.
        /// <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/bddb522a-0795-4b5c-b25d-10e933426367.svg" alt="ai-pipeline-flowchart.svg">
        /// Each AI capability is described as follows:</para>
        /// <ol>
        /// <item><description><para><b>Intelligent element detection:</b> An element detection capability designed for e-commerce images. Detects text, logos, watermarks, and text-bearing color blocks in both the subject and background of an image, and returns Boolean detection results. Allows users to filter images based on detection results (for example, process only images that contain watermarks). Works in conjunction with subsequent capabilities — first identifies the types of elements that need optimization, then precisely executes removal and other operations.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent matting:</b> Automatically identifies the product subject in an image and precisely separates the subject from the background. Based on deep learning models, supports accurate segmentation of complex edges such as hair strands and transparent objects. Outputs images with a transparent or white background, supports custom background colors and target dimension cropping, and directly generates product display images that comply with e-commerce platform specifications.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent removal:</b> Automatically detects and removes non-compliant elements from e-commerce images, including text, specific names (brand/store names), transparent text blocks, and overlay patches. Supports specifying removal of elements in the subject area or non-subject area separately, and also supports precise removal area specification through the Mask parameter for efficient compliance cleanup of large batches of images.</para>
        /// </description></item>
        /// <item><description><para><b>Image Translation Pro:</b> Leverages multimodal foundation model technology to translate text in images into a target language and render it directly at the corresponding position in the original image. Supports more than 100 language pairs. Provides product subject text protection, brand name protection, and translation intervention glossaries to prevent mistranslation of embedded product information. After translation, returns layout information such as text position, font, and color for secondary editing.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent image expansion:</b> Expands the image canvas using AI generation technology to broaden the image view without cropping the subject. Supports multiple expansion methods: by aspect ratio (1:1, 3:4, 4:3, 9:16, 16:9), by horizontal/vertical scaling ratio (1.0× to 3.0×), or by pixel offset in the up, down, left, and right directions. AI automatically generates naturally transitioning background content.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent cropping:</b> Intelligently crops images to specified dimensions, automatically identifies the subject area, and precisely preserves core content. Supports custom output width and height (100 to 5000 pixels) to meet the image dimension requirements of different e-commerce platforms and ad placements, ensuring the subject remains prominent and the composition stays balanced after cropping.</para>
        /// </description></item>
        /// <item><description><para><b>HD upscaling:</b> Enhances details and reduces noise while upscaling images. Supports 2× to 4× upscaling. Suitable for improving the clarity of low-resolution product images and optimizing visual presentation. Supports output in PNG, JPG, BMP, and other formats.</para>
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
        /// <item><description><para>HD upscaling | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/95d29e79-8622-45fb-b284-cd580fe40ea0.jpeg" alt="R2.jpeg"> |.</para>
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
        /// <para>Provides a one-stop AI-powered image processing service for e-commerce sellers. Orchestrates seven atomic capabilities — element detection, intelligent matting, intelligent removal, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling — into an image processing workflow. Upload an image once, select the desired capabilities, and complete multiple image optimizations sequentially in a single call to produce product images that meet listing platform requirements. (Asynchronous).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h1>1. Product Introduction</h1>
        /// <para>A one-stop AI-powered image processing service for e-commerce sellers. Orchestrates seven atomic capabilities — element detection, intelligent matting, intelligent removal, Image Translation Pro, image expansion, intelligent cropping, and HD upscaling — into an image processing workflow. Upload an image once, select the desired capabilities, and complete multiple image optimizations sequentially in a single call to produce product images that meet listing platform requirements. (Asynchronous).</para>
        /// <h1>2. Common scenarios</h1>
        /// <para>Applicable to batch optimization of product images for cross-platform listing scenarios. Adapts source product images into main images, SKU images, and detail images required by listing platforms. Supported capabilities include:</para>
        /// <list type="bullet">
        /// <item><description><para>Detecting low-quality images that contain text, watermarks, logos, or overlay patches, and allowing users to filter images that require processing</para>
        /// </description></item>
        /// <item><description><para>Removing non-compliant elements such as watermarks, logos, overlay patches, and Chinese text from original images</para>
        /// </description></item>
        /// <item><description><para>Removing the background around the product subject edges</para>
        /// </description></item>
        /// <item><description><para>Translating text within images into other languages</para>
        /// </description></item>
        /// <item><description><para>Expanding images to other dimensions (by ratio, size, or other methods) with automatic background completion</para>
        /// </description></item>
        /// <item><description><para>Cropping images to specified dimensions</para>
        /// </description></item>
        /// <item><description><para>Upscaling image resolution by a specified factor.</para>
        /// </description></item>
        /// </list>
        /// <h1>3. Features</h1>
        /// <para>Provide a product image URL and use the Ability parameter to select the AI capability combination to invoke (1 = intelligent element detection, 2 = intelligent matting, 3 = intelligent removal, 4 = Image Translation Pro, 5 = image expansion, 6 = intelligent cropping, 7 = HD upscaling). The system executes the selected capabilities sequentially in a preset order. Because intelligent element detection helps users determine whether an image contains certain specified elements, and the presence of elements affects subsequent AI capability selection, an additional input is provided that allows users to either filter images out of or retain images in the subsequent AI processing pipeline.
        /// <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/bddb522a-0795-4b5c-b25d-10e933426367.svg" alt="ai-pipeline-flowchart.svg">
        /// Each AI capability is described as follows:</para>
        /// <ol>
        /// <item><description><para><b>Intelligent element detection:</b> An element detection capability designed for e-commerce images. Detects text, logos, watermarks, and text-bearing color blocks in both the subject and background of an image, and returns Boolean detection results. Allows users to filter images based on detection results (for example, process only images that contain watermarks). Works in conjunction with subsequent capabilities — first identifies the types of elements that need optimization, then precisely executes removal and other operations.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent matting:</b> Automatically identifies the product subject in an image and precisely separates the subject from the background. Based on deep learning models, supports accurate segmentation of complex edges such as hair strands and transparent objects. Outputs images with a transparent or white background, supports custom background colors and target dimension cropping, and directly generates product display images that comply with e-commerce platform specifications.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent removal:</b> Automatically detects and removes non-compliant elements from e-commerce images, including text, specific names (brand/store names), transparent text blocks, and overlay patches. Supports specifying removal of elements in the subject area or non-subject area separately, and also supports precise removal area specification through the Mask parameter for efficient compliance cleanup of large batches of images.</para>
        /// </description></item>
        /// <item><description><para><b>Image Translation Pro:</b> Leverages multimodal foundation model technology to translate text in images into a target language and render it directly at the corresponding position in the original image. Supports more than 100 language pairs. Provides product subject text protection, brand name protection, and translation intervention glossaries to prevent mistranslation of embedded product information. After translation, returns layout information such as text position, font, and color for secondary editing.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent image expansion:</b> Expands the image canvas using AI generation technology to broaden the image view without cropping the subject. Supports multiple expansion methods: by aspect ratio (1:1, 3:4, 4:3, 9:16, 16:9), by horizontal/vertical scaling ratio (1.0× to 3.0×), or by pixel offset in the up, down, left, and right directions. AI automatically generates naturally transitioning background content.</para>
        /// </description></item>
        /// <item><description><para><b>Intelligent cropping:</b> Intelligently crops images to specified dimensions, automatically identifies the subject area, and precisely preserves core content. Supports custom output width and height (100 to 5000 pixels) to meet the image dimension requirements of different e-commerce platforms and ad placements, ensuring the subject remains prominent and the composition stays balanced after cropping.</para>
        /// </description></item>
        /// <item><description><para><b>HD upscaling:</b> Enhances details and reduces noise while upscaling images. Supports 2× to 4× upscaling. Suitable for improving the clarity of low-resolution product images and optimizing visual presentation. Supports output in PNG, JPG, BMP, and other formats.</para>
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
        /// <item><description><para>HD upscaling | <img src="https://alidocs.oss-cn-zhangjiakou.aliyuncs.com/res/NpQlK5jRe9w5jqDv/img/95d29e79-8622-45fb-b284-cd580fe40ea0.jpeg" alt="R2.jpeg"> |.</para>
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
