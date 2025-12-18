// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DescribeIntegratedServiceStatusRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cadt</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

    }

}
