// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class UpdateAnycastEipAddressAssociationsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Anycast EIP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aeip-bp1ix34fralt4ykf3****</para>
        /// </summary>
        [NameInMap("AnycastId")]
        [Validation(Required=false)]
        public string AnycastId { get; set; }

        /// <summary>
        /// <para>The association mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Default</b>: the default mode. In this mode, cloud resources to be associated are set as default origin servers.</description></item>
        /// <item><description><b>Normal</b>: the standard mode. In this mode, cloud resources to be associated are set as standard origin servers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("AssociationMode")]
        [Validation(Required=false)]
        public string AssociationMode { get; set; }

        /// <summary>
        /// <para>The ID of the cloud resource with which you want to associate the Anycast EIP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-d7oxbixhxv1uupnon****</para>
        /// </summary>
        [NameInMap("BindInstanceId")]
        [Validation(Required=false)]
        public string BindInstanceId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <remarks>
        /// <para> If you do not set this parameter, the system automatically uses <b>RequestId</b> as <b>ClientToken</b>. <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without updating the association information. The system checks the required parameters, request syntax, and limits. If the request fails to pass the precheck, an error message is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the API request. If the request passes the precheck, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The access areas and access points to be added.</para>
        /// </summary>
        [NameInMap("PopLocationAddList")]
        [Validation(Required=false)]
        public List<UpdateAnycastEipAddressAssociationsRequestPopLocationAddList> PopLocationAddList { get; set; }
        public class UpdateAnycastEipAddressAssociationsRequestPopLocationAddList : TeaModel {
            /// <summary>
            /// <para>The access points in the access areas to be added.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/171938.html">DescribeAnycastPopLocations</a> operation to query the access points in supported access areas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>us-west-1-pop</para>
            /// </summary>
            [NameInMap("PopLocation")]
            [Validation(Required=false)]
            public string PopLocation { get; set; }

        }

        /// <summary>
        /// <para>The access areas and access points to be deleted.</para>
        /// </summary>
        [NameInMap("PopLocationDeleteList")]
        [Validation(Required=false)]
        public List<UpdateAnycastEipAddressAssociationsRequestPopLocationDeleteList> PopLocationDeleteList { get; set; }
        public class UpdateAnycastEipAddressAssociationsRequestPopLocationDeleteList : TeaModel {
            /// <summary>
            /// <para>The access points in the access areas to be deleted.</para>
            /// <remarks>
            /// <para> If the access point in the access area is associated with a default origin server, you cannot delete the access point in the access area.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>eu-west-1-pop</para>
            /// </summary>
            [NameInMap("PopLocation")]
            [Validation(Required=false)]
            public string PopLocation { get; set; }

        }

    }

}
