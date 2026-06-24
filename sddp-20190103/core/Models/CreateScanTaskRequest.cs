// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class CreateScanTaskRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the data asset. The asset can be an instance, a database, or a bucket. Call the <a href="~~DescribeDataLimits~~">DescribeDataLimits</a> operation to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DataLimitId")]
        [Validation(Required=false)]
        public long? DataLimitId { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>The interval in days between two consecutive custom scan tasks. The value must be between 1 and 2147483648.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IntervalDay")]
        [Validation(Required=false)]
        public int? IntervalDay { get; set; }

        /// <summary>
        /// <para>The language of the request and response.</para>
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
        /// <para>The scan scope for OSS assets. You can specify a prefix, a suffix, or a regular expression to match objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test/test</para>
        /// </summary>
        [NameInMap("OssScanPath")]
        [Validation(Required=false)]
        public string OssScanPath { get; set; }

        /// <summary>
        /// <para>The type of resource to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: MaxCompute.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: OSS.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: AnalyticDB.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: Tablestore.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: RDS.</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: a self-managed database.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public long? ResourceType { get; set; }

        /// <summary>
        /// <para>The hour at which the next scan task runs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("RunHour")]
        [Validation(Required=false)]
        public int? RunHour { get; set; }

        /// <summary>
        /// <para>The minute at which the next scan task runs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("RunMinute")]
        [Validation(Required=false)]
        public int? RunMinute { get; set; }

        /// <summary>
        /// <para>The matching rule for the scan scope of the custom scan task. This parameter takes effect only when you configure the <b>ScanRangeContent</b> parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: full match.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: prefix match.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: suffix match.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: regular expression match.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public int? ScanRange { get; set; }

        /// <summary>
        /// <para>The content to match for the scan of structured data assets. This parameter is used with the ScanRange parameter.</para>
        /// <remarks>
        /// <para>If you set ScanRange to 0, the scan matches the exact value of this parameter. If you set ScanRange to 1, the scan matches items that have the prefix specified by this parameter. For example, if you set this parameter to \<c>test/abc\\</c>, file paths that start with \<c>test/abc\\</c> are matched. If you set ScanRange to 2, the scan matches items that have the suffix specified by this parameter. If you set ScanRange to 3, the scan matches items that match the regular expression specified by this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>datamask/</para>
        /// </summary>
        [NameInMap("ScanRangeContent")]
        [Validation(Required=false)]
        public string ScanRangeContent { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>106.11.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The name of the scan task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scan-test-sample****</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The account that creates the scan task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("TaskUserName")]
        [Validation(Required=false)]
        public string TaskUserName { get; set; }

    }

}
