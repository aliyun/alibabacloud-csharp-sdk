// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeOssObjectsRequest : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The code of the file category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FileCategoryCode")]
        [Validation(Required=false)]
        public long? FileCategoryCode { get; set; }

        /// <summary>
        /// <para>The ID of the asset instance to which the OSS object belongs.</para>
        /// <remarks>
        /// <para>To query the list of authorized OSS objects by the ID of the asset instance, call the <b>DescribeInstances</b> operation to obtain the instance ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ins-2222</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The end time of the last scan. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1536751124000</para>
        /// </summary>
        [NameInMap("LastScanTimeEnd")]
        [Validation(Required=false)]
        public long? LastScanTimeEnd { get; set; }

        /// <summary>
        /// <para>The start time of the last scan. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1536751124000</para>
        /// </summary>
        [NameInMap("LastScanTimeStart")]
        [Validation(Required=false)]
        public long? LastScanTimeStart { get; set; }

        /// <summary>
        /// <para>The position where the query starts. To retrieve the next page of results, set this parameter to the value of <c>NextMarker</c> from the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1754786235714378752</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public long? Marker { get; set; }

        /// <summary>
        /// <para>The search keyword. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The risk level ID of the OSS object. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: N/A. No sensitive data is detected.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: S1. Level 1 sensitive data.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: S2. Level 2 sensitive data.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: S3. Level 3 sensitive data.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: S4. Level 4 sensitive data.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RiskLevelId")]
        [Validation(Required=false)]
        public int? RiskLevelId { get; set; }

        /// <summary>
        /// <para>The ID of the sensitive data detection rule that the OSS object matches.</para>
        /// <remarks>
        /// <para>To query the list of authorized OSS objects by the ID of a matched sensitive data detection rule, call the <b>DescribeRules</b> operation to obtain the rule ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1222</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The region of the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the industry-specific template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
