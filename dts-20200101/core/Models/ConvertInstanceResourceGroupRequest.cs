// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConvertInstanceResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>This historical parameter does not take effect and is not required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m4312mab158****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The ID of new resource group. You can obtain the ID on the Resource Group page in the Resource Management console. For more information, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information about a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2r4fkrqw****</para>
        /// </summary>
        [NameInMap("NewResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the Data Transmission Service (DTS) instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>This parameter is only for special services and not required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-3m1213ye7l****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the DTS instance. You can view the ID in the <b>ID/Name</b> column on the task page in the console.</para>
        /// <remarks>
        /// <para> This parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtszhc12zp727o****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>This parameter is only for special services and not required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ZeroEtlJob")]
        [Validation(Required=false)]
        public bool? ZeroEtlJob { get; set; }

    }

}
