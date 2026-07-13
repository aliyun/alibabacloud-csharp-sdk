// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateRspDomainServerProhibitStatusForGatewayOteRequest : TeaModel {
        /// <summary>
        /// <para>List of domain name statuses to add.</para>
        /// </summary>
        [NameInMap("AddStatusList")]
        [Validation(Required=false)]
        public List<UpdateRspDomainServerProhibitStatusForGatewayOteRequestAddStatusList> AddStatusList { get; set; }
        public class UpdateRspDomainServerProhibitStatusForGatewayOteRequestAddStatusList : TeaModel {
            /// <summary>
            /// <para>Domain name status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>serverDeleteProhibited</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Description of the status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>实名认证未通过，增加serverUpdateProhibited状态</para>
            /// </summary>
            [NameInMap("StatusMsg")]
            [Validation(Required=false)]
            public string StatusMsg { get; set; }

        }

        /// <summary>
        /// <para>Idempotency token.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwoefasdf</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>List of domain name statuses to remove.</para>
        /// </summary>
        [NameInMap("DeleteStatusList")]
        [Validation(Required=false)]
        public List<UpdateRspDomainServerProhibitStatusForGatewayOteRequestDeleteStatusList> DeleteStatusList { get; set; }
        public class UpdateRspDomainServerProhibitStatusForGatewayOteRequestDeleteStatusList : TeaModel {
            /// <summary>
            /// <para>Domain name status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>serverDeleteProhibited</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Description of the status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>实名认证通过，删除serverUpdateProhibited状态</para>
            /// </summary>
            [NameInMap("StatusMsg")]
            [Validation(Required=false)]
            public string StatusMsg { get; set; }

        }

        /// <summary>
        /// <para>Domain name.</para>
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
