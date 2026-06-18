// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateCustomScenePolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The end time of the policy.</para>
        /// <para>The time is in UTC and in the ISO 8601 format: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-03T19:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The name of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>A list of associated site IDs.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. We recommend that you use the <c>SiteIds</c> parameter instead.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Objects")]
        [Validation(Required=false)]
        public List<string> Objects { get; set; }

        /// <summary>
        /// <para>The ID of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The associated site IDs. Multiple IDs are separated by a comma (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****,123457****</para>
        /// </summary>
        [NameInMap("SiteIds")]
        [Validation(Required=false)]
        public string SiteIds { get; set; }

        /// <summary>
        /// <para>The start time of the policy.</para>
        /// <para>The time is in UTC and in the ISO 8601 format: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-03T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the template. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>promotion</b>: major promotion</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>promotion</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

    }

}
