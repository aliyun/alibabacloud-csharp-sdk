// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class BindAuthToMachineResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of bound servers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BindCount")]
        [Validation(Required=false)]
        public int? BindCount { get; set; }

        /// <summary>
        /// <para>The shortage in the quota for cores of servers that can be protected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InsufficientCoreCount")]
        [Validation(Required=false)]
        public int? InsufficientCoreCount { get; set; }

        /// <summary>
        /// <para>The shortage in the quota for servers that can be protected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InsufficientEcsCount")]
        [Validation(Required=false)]
        public int? InsufficientEcsCount { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23AD0BD2-8771-5647-819E-6BA51E212F80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code that indicates the result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The servers are bound to or unbound from Security Center.</description></item>
        /// <item><description><b>1</b>: The values that you specified for the parameters are invalid.</description></item>
        /// <item><description><b>2</b>: The quota for servers that can be protected is insufficient.</description></item>
        /// <item><description><b>3</b>: The quota for cores of servers that can be protected is insufficient.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public int? ResultCode { get; set; }

        /// <summary>
        /// <para>The number of unbound servers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UnBindCount")]
        [Validation(Required=false)]
        public int? UnBindCount { get; set; }

    }

}
