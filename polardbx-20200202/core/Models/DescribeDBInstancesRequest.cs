// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstancesRequest : TeaModel {
        [NameInMap("DbVersion")]
        [Validation(Required=false)]
        public string DbVersion { get; set; }

        /// <summary>
        /// <para>The description or remarks of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dinga93c84f4d***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance must have a log engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MustHasCdc")]
        [Validation(Required=false)]
        public bool? MustHasCdc { get; set; }

        /// <summary>
        /// <para>The page number. Starts from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>30</description></item>
        /// <item><description>50</description></item>
        /// <item><description><ol start="100">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyst47******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The instance edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enterprise</b>: Enterprise Edition.</description></item>
        /// <item><description><b>standard</b>: Standard Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise</para>
        /// </summary>
        [NameInMap("Series")]
        [Validation(Required=false)]
        public string Series { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;TagKey\&quot;:\&quot;test\&quot;,\&quot;TagValue\&quot;:\&quot;test-value\&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
