// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class Story : TeaModel {
        /// <summary>
        /// <para>The ID of the story cover file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63e5e4340f76cb3ead5f40f68163f0f967c1a7bf</para>
        /// </summary>
        [NameInMap("cover_file_id")]
        [Validation(Required=false)]
        public string CoverFileId { get; set; }

        /// <summary>
        /// <para>The URL of thumbnail of the story cover file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://pds-domain-bucket.oss-cn-hangzhou.aliyuncs.com/Bh1HqdAs%2F1001%2F642a88c26f99cad589904fc8a6b2db6021c6601f%2F642a88c29391c47f221e49e88a21fa9b0a9e5063?security-token=CAIS%2BgF1q6Ft5B2yfSjIr5eGE8nGtYZ59bSnbUODlmsjTttVhpbFpjz2IHpPfHdoBe0btvU%2BlWxX6fwZlq5rR4QAXlDfNXD6XXO2qFHPWZHInuDox55m4cTXNAr%2BIhr%2F29CoEIedZdjBe%2FCrRknZnytou9XTfimjWFrXWv%2Fgy%2BQQDLItUxK%2FcCBNCfpPOwJms7V6D3bKMuu3OROY6Qi5TmgQ41En1DIlt%2FXuk5DCtkqB12eXkLFF%2B97DRbG%2FdNRpMZtFVNO44fd7bKKp0lQLsUMSqv8q0fEcqGaW4o7CWQJLnzyCMvvJ9OVDFyN0aKEnH7J%2Bq%2FzxhTPrMnpkSlacGoABVgD3mIAeUoDYKTJrFTPdmAPIrlUUQ1HZstB0ZVHvYByygr3oeitG9FEQ8lcfaZYJOtWRchdgH8tsSwHj2jI1vMeAiLHgbW98SPA3yfN8OR1kLW73uq3LAvekc9Qldz33YTM4JA5MNJzR8x5O6Oe4rY5OMSSVU5F%2Ffr8bJZD%2FXMM%3D&x-oss-access-key-id=STS.NT3XsrXYXBvLoe2rkvBTyiSnD&x-oss-expires=1685966251&x-oss-process=image%2Fresize%2Cw_500&x-oss-signature=XimW6haBxYktKg4cstMfpd%2F2LSoMibj6A%2B7ZqBJcSbQ%3D&x-oss-signature-version=OSS2">https://pds-domain-bucket.oss-cn-hangzhou.aliyuncs.com/Bh1HqdAs%2F1001%2F642a88c26f99cad589904fc8a6b2db6021c6601f%2F642a88c29391c47f221e49e88a21fa9b0a9e5063?security-token=CAIS%2BgF1q6Ft5B2yfSjIr5eGE8nGtYZ59bSnbUODlmsjTttVhpbFpjz2IHpPfHdoBe0btvU%2BlWxX6fwZlq5rR4QAXlDfNXD6XXO2qFHPWZHInuDox55m4cTXNAr%2BIhr%2F29CoEIedZdjBe%2FCrRknZnytou9XTfimjWFrXWv%2Fgy%2BQQDLItUxK%2FcCBNCfpPOwJms7V6D3bKMuu3OROY6Qi5TmgQ41En1DIlt%2FXuk5DCtkqB12eXkLFF%2B97DRbG%2FdNRpMZtFVNO44fd7bKKp0lQLsUMSqv8q0fEcqGaW4o7CWQJLnzyCMvvJ9OVDFyN0aKEnH7J%2Bq%2FzxhTPrMnpkSlacGoABVgD3mIAeUoDYKTJrFTPdmAPIrlUUQ1HZstB0ZVHvYByygr3oeitG9FEQ8lcfaZYJOtWRchdgH8tsSwHj2jI1vMeAiLHgbW98SPA3yfN8OR1kLW73uq3LAvekc9Qldz33YTM4JA5MNJzR8x5O6Oe4rY5OMSSVU5F%2Ffr8bJZD%2FXMM%3D&amp;x-oss-access-key-id=STS.NT3XsrXYXBvLoe2rkvBTyiSnD&amp;x-oss-expires=1685966251&amp;x-oss-process=image%2Fresize%2Cw_500&amp;x-oss-signature=XimW6haBxYktKg4cstMfpd%2F2LSoMibj6A%2B7ZqBJcSbQ%3D&amp;x-oss-signature-version=OSS2</a></para>
        /// </summary>
        [NameInMap("cover_file_thumbnail_url")]
        [Validation(Required=false)]
        public string CoverFileThumbnailUrl { get; set; }

        /// <summary>
        /// <para>The time when the story was created. The time follows the RFC3339 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-14T10:17:18.102700407+08:00</para>
        /// </summary>
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The custom tags. You can specify key-value pairs based on your business requirements to search for stories by calling the FindStories operation.</para>
        /// </summary>
        [NameInMap("custom_labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        /// <summary>
        /// <para>The information about face-based groups. This parameter is valid only if story_type is set to PeopleMemory. This parameter is invalid for stories of other types or custom stories.</para>
        /// </summary>
        [NameInMap("face_group_ids")]
        [Validation(Required=false)]
        public List<string> FaceGroupIds { get; set; }

        /// <summary>
        /// <para>The time when the story ends. The time follows the RFC3339 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-14T10:17:18.102700407+08:00</para>
        /// </summary>
        [NameInMap("story_end_time")]
        [Validation(Required=false)]
        public string StoryEndTime { get; set; }

        /// <summary>
        /// <para>The story files.</para>
        /// </summary>
        [NameInMap("story_file_list")]
        [Validation(Required=false)]
        public List<File> StoryFileList { get; set; }

        /// <summary>
        /// <para>The story ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9132e0d8-fe92-4e56-86c3-f5f112308003</para>
        /// </summary>
        [NameInMap("story_id")]
        [Validation(Required=false)]
        public string StoryId { get; set; }

        /// <summary>
        /// <para>The name of the story.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("story_name")]
        [Validation(Required=false)]
        public string StoryName { get; set; }

        /// <summary>
        /// <para>The time when the story starts. The time follows the RFC3339 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-14T10:17:18.102700407+08:00</para>
        /// </summary>
        [NameInMap("story_start_time")]
        [Validation(Required=false)]
        public string StoryStartTime { get; set; }

        /// <summary>
        /// <para>The subtype of the story. It is specified when the story is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Solo</para>
        /// </summary>
        [NameInMap("story_sub_type")]
        [Validation(Required=false)]
        public string StorySubType { get; set; }

        /// <summary>
        /// <para>The type of the story. It is specified when the story is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PeopleMemory</para>
        /// </summary>
        [NameInMap("story_type")]
        [Validation(Required=false)]
        public string StoryType { get; set; }

        /// <summary>
        /// <para>The time when the story was updated. The time follows the RFC3339 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-14T10:17:18.102700407+08:00</para>
        /// </summary>
        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
