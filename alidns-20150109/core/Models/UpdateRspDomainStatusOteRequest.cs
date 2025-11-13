// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateRspDomainStatusOteRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;Status&quot;:&quot;renewProhibited&quot;,&quot;StatusMsg&quot;:&quot;test&quot;}]</para>
        /// </summary>
        [NameInMap("AddStatusList")]
        [Validation(Required=false)]
        public List<UpdateRspDomainStatusOteRequestAddStatusList> AddStatusList { get; set; }
        public class UpdateRspDomainStatusOteRequestAddStatusList : TeaModel {
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
        /// <b>Example:</b>
        /// <para>443F1A21-XXXX-55C4-93E1-FF020DF93D7B</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;Status&quot;:&quot;renewProhibited&quot;,&quot;StatusMsg&quot;:&quot;test&quot;}]</para>
        /// </summary>
        [NameInMap("DeleteStatusList")]
        [Validation(Required=false)]
        public List<UpdateRspDomainStatusOteRequestDeleteStatusList> DeleteStatusList { get; set; }
        public class UpdateRspDomainStatusOteRequestDeleteStatusList : TeaModel {
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gatewayId001</para>
        /// </summary>
        [NameInMap("OperatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registryGateway</para>
        /// </summary>
        [NameInMap("OperatorType")]
        [Validation(Required=false)]
        public string OperatorType { get; set; }

    }

}
