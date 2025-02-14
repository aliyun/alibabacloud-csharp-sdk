// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeOssObjectsRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The code of the file type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FileCategoryCode")]
        [Validation(Required=false)]
        public long? FileCategoryCode { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which the OSS object belongs.</para>
        /// <remarks>
        /// <para>You can call the <b>DescribeInstances</b> operation to query the instance ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ins-2222</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
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
        /// <para>When you query data by page, use the <c>Marker</c> parameter to query the data that follows the <c>Marker</c> value.</para>
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
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sensitivity level of the OSS object. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: N/A, which indicates that no sensitive data is detected.</description></item>
        /// <item><description><b>2</b>: S1, which indicates the low sensitivity level.</description></item>
        /// <item><description><b>3</b>: S2, which indicates the medium sensitivity level.</description></item>
        /// <item><description><b>4</b>: S3, which indicates the high sensitivity level.</description></item>
        /// <item><description><b>5</b>: S4, which indicates the highest sensitivity level.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RiskLevelId")]
        [Validation(Required=false)]
        public int? RiskLevelId { get; set; }

        /// <summary>
        /// <para>The ID of the sensitive data detection rule that the OSS object hits.</para>
        /// <remarks>
        /// <para>You can call the <b>DescribeRules</b> operation to query the ID of the sensitive data detection rule.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1222</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The region in which the data asset resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the industry-specific rule template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
