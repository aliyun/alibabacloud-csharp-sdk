// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstanceTDEResponseBody : TeaModel {
        /// <summary>
        /// <para>The data struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceTDEResponseBodyData Data { get; set; }
        public class DescribeDBInstanceTDEResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether TDE is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: TDE is disabled.</description></item>
            /// <item><description>1: TDE is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TDEStatus")]
            [Validation(Required=false)]
            public string TDEStatus { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C458B1E8-1683-3645-B154-6BA32080EEA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
