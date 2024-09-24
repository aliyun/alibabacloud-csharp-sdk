// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteCustomMetricRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3607****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The MD5 value of the HTTP request body. The MD5 value is a 128-bit hash value used to verify the uniqueness of the reported monitoring data.</para>
        /// <remarks>
        /// <para> <c>Md5</c> is returned when you query the reported monitoring data of a metric.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>38796C8CFFEB8F89BB2A626C7BD7****</para>
        /// </summary>
        [NameInMap("Md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// <para>The name of the metric.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AdvanceCredit</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request for reporting monitoring data.</para>
        /// <remarks>
        /// <para> <c>UUID</c> is returned when you query the reported monitoring data of a metric. We recommend that you specify the <c>Md5</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5497633c-66c5-4eae-abaa-89db5adb****</para>
        /// </summary>
        [NameInMap("UUID")]
        [Validation(Required=false)]
        public string UUID { get; set; }

    }

}
