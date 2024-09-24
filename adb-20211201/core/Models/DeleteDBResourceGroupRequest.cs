// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DeleteDBResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/612410.html">DescribeDBResourceGroup</a> operation to query the information about resource groups of an AnalyticDB for MySQL cluster, including resource group names.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_group</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

    }

}
