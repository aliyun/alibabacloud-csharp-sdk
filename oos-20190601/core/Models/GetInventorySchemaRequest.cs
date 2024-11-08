// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetInventorySchemaRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return only properties that support the aggregate feature in the configuration list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: only returns properties that support the aggregate feature in the configuration list.</description></item>
        /// <item><description>false: returns all properties in the configuration list.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Aggregator")]
        [Validation(Required=false)]
        public bool? Aggregator { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gAAAAABfh8MVLQI9AuKGACLgjbsXbWs-Mna47IDM6tr6wK7TZ1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The configuration list type name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ACS:InstanceInformation</description></item>
        /// <item><description>ACS:Application</description></item>
        /// <item><description>ACS:File</description></item>
        /// <item><description>ACS:Network</description></item>
        /// <item><description>ACS:WindowsRole</description></item>
        /// <item><description>ACS:Service</description></item>
        /// <item><description>ACS:WindowsUpdate</description></item>
        /// <item><description>ACS:WindowsRegistry</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACS:Application</para>
        /// </summary>
        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

    }

}
