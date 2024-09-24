// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyTagWithUuidRequest : TeaModel {
        /// <summary>
        /// <para>The type of the asset to query. If you do not specify this parameter, the tags of all asset types are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b>: server</description></item>
        /// <item><description><b>cloud_product</b>: Alibaba Cloud service</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypes { get; set; }

        /// <summary>
        /// <para>The ID of the tag that you want to manage.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeGroupedTags~~">DescribeGroupedTags</a> operation to query the IDs of tags.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3897941</para>
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

        /// <summary>
        /// <para>The names of the tags that you want to manage. Separate multiple tag names with commas (,).</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeGroupedTags~~">DescribeGroupedTags</a> operation to query the names of tags.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac,ad</para>
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public string TagList { get; set; }

        /// <summary>
        /// <para>The details of the server for which you want to manage the tag. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Target</b>: the UUID of the server that you want to add or remove.</para>
        /// </description></item>
        /// <item><description><para><b>targetType</b>: the method by which the server is added. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>uuid</b>: by server</description></item>
        /// <item><description><b>groupId</b>: by server group</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>flag</b>: the operation that you want to perform on the server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>del</b>: removes the tag from the server.</description></item>
        /// <item><description><b>add</b>: adds the tag to the server.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;target&quot;:&quot;inet-7c676676-06fa-442e-90fb-b802e5d6****&quot;,&quot;targetType&quot;:&quot;uuid&quot;,&quot;flag&quot;:&quot;add&quot;}]</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to query the UUIDs of servers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>e2737dc3-78f4-4653-a986-dc5fad4b****,c189f0e3-df22-42d5-a73d-02c05667****</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public string UuidList { get; set; }

    }

}
