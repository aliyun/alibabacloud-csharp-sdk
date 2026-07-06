// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListInstanceRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        [Obsolete]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PENDING</c>: Initializing.</para>
        /// </description></item>
        /// <item><description><para><c>INIT_ERROR</c>: Initialization failed.</para>
        /// </description></item>
        /// <item><description><para><c>STARTING</c>: Starting.</para>
        /// </description></item>
        /// <item><description><para><c>RUNNING</c>: Running.</para>
        /// </description></item>
        /// <item><description><para><c>STOPPING</c>: Stopping.</para>
        /// </description></item>
        /// <item><description><para><c>STOPPED</c>: Stopped.</para>
        /// </description></item>
        /// <item><description><para><c>DELETING</c>: Deleting.</para>
        /// </description></item>
        /// <item><description><para><c>DELETED</c>: Deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmv36i4is****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
