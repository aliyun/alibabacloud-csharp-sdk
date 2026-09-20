// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListShiftPersonnelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination result.</para>
        /// </summary>
        [NameInMap("Paging")]
        [Validation(Required=false)]
        public ListShiftPersonnelsResponseBodyPaging Paging { get; set; }
        public class ListShiftPersonnelsResponseBodyPaging : TeaModel {
            /// <summary>
            /// <para>The page number. Minimum value: 1. Maximum value: 100. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of on-duty personnel.</para>
            /// </summary>
            [NameInMap("ShiftPersons")]
            [Validation(Required=false)]
            public List<ListShiftPersonnelsResponseBodyPagingShiftPersons> ShiftPersons { get; set; }
            public class ListShiftPersonnelsResponseBodyPagingShiftPersons : TeaModel {
                /// <summary>
                /// <para>The start time of the on-duty cycle.</para>
                /// <para>The value is a 13-digit timestamp, for example, <c>1593950832000</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593950832000</para>
                /// </summary>
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public long? BeginTime { get; set; }

                /// <summary>
                /// <para>The end time of the on-duty cycle.</para>
                /// <para>The value is a 13-digit timestamp, for example, <c>1593950832000</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593950832000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The name of the on-duty person.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang San</para>
                /// </summary>
                [NameInMap("ShiftPersonName")]
                [Validation(Required=false)]
                public string ShiftPersonName { get; set; }

                /// <summary>
                /// <para>The UID of the on-duty person.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3726346****</para>
                /// </summary>
                [NameInMap("ShiftPersonUID")]
                [Validation(Required=false)]
                public string ShiftPersonUID { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries that meet the conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
