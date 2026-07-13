// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateRspDomainServerProhibitStatusForGatewayRequest : TeaModel {
        /// <summary>
        /// <para>A collection of domain name statuses to add.</para>
        /// </summary>
        [NameInMap("AddStatusList")]
        [Validation(Required=false)]
        public List<UpdateRspDomainServerProhibitStatusForGatewayRequestAddStatusList> AddStatusList { get; set; }
        public class UpdateRspDomainServerProhibitStatusForGatewayRequestAddStatusList : TeaModel {
            /// <summary>
            /// <para>The domain name status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>serverDeleteProhibited</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The description of the status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>实名认证未通过，增加serverUpdateProhibited状态</para>
            /// </summary>
            [NameInMap("StatusMsg")]
            [Validation(Required=false)]
            public string StatusMsg { get; set; }

        }

        /// <summary>
        /// <para>A parameter that ensures idempotence.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asdf</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>A collection of domain name statuses to delete.</para>
        /// </summary>
        [NameInMap("DeleteStatusList")]
        [Validation(Required=false)]
        public List<UpdateRspDomainServerProhibitStatusForGatewayRequestDeleteStatusList> DeleteStatusList { get; set; }
        public class UpdateRspDomainServerProhibitStatusForGatewayRequestDeleteStatusList : TeaModel {
            /// <summary>
            /// <para>The domain name status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>serverDeleteProhibited</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The description of the status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>实名认证通过，删除serverUpdateProhibited状态</para>
            /// </summary>
            [NameInMap("StatusMsg")]
            [Validation(Required=false)]
            public string StatusMsg { get; set; }

        }

        /// <summary>
        /// <para>The domain name whose serverHold status you want to change.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

    }

}
