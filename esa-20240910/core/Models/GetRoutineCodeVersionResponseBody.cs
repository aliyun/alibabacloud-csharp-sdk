// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetRoutineCodeVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the code version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test ver code desc</para>
        /// </summary>
        [NameInMap("CodeDescription")]
        [Validation(Required=false)]
        public string CodeDescription { get; set; }

        /// <summary>
        /// <para>The time when the version was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-11T01:23:21Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDBD3EB3-97DA-5465-AEF5-8DCA5DC5E395</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The code content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiPz4KPEVycm9yPgogIDxDb2RlPk5vU3VjaEtleTwvQ29kZT4KICA8TWVzc2FnZT5UaGUgc3BlY2lmaWVkIGtleSBkb2VzIG5vdCBleGlzdC48L01lc3NhZ2U</para>
        /// </summary>
        [NameInMap("RoutineCode")]
        [Validation(Required=false)]
        public string RoutineCode { get; set; }

    }

}
