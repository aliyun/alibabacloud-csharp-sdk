// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateRspDomainServerProhibitStatusForGatewayRequest : TeaModel {
        [NameInMap("AddStatusList")]
        [Validation(Required=false)]
        public List<UpdateRspDomainServerProhibitStatusForGatewayRequestAddStatusList> AddStatusList { get; set; }
        public class UpdateRspDomainServerProhibitStatusForGatewayRequestAddStatusList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>serverDeleteProhibited</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusMsg")]
            [Validation(Required=false)]
            public string StatusMsg { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asdf</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DeleteStatusList")]
        [Validation(Required=false)]
        public List<UpdateRspDomainServerProhibitStatusForGatewayRequestDeleteStatusList> DeleteStatusList { get; set; }
        public class UpdateRspDomainServerProhibitStatusForGatewayRequestDeleteStatusList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>serverDeleteProhibited</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusMsg")]
            [Validation(Required=false)]
            public string StatusMsg { get; set; }

        }

        /// <summary>
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
