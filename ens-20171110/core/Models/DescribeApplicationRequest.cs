// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can call the ListApplications operation to obtain the application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2bac6f4-75dc-455e-8389-2dc8e47526d3</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The version number of the application. Separate multiple version numbers with commas (,). If you want to query data of all versions of applications, specify All for this parameter. By default, only data of applications in the stable versions are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1,v2</para>
        /// </summary>
        [NameInMap("AppVersions")]
        [Validation(Required=false)]
        public string AppVersions { get; set; }

        /// <summary>
        /// <para>The region level by which edge resources of the application are collected. The value is of the enumeration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>National: Chinese mainland</description></item>
        /// <item><description>Big: area</description></item>
        /// <item><description>Middle: province</description></item>
        /// <item><description>Small: city</description></item>
        /// <item><description>RegionId: edge node</description></item>
        /// </list>
        /// <para>Default value: National.</para>
        /// 
        /// <b>Example:</b>
        /// <para>National</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>Specifies whether to return other information about the application, such as statistics on resource instances and pods. The value must be a JSON string. By default, all information is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;appInfo\&quot;:true,\&quot;detailStat\&quot;: true, \&quot;appVersionStat\&quot;: true, \&quot;districtStat\&quot;:true ,\&quot;instanceStat\&quot;: true, \&quot;podCountStat\&quot;: true}</para>
        /// </summary>
        [NameInMap("OutDetailStatParams")]
        [Validation(Required=false)]
        public string OutDetailStatParams { get; set; }

        /// <summary>
        /// <para>The resource filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;regionCode\&quot;: \&quot;cn-wuxi-telecom_unicom_cmcc-3\&quot;,    \&quot;ispCode\&quot;: \&quot;telecom\&quot;,    \&quot;count\&quot;: 2	},{    \&quot;regionCode\&quot;: \&quot;cn-shanghai-cmcc\&quot;,    \&quot;count\&quot;: 4	}]</para>
        /// </summary>
        [NameInMap("ResourceSelector")]
        [Validation(Required=false)]
        public string ResourceSelector { get; set; }

    }

}
