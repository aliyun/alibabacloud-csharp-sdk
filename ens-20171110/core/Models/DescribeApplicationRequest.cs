// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can obtain the ID by calling the ListApplications operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2bac6f4-75dc-455e-8389-2dc8e47526d3</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The business service version numbers of the application. Multiple values are supported and separated by commas (,). If you enter All, data of all versions is returned. By default, only data associated with the stable version number is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1,v2</para>
        /// </summary>
        [NameInMap("AppVersions")]
        [Validation(Required=false)]
        public string AppVersions { get; set; }

        /// <summary>
        /// <para>The regional statistical level of the application edge resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>National: nationwide</description></item>
        /// <item><description>Big: region</description></item>
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
        /// <para>Specifies whether to return information about statistical resource instances and container pods. The value is a JSON string. By default, all information is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;appInfo\&quot;:true,\&quot;detailStat\&quot;: true, \&quot;appVersionStat\&quot;: true, \&quot;districtStat\&quot;:true ,\&quot;instanceStat\&quot;: true, \&quot;podCountStat\&quot;: true}</para>
        /// </summary>
        [NameInMap("OutDetailStatParams")]
        [Validation(Required=false)]
        public string OutDetailStatParams { get; set; }

        /// <summary>
        /// <para>The resource filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;regionCode\&quot;: \&quot;cn-wuxi-telecom_unicom_cmcc-3\&quot;,    \&quot;ispCode\&quot;: \&quot;telecom\&quot;,    \&quot;count\&quot;: 2	},{    \&quot;regionCode\&quot;: \&quot;cn-shanghai-cmcc\&quot;,    \&quot;count\&quot;: 4	}]</para>
        /// </summary>
        [NameInMap("ResourceSelector")]
        [Validation(Required=false)]
        public string ResourceSelector { get; set; }

    }

}
