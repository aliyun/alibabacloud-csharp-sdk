// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataTrackOrderRequest : TeaModel {
        /// <summary>
        /// <para>The purpose or objective of the data tracking ticket. This parameter is used to help reduce unnecessary communication.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The parameters of the ticket.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateDataTrackOrderRequestParam Param { get; set; }
        public class CreateDataTrackOrderRequestParam : TeaModel {
            /// <summary>
            /// <para>The ID of the database. You can call the <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabases</a> operation to query the ID of the database.</para>
            /// <remarks>
            /// <para>You can call this operation to create a data tracking ticket for only physical databases. This operation is not applicable to logical databases.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123***</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public string DbId { get; set; }

            /// <summary>
            /// <para>The end time of the time range in which you want to track data operations. The time must be in the yyyy-MM-dd HH:mm:ss format.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-23 10:00:00</para>
            /// </summary>
            [NameInMap("JobEndTime")]
            [Validation(Required=false)]
            public string JobEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the time range in which you want to track data operations. The time must be in the yyyy-MM-dd HH:mm:ss format.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-23 00:00:00</para>
            /// </summary>
            [NameInMap("JobStartTime")]
            [Validation(Required=false)]
            public string JobStartTime { get; set; }

            /// <summary>
            /// <para>The names of the tables for which you want to track data operations.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("TableNames")]
            [Validation(Required=false)]
            public List<string> TableNames { get; set; }

            /// <summary>
            /// <para>The types of data operations that you want to track.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("TrackTypes")]
            [Validation(Required=false)]
            public List<string> TrackTypes { get; set; }

        }

        /// <summary>
        /// <para>The IDs of the operators that are related to the ticket.</para>
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<string> RelatedUserList { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> operation to query the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
