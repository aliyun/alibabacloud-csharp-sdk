// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class GetCaInstanceCrlAddressResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the CA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("CaInstanceStatus")]
        [Validation(Required=false)]
        public string CaInstanceStatus { get; set; }

        [NameInMap("CaType")]
        [Validation(Required=false)]
        public string CaType { get; set; }

        /// <summary>
        /// <para>The CRL URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://crl-cn-publish.oss-cn-hangzhou.aliyuncs.com/pca/crl/35118048/1f0be094-14bd-6caa-bd7f-db45730d510a.crl">https://crl-cn-publish.oss-cn-hangzhou.aliyuncs.com/pca/crl/35118048/1f0be094-14bd-6caa-bd7f-db45730d510a.crl</a></para>
        /// </summary>
        [NameInMap("CrlUrl")]
        [Validation(Required=false)]
        public string CrlUrl { get; set; }

        /// <summary>
        /// <para>The hash code used to identify whether the CRL contains new revoked certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5481d1b1228fXXX40ee70dc8cd</para>
        /// </summary>
        [NameInMap("HashCode")]
        [Validation(Required=false)]
        public string HashCode { get; set; }

        /// <summary>
        /// <para>The next update time of the CRL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1778688000000</para>
        /// </summary>
        [NameInMap("NextUpdateTime")]
        [Validation(Required=false)]
        public string NextUpdateTime { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C53C2341-F321-55A5-895C-D0746E6DA58E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
