// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListKeyVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of key versions.</para>
        /// </summary>
        [NameInMap("KeyVersions")]
        [Validation(Required=false)]
        public ListKeyVersionsResponseBodyKeyVersions KeyVersions { get; set; }
        public class ListKeyVersionsResponseBodyKeyVersions : TeaModel {
            [NameInMap("KeyVersion")]
            [Validation(Required=false)]
            public List<ListKeyVersionsResponseBodyKeyVersionsKeyVersion> KeyVersion { get; set; }
            public class ListKeyVersionsResponseBodyKeyVersionsKeyVersion : TeaModel {
                /// <summary>
                /// <para>The date and time when the CMK version was created. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-03-25T10:42:40Z</para>
                /// </summary>
                [NameInMap("CreationDate")]
                [Validation(Required=false)]
                public string CreationDate { get; set; }

                /// <summary>
                /// <para>The globally unique ID of the CMK.</para>
                /// <remarks>
                /// <para> If you set the KeyId parameter to the alias of the CMK, the ID of the CMK to which the alias is bound is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0b30658a-ed1a-4922-b8f7-a673ca9c****</para>
                /// </summary>
                [NameInMap("KeyId")]
                [Validation(Required=false)]
                public string KeyId { get; set; }

                /// <summary>
                /// <para>The globally unique ID of the CMK version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1e3304fd-68ac-4d5b-8886-ae5f01a1****</para>
                /// </summary>
                [NameInMap("KeyVersionId")]
                [Validation(Required=false)]
                public string KeyVersionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f71204c4-53cd-4eea-b405-653ba2db7e86</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned key versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
