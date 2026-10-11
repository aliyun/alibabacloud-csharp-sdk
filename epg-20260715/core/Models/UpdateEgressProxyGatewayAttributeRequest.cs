// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class UpdateEgressProxyGatewayAttributeRequest : TeaModel {
        [NameInMap("AddListenerProperties")]
        [Validation(Required=false)]
        public List<UpdateEgressProxyGatewayAttributeRequestAddListenerProperties> AddListenerProperties { get; set; }
        public class UpdateEgressProxyGatewayAttributeRequestAddListenerProperties : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17486</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426614174000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eppool-gw80d96a96ca0b00****</para>
        /// </summary>
        [NameInMap("DefaultEgressProxyIpPoolId")]
        [Validation(Required=false)]
        public string DefaultEgressProxyIpPoolId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epg-gw80bb6a94f835db****</para>
        /// </summary>
        [NameInMap("EgressProxyGatewayId")]
        [Validation(Required=false)]
        public string EgressProxyGatewayId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("EgressProxyGatewayName")]
        [Validation(Required=false)]
        public string EgressProxyGatewayName { get; set; }

        [NameInMap("RemoveListenerProperties")]
        [Validation(Required=false)]
        public List<UpdateEgressProxyGatewayAttributeRequestRemoveListenerProperties> RemoveListenerProperties { get; set; }
        public class UpdateEgressProxyGatewayAttributeRequestRemoveListenerProperties : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32720</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        [NameInMap("TlsInterceptProperties")]
        [Validation(Required=false)]
        public UpdateEgressProxyGatewayAttributeRequestTlsInterceptProperties TlsInterceptProperties { get; set; }
        public class UpdateEgressProxyGatewayAttributeRequestTlsInterceptProperties : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1f01a6f9-a0e7-64e5-9d3c-29c056****</para>
            /// </summary>
            [NameInMap("PrivateCaCertificateId")]
            [Validation(Required=false)]
            public string PrivateCaCertificateId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("TlsInterceptMode")]
            [Validation(Required=false)]
            public string TlsInterceptMode { get; set; }

        }

    }

}
