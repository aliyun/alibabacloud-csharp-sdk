// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class CreateCloudConnectNetworkResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the CCN instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccn-l9340rlu5ens*****</para>
        /// </summary>
        [NameInMap("CcnId")]
        [Validation(Required=false)]
        public string CcnId { get; set; }

        /// <summary>
        /// <para>The private CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.XX.XX.0/24</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The description about the CCN instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccndesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the CCN instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccnname</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C48E8EB2-37A4-495B-A95C-29CA1FD26C82</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the CCN instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2iu4fnc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The private CIDR block used for SNAT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.XX.XX.0/25</para>
        /// </summary>
        [NameInMap("SnatCidrBlock")]
        [Validation(Required=false)]
        public string SnatCidrBlock { get; set; }

        /// <summary>
        /// <para>The status of the CCN instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Active</b>: indicates the CNN instance running as expected.</description></item>
        /// <item><description><b>Pending</b>: indicates the CCN instance is to be created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
