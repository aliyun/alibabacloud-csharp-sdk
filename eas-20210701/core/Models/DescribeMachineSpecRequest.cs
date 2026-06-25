// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeMachineSpecRequest : TeaModel {
        /// <summary>
        /// <para>The billing method. The default value is \<c>PostPaid\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No input required</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The resource type. The default value is \<c>Public\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
