// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantMetricsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-13T15:45:43Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>2021-06-13T15:40:43Z</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob317v4uif****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>{&quot;name&quot;:&quot;DescribeTenantMetrics&quot;,&quot;product&quot;:&quot;OceanBasePro&quot;,&quot;version&quot;:&quot;2019-09-01&quot;,&quot;path&quot;:&quot;/&quot;,&quot;deprecated&quot;:0,&quot;method&quot;:&quot;POST|GET&quot;,&quot;protocol&quot;:&quot;HTTP|HTTPS&quot;,&quot;hidden&quot;:0,&quot;timeout&quot;:10000,&quot;parameter_type&quot;:&quot;Single&quot;,&quot;params&quot;:&quot;[{\&quot;name\&quot;:\&quot;Action\&quot;,\&quot;position\&quot;:\&quot;Query\&quot;,\&quot;required\&quot;:true,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;String\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;DescribeTenantMetrics\&quot;},{\&quot;name\&quot;:\&quot;InstanceId\&quot;,\&quot;position\&quot;:\&quot;Body\&quot;,\&quot;required\&quot;:true,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;String\&quot;,\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;ob317v4uif****\&quot;},{\&quot;name\&quot;:\&quot;PageSize\&quot;,\&quot;position\&quot;:\&quot;Body\&quot;,\&quot;required\&quot;:false,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;Integer\&quot;,\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;10\&quot;},{\&quot;name\&quot;:\&quot;PageNumber\&quot;,\&quot;position\&quot;:\&quot;Body\&quot;,\&quot;required\&quot;:false,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;Integer\&quot;,\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;1\&quot;},{\&quot;name\&quot;:\&quot;TenantName\&quot;,\&quot;position\&quot;:\&quot;Body\&quot;,\&quot;required\&quot;:false,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:true,\&quot;type\&quot;:\&quot;String\&quot;,\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;pay_online\&quot;},{\&quot;name\&quot;:\&quot;StartTime\&quot;,\&quot;position\&quot;:\&quot;Body\&quot;,\&quot;required\&quot;:true,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;String\&quot;,\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;2021-06-13T15:40:43Z\&quot;},{\&quot;name\&quot;:\&quot;EndTime\&quot;,\&quot;position\&quot;:\&quot;Body\&quot;,\&quot;required\&quot;:true,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;String\&quot;,\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;2021-06-13T15:45:43Z\&quot;},{\&quot;name\&quot;:\&quot;Metrics\&quot;,\&quot;position\&quot;:\&quot;Body\&quot;,\&quot;required\&quot;:true,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;String\&quot;,\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;tps\&quot;},{\&quot;name\&quot;:\&quot;TenantId\&quot;,\&quot;position\&quot;:\&quot;Body\&quot;,\&quot;required\&quot;:false,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:true,\&quot;type\&quot;:\&quot;String\&quot;,\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;tfafd34fs****\&quot;},{\&quot;name\&quot;:\&quot;TenantIdList\&quot;,\&quot;position\&quot;:\&quot;Body\&quot;,\&quot;required\&quot;:false,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;String\&quot;,\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;[tdak3nac****,tdakc42df****]\&quot;}]&quot;,&quot;response_headers&quot;:&quot;[]&quot;,&quot;response&quot;:&quot;{\&quot;type\&quot;:\&quot;Object\&quot;,\&quot;children\&quot;:[{\&quot;name\&quot;:\&quot;TotalCount\&quot;,\&quot;required\&quot;:false,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;Integer\&quot;,\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;9\&quot;},{\&quot;name\&quot;:\&quot;RequestId\&quot;,\&quot;required\&quot;:false,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;String\&quot;,\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C\&quot;},{\&quot;name\&quot;:\&quot;TenantMetrics\&quot;,\&quot;required\&quot;:false,\&quot;checkBlank\&quot;:false,\&quot;visibility\&quot;:\&quot;Public\&quot;,\&quot;deprecated\&quot;:false,\&quot;type\&quot;:\&quot;String\&quot;,\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;,\&quot;example\&quot;:\&quot;\\\&quot;Metrics\\\&quot;:[ {\\\&quot;request_queue_rt\\\&quot;:0.0,\\\&quot;TimeStamp\\\&quot;:\\\&quot;2022-02-23T01:58:00Z\\\&quot;}]\&quot;}],\&quot;title\&quot;:\&quot;\&quot;,\&quot;description\&quot;:\&quot;\&quot;}&quot;,&quot;errors&quot;:&quot;{}&quot;}</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tps</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// <para>The ID of the OceanBase cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>tfafd34fs****</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Example 1</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-13T15:40:43Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>tfafd34fs****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        [Obsolete]
        public string TenantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[tdak3nac****,tdakc42df****]</para>
        /// </summary>
        [NameInMap("TenantIdList")]
        [Validation(Required=false)]
        public string TenantIdList { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>2021-06-13T15:45:43Z</para>
        /// 
        /// <b>Example:</b>
        /// <para>pay_online</para>
        /// </summary>
        [NameInMap("TenantName")]
        [Validation(Required=false)]
        [Obsolete]
        public string TenantName { get; set; }

    }

}
