// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class CreateScanTaskRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the data asset, such as an instance, a database, and a bucket. You can call the <a href="~~DescribeDataLimits~~">DescribeDataLimits</a> operation to query the unique ID.</para>
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
        /// <para>The interval between two consecutive custom scan tasks. Unit: days. Valid values: 1 to 2147483648.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IntervalDay")]
        [Validation(Required=false)]
        public int? IntervalDay { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response.</para>
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
        /// <para>The data to be scanned in the Object Storage Service (OSS) bucket. Prefix match, suffix match, and regular expression match are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test/test</para>
        /// </summary>
        [NameInMap("OssScanPath")]
        [Validation(Required=false)]
        public string OssScanPath { get; set; }

        /// <summary>
        /// <para>The type of the service to which the data assets to be scanned belong. Valid values include <b>1</b>, <b>2</b>, <b>3</b>, <b>4</b>, and <b>5</b>. The value 1 indicates MaxCompute. The value 2 indicates OSS. The value 3 indicates AnalyticDB for MySQL. The value 4 indicates Tablestore. The value 5 indicates ApsaraDB RDS.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public long? ResourceType { get; set; }

        /// <summary>
        /// <para>The time when the scan task is executed next time. Unit: hours.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("RunHour")]
        [Validation(Required=false)]
        public int? RunHour { get; set; }

        /// <summary>
        /// <para>The time when the scan task is executed next time. Unit: minutes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("RunMinute")]
        [Validation(Required=false)]
        public int? RunMinute { get; set; }

        /// <summary>
        /// <para>The matching rule that specifies the scan scope of the custom scan task. This parameter takes effect only if you set the <b>ScanRangeContent</b> parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: exact match</description></item>
        /// <item><description><b>1</b>: prefix match</description></item>
        /// <item><description><b>2</b>: suffix match</description></item>
        /// <item><description><b>3</b>: regular expression match</description></item>
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
        /// <para>The data to be scanned in a structured data asset. Prefix match, suffix match, and regular expression match are supported.</para>
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
        /// <para>39.170.XX.XX</para>
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
        /// <para>The account that is used to create the scan task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("TaskUserName")]
        [Validation(Required=false)]
        public string TaskUserName { get; set; }

    }

}
