// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeBucketsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// <remarks>
        /// <para>This parameter is returned only when an error occurs during the API call.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeBucketsResponseBodyData> Data { get; set; }
        public class DescribeBucketsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The bucket name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zydctest</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The public endpoint used to access the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-hangzhou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ExtranetEndpoint")]
            [Validation(Required=false)]
            public string ExtranetEndpoint { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-15 17:33:59</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The internal endpoint used by ECS instances in the same region to access the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-hangzhou-internal.aliyuncs.com</para>
            /// </summary>
            [NameInMap("IntranetEndpoint")]
            [Validation(Required=false)]
            public string IntranetEndpoint { get; set; }

            /// <summary>
            /// <para>The storage path, such as HDFS or OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>center</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The information about objects in the bucket.</para>
            /// </summary>
            [NameInMap("OssObjectList")]
            [Validation(Required=false)]
            public List<DescribeBucketsResponseBodyDataOssObjectList> OssObjectList { get; set; }
            public class DescribeBucketsResponseBodyDataOssObjectList : TeaModel {
                /// <summary>
                /// <para>The bucket name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tf-testacceu-central-1ensbucketlifecycle44222</para>
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The ETag (Entity Tag) is created when an object is generated and is used to identify the content of the object.</para>
                /// <list type="bullet">
                /// <item><description><para>For an object created by a PutObject request, the ETag is the MD5 hash of the object content.</para>
                /// </description></item>
                /// <item><description><para>For an object created by other methods, the ETag is a unique value generated based on specific calculation rules, but it is not the MD5 hash of the object content.</para>
                /// </description></item>
                /// <item><description><para>You can use the ETag to check whether the object content has changed. Do not use the ETag as the MD5 hash to verify the data integrity of the object content.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>5B3C1A2E053D763E1B002CC607C5A0FE1****</para>
                /// </summary>
                [NameInMap("ETag")]
                [Validation(Required=false)]
                public string ETag { get; set; }

                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>con</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The time when the object was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2012-02-24T08:42:32.000Z</para>
                /// </summary>
                [NameInMap("LastModified")]
                [Validation(Required=false)]
                public string LastModified { get; set; }

                /// <summary>
                /// <para>The bucket owner information.</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public DescribeBucketsResponseBodyDataOssObjectListOwner Owner { get; set; }
                public class DescribeBucketsResponseBodyDataOssObjectListOwner : TeaModel {
                    /// <summary>
                    /// <para>The name of the bucket owner.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Jiayu</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the bucket owner.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>395</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }

                /// <summary>
                /// <para>The database restoration information when the restored database type is MSSQL. The value is a JSON string that contains the following fields:</para>
                /// <list type="bullet">
                /// <item><description><b>name</b>: The database name.</description></item>
                /// <item><description><b>files</b>: The database file path.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ongoing-request=&quot;true&quot;</para>
                /// </summary>
                [NameInMap("RestoreInfo")]
                [Validation(Required=false)]
                public string RestoreInfo { get; set; }

                /// <summary>
                /// <para>The file size. Unit: KB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The storage class of the bucket. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Standard: Standard storage (default).</description></item>
                /// <item><description>IA: Infrequent Access.</description></item>
                /// <item><description>Archive: Archive.</description></item>
                /// <item><description>ColdArchive: Cold Archive.</description></item>
                /// <item><description>DeepColdArchive: Deep Cold Archive.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ARCHIVE</para>
                /// </summary>
                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                /// <summary>
                /// <para>The trigger type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceGroup</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>425F351C-3F8E-5218-A520-B6311D0D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The request result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
