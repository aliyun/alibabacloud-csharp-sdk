// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateLiveMessageAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The application ID. The ID is used in subsequent operations, such as joining a group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The AppKey for authentication of this application.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>The application signature. The signature is required when you use the interactive messaging SDK.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("AppSign")]
        [Validation(Required=false)]
        public string AppSign { get; set; }

        /// <summary>
        /// <para>The data center in which the interactive messaging application was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65EEDBEB-43FE-1E15-976F-3DDD753A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
