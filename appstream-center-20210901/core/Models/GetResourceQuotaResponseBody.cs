// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetResourceQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned when an error occurs during the call. A normal result does not necessarily include this field. Do not use the return of a specific success code as a prerequisite for obtaining the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidProductType.ValueNotSupported</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The maximum resource count quota applicable to the current query conditions. This is not the usage or remaining quota.</para>
        /// <list type="bullet">
        /// <item><description><c>ResourceType=AppInstanceGroup</c>: Unit: groups.</description></item>
        /// <item><description><c>ResourceType=AppAuthUser</c>: Unit: users.</description></item>
        /// <item><description><c>ResourceType=PoolNodeAmount</c>: Unit: nodes.</description></item>
        /// </list>
        /// <para>If no smaller limit is obtained, <c>2147483647</c> is returned. This does not mean that the resource inventory is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public long? Data { get; set; }

        /// <summary>
        /// <para>The error message returned when an error occurs during the call. This message and the error code help you locate the cause of the error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The ProductType is not supported.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
