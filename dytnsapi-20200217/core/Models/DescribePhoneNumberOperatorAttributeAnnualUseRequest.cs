// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberOperatorAttributeAnnualUseRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputNumber")]
        [Validation(Required=false)]
        public string InputNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

    }

}
