// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class OperateAxgGroupRequest : TeaModel {
        /// <summary>
        /// <para>The group ID in the AXG binding.</para>
        /// <para>You can view the group ID by using either of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>On the <b>Number Pool Management</b> page in the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a>, filter AXG private numbers and click <b>Number Group G Management</b> to view the group IDs of number groups G.****</description></item>
        /// <item><description>If the <a href="https://help.aliyun.com/document_detail/110250.html">CreateAxgGroup</a> operation is called to create number group G, the value of <b>GroupId</b> in the response of the CreateAxgGroup operation is specified as the value of the request parameter <b>GroupId</b> of the OperateAxgGroup operation.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Number group G must have one or more phone numbers.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The phone numbers that you add to number group G. Separate the phone numbers with commas (,). You can add up to 200 phone numbers at a time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1390000****,1380000****</para>
        /// </summary>
        [NameInMap("Numbers")]
        [Validation(Required=false)]
        public string Numbers { get; set; }

        /// <summary>
        /// <para>The type of the operation on number group G. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>addNumbers</b>: adds phone numbers to number group G.</description></item>
        /// <item><description><b>deleteNumbers</b>: deletes phone numbers from number group G.</description></item>
        /// <item><description><b>overwriteNumbers</b>: replaces all phone numbers in number group G. All the original phone numbers are deleted from number group G, and new phone numbers are added to number group G.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>When you replace all phone numbers in number group G, the quantity of original phone numbers in number group G cannot exceed 200.</para>
        /// </description></item>
        /// <item><description><para>You can add up to 200 phone numbers to number group G at a time.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>addNumbers</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The key of the phone number pool. Log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a> and view the key of the phone number pool on the <b>Number Pool Management</b> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC123456</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
