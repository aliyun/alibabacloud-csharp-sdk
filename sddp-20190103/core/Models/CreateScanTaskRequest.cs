// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class CreateScanTaskRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the data asset such as an instance, database, or bucket. You can call <a href="~~DescribeDataLimits~~">DescribeDataLimits</a> to obtain the ID.</para>
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
        /// <para>The interval in days between two consecutive custom scan tasks. Valid values: 1 to 2147483648.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IntervalDay")]
        [Validation(Required=false)]
        public int? IntervalDay { get; set; }

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
        /// <para>The scan scope for OSS assets. Prefix match, suffix match, and regular expression match are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test/test</para>
        /// </summary>
        [NameInMap("OssScanPath")]
        [Validation(Required=false)]
        public string OssScanPath { get; set; }

        /// <summary>
        /// <para>The resource type of the product to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: MaxCompute.</description></item>
        /// <item><description><b>2</b>: OSS.</description></item>
        /// <item><description><b>3</b>: ADS.</description></item>
        /// <item><description><b>4</b>: OTS.</description></item>
        /// <item><description><b>5</b>: RDS.</description></item>
        /// <item><description><b>6</b>: SELF_DB.</description></item>
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
        /// <para>The runtime of the next scan task. Unit: hours.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("RunHour")]
        [Validation(Required=false)]
        public int? RunHour { get; set; }

        /// <summary>
        /// <para>The runtime of the next scan task. Unit: minutes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("RunMinute")]
        [Validation(Required=false)]
        public int? RunMinute { get; set; }

        /// <summary>
        /// <para>The scan scope matching rule for the custom scan task. This parameter takes effect only when used together with <b>ScanRangeContent</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: full match.</description></item>
        /// <item><description><b>1</b>: prefix match.</description></item>
        /// <item><description><b>2</b>: suffix match.</description></item>
        /// <item><description><b>3</b>: regular expression match.</description></item>
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
        /// <para>The content to match within the scan scope of structured data assets by using prefix match, suffix match, or regular expression match.</para>
        /// <remarks>
        /// <para>When ScanRange is set to 0, all content in this field is fully matched. When ScanRange is set to 1, the content in this field is matched by prefix. For example, if this field is set to test/abc, file paths that start with test/abc are matched. When ScanRange is set to 2, the content in this field is matched by suffix. When ScanRange is set to 3, the content in this field is matched by regular expression.</para>
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
