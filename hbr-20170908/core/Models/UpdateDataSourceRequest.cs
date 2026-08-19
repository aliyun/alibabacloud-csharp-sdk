// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdateDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the client group used to access the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cl-000**************hg9</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The connection information for the data source. Examples:</para>
        /// <list type="bullet">
        /// <item><description><para>On-premises NAS data source:
        /// {
        /// &quot;dataServerAddresses&quot;: [
        /// {
        /// &quot;host&quot;: &quot;123.123.123.123&quot;,
        /// &quot;port&quot;: &quot;8080&quot;
        /// }
        /// ],
        /// &quot;sharePath&quot;: &quot;/share&quot;,
        /// &quot;mountOptions&quot;: &quot;vers=3&quot;,
        /// &quot;fileSystemType&quot;: &quot;nfs&quot;
        /// }</para>
        /// </description></item>
        /// <item><description><para>Intelligent Computing CPFS data source:
        /// {&quot;vpcMountTarget&quot;:&quot;cpfs-010wn\<em>\</em>\<em>wy-vpc-ta\</em>\*\*8.cn-shanghai.cpfs.aliyuncs.com&quot;,&quot;sharePath&quot;:&quot;/&quot;}</para>
        /// </description></item>
        /// <item><description><para>Other large-scale file system data sources:
        /// {&quot;path&quot;:&quot;/mnt&quot;}</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;dataServerAddresses&quot;: [
        ///         {
        ///             &quot;host&quot;: &quot;123.123.123.123&quot;,
        ///             &quot;port&quot;: &quot;8080&quot;
        ///         }
        ///     ],
        ///     &quot;sharePath&quot;: &quot;/share&quot;,
        ///     &quot;mountOptions&quot;: &quot;vers=3&quot;,
        ///     &quot;fileSystemType&quot;: &quot;nfs&quot;
        /// }</para>
        /// </summary>
        [NameInMap("ConnectionInfo")]
        [Validation(Required=false)]
        public string ConnectionInfo { get; set; }

        /// <summary>
        /// <para>The access credentials for the data source. This parameter is used for on-premises NAS data sources that use the SMB protocol, and for OSS and S3 protocol-compatible data sources. Examples:</para>
        /// <list type="bullet">
        /// <item><description><para>On-premises NAS data source (SMB protocol):
        /// {
        /// &quot;mountUsername&quot;: &quot;\<em>\</em>\<em>\</em>\<em>&quot;,
        /// &quot;mountPassword&quot;: &quot;\</em>\<em>\</em>\<em>\</em>&quot;
        /// }</para>
        /// </description></item>
        /// <item><description><para>OSS protocol-compatible data source/S3 protocol-compatible data source:
        /// {
        /// &quot;accessKeyId&quot;: &quot;\<em>\</em>\<em>\</em>\<em>&quot;,
        /// &quot;accessKeySecret&quot;: &quot;\</em>\<em>\</em>\<em>\</em>&quot;
        /// }</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;mountUsername&quot;:&quot;<em><b>&quot;,&quot;mountPassword&quot;:&quot;</b></em>&quot;}</para>
        /// </summary>
        [NameInMap("Credential")]
        [Validation(Required=false)]
        public string Credential { get; set; }

        /// <summary>
        /// <para>The ID of the data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-0006xo****dtle</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>The name of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyLocalNas</para>
        /// </summary>
        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>A filter to specify which files to exclude. This parameter applies only to the archive feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/home/alice/log/&quot;]</para>
        /// </summary>
        [NameInMap("Exclude")]
        [Validation(Required=false)]
        public string Exclude { get; set; }

        /// <summary>
        /// <para>A filter to specify which files to include. This parameter applies only to the archive feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;/home/alice/&quot;, &quot;/home/bob/&quot;]</para>
        /// </summary>
        [NameInMap("Include")]
        [Validation(Required=false)]
        public string Include { get; set; }

        /// <summary>
        /// <para>The index level for data source analysis. This parameter applies only to the archive feature.</para>
        /// <list type="bullet">
        /// <item><description><para>OFF: No index is created.</para>
        /// </description></item>
        /// <item><description><para>META: A metadata index is created.</para>
        /// </description></item>
        /// <item><description><para>ALL: A full-text index is created. (Deprecated)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>META</para>
        /// </summary>
        [NameInMap("IndexLevel")]
        [Validation(Required=false)]
        public string IndexLevel { get; set; }

        /// <summary>
        /// <para>The options for data source analysis. This parameter applies only to the archive feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <para>A list of paths for data source analysis. This parameter applies only to the archive feature.</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public List<string> Path { get; set; }

        /// <summary>
        /// <para>The schedule for data source analysis. This parameter applies only to the archive feature. The format is <c>I|{startTime}|{interval}</c>. This specifies a task that starts at <c>{startTime}</c> and repeats at the specified <c>{interval}</c>. <c>startTime</c> is a Unix time value in seconds. <c>interval</c> is an ISO 8601 time interval. For example, <c>PT1H</c> indicates a one-hour interval, and <c>P1D</c> indicates a one-day interval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>I|1729493847|P1D</para>
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public string Schedule { get; set; }

        /// <summary>
        /// <para>The rate limiting configuration for data source analysis. This parameter applies only to the archive feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0:24:102400</para>
        /// </summary>
        [NameInMap("SpeedLimit")]
        [Validation(Required=false)]
        public string SpeedLimit { get; set; }

    }

}
