// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDAGVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the published versions.</para>
        /// </summary>
        [NameInMap("DagVersionList")]
        [Validation(Required=false)]
        public ListDAGVersionsResponseBodyDagVersionList DagVersionList { get; set; }
        public class ListDAGVersionsResponseBodyDagVersionList : TeaModel {
            [NameInMap("DagVersion")]
            [Validation(Required=false)]
            public List<ListDAGVersionsResponseBodyDagVersionListDagVersion> DagVersion { get; set; }
            public class ListDAGVersionsResponseBodyDagVersionListDagVersion : TeaModel {
                /// <summary>
                /// <para>The name of the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Spark SQL</para>
                /// </summary>
                [NameInMap("DagName")]
                [Validation(Required=false)]
                public string DagName { get; set; }

                /// <summary>
                /// <para>The ID of the task flow owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>51****</para>
                /// </summary>
                [NameInMap("DagOwnerId")]
                [Validation(Required=false)]
                public string DagOwnerId { get; set; }

                /// <summary>
                /// <para>The name of the task flow owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("DagOwnerNickName")]
                [Validation(Required=false)]
                public string DagOwnerNickName { get; set; }

                /// <summary>
                /// <para>The ID of the previously published version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2****</para>
                /// </summary>
                [NameInMap("LastVersionId")]
                [Validation(Required=false)]
                public long? LastVersionId { get; set; }

                /// <summary>
                /// <para>The description of the version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_OSS</para>
                /// </summary>
                [NameInMap("VersionComments")]
                [Validation(Required=false)]
                public string VersionComments { get; set; }

                /// <summary>
                /// <para>The ID of the version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2****</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public long? VersionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7775630-7901-51B9-8782-9B585EC0799A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
