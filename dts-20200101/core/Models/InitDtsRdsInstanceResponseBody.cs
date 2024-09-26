// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class InitDtsRdsInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The built-in account that is used by DTS to connect to the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rdsdt_dtsacct</para>
        /// </summary>
        [NameInMap("AdminAccount")]
        [Validation(Required=false)]
        public string AdminAccount { get; set; }

        /// <summary>
        /// <para>The password of the built-in account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1jecpqrtc****</para>
        /// </summary>
        [NameInMap("AdminPassword")]
        [Validation(Required=false)]
        public string AdminPassword { get; set; }

        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Value of Input Parameter %s is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7796ECE0-9C17-5E4D-9CE6-B7EC825A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
