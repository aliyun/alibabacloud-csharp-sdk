// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySavingsPlansDeductLogRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the format of yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-05 00:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spn-XXXXXXX</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the instance ID based on which the data is queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>spn: queries data based on the ID of the savings plan instance.</description></item>
        /// <item><description>product: queries data based on the ID of the cloud service instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>spn</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The language of the return data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ZH: Chinese</description></item>
        /// <item><description>EN: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ZH</para>
        /// </summary>
        [NameInMap("Locale")]
        [Validation(Required=false)]
        public string Locale { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the format of yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
