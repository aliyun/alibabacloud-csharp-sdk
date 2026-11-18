// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class UnifiedSearchInput : TeaModel {
        /// <summary>
        /// <para>The advanced search parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;numResults&quot;:&quot;10&quot;}</para>
        /// </summary>
        [NameInMap("advancedParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> AdvancedParams { get; set; }

        /// <summary>
        /// <para>The query category. If specified, only search results from sites of the corresponding category are returned. Separate multiple categories with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>medical</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The options for controlling the returned content.</para>
        /// </summary>
        [NameInMap("contents")]
        [Validation(Required=false)]
        public RequestContents Contents { get; set; }

        /// <summary>
        /// <para>The engine type. Default value: Generic. Valid values: Generic, GenericAdvanced. GenericAdvanced is billed separately and returns more records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Generic</para>
        /// </summary>
        [NameInMap("engineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> The location parameter. Use locationInfo to specify a city or IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60.194.214.228</para>
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <para>The location information, used for scenario-based searches such as weather.</para>
        /// </summary>
        [NameInMap("locationInfo")]
        [Validation(Required=false)]
        public LocationInfo LocationInfo { get; set; }

        /// <summary>
        /// <para>The query content. The length limit is 1 to 100 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Apsara Conference</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The publication time range for the content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoLimit</para>
        /// </summary>
        [NameInMap("timeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
