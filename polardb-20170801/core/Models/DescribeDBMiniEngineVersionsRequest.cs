// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBMiniEngineVersionsRequest : TeaModel {
        /// <summary>
        /// <para>The CPU architecture. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>X86</b></para>
        /// </description></item>
        /// <item><description><para><b>ARM</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>X86</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>The product series. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: Cluster Edition (default)</para>
        /// </description></item>
        /// <item><description><para><b>SENormal</b>: Standard Edition</para>
        /// </description></item>
        /// </list>
        /// <para>For more information about product series, see <a href="https://help.aliyun.com/document_detail/183258.html">Product series</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("CreationCategory")]
        [Validation(Required=false)]
        public string CreationCategory { get; set; }

        /// <summary>
        /// <para>The minor version of the database engine.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>DBVersion</c> is set to <b>8.0</b>, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>8.0.2</b></para>
        /// </description></item>
        /// <item><description><para><b>8.0.1</b></para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If <c>DBVersion</c> is set to <b>5.7</b>, the valid value is <b>5.7.28</b>.</para>
        /// </description></item>
        /// <item><description><para>If <c>DBVersion</c> is set to <b>5.6</b>, the valid value is <b>5.6.16</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8.0.1</para>
        /// </summary>
        [NameInMap("DBMinorVersion")]
        [Validation(Required=false)]
        public string DBMinorVersion { get; set; }

        /// <summary>
        /// <para>The database type. The only valid value is <b>MySQL</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The major version of the database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>8.0</b></para>
        /// </description></item>
        /// <item><description><para><b>5.7</b></para>
        /// </description></item>
        /// <item><description><para><b>5.6</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.6</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
