// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCanTrySasResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether you have the permissions on the trial use of Security Center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CanTry")]
        [Validation(Required=false)]
        public int? CanTry { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E90DE229-9FC6-58F6-BF4B-03AD6179****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
