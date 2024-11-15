// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class CreateAccountFactoryBaselineResponseBody : TeaModel {
        /// <summary>
        /// <para>The baseline ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>afb-bp1e6ixtiwupap8m****</para>
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public string BaselineId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5592E2E-0FC4-557C-B989-DF229B5EBE13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
