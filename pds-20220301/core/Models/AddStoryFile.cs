// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class AddStoryFile : TeaModel {
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("error_message")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>63e5e4340f76cb3ead5f40f68163f0f967c1a7bf</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>642a88dd06e49d9c0a14411ebae606f70edd9a59</para>
        /// </summary>
        [NameInMap("revision_id")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

    }

}
